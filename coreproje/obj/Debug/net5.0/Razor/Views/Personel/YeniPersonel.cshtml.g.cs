#pragma checksum "C:\Users\msi\source\repos\coreproje\coreproje\Views\Personel\YeniPersonel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9416cb7eae97371c9909a9e56eaa4fdcbe8884a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personel_YeniPersonel), @"mvc.1.0.view", @"/Views/Personel/YeniPersonel.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9416cb7eae97371c9909a9e56eaa4fdcbe8884a4", @"/Views/Personel/YeniPersonel.cshtml")]
    public class Views_Personel_YeniPersonel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<coreproje.Models.Personel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\msi\source\repos\coreproje\coreproje\Views\Personel\YeniPersonel.cshtml"
  
    ViewData["Title"] = "YeniPersonel";
    Layout = "~/Views/Shared/_TestLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<form method=\"post\" class=\"form-group\" style=\"margin:20px;\">\r\n    <div>\r\n        <label>Personel Ad: </label><br />\r\n        ");
#nullable restore
#line 11 "C:\Users\msi\source\repos\coreproje\coreproje\Views\Personel\YeniPersonel.cshtml"
   Write(Html.TextBoxFor(q => q.Ad, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <label>Personel Soyad: </label><br />\r\n        ");
#nullable restore
#line 15 "C:\Users\msi\source\repos\coreproje\coreproje\Views\Personel\YeniPersonel.cshtml"
   Write(Html.TextBoxFor(q => q.Soyad, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <label>Personel Şehir: </label><br />\r\n        ");
#nullable restore
#line 19 "C:\Users\msi\source\repos\coreproje\coreproje\Views\Personel\YeniPersonel.cshtml"
   Write(Html.TextBoxFor(q => q.Sehir, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <label>Departman: </label><br />\r\n        ");
#nullable restore
#line 23 "C:\Users\msi\source\repos\coreproje\coreproje\Views\Personel\YeniPersonel.cshtml"
   Write(Html.DropDownListFor(q => q.departman.ID,(List<SelectListItem>)ViewBag.dp,new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div style=\"margin-top:15px;\">\r\n        <button class=\"btn btn-info\">Yeni Personel Ekle</button>\r\n    </div>\r\n</form>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<coreproje.Models.Personel> Html { get; private set; }
    }
}
#pragma warning restore 1591