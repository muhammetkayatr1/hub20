#pragma checksum "C:\Users\muhammetkaya\Desktop\hhub-main\HalicHub\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfbddc96b374eb536e3b915b90b4020a320495bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfbddc96b374eb536e3b915b90b4020a320495bd", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1d447f06f600cad35a08585f36a3d6ae0aa3e3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\muhammetkaya\Desktop\hhub-main\HalicHub\Views\Home\Index.cshtml"
Write(await Html.PartialAsync("_Header"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\muhammetkaya\Desktop\hhub-main\HalicHub\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("Slider"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""ftco-section bg-light"" id=""schedule-section"">
    <div class=""container"">
        <div class=""row justify-content-center pb-5"">
            <div class=""col-md-12 heading-section text-center ftco-animate"">
                <h2 class=""mb-4"">Son Ekleneler</h2>
            </div>
        </div>
        <div class=""ftco-schedule"">
            <div class=""row"">
                <div class=""col-lg-4"">
                    <div class=""row"">
                        ");
#nullable restore
#line 14 "C:\Users\muhammetkaya\Desktop\hhub-main\HalicHub\Views\Home\Index.cshtml"
                   Write(await Html.PartialAsync("_IndexCategory"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n                <div class=\"col-lg-8 tab-wrap\">\n                    <div class=\"tab-content\" id=\"v-pills-tabContent\">\n                        ");
#nullable restore
#line 19 "C:\Users\muhammetkaya\Desktop\hhub-main\HalicHub\Views\Home\Index.cshtml"
                   Write(await Component.InvokeAsync("ArticleTake"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</section>\n");
#nullable restore
#line 26 "C:\Users\muhammetkaya\Desktop\hhub-main\HalicHub\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("Activities"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 27 "C:\Users\muhammetkaya\Desktop\hhub-main\HalicHub\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("NewsTake"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 28 "C:\Users\muhammetkaya\Desktop\hhub-main\HalicHub\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("Video"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 29 "C:\Users\muhammetkaya\Desktop\hhub-main\HalicHub\Views\Home\Index.cshtml"
Write(await Html.PartialAsync("_Footer"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
