#pragma checksum "C:\Users\KT\source\repos\alkfejk\Project-X\web\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bad8dbafd6f8f9f7fad61e9b10d6deecbdf395a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Index.cshtml", typeof(AspNetCore.Views_User_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\KT\source\repos\alkfejk\Project-X\web\Views\_ViewImports.cshtml"
using DicomLoaderWeb;

#line default
#line hidden
#line 2 "C:\Users\KT\source\repos\alkfejk\Project-X\web\Views\_ViewImports.cshtml"
using DicomLoaderWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bad8dbafd6f8f9f7fad61e9b10d6deecbdf395a2", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"402b660e865e38d303542a35fee4092cae679518", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\KT\source\repos\alkfejk\Project-X\web\Views\User\Index.cshtml"
  
    ViewBag.Title = "Kezdőlap";

#line default
#line hidden
            BeginContext(40, 401, true);
            WriteLiteral(@"

<!--Main-->
<div class=""card-deck my-2 text-center"">

    <div class=""card py-2"">

        <div class=""card-body"">
            <h5 class=""card-title my-4"">Regisztráció</h5>
            <p class=""card-text my-4"">A szolgálatás regisztrálásához kattintson a regisztráció gombra és használja 30 napig ingyenesen szolgáltatásunkat.</p>
            <button class=""btn btn-primary btn-block my-4""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 441, "\"", 502, 3);
            WriteAttributeValue("", 451, "location.href=\'", 451, 15, true);
#line 14 "C:\Users\KT\source\repos\alkfejk\Project-X\web\Views\User\Index.cshtml"
WriteAttributeValue("", 466, Url.Action("Registration", "User"), 466, 35, false);

#line default
#line hidden
            WriteAttributeValue("", 501, "\'", 501, 1, true);
            EndWriteAttribute();
            BeginContext(503, 376, true);
            WriteLiteral(@">Regisztráció</button>
        </div>
    </div>
    <div class=""card py-2"">
        <div class=""card-body"">
            <h5 class=""card-title my-4"">Belépés</h5>
            <p class=""card-text my-4"">Amennyiben rendelkezik felhasználói fóikkal, belépés gombra kattintva ellenőrizheti license érvényességét.</p>
            <button class=""btn btn-primary btn-block my-4""");
            EndContext();
            BeginWriteAttribute("onclick", "onclick=\"", 879, "\"", 933, 3);
            WriteAttributeValue("", 888, "location.href=\'", 888, 15, true);
#line 21 "C:\Users\KT\source\repos\alkfejk\Project-X\web\Views\User\Index.cshtml"
WriteAttributeValue("", 903, Url.Action("SignIn", "User"), 903, 29, false);

#line default
#line hidden
            WriteAttributeValue("", 932, "\'", 932, 1, true);
            EndWriteAttribute();
            BeginContext(934, 67, true);
            WriteLiteral(">Belépés</button>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!--/Main-->");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
