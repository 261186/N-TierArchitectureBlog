#pragma checksum "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Blog\BlogListByWriter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c783e3ff2a80f00438e906ee5c8b0195a59d289"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogListByWriter), @"mvc.1.0.view", @"/Views/Blog/BlogListByWriter.cshtml")]
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
#line 1 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\_ViewImports.cshtml"
using MyBlogSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\_ViewImports.cshtml"
using MyBlogSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Blog\BlogListByWriter.cshtml"
using MyBlogSite.Entities.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c783e3ff2a80f00438e906ee5c8b0195a59d289", @"/Views/Blog/BlogListByWriter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f49f5c77bc5267b6d715adb0850487e31dd72c22", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_BlogListByWriter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Blog\BlogListByWriter.cshtml"
  
    ViewData["Title"] = "BlogListByWriter";
    Layout = "~/Views/Shared/WriterLayot.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3 style=""color:blue"">Yazarın Blokları</h3>
<table class=""table table-bordered"">
    <tr style =""color:blue"">
        <th>#</th>
        <th>Blog Başlık</th>
        <th>Blog Tarihi</th>
        <th>Kategori</th>
        <th>Durumu</th>
        <th>Sil</th>
        <th>Düzenle</th>
    </tr>
");
#nullable restore
#line 19 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Blog\BlogListByWriter.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 22 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Blog\BlogListByWriter.cshtml"
           Write(item.BlogID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Blog\BlogListByWriter.cshtml"
           Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Blog\BlogListByWriter.cshtml"
            Write(((DateTime)item.BlogCreateDate).ToString("dd/MMM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Blog\BlogListByWriter.cshtml"
           Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>        \r\n            <td>");
#nullable restore
#line 26 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Blog\BlogListByWriter.cshtml"
           Write(item.BlogStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 788, "\"", 824, 2);
            WriteAttributeValue("", 795, "/Blog/BlogDelete/", 795, 17, true);
#nullable restore
#line 27 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Blog\BlogListByWriter.cshtml"
WriteAttributeValue("", 812, item.BlogID, 812, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 889, "\"", 923, 2);
            WriteAttributeValue("", 896, "/Blog/EditBlog/", 896, 15, true);
#nullable restore
#line 28 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Blog\BlogListByWriter.cshtml"
WriteAttributeValue("", 911, item.BlogID, 911, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning\">Düzenle</a></td>\r\n        </tr>\n");
#nullable restore
#line 30 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Blog\BlogListByWriter.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<br/>\r\n<a href=\"/Blog/BlogAdd/\" class=\"btn btn-outline-success\">Yeni Blog Ekle</a>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
