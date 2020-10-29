#pragma checksum "C:\Users\KT\source\repos\DicomLoaderWeb\Views\User\Registration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2851efbef179bc94f33ed1850b21fb1a341f5a29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Registration), @"mvc.1.0.view", @"/Views/User/Registration.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Registration.cshtml", typeof(AspNetCore.Views_User_Registration))]
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
#line 1 "C:\Users\KT\source\repos\DicomLoaderWeb\Views\_ViewImports.cshtml"
using DicomLoaderWeb;

#line default
#line hidden
#line 2 "C:\Users\KT\source\repos\DicomLoaderWeb\Views\_ViewImports.cshtml"
using DicomLoaderWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2851efbef179bc94f33ed1850b21fb1a341f5a29", @"/Views/User/Registration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"402b660e865e38d303542a35fee4092cae679518", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Registration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DicomLoaderWeb.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-light p-3 my-2 col-9 container-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Registration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\KT\source\repos\DicomLoaderWeb\Views\User\Registration.cshtml"
  
    ViewBag.Title = "Regisztráció";

#line default
#line hidden
            BeginContext(79, 15, true);
            WriteLiteral("\r\n<!--Main-->\r\n");
            EndContext();
            BeginContext(94, 1143, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30bb363c3a7d48e3b4c8d4d6d7714962", async() => {
                BeginContext(196, 882, true);
                WriteLiteral(@"
    <h1 class=""h2 text-center"">Regisztráció</h1>
    <div class=""form-group"">
        <label for=""lastName"">Vezetéknév</label>
        <input type=""text"" name=""LastName"" id=""lastName"" class=""form-control"" required>
    </div>
    <div class=""form-group"">
        <label for=""firstName"">Keresztnév</label>
        <input type=""text"" name=""FirstName"" id=""firstName"" class=""form-control"" required>
    </div>
    <div class=""form-group"">
        <label for=""email"">Email cím</label>
        <input type=""email"" name=""Email"" class=""form-control"" id=""email"" aria-describedby=""emailHelp"" required>
    </div>
    <div class=""form-group"">
        <label for=""password"">Jelszó</label>
        <input type=""password"" name=""Password"" class=""form-control"" id=""password"" required>
    </div>
    <button type=""submit"" class=""btn btn-primary btn-block"">Regisztráció</button>
");
                EndContext();
#line 26 "C:\Users\KT\source\repos\DicomLoaderWeb\Views\User\Registration.cshtml"
     if (ViewBag.Error != null)
    {

#line default
#line hidden
                BeginContext(1118, 73, true);
                WriteLiteral("        <div class=\"alert alert-warning my-2\" role=\"alert\">\r\n            ");
                EndContext();
                BeginContext(1192, 13, false);
#line 29 "C:\Users\KT\source\repos\DicomLoaderWeb\Views\User\Registration.cshtml"
       Write(ViewBag.Error);

#line default
#line hidden
                EndContext();
                BeginContext(1205, 18, true);
                WriteLiteral("\r\n        </div>\r\n");
                EndContext();
#line 31 "C:\Users\KT\source\repos\DicomLoaderWeb\Views\User\Registration.cshtml"
    }

#line default
#line hidden
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1237, 16, true);
            WriteLiteral("\r\n\r\n<!--/Main-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DicomLoaderWeb.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591