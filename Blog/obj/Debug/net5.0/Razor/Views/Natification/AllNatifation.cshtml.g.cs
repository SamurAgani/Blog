#pragma checksum "C:\Users\Samur\OneDrive\Masaüstü\Blog\Blog\Views\Natification\AllNatifation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1084e9d19446a99d3bab042372ed5f6096370328"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Natification_AllNatifation), @"mvc.1.0.view", @"/Views/Natification/AllNatifation.cshtml")]
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
#line 1 "C:\Users\Samur\OneDrive\Masaüstü\Blog\Blog\Views\_ViewImports.cshtml"
using Blog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Samur\OneDrive\Masaüstü\Blog\Blog\Views\_ViewImports.cshtml"
using Blog.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Samur\OneDrive\Masaüstü\Blog\Blog\Views\Natification\AllNatifation.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1084e9d19446a99d3bab042372ed5f6096370328", @"/Views/Natification/AllNatifation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60de8826b8954e9153bb5ddebbd8520bddd0a921", @"/Views/_ViewImports.cshtml")]
    public class Views_Natification_AllNatifation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Natification>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Samur\OneDrive\Masaüstü\Blog\Blog\Views\Natification\AllNatifation.cshtml"
  
    ViewData["Title"] = "AllNatifation";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Notifications</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Notification</th>\r\n        <th>Date</th>\r\n    </tr>\r\n");
#nullable restore
#line 16 "C:\Users\Samur\OneDrive\Masaüstü\Blog\Blog\Views\Natification\AllNatifation.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\Samur\OneDrive\Masaüstü\Blog\Blog\Views\Natification\AllNatifation.cshtml"
           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\Samur\OneDrive\Masaüstü\Blog\Blog\Views\Natification\AllNatifation.cshtml"
           Write(item.NatifationDetails);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\Samur\OneDrive\Masaüstü\Blog\Blog\Views\Natification\AllNatifation.cshtml"
           Write(item.NatificationDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td></td>\r\n        </tr>\r\n");
#nullable restore
#line 24 "C:\Users\Samur\OneDrive\Masaüstü\Blog\Blog\Views\Natification\AllNatifation.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Natification>> Html { get; private set; }
    }
}
#pragma warning restore 1591