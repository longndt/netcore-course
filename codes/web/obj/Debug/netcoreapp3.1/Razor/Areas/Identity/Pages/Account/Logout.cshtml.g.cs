#pragma checksum "D:\workspace\Teaching\netcore-course\codes\web\Areas\Identity\Pages\Account\Logout.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "241688ba6e50ccba9b7adadac7c8ab48ae7c006c7bf9eec7bdb6109741cde737"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Areas_Identity_Pages_Account_Logout), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Logout.cshtml")]
namespace AspNetCoreGeneratedDocument
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\workspace\Teaching\netcore-course\codes\web\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity

#nullable disable
    ;
#nullable restore
#line 2 "D:\workspace\Teaching\netcore-course\codes\web\Areas\Identity\Pages\_ViewImports.cshtml"
using web.Areas.Identity

#nullable disable
    ;
#nullable restore
#line 3 "D:\workspace\Teaching\netcore-course\codes\web\Areas\Identity\Pages\_ViewImports.cshtml"
using web.Areas.Identity.Pages

#nullable disable
    ;
#nullable restore
#line 1 "D:\workspace\Teaching\netcore-course\codes\web\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using web.Areas.Identity.Pages.Account

#nullable disable
    ;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"241688ba6e50ccba9b7adadac7c8ab48ae7c006c7bf9eec7bdb6109741cde737", @"/Areas/Identity/Pages/Account/Logout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"01c4ec7f00158df8cb56ac1579dbd8fb6b42b1c2b6f50563296c9b0b99cd7e7f", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"8732e139f91668a50f4e7d15f3be7a2524ee3a4ef5ac739c0a49c0e5c0e8283d", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Areas_Identity_Pages_Account_Logout : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\workspace\Teaching\netcore-course\codes\web\Areas\Identity\Pages\Account\Logout.cshtml"
  
    ViewData["Title"] = "Log out";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<header>\r\n    <h1>");
            Write(
#nullable restore
#line 8 "D:\workspace\Teaching\netcore-course\codes\web\Areas\Identity\Pages\Account\Logout.cshtml"
         ViewData["Title"]

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h1>\r\n    <p>You have successfully logged out of the application.</p>\r\n</header>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LogoutModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LogoutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LogoutModel>)PageContext?.ViewData;
        public LogoutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
