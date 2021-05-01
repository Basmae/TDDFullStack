#pragma checksum "C:\Users\basma.essam\Desktop\Learning\TDD\DeskBooker\DeskBooker.Web\Pages\DeskBookings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75aa8962c9875971eb294d595af514e79f1bc890"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DeskBooker.Web.Pages.Pages_DeskBookings), @"mvc.1.0.razor-page", @"/Pages/DeskBookings.cshtml")]
namespace DeskBooker.Web.Pages
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
#line 1 "C:\Users\basma.essam\Desktop\Learning\TDD\DeskBooker\DeskBooker.Web\Pages\_ViewImports.cshtml"
using DeskBooker.Web;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75aa8962c9875971eb294d595af514e79f1bc890", @"/Pages/DeskBookings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ccd0aaef2dc92c7e8903ef22aba6aa450a0fd4c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_DeskBookings : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\basma.essam\Desktop\Learning\TDD\DeskBooker\DeskBooker.Web\Pages\DeskBookings.cshtml"
  
  ViewData["Title"] = "Desk Bookings";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 class=""display-4"">Desk Bookings</h1>

<p class=""lead"">Here you see a table with all desk bookings ordered by date.</p>

<hr />

<table class=""table table-striped table-bordered dt-responsive nowrap"">
  <thead class=""thead-light"">
    <tr>
      <th>Date</th>
      <th>Desk Id</th>
      <th>Email</th>
      <th>FirstName</th>
      <th>LastName</th>
    </tr>
  </thead>
  <tbody>
");
#nullable restore
#line 24 "C:\Users\basma.essam\Desktop\Learning\TDD\DeskBooker\DeskBooker.Web\Pages\DeskBookings.cshtml"
     foreach (var deskBooking in Model.DeskBookings)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <tr>\n        <td>");
#nullable restore
#line 27 "C:\Users\basma.essam\Desktop\Learning\TDD\DeskBooker\DeskBooker.Web\Pages\DeskBookings.cshtml"
       Write(deskBooking.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 28 "C:\Users\basma.essam\Desktop\Learning\TDD\DeskBooker\DeskBooker.Web\Pages\DeskBookings.cshtml"
       Write(deskBooking.DeskId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 29 "C:\Users\basma.essam\Desktop\Learning\TDD\DeskBooker\DeskBooker.Web\Pages\DeskBookings.cshtml"
       Write(deskBooking.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 30 "C:\Users\basma.essam\Desktop\Learning\TDD\DeskBooker\DeskBooker.Web\Pages\DeskBookings.cshtml"
       Write(deskBooking.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 31 "C:\Users\basma.essam\Desktop\Learning\TDD\DeskBooker\DeskBooker.Web\Pages\DeskBookings.cshtml"
       Write(deskBooking.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n      </tr>\n");
#nullable restore
#line 33 "C:\Users\basma.essam\Desktop\Learning\TDD\DeskBooker\DeskBooker.Web\Pages\DeskBookings.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </tbody>\n</table>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DeskBookingsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DeskBookingsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DeskBookingsModel>)PageContext?.ViewData;
        public DeskBookingsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
