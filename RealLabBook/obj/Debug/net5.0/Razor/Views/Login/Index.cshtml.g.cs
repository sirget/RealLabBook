#pragma checksum "C:\Users\Pnach\Documents\GitHub\RealLabBook\RealLabBook\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1586b0fe137b59dcfba95af170e241cc95cc7bd5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Pnach\Documents\GitHub\RealLabBook\RealLabBook\Views\_ViewImports.cshtml"
using RealLabBook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pnach\Documents\GitHub\RealLabBook\RealLabBook\Views\_ViewImports.cshtml"
using RealLabBook.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pnach\Documents\GitHub\RealLabBook\RealLabBook\Views\Login\Index.cshtml"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1586b0fe137b59dcfba95af170e241cc95cc7bd5", @"/Views/Login/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f65343cbe2976bd8de915b1d0846221a402a747c", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 2 "C:\Users\Pnach\Documents\GitHub\RealLabBook\RealLabBook\Views\Login\Index.cshtml"
                                
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""login-wrapper"">
    <div class=""login"">
        <div class=""login-decoration""></div>
        <div class=""login-form"">
            <p class=""login-label"">LABBOOK</p>
            <h1 class=""login-title"">Login</h1>
            <div class=""form-wrapper"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1586b0fe137b59dcfba95af170e241cc95cc7bd55191", async() => {
                WriteLiteral("\r\n                    <div class=\"input-wrapper\">\r\n                        <label class=\"label\" for=\"email\">Email Address</label>\r\n                        <input");
                BeginWriteAttribute("class", " class=\"", 605, "\"", 710, 1);
#nullable restore
#line 16 "C:\Users\Pnach\Documents\GitHub\RealLabBook\RealLabBook\Views\Login\Index.cshtml"
WriteAttributeValue("", 613, ViewBag!=null &&ViewBag.errors != null &&ViewBag.errors.email !=null ? "input error" : "input", 613, 97, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"email\" id=\"email\" name=\"email\" required>\r\n");
#nullable restore
#line 17 "C:\Users\Pnach\Documents\GitHub\RealLabBook\RealLabBook\Views\Login\Index.cshtml"
                         if (ViewBag != null && ViewBag.errors != null && ViewBag.errors.email != null)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"error\">");
#nullable restore
#line 19 "C:\Users\Pnach\Documents\GitHub\RealLabBook\RealLabBook\Views\Login\Index.cshtml"
                                           Write(ViewBag.errors.email[0]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 20 "C:\Users\Pnach\Documents\GitHub\RealLabBook\RealLabBook\Views\Login\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n                    <div class=\"input-wrapper\">\r\n                        <label class=\"label\" for=\"password\">Password</label>\r\n                        <input");
                BeginWriteAttribute("class", " class=\"", 1185, "\"", 1293, 1);
#nullable restore
#line 24 "C:\Users\Pnach\Documents\GitHub\RealLabBook\RealLabBook\Views\Login\Index.cshtml"
WriteAttributeValue("", 1193, ViewBag!=null &&ViewBag.errors != null &&ViewBag.errors.password !=null ? "input error" : "input", 1193, 100, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"password\" id=\"password\" name=\"password\" required>\r\n");
#nullable restore
#line 25 "C:\Users\Pnach\Documents\GitHub\RealLabBook\RealLabBook\Views\Login\Index.cshtml"
                         if (ViewBag != null && ViewBag.errors != null && ViewBag.errors.password != null)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"error\">");
#nullable restore
#line 27 "C:\Users\Pnach\Documents\GitHub\RealLabBook\RealLabBook\Views\Login\Index.cshtml"
                                           Write(ViewBag.errors.password[0]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 28 "C:\Users\Pnach\Documents\GitHub\RealLabBook\RealLabBook\Views\Login\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n                    <button class=\"action\" type=\"submit\">Login</button>\r\n                    <p class=\"register-link\">Haven\'t an account? <a href=\"/Register\">Register</a></p>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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