#pragma checksum "C:\Users\bestv\Documents\GitHub\RealLabBook\RealLabBook\RealLabBook\Views\Tools\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9efae0d436a1ea077a7b06db92f9529d79f00c91"
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
#line 1 "C:\Users\bestv\Documents\GitHub\RealLabBook\RealLabBook\RealLabBook\Views\_ViewImports.cshtml"
using RealLabBook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bestv\Documents\GitHub\RealLabBook\RealLabBook\RealLabBook\Views\_ViewImports.cshtml"
using RealLabBook.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9efae0d436a1ea077a7b06db92f9529d79f00c91", @"/Views/Tools/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f65343cbe2976bd8de915b1d0846221a402a747c", @"/Views/_ViewImports.cshtml")]
    public class Views_Tools_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\bestv\Documents\GitHub\RealLabBook\RealLabBook\RealLabBook\Views\Tools\Index.cshtml"
  
    ViewData["Title"] = "LabBook";

#line default
#line hidden
#nullable disable
            DefineSection("JavaScript", async() => {
                WriteLiteral("\r\n    <script type=\"text/javascript\"");
                BeginWriteAttribute("src", " src=\"", 101, "\"", 139, 1);
#nullable restore
#line 6 "C:\Users\bestv\Documents\GitHub\RealLabBook\RealLabBook\RealLabBook\Views\Tools\Index.cshtml"
WriteAttributeValue("", 107, Url.Content("~/js/lab-card.js"), 107, 32, false);

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
                      itemName=""Voltmeter""
                      ToolID =""1""
                      vol=""12""
                      desc=""aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa""></lab-card>
            <lab-card lab="" Lab 2""
                      image=""https://images.unsplash.com/photo-1553063085-dbbf64d936ea?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1189&q=80""
                      itemName=""Arduino""
                      ToolID =""2""
                      vol=""12""
                      desc=""aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            WriteLiteral(@"aaaaaaaaaaaaaa""></lab-card>
            <lab-card lab="" Lab 3""
                      image=""https://www.ato.com/content/images/thumbs/0001186_200-mhz-digital-oscilloscope-24-channels-4-gsas_550.jpeg""
                      itemName=""Oscilloscope""
                      ToolID =""3""
                      vol=""12""
                      desc=""aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa""></lab-card>
            <lab-card lab="" Lab 4""
                      image=""https://cf.shopee.co.th/file/c44dfdb32f3d522113780557ae3779aa""
                      itemName=""Soldering Iron""
                      ToolID =""4""
                      vol=""12""
                      desc=""aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa""></lab-card>
            <lab-card lab="" Lab 5""
                      image=""https://images.unsplash.com/photo-1582648373212-d5bd3015d35c?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=fo");
            WriteLiteral(@"rmat&fit=crop&w=1042&q=80""
                      itemName=""Pliers""
                      ToolID =""5""
                      vol=""12""
                      desc=""aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa""></lab-card>
        </div>
    </div>
    <div class=""wrapper-lab"">
        <h1>Lab: goLabLint.com</h1>
        <div class=""card-container"">
            <lab-card lab="" Lab 1""
                      image=""https://cdn.discordapp.com/attachments/366279112488124416/839898183957610506/arduino-uno-rev3-a000066-0f4.png""
                      itemName=""Voltmeter""
                      vol=""12""
                      desc=""aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa""></lab-card>
            <lab-card lab="" Lab 2""
                      image=""https://cdn.discordapp.com/attachments/366279112488124416/839898183957610506/arduino-uno-rev3-a000066-0f4.png""
                      itemName=""Arduino""
                  ");
            WriteLiteral(@"    vol=""12""
                      desc=""aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa""></lab-card>
            <lab-card lab="" Lab 3""
                      image=""https://cdn.discordapp.com/attachments/366279112488124416/839898183957610506/arduino-uno-rev3-a000066-0f4.png""
                      itemName=""Oscilloscope""
                      vol=""12""
                      desc=""aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa""></lab-card>
            <lab-card lab="" Lab 4""
                      image=""https://cdn.discordapp.com/attachments/366279112488124416/839898183957610506/arduino-uno-rev3-a000066-0f4.png""
                      itemName=""Soldering Iron""
                      vol=""12""
                      desc=""aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa""></lab-card>
            <lab-card lab="" Lab 5""
                      image=""https://cdn.discordapp.com/attachme");
            WriteLiteral(@"nts/366279112488124416/839898183957610506/arduino-uno-rev3-a000066-0f4.png""
                      itemName=""Pliers""
                      vol=""12""
                      desc=""aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa""></lab-card>
        </div>
    </div>
</div>









");
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
