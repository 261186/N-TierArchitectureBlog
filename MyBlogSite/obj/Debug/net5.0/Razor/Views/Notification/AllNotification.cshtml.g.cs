#pragma checksum "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Notification\AllNotification.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3617a13e289277dbdea9c8cb5cb7a07cd8cd8f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Notification_AllNotification), @"mvc.1.0.view", @"/Views/Notification/AllNotification.cshtml")]
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
#line 1 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Notification\AllNotification.cshtml"
using MyBlogSite.Entities.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3617a13e289277dbdea9c8cb5cb7a07cd8cd8f2", @"/Views/Notification/AllNotification.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f49f5c77bc5267b6d715adb0850487e31dd72c22", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Notification_AllNotification : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Notification>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Notification\AllNotification.cshtml"
  
    ViewData["Title"] = "AllNotification";
    Layout = "~/Views/Shared/WriterLayot.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Bildirimler</h1>\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Bildirim Konusu</th>\r\n        <th>Bildirimler</th>\r\n        <th>Bildirim Tarihi</th>\r\n    </tr>\r\n");
#nullable restore
#line 17 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Notification\AllNotification.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Notification\AllNotification.cshtml"
           Write(item.NotificationID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Notification\AllNotification.cshtml"
           Write(item.NotificationType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Notification\AllNotification.cshtml"
           Write(item.NotificationDetails);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Notification\AllNotification.cshtml"
           Write(item.NotificationDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\n");
#nullable restore
#line 25 "C:\Users\drnma\Desktop\N-TierArchitectureBlog\MyBlogSite\Views\Notification\AllNotification.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Notification>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
