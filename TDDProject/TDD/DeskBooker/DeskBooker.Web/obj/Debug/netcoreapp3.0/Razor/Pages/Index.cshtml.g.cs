#pragma checksum "C:\Users\basma.essam\Desktop\Learning\TDD\DeskBooker\DeskBooker.Web\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a2bda4e8e19ab6a2fe6351eacb06e132821be9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DeskBooker.Web.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a2bda4e8e19ab6a2fe6351eacb06e132821be9e", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ccd0aaef2dc92c7e8903ef22aba6aa450a0fd4c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\basma.essam\Desktop\Learning\TDD\DeskBooker\DeskBooker.Web\Pages\Index.cshtml"
  
  ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 class=""display-4"">Welcome to Wired Brain Coffee</h1>

<div class=""card"">
  <div class=""card-header"">
    Book a desk
  </div>
  <div class=""card-body"">
    <p>
      Now you can book a desk for a full day in our coffee shop in Zurich.
      Enjoy a desk with two screens and unlimited coffee.
      Just bring in your laptop and you're ready to spend a productive office day in our coffee shop in Zurich.
    </p>
    <a href=""/bookDesk"" class=""btn btn-primary"">Book a desk</a>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
