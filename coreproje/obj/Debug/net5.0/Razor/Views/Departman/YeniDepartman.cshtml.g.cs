#pragma checksum "C:\Users\msi\source\repos\coreproje\coreproje\Views\Departman\YeniDepartman.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e222cb0a1d91f4af3df347656b86e1a37b25ece7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Departman_YeniDepartman), @"mvc.1.0.view", @"/Views/Departman/YeniDepartman.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e222cb0a1d91f4af3df347656b86e1a37b25ece7", @"/Views/Departman/YeniDepartman.cshtml")]
    public class Views_Departman_YeniDepartman : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<coreproje.Models.Departman>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\msi\source\repos\coreproje\coreproje\Views\Departman\YeniDepartman.cshtml"
  
    ViewData["Title"] = "YeniDepartman";
    Layout = "~/Views/Shared/_TestLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<form method=\"post\" class=\"form-group\" style=\"margin:20px;\">\r\n    <div>\r\n        <label>Departman Adı: </label><br />\r\n        ");
#nullable restore
#line 11 "C:\Users\msi\source\repos\coreproje\coreproje\Views\Departman\YeniDepartman.cshtml"
   Write(Html.TextBoxFor(q => q.Ad, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div style=\"margin-top:15px;\">\r\n        <button class=\"btn btn-info\">Ekle</button>\r\n    </div>\r\n</form>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<coreproje.Models.Departman> Html { get; private set; }
    }
}
#pragma warning restore 1591
