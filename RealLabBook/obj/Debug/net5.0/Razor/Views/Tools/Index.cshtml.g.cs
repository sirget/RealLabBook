#pragma checksum "C:\Users\Pnach\Documents\GitHub\RealLabBook\RealLabBook\Views\Tools\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a1aebefd1efb80e06c51ca4efc6e58f0878b124"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tools_Index), @"mvc.1.0.view", @"/Views/Tools/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a1aebefd1efb80e06c51ca4efc6e58f0878b124", @"/Views/Tools/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f65343cbe2976bd8de915b1d0846221a402a747c", @"/Views/_ViewImports.cshtml")]
    public class Views_Tools_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Pnach\Documents\GitHub\RealLabBook\RealLabBook\Views\Tools\Index.cshtml"
  
    ViewData["Title"] = "LabBook";

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Pnach\Documents\GitHub\RealLabBook\RealLabBook\Views\Tools\Index.cshtml"
   
    var quan = ViewData["ListQuan"] as List<int>;

#line default
#line hidden
#nullable disable
            DefineSection("JavaScript", async() => {
                WriteLiteral("\r\n    <script type=\"text/javascript\"");
                BeginWriteAttribute("src", " src=\"", 160, "\"", 198, 1);
#nullable restore
#line 9 "C:\Users\Pnach\Documents\GitHub\RealLabBook\RealLabBook\Views\Tools\Index.cshtml"
WriteAttributeValue("", 166, Url.Content("~/js/lab-card.js"), 166, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\r\n");
            }
            );
            WriteLiteral(@"
<div class=""wrapper"">
    <div class=""wrapper-lab"">
        <h1>This Lab</h1>
        <div class=""card-container"">
            <lab-card lab="" Lab 1""
                      image=""https://images.unsplash.com/photo-1619345371662-fccc15cc4814?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=976&q=80""
                      itemname=""Voltmeter""");
            BeginWriteAttribute("vol", "\r\n                      vol=", 604, "", 640, 1);
#nullable restore
#line 20 "C:\Users\Pnach\Documents\GitHub\RealLabBook\RealLabBook\Views\Tools\Index.cshtml"
WriteAttributeValue("", 632, quan[0], 632, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                      itemid=""1""
                      desc=""เครื่องวัดแรงดันไฟฟ้า""></lab-card>
            <lab-card lab="" Lab 2""
                      image=""https://images.unsplash.com/photo-1553063085-dbbf64d936ea?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1189&q=80""
                      itemname=""Arduino""");
            BeginWriteAttribute("vol", "\r\n                      vol=", 1003, "", 1039, 1);
#nullable restore
#line 26 "C:\Users\Pnach\Documents\GitHub\RealLabBook\RealLabBook\Views\Tools\Index.cshtml"
WriteAttributeValue("", 1031, quan[1], 1031, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                      itemid=""2""
                      desc=""บอร์ดไมโครคอนโทรเลอร์ตระกูล AVR""></lab-card>
            <lab-card lab="" Lab 3""
                      image=""https://www.ato.com/content/images/thumbs/0001186_200-mhz-digital-oscilloscope-24-channels-4-gsas_550.jpeg""
                      itemname=""Oscilloscope""");
            BeginWriteAttribute("vol", "\r\n                      vol=", 1368, "", 1404, 1);
#nullable restore
#line 32 "C:\Users\Pnach\Documents\GitHub\RealLabBook\RealLabBook\Views\Tools\Index.cshtml"
WriteAttributeValue("", 1396, quan[2], 1396, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                      itemid=""3""
                      desc=""เครื่องวัดสัญญาณไฟฟ้า""></lab-card>
            <lab-card lab="" Lab 4""
                      image=""https://cf.shopee.co.th/file/c44dfdb32f3d522113780557ae3779aa""
                      itemname=""Soldering Iron""");
            BeginWriteAttribute("vol", "\r\n                      vol=", 1680, "", 1716, 1);
#nullable restore
#line 38 "C:\Users\Pnach\Documents\GitHub\RealLabBook\RealLabBook\Views\Tools\Index.cshtml"
WriteAttributeValue("", 1708, quan[3], 1708, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                      itemid=""4""
                      desc=""หัวแร้ง""></lab-card>
            <lab-card lab="" Lab 5""
                      image=""https://images.unsplash.com/photo-1582648373212-d5bd3015d35c?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1042&q=80""
                      itemname=""Pliers""");
            BeginWriteAttribute("vol", "\r\n                      vol=", 2067, "", 2103, 1);
#nullable restore
#line 44 "C:\Users\Pnach\Documents\GitHub\RealLabBook\RealLabBook\Views\Tools\Index.cshtml"
WriteAttributeValue("", 2095, quan[4], 2095, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                      itemid=""5""
                      desc=""คีม""></lab-card>
        </div>
    </div>
    <div class=""wrapper-lab"">
        <a style=""padding-top: 20px; color:black;"" href=""https://golablint.azurewebsites.net/""><h1>Lab: goLabLint.com</h1></a>
        <div class=""card-container"">
            <lab-card id=""gtool1""
                      lab="" Lab 1""
                      image=""https://itcats.in/images/spinner-loop.gif""
                      itemname=""Loading""
                      vol=""0""
                      desc=""Loading""
                      lablint=""true""
                      itemid=""d95ec54b-636f-4947-8a0c-a23261948f42""></lab-card>
            <lab-card id=""gtool2""
                      lab="" Lab 2""
                      image=""https://itcats.in/images/spinner-loop.gif""
                      itemname=""Loading""
                      vol=""0""
                      desc=""Loading""
                      lablint=""true""
                      itemid=""dd462e6a-7b9e-4fc5-a");
            WriteLiteral(@"8cf-7e02dc2c4457""></lab-card>
            <lab-card id=""gtool3""
                      lab="" Lab 3""
                      image=""https://itcats.in/images/spinner-loop.gif""
                      itemname=""Loading""
                      vol=""0""
                      desc=""Loading""
                      lablint=""true""
                      itemid=""5d9171a5-51cf-4f1b-8262-566fe6bd54af""></lab-card>
            <lab-card id=""gtool4""
                      lab="" Lab 4""
                      image=""https://itcats.in/images/spinner-loop.gif""
                      itemname=""Loading""
                      vol=""0""
                      desc=""Loading""
                      lablint=""true""
                      itemid=""d2adfb9c-4ed7-4922-b731-ec733bc1fbe1""></lab-card>
            <lab-card id=""gtool5""
                      lab="" Lab 5""
                      image=""https://itcats.in/images/spinner-loop.gif""
                      itemname=""Loading""
                      vol=""0""
                      desc=""");
            WriteLiteral("Loading\"\r\n                      lablint=\"true\"\r\n                      itemid=\"ce8227bb-7ecd-41ea-a9dd-81078bbf496d\"></lab-card>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
