#pragma checksum "C:\Users\emrey\source\repos\RentAndDrive\RentAndDrive\Views\CarAdminPanel\CarAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "599a8c418e54aff357b7fb54d214a722a5414cf7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CarAdminPanel_CarAdd), @"mvc.1.0.view", @"/Views/CarAdminPanel/CarAdd.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"599a8c418e54aff357b7fb54d214a722a5414cf7", @"/Views/CarAdminPanel/CarAdd.cshtml")]
    public class Views_CarAdminPanel_CarAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RentAndDrive.Models.Car>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\emrey\source\repos\RentAndDrive\RentAndDrive\Views\CarAdminPanel\CarAdd.cshtml"
  
    ViewData["Title"] = "Araç Ekle";
    Layout = "~/Views/Shared/_AdminPanelLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Yeni Araç Ekleme</h1>\r\n<br />\r\n<form class=\"form-group\" action=\"CarAdd\" asp-controller=\"CarAdminPanelController\" method=\"post\" enctype=\"multipart/form-data\">\r\n    ");
#nullable restore
#line 10 "C:\Users\emrey\source\repos\RentAndDrive\RentAndDrive\Views\CarAdminPanel\CarAdd.cshtml"
Write(Html.Label("Araba Markası"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 11 "C:\Users\emrey\source\repos\RentAndDrive\RentAndDrive\Views\CarAdminPanel\CarAdd.cshtml"
Write(Html.TextBoxFor(x => x.CarName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <br />\r\n    ");
#nullable restore
#line 14 "C:\Users\emrey\source\repos\RentAndDrive\RentAndDrive\Views\CarAdminPanel\CarAdd.cshtml"
Write(Html.Label("Modeli"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 15 "C:\Users\emrey\source\repos\RentAndDrive\RentAndDrive\Views\CarAdminPanel\CarAdd.cshtml"
Write(Html.TextBoxFor(x => x.Model, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <br />\r\n    ");
#nullable restore
#line 18 "C:\Users\emrey\source\repos\RentAndDrive\RentAndDrive\Views\CarAdminPanel\CarAdd.cshtml"
Write(Html.Label("Fiyatı"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 19 "C:\Users\emrey\source\repos\RentAndDrive\RentAndDrive\Views\CarAdminPanel\CarAdd.cshtml"
Write(Html.TextBoxFor(x => x.Price, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <br />\r\n    ");
#nullable restore
#line 22 "C:\Users\emrey\source\repos\RentAndDrive\RentAndDrive\Views\CarAdminPanel\CarAdd.cshtml"
Write(Html.Label("Yılı"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 23 "C:\Users\emrey\source\repos\RentAndDrive\RentAndDrive\Views\CarAdminPanel\CarAdd.cshtml"
Write(Html.TextBoxFor(x => x.Year, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <br />\r\n    ");
#nullable restore
#line 26 "C:\Users\emrey\source\repos\RentAndDrive\RentAndDrive\Views\CarAdminPanel\CarAdd.cshtml"
Write(Html.Label("Vites"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 27 "C:\Users\emrey\source\repos\RentAndDrive\RentAndDrive\Views\CarAdminPanel\CarAdd.cshtml"
Write(Html.TextBoxFor(x => x.Vites, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    ");
#nullable restore
#line 29 "C:\Users\emrey\source\repos\RentAndDrive\RentAndDrive\Views\CarAdminPanel\CarAdd.cshtml"
Write(Html.Label("Km"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 30 "C:\Users\emrey\source\repos\RentAndDrive\RentAndDrive\Views\CarAdminPanel\CarAdd.cshtml"
Write(Html.TextBoxFor(x => x.Km, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    ");
#nullable restore
#line 32 "C:\Users\emrey\source\repos\RentAndDrive\RentAndDrive\Views\CarAdminPanel\CarAdd.cshtml"
Write(Html.Label("Yakıt Türü"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 33 "C:\Users\emrey\source\repos\RentAndDrive\RentAndDrive\Views\CarAdminPanel\CarAdd.cshtml"
Write(Html.TextBoxFor(x => x.Yakit, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    ");
#nullable restore
#line 35 "C:\Users\emrey\source\repos\RentAndDrive\RentAndDrive\Views\CarAdminPanel\CarAdd.cshtml"
Write(Html.Label("Fotoğraf Url"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 36 "C:\Users\emrey\source\repos\RentAndDrive\RentAndDrive\Views\CarAdminPanel\CarAdd.cshtml"
Write(Html.TextBoxFor(x => x.ImageUrl, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <br />\r\n    ");
#nullable restore
#line 39 "C:\Users\emrey\source\repos\RentAndDrive\RentAndDrive\Views\CarAdminPanel\CarAdd.cshtml"
Write(Html.Label("Category"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 40 "C:\Users\emrey\source\repos\RentAndDrive\RentAndDrive\Views\CarAdminPanel\CarAdd.cshtml"
Write(Html.DropDownListFor(x => x.CategoryId, (List<SelectListItem>)ViewBag.value, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n \r\n    <button class=\"btn btn-primary\">Kaydet</button>\r\n\r\n</form>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RentAndDrive.Models.Car> Html { get; private set; }
    }
}
#pragma warning restore 1591
