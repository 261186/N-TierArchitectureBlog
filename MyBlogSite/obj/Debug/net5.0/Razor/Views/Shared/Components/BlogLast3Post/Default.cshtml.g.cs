#pragma checksum "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Shared\Components\BlogLast3Post\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bb7fc4234f0bbb314e6a73259b6e2a17f1b0ce3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogLast3Post_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogLast3Post/Default.cshtml")]
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
#line 1 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Shared\Components\BlogLast3Post\Default.cshtml"
using MyBlogSite.Entities.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bb7fc4234f0bbb314e6a73259b6e2a17f1b0ce3", @"/Views/Shared/Components/BlogLast3Post/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f49f5c77bc5267b6d715adb0850487e31dd72c22", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_BlogLast3Post_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"tech-btm\">\r\n    <h3>Son Gönderiler</h3>\r\n");
#nullable restore
#line 5 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Shared\Components\BlogLast3Post\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"blog-grids row mb-3\">\r\n            <div class=\"col-md-5 blog-grid-left\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 262, "\"", 299, 2);
            WriteAttributeValue("", 269, "/Blog/BlogReadAll/", 269, 18, true);
#nullable restore
#line 9 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Shared\Components\BlogLast3Post\Default.cshtml"
WriteAttributeValue("", 287, item.BlogID, 287, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 327, "\"", 348, 1);
#nullable restore
#line 10 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Shared\Components\BlogLast3Post\Default.cshtml"
WriteAttributeValue("", 333, item.BlogImage, 333, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 380, "\"", 386, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </a>\r\n            </div>\r\n            <div class=\"col-md-7 blog-grid-right\">\r\n                <h5>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 528, "\"", 565, 2);
            WriteAttributeValue("", 535, "/Blog/BlogReadAll/", 535, 18, true);
#nullable restore
#line 15 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Shared\Components\BlogLast3Post\Default.cshtml"
WriteAttributeValue("", 553, item.BlogID, 553, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 15 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Shared\Components\BlogLast3Post\Default.cshtml"
                                                        Write(item.BlogContent.Substring(0,item.BlogContent.Substring(0,50).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</a>\r\n                </h5>\r\n                <div class=\"sub-meta\">\r\n                    <span>\r\n                        <i class=\"far fa-clock\"></i> ");
#nullable restore
#line 19 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Shared\Components\BlogLast3Post\Default.cshtml"
                                                 Write(((DateTime)item.BlogCreateDate).ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 24 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Shared\Components\BlogLast3Post\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
