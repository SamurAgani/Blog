#pragma checksum "C:\Users\Samur\OneDrive\Masaüstü\Blog\Blog\Views\Blog\EditBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b273d9e2bc3e6e0dfc62fc602bc3977b35f75c43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_EditBlog), @"mvc.1.0.view", @"/Views/Blog/EditBlog.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b273d9e2bc3e6e0dfc62fc602bc3977b35f75c43", @"/Views/Blog/EditBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60de8826b8954e9153bb5ddebbd8520bddd0a921", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_EditBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Blog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Samur\OneDrive\Masaüstü\Blog\Blog\Views\Blog\EditBlog.cshtml"
  
    ViewData["Title"] = "EditBlog";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Samur\OneDrive\Masaüstü\Blog\Blog\Views\Blog\EditBlog.cshtml"
 using (Html.BeginForm("EditBlog", "Blog", FormMethod.Post))
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Samur\OneDrive\Masaüstü\Blog\Blog\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Id"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Samur\OneDrive\Masaüstü\Blog\Blog\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x => x.BlogID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Samur\OneDrive\Masaüstü\Blog\Blog\Views\Blog\EditBlog.cshtml"
Write(Html.ValidationMessageFor(x => x.BlogID));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 13 "C:\Users\Samur\OneDrive\Masaüstü\Blog\Blog\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Title"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Samur\OneDrive\Masaüstü\Blog\Blog\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x => x.BlogTitle, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Samur\OneDrive\Masaüstü\Blog\Blog\Views\Blog\EditBlog.cshtml"
Write(Html.ValidationMessageFor(x => x.BlogTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 17 "C:\Users\Samur\OneDrive\Masaüstü\Blog\Blog\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Image"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Samur\OneDrive\Masaüstü\Blog\Blog\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x => x.BlogImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Samur\OneDrive\Masaüstü\Blog\Blog\Views\Blog\EditBlog.cshtml"
Write(Html.ValidationMessageFor(x => x.BlogImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 21 "C:\Users\Samur\OneDrive\Masaüstü\Blog\Blog\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Thumbnail"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Samur\OneDrive\Masaüstü\Blog\Blog\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x => x.BlogThumbnailImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Samur\OneDrive\Masaüstü\Blog\Blog\Views\Blog\EditBlog.cshtml"
Write(Html.ValidationMessageFor(x => x.BlogThumbnailImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 25 "C:\Users\Samur\OneDrive\Masaüstü\Blog\Blog\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Category"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Samur\OneDrive\Masaüstü\Blog\Blog\Views\Blog\EditBlog.cshtml"
Write(Html.DropDownListFor(x => x.CategoryID, (List<SelectListItem>)ViewBag.cv, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 28 "C:\Users\Samur\OneDrive\Masaüstü\Blog\Blog\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Content"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Samur\OneDrive\Masaüstü\Blog\Blog\Views\Blog\EditBlog.cshtml"
Write(Html.TextAreaFor(x => x.BlogContent, 15, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Samur\OneDrive\Masaüstü\Blog\Blog\Views\Blog\EditBlog.cshtml"
Write(Html.ValidationMessageFor(x => x.BlogContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-success\">Save</button>\r\n");
#nullable restore
#line 33 "C:\Users\Samur\OneDrive\Masaüstü\Blog\Blog\Views\Blog\EditBlog.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
