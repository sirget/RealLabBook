#pragma checksum "C:\Users\bestv\source\repos\RealLabBook\RealLabBook\Views\Register\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a9170d4cffbce583767dc956a835eb3063ebaf4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Register_Index), @"mvc.1.0.view", @"/Views/Register/Index.cshtml")]
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
#line 1 "C:\Users\bestv\source\repos\RealLabBook\RealLabBook\Views\_ViewImports.cshtml"
using RealLabBook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bestv\source\repos\RealLabBook\RealLabBook\Views\_ViewImports.cshtml"
using RealLabBook.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a9170d4cffbce583767dc956a835eb3063ebaf4", @"/Views/Register/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f65343cbe2976bd8de915b1d0846221a402a747c", @"/Views/_ViewImports.cshtml")]
    public class Views_Register_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/icon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("register-logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\bestv\source\repos\RealLabBook\RealLabBook\Views\Register\Index.cshtml"
  
    ViewData["Title"] = "ŧ����¹";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"register-container body\">\r\n    <h1 class=\"authen-title\">ŧ����¹</h1>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a9170d4cffbce583767dc956a835eb3063ebaf45974", async() => {
                WriteLiteral("\r\n        <div class=\"row\">\r\n            <div class=\"input-block\">\r\n                <label class=\"input-label\" for=\"name\">���ͨ�ԧ</label>\r\n                <input");
                BeginWriteAttribute("class", " class=\"", 371, "\"", 483, 1);
#nullable restore
#line 10 "C:\Users\bestv\source\repos\RealLabBook\RealLabBook\Views\Register\Index.cshtml"
WriteAttributeValue("", 379, ViewBag!=null &&ViewBag.errors != null &&ViewBag.errors.name !=null ? "input-box error" : "input-box", 379, 104, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                       id=\"name\" name=\"name\" placeholder=\"�����\"");
                BeginWriteAttribute("value", "\r\n                       value=\"", 550, "\"", 673, 1);
#nullable restore
#line 12 "C:\Users\bestv\source\repos\RealLabBook\RealLabBook\Views\Register\Index.cshtml"
WriteAttributeValue("", 582, ViewBag != null && ViewBag.user != null&& ViewBag.user.name != null?ViewBag.user.name:"", 582, 91, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></input>\r\n");
#nullable restore
#line 13 "C:\Users\bestv\source\repos\RealLabBook\RealLabBook\Views\Register\Index.cshtml"
                 if (ViewBag != null && ViewBag.errors != null && ViewBag.errors.name != null)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"error\">");
#nullable restore
#line 15 "C:\Users\bestv\source\repos\RealLabBook\RealLabBook\Views\Register\Index.cshtml"
                                   Write(ViewBag.errors.name[0]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 16 "C:\Users\bestv\source\repos\RealLabBook\RealLabBook\Views\Register\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n            <div class=\"input-block\">\r\n                <label class=\"input-label\" for=\"surname\">���ʡ��</label>\r\n                <input");
                BeginWriteAttribute("class", " class=\"", 1045, "\"", 1160, 1);
#nullable restore
#line 20 "C:\Users\bestv\source\repos\RealLabBook\RealLabBook\Views\Register\Index.cshtml"
WriteAttributeValue("", 1053, ViewBag!=null &&ViewBag.errors != null &&ViewBag.errors.surname !=null ? "input-box error" : "input-box", 1053, 107, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                       id=\"surname\" name=\"surname\" placeholder=\"㨴�\"");
                BeginWriteAttribute("value", "\r\n                       value=\"", 1230, "\"", 1359, 1);
#nullable restore
#line 22 "C:\Users\bestv\source\repos\RealLabBook\RealLabBook\Views\Register\Index.cshtml"
WriteAttributeValue("", 1262, ViewBag != null && ViewBag.user != null&& ViewBag.user.surname != null?ViewBag.user.surname:"", 1262, 97, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></input>\r\n");
#nullable restore
#line 23 "C:\Users\bestv\source\repos\RealLabBook\RealLabBook\Views\Register\Index.cshtml"
                 if (ViewBag != null && ViewBag.errors != null && ViewBag.errors.surname != null)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"error\">");
#nullable restore
#line 25 "C:\Users\bestv\source\repos\RealLabBook\RealLabBook\Views\Register\Index.cshtml"
                                   Write(ViewBag.errors.surname[0]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 26 "C:\Users\bestv\source\repos\RealLabBook\RealLabBook\Views\Register\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n        </div>\r\n        <div class=\"input-block\">\r\n            <label class=\"input-label\" for=\"email\">�����</label>\r\n            <input");
                BeginWriteAttribute("class", " class=\"", 1738, "\"", 1851, 1);
#nullable restore
#line 31 "C:\Users\bestv\source\repos\RealLabBook\RealLabBook\Views\Register\Index.cshtml"
WriteAttributeValue("", 1746, ViewBag!=null &&ViewBag.errors != null &&ViewBag.errors.email !=null ? "input-box error" : "input-box", 1746, 105, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                   id=\"email\" name=\"email\" type=\"email\" placeholder=\"abc@gmail.com\"");
                BeginWriteAttribute("value", "\r\n                   value=\"", 1937, "\"", 2058, 1);
#nullable restore
#line 33 "C:\Users\bestv\source\repos\RealLabBook\RealLabBook\Views\Register\Index.cshtml"
WriteAttributeValue("", 1965, ViewBag != null && ViewBag.user != null&& ViewBag.user.email != null?ViewBag.user.email:"", 1965, 93, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></input>\r\n");
#nullable restore
#line 34 "C:\Users\bestv\source\repos\RealLabBook\RealLabBook\Views\Register\Index.cshtml"
             if (ViewBag != null && ViewBag.errors != null && ViewBag.errors.email != null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"error\">");
#nullable restore
#line 36 "C:\Users\bestv\source\repos\RealLabBook\RealLabBook\Views\Register\Index.cshtml"
                               Write(ViewBag.errors.email[0]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 37 "C:\Users\bestv\source\repos\RealLabBook\RealLabBook\Views\Register\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n        <div class=\"input-block\">\r\n            <label class=\"input-label\" for=\"password\">���ʼ�ҹ</label>\r\n            <input");
                BeginWriteAttribute("class", " class=\"", 2401, "\"", 2517, 1);
#nullable restore
#line 41 "C:\Users\bestv\source\repos\RealLabBook\RealLabBook\Views\Register\Index.cshtml"
WriteAttributeValue("", 2409, ViewBag!=null &&ViewBag.errors != null &&ViewBag.errors.password !=null ? "input-box error" : "input-box", 2409, 108, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                   id=\"password\" name=\"password\" type=\"password\" placeholder=\"��������\"");
                BeginWriteAttribute("value", "\r\n                   value=\"", 2607, "\"", 2734, 1);
#nullable restore
#line 43 "C:\Users\bestv\source\repos\RealLabBook\RealLabBook\Views\Register\Index.cshtml"
WriteAttributeValue("", 2635, ViewBag != null && ViewBag.user != null&& ViewBag.user.password != null?ViewBag.user.password:"", 2635, 99, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></input>\r\n");
#nullable restore
#line 44 "C:\Users\bestv\source\repos\RealLabBook\RealLabBook\Views\Register\Index.cshtml"
             if (ViewBag != null && ViewBag.errors != null && ViewBag.errors.password != null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"error\">");
#nullable restore
#line 46 "C:\Users\bestv\source\repos\RealLabBook\RealLabBook\Views\Register\Index.cshtml"
                               Write(ViewBag.errors.password[0]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 47 "C:\Users\bestv\source\repos\RealLabBook\RealLabBook\Views\Register\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n        <div class=\"input-block\">\r\n            <label class=\"input-label\" for=\"confirmPassword\">�׹�ѹ���ʼ�ҹ</label>\r\n            <input");
                BeginWriteAttribute("class", " class=\"", 3094, "\"", 3217, 1);
#nullable restore
#line 51 "C:\Users\bestv\source\repos\RealLabBook\RealLabBook\Views\Register\Index.cshtml"
WriteAttributeValue("", 3102, ViewBag!=null &&ViewBag.errors != null &&ViewBag.errors.confirmPassword !=null ? "input-box error" : "input-box", 3102, 115, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                   id=\"confirmPassword\" name=\"confirmPassword\" type=\"password\" placeholder=\"��������\"");
                BeginWriteAttribute("value", "\r\n                   value=\"", 3321, "\"", 3462, 1);
#nullable restore
#line 53 "C:\Users\bestv\source\repos\RealLabBook\RealLabBook\Views\Register\Index.cshtml"
WriteAttributeValue("", 3349, ViewBag != null && ViewBag.user != null&& ViewBag.user.confirmPassword != null?ViewBag.user.confirmPassword:"", 3349, 113, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></input>\r\n");
#nullable restore
#line 54 "C:\Users\bestv\source\repos\RealLabBook\RealLabBook\Views\Register\Index.cshtml"
             if (ViewBag != null && ViewBag.errors != null && ViewBag.errors.confirmPassword != null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"error\">");
#nullable restore
#line 56 "C:\Users\bestv\source\repos\RealLabBook\RealLabBook\Views\Register\Index.cshtml"
                               Write(ViewBag.errors.confirmPassword[0]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 57 "C:\Users\bestv\source\repos\RealLabBook\RealLabBook\Views\Register\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n        <input class=\"register\" type=\"submit\" value=\"���ҧ�ѭ�ռ����\"></input>\r\n    ");
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6a9170d4cffbce583767dc956a835eb3063ebaf418302", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
