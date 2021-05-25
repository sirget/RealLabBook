#pragma checksum "C:\Users\bestv\Documents\GitHub\RealLabBook\RealLabBook\Views\Bookings\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bacf4804e33a2a50f7fb2cae6011bfce3e2aa5d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bookings_Index), @"mvc.1.0.view", @"/Views/Bookings/Index.cshtml")]
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
#line 1 "C:\Users\bestv\Documents\GitHub\RealLabBook\RealLabBook\Views\_ViewImports.cshtml"
using RealLabBook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bestv\Documents\GitHub\RealLabBook\RealLabBook\Views\_ViewImports.cshtml"
using RealLabBook.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\bestv\Documents\GitHub\RealLabBook\RealLabBook\Views\Bookings\Index.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bacf4804e33a2a50f7fb2cae6011bfce3e2aa5d1", @"/Views/Bookings/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f65343cbe2976bd8de915b1d0846221a402a747c", @"/Views/_ViewImports.cshtml")]
    public class Views_Bookings_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RealLabBook.Models.Booking>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\bestv\Documents\GitHub\RealLabBook\RealLabBook\Views\Bookings\Index.cshtml"
  
    ViewData["Title"] = "Booking";
    var quan = ViewData["ListQuan"] as List<int>;

#line default
#line hidden
#nullable disable
            DefineSection("JavaScript", async() => {
                WriteLiteral("\r\n    <script>\r\n        var lablint = false;\r\n    </script>\r\n    <script type=\"text/javascript\"");
                BeginWriteAttribute("src", " src=\"", 382, "\"", 421, 1);
#nullable restore
#line 14 "C:\Users\bestv\Documents\GitHub\RealLabBook\RealLabBook\Views\Bookings\Index.cshtml"
WriteAttributeValue("", 388, Url.Content("~/js/time-card.js"), 388, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\r\n");
            }
            );
            WriteLiteral(@"<div class=""sel-wrapper"">

    <div class=""topic"">Select Booking Time</div>
    <div class=""select"">
        <div class=""sel-date"">

            <div class=""input-wrapper"">
                <label class=""label"">Date</label>
                <input class=""input"" id=""dateinput"" type=""date"" />
            </div>
            <a id=""asearch""><button class=""sel-btn"" id=""sel-search"">SEARCH</button></a>
");
            WriteLiteral("                    <input class=\"input hide\" type=\"hidden\" id=\"userinput\"");
            BeginWriteAttribute("value", " value=\"", 999, "\"", 1100, 1);
#nullable restore
#line 31 "C:\Users\bestv\Documents\GitHub\RealLabBook\RealLabBook\Views\Bookings\Index.cshtml"
WriteAttributeValue("", 1007, Context.User.Claims.Where(claim => claim.Type ==
ClaimTypes.Email).FirstOrDefault().Value, 1007, 93, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
            WriteLiteral("                <div class=\"input-wrapper\">\r\n                    <label class=\"label\">Equity</label>\r\n                    <input class=\"input\" type=\"number\" min=\"1\" id=\"eqtinput\" />\r\n                </div>\r\n");
            WriteLiteral(@"
                <a id=""abook""><button class=""sel-btn"" id=""sel-book"">BOOK</button></a>
            </div>
        <div class=""sel-hour"">
            <div class=""title-hour"">Select Time interval</div>
            <div class=""card-container"">
                <time-card no=""1""
                           hour=""8.00""
                           e_hour=""9.00""");
            BeginWriteAttribute("vol", "\r\n                           vol=", 1712, "", 1753, 1);
#nullable restore
#line 48 "C:\Users\bestv\Documents\GitHub\RealLabBook\RealLabBook\Views\Bookings\Index.cshtml"
WriteAttributeValue("", 1745, quan[0], 1745, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" 
                           enough=""false""
                           id=""card1""
                           select=""false""></time-card>
                <time-card id=""card2""
                           select=""false""
                           hour=""9.00""
                           e_hour=""10.00""");
            BeginWriteAttribute("vol", "\r\n                           vol=", 2057, "", 2098, 1);
#nullable restore
#line 56 "C:\Users\bestv\Documents\GitHub\RealLabBook\RealLabBook\Views\Bookings\Index.cshtml"
WriteAttributeValue("", 2090, quan[1], 2090, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" \r\n                           enough=\"false\"></time-card>\r\n                <time-card id=\"card3\"\r\n                           select=\"false\"\r\n                           hour=\"10.00\"\r\n                           e_hour=\"11.00\"");
            BeginWriteAttribute("vol", "\r\n                           vol=", 2321, "", 2362, 1);
#nullable restore
#line 62 "C:\Users\bestv\Documents\GitHub\RealLabBook\RealLabBook\Views\Bookings\Index.cshtml"
WriteAttributeValue("", 2354, quan[2], 2354, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" \r\n                           enough=\"false\"></time-card>\r\n                <time-card id=\"card4\"\r\n                           select=\"false\"\r\n                           hour=\"11.00\"\r\n                           e_hour=\"12.00\"");
            BeginWriteAttribute("vol", "\r\n                           vol=", 2585, "", 2626, 1);
#nullable restore
#line 68 "C:\Users\bestv\Documents\GitHub\RealLabBook\RealLabBook\Views\Bookings\Index.cshtml"
WriteAttributeValue("", 2618, quan[3], 2618, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" \r\n                           enough=\"false\"></time-card>\r\n                <time-card id=\"card5\"\r\n                           select=\"false\"\r\n                           hour=\"12.00\"\r\n                           e_hour=\"13.00\"");
            BeginWriteAttribute("vol", "\r\n                           vol=", 2849, "", 2890, 1);
#nullable restore
#line 74 "C:\Users\bestv\Documents\GitHub\RealLabBook\RealLabBook\Views\Bookings\Index.cshtml"
WriteAttributeValue("", 2882, quan[4], 2882, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" \r\n                           enough=\"false\"></time-card>\r\n                <time-card id=\"card6\"\r\n                           select=\"false\"\r\n                           hour=\"13.00\"\r\n                           e_hour=\"14.00\"");
            BeginWriteAttribute("vol", "\r\n                           vol=", 3113, "", 3154, 1);
#nullable restore
#line 80 "C:\Users\bestv\Documents\GitHub\RealLabBook\RealLabBook\Views\Bookings\Index.cshtml"
WriteAttributeValue("", 3146, quan[5], 3146, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" \r\n                           enough=\"false\"></time-card>\r\n                <time-card id=\"card7\"\r\n                           select=\"false\"\r\n                           hour=\"14.00\"\r\n                           e_hour=\"15.00\"");
            BeginWriteAttribute("vol", "\r\n                           vol=", 3377, "", 3418, 1);
#nullable restore
#line 86 "C:\Users\bestv\Documents\GitHub\RealLabBook\RealLabBook\Views\Bookings\Index.cshtml"
WriteAttributeValue("", 3410, quan[6], 3410, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" \r\n                           enough=\"false\"></time-card>\r\n                <time-card id=\"card8\"\r\n                           select=\"false\"\r\n                           hour=\"15.00\"\r\n                           e_hour=\"16.00\"");
            BeginWriteAttribute("vol", "\r\n                           vol=", 3641, "", 3682, 1);
#nullable restore
#line 92 "C:\Users\bestv\Documents\GitHub\RealLabBook\RealLabBook\Views\Bookings\Index.cshtml"
WriteAttributeValue("", 3674, quan[7], 3674, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" \r\n                           enough=\"false\"></time-card>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RealLabBook.Models.Booking>> Html { get; private set; }
    }
}
#pragma warning restore 1591
