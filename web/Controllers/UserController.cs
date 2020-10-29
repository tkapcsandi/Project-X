﻿using System;

using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

using DicomLoaderWeb.DBContext;
using DicomLoaderWeb.Models;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DicomLoaderWeb.Controllers
{
    public class UserController : Controller
    {
        private readonly EFContext _Context = new EFContext();

        public IActionResult Index()
        {
            
            return View();
        }

        public async Task<IActionResult> Users()
        {
            if(HttpContext.Session.GetString("_User") == UserRole.USER.ToString())
            {
                return Redirect("index");
            }
            var users = await _Context.Users.ToArrayAsync();

            return View(users);
        }


        public IActionResult Registration()
        {
            User user = new User();
            return View(user);
        }


        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Registration(User PostUser)
        {

            if(PostUser.LastName == null || PostUser.FirstName == null || PostUser.Password == null || PostUser.Email == null)
            {
                /*ViewBag.Error = "Hiba a bevitt adatokban";
                return View(PostUser);*/
                return RedirectToAction("Error", new Error { ErrorMessage = "Üresek a bevitt adatok" });
            }

            if(_Context.Users.Where(x => x.Email == PostUser.Email).Any())
            {
                return RedirectToAction("Error", new Error { ErrorMessage = "A megadott email címmel már regisztráltak" });
            }

            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            string hashed = HashPassword(salt, PostUser.Password);
            PostUser.Password = hashed;
            PostUser.RegDate = DateTime.Today;
            PostUser.Salt = Convert.ToBase64String(salt);
            PostUser.Role = UserRole.USER;
            PostUser.Status = UserStatus.DISABLED;

            if (ModelState.IsValid)
            {
                _Context.Add(PostUser);
                await _Context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        [HttpGet]
        [Route("/ResetPassword/{id:int}")]
        public async Task<IActionResult> ResetPassword(int id)
        {
            try
            {
                var users = await _Context.Users.Where(x => x.ID == id).ToArrayAsync();
                var user = users[0];
                user.Password = HashPassword(Convert.FromBase64String(user.Salt), "321");
                _Context.Add(user);
                _Context.Entry(user).State = EntityState.Modified;
                _Context.SaveChanges();
            
                return RedirectToAction("Users");
            }
            catch (Exception)
            {
                return RedirectToAction("Error", new Error { ErrorMessage = "Hiba a jelszó visszaállíta közben" });
            }

        }
        [HttpGet]
        [Route("/UpdateRole/{id:int}")]
        public async Task<IActionResult> UpdateRole(int id)
        {
            try
            {
                var users = await _Context.Users.Where(x => x.ID == id).ToArrayAsync();
                var user = users[0];
                user.Role = user.Role == UserRole.ADMIN ? UserRole.USER : UserRole.ADMIN;
                _Context.Add(user);
                _Context.Entry(user).State = EntityState.Modified;
                _Context.SaveChanges();
                HttpContext.Session.SetString("_User", user.Role.ToString());
                return RedirectToAction("Users");
            }
            catch (Exception)
            {
                return RedirectToAction("Error", new Error { ErrorMessage = "Hiba a jelszó visszaállítása közben" });
            }
        }

        [HttpGet]
        [Route("/UpdateState/{id:int}")]
        public async Task<IActionResult> UpdateState(int id)
        {
            try
            {
                var users = await _Context.Users.Where(x => x.ID == id).ToArrayAsync();
                var user = users[0];
                user.Status = user.Status == UserStatus.ACTIVE ? UserStatus.DISABLED : UserStatus.ACTIVE;
                _Context.Add(user);
                _Context.Entry(user).State = EntityState.Modified;
                _Context.SaveChanges();
                return RedirectToAction("Users");
            }
            catch (Exception)
            {
                return RedirectToAction("Error", new Error { ErrorMessage = "Hiba státusz változása közben" });
            }
        }
        public IActionResult License(User user)
        {
            return View(user);
        }

        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(String Email, String Password)
        {
            User user = null;
            try
            {
                var users = await _Context.Users.Where(x => x.Email == Email).ToArrayAsync();
                user = users[0];
            }
            catch (ArgumentNullException)
            {
                var Experror = new Error { ErrorMessage = "Hiányzó jelszó" };
                return RedirectToAction("Error", Experror);
            }
            catch (IndexOutOfRangeException)
            {
                var Experror = new Error { ErrorMessage = "Hibás jelszó" };
                return RedirectToAction("Error", Experror);
            }
            
            if(CheckPassword(user.Salt, user.Password, Password))
            {
                if (user.Status == UserStatus.DISABLED) {
                    return RedirectToAction("Error", new Error { ErrorMessage = "A felhasználó még nincs aktiválva" });
                }
                user.RegDate = user.RegDate.AddDays(90);

                if ((user.RegDate > DateTime.Today))
                {
                    HttpContext.Session.SetString("_User", user.Role.ToString());
                    return RedirectToAction("License", user);
                }
                else
                {
                    var EndOfLicense = user.RegDate.Year + "/" + user.RegDate.Month + "/" + user.RegDate.Day;
                    var LicenseError = new Error { ErrorMessage = "Lejárt license: " + EndOfLicense  };
                    return RedirectToAction("Error", LicenseError);
                }
               
            }

            var error = new Error { ErrorMessage = "Hibás bejelentkezési adatok" };
            return RedirectToAction("Error", error);
        }
        private String HashPassword(byte[] Salt, String Password)
        {
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: Password,
                salt: Salt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));
            return hashed;
        }
        private Boolean CheckPassword(String Salt, String PasswordStored, String PasswordInput)
        {

            String hashed = HashPassword(Convert.FromBase64String(Salt), PasswordInput);
            if (PasswordStored.Equals(hashed))
            {
                return true;
            }

            return false;
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(Error error)
        {
            return View(error);
        }

        //Handle HTTP request from desktop App
        [HttpPost]
        [Route("/SignIn")]
        public async Task<ActionResult> GetData(String Email, String Password)
        {
            User user = null;

            try
            {
                var users = await _Context.Users.Where(x => x.Email == Email).ToArrayAsync();
                user = users[0];
            }
            catch (ArgumentNullException)
            {
                return Ok(new { accepted = false, error = "Hibás email/jelszó" });
            }
            catch (IndexOutOfRangeException)
            {
                return Ok(new { accepted = false, error = "Az email cím nincs regisztrálva" });
            }

            if (CheckPassword(user.Salt, user.Password, Password))
            {
                if(user.Status != UserStatus.ACTIVE)
                {
                    return Ok(new { accepted = false, error = "A felhasználó nincs aktiválva" });
                }
                user.RegDate = user.RegDate.AddDays(90);

                if ((user.RegDate > DateTime.Today))
                {
                    var EndOfLicense = user.RegDate.Year + "," + user.RegDate.Month + "," + user.RegDate.Day;
                    return Ok(new {
                        accepted = true,
                        error = "none",
                        user = new {
                            firstname = user.FirstName,
                            lastname = user.LastName,
                            licenseDate = EndOfLicense
                        } });
                }
                else
                {
                    var EndOfLicense = user.RegDate.Year + "/" + user.RegDate.Month + "/" + user.RegDate.Day;
                    return Ok(new { accepted = false, error = "Lejárt license" });
                }
            }



                return Ok(new {accepted = false, error = "Hibás jelszó" });

        }
    }
}
