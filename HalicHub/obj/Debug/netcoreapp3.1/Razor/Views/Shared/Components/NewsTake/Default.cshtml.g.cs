#pragma checksum "C:\Users\muhammetkaya\Desktop\hhub-main\HalicHub\Views\Shared\Components\NewsTake\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2c9b63998f0f7940ae96e1768dc6c3b2639c46d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_NewsTake_Default), @"mvc.1.0.view", @"/Views/Shared/Components/NewsTake/Default.cshtml")]
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
#line 1 "C:\Users\muhammetkaya\Desktop\hhub-main\HalicHub\Views\_ViewImports.cshtml"
using HalicHub;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\muhammetkaya\Desktop\hhub-main\HalicHub\Views\_ViewImports.cshtml"
using HalicHub.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\muhammetkaya\Desktop\hhub-main\HalicHub\Views\_ViewImports.cshtml"
using Halic.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\muhammetkaya\Desktop\hhub-main\HalicHub\Views\_ViewImports.cshtml"
using HalicHub.ViewComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\muhammetkaya\Desktop\hhub-main\HalicHub\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\muhammetkaya\Desktop\hhub-main\HalicHub\Views\_ViewImports.cshtml"
using HalicHub.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\muhammetkaya\Desktop\hhub-main\HalicHub\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\muhammetkaya\Desktop\hhub-main\HalicHub\Views\_ViewImports.cshtml"
using HalicHub.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2c9b63998f0f7940ae96e1768dc6c3b2639c46d", @"/Views/Shared/Components/NewsTake/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1d447f06f600cad35a08585f36a3d6ae0aa3e3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_NewsTake_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section style=""margin-top: 50px; margin-bottom: 100px"">
    <div class=""popular-directorya-area  border-bottom section-padding40 fix"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""section-tittle text-center mb-80"">
                        <h2>Son Haberler</h2>
                    </div>
                </div>
            </div>
            <div class=""directory-active"">
");
#nullable restore
#line 13 "C:\Users\muhammetkaya\Desktop\hhub-main\HalicHub\Views\Shared\Components\NewsTake\Default.cshtml"
                 foreach (var item in Model.News)
                {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\muhammetkaya\Desktop\hhub-main\HalicHub\Views\Shared\Components\NewsTake\Default.cshtml"
Write(await Html.PartialAsync("_News", item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\muhammetkaya\Desktop\hhub-main\HalicHub\Views\Shared\Components\NewsTake\Default.cshtml"
                                           }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
