#pragma checksum "D:\workspace\Teaching\netcore-course\codes\web\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "fa6f4805b2da5f2b6c8d87591e41cfa936fe9032a3e77feea42f89e33dbf0533"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Areas_Identity_Pages_Account_Manage__StatusMessage), @"mvc.1.0.view", @"/Areas/Identity/Pages/Account/Manage/_StatusMessage.cshtml")]
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
#nullable restore
#line 1 "D:\workspace\Teaching\netcore-course\codes\web\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using web.Areas.Identity.Pages.Account.Manage

#nullable disable
    ;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"fa6f4805b2da5f2b6c8d87591e41cfa936fe9032a3e77feea42f89e33dbf0533", @"/Areas/Identity/Pages/Account/Manage/_StatusMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"01c4ec7f00158df8cb56ac1579dbd8fb6b42b1c2b6f50563296c9b0b99cd7e7f", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"8732e139f91668a50f4e7d15f3be7a2524ee3a4ef5ac739c0a49c0e5c0e8283d", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"4aa67b5eb69a07203cdbc3468fcbeaffd39e948e608d292bfaa843b9b55a6d51", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Areas_Identity_Pages_Account_Manage__StatusMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 1 "D:\workspace\Teaching\netcore-course\codes\web\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml"
       string

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\workspace\Teaching\netcore-course\codes\web\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml"
 if (!String.IsNullOrEmpty(Model))
{
    var statusMessageClass = Model.StartsWith("Error") ? "danger" : "success";

#line default
#line hidden
#nullable disable

            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 144, "\"", 201, 4);
            WriteAttributeValue("", 152, "alert", 152, 5, true);
            WriteAttributeValue(" ", 157, "alert-", 158, 7, true);
            WriteAttributeValue("", 164, 
#nullable restore
#line 6 "D:\workspace\Teaching\netcore-course\codes\web\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml"
                             statusMessageClass

#line default
#line hidden
#nullable disable
            , 164, 19, false);
            WriteAttributeValue(" ", 183, "alert-dismissible", 184, 18, true);
            EndWriteAttribute();
            WriteLiteral(" role=\"alert\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\r\n        ");
            Write(
#nullable restore
#line 8 "D:\workspace\Teaching\netcore-course\codes\web\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml"
         Model

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 10 "D:\workspace\Teaching\netcore-course\codes\web\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
