#pragma checksum "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Blog\EditBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e5615177b1ada84d3150ff61949364b2752e138"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e5615177b1ada84d3150ff61949364b2752e138", @"/Views/Blog/EditBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f49f5c77bc5267b6d715adb0850487e31dd72c22", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_EditBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyBlogSite.Entities.Concrete.Blog>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Blog\EditBlog.cshtml"
  
    ViewData["Title"] = "EditBlog";
    Layout = "~/Views/Shared/WriterLayot.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3 style=\"color:blue\">Blog Güncelleme</h3>\r\n<br />\r\n<br />\r\n");
#nullable restore
#line 10 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Blog\EditBlog.cshtml"
 using(Html.BeginForm("EditBlog","Blog",FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog ID"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(b => b.BlogID,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 15 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Başlığı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(b => b.BlogTitle,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 18 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Thumbnail Url"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(b => b.BlogThumbnailImage,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 21 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Görseli"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(b => b.BlogImage,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 24 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Kategorisi"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Blog\EditBlog.cshtml"
Write(Html.DropDownListFor(b => b.CategoryID,(List<SelectListItem>)ViewBag.category,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 27 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog İçeriği"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Blog\EditBlog.cshtml"
Write(Html.TextAreaFor(b => b.BlogContent,15,3,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />  \r\n");
            WriteLiteral("    <button class=\"btn btn-primary submit mb-4\">Güncelle</button>\r\n");
#nullable restore
#line 33 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Blog\EditBlog.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyBlogSite.Entities.Concrete.Blog> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
