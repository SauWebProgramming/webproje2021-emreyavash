#pragma checksum "C:\Users\emrey\source\repos\RentAndDrive\RentAndDrive\Views\Shared\Components\CategoryGetList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a495fae240ea9100a7df25fff7f025e32b523e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryGetList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryGetList/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a495fae240ea9100a7df25fff7f025e32b523e1", @"/Views/Shared/Components/CategoryGetList/Default.cshtml")]
    public class Views_Shared_Components_CategoryGetList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RentAndDrive.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<ul class=\"categoryListContainer\">\r\n");
#nullable restore
#line 6 "C:\Users\emrey\source\repos\RentAndDrive\RentAndDrive\Views\Shared\Components\CategoryGetList\Default.cshtml"
     foreach (var item in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"categoryList\"><a class=\"categoryText\"");
            BeginWriteAttribute("href", " href=\"", 209, "\"", 243, 2);
            WriteAttributeValue("", 216, "/Home/Cars/", 216, 11, true);
#nullable restore
#line 9 "C:\Users\emrey\source\repos\RentAndDrive\RentAndDrive\Views\Shared\Components\CategoryGetList\Default.cshtml"
WriteAttributeValue("", 227, item.CategoryId, 227, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 9 "C:\Users\emrey\source\repos\RentAndDrive\RentAndDrive\Views\Shared\Components\CategoryGetList\Default.cshtml"
                                                                                   Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 10 "C:\Users\emrey\source\repos\RentAndDrive\RentAndDrive\Views\Shared\Components\CategoryGetList\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</ul> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RentAndDrive.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
