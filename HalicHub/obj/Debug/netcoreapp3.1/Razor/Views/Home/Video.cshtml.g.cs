#pragma checksum "C:\Users\muhammetkaya\Desktop\hhub-main\HalicHub\Views\Home\Video.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0719bde229c6012c9e04006baae2f5636a45674d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Video), @"mvc.1.0.view", @"/Views/Home/Video.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0719bde229c6012c9e04006baae2f5636a45674d", @"/Views/Home/Video.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1d447f06f600cad35a08585f36a3d6ae0aa3e3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Video : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VideoListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\muhammetkaya\Desktop\hhub-main\HalicHub\Views\Home\Video.cshtml"
Write(await Html.PartialAsync("_Header"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<section class=\"videos spad\">\n    <div class=\"container\">\n        <div class=\"row\">\n            <div class=\"col-lg-12\">\n                ");
#nullable restore
#line 7 "C:\Users\muhammetkaya\Desktop\hhub-main\HalicHub\Views\Home\Video.cshtml"
           Write(await Component.InvokeAsync("VideoFirst"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                <div class=\"row\">\n                    <div class=\"videos__slider owl-carousel\">\n");
#nullable restore
#line 11 "C:\Users\muhammetkaya\Desktop\hhub-main\HalicHub\Views\Home\Video.cshtml"
                         foreach (var item in Model.Videos)
                        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\muhammetkaya\Desktop\hhub-main\HalicHub\Views\Home\Video.cshtml"
       Write(await Html.PartialAsync("_VideoList", item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\muhammetkaya\Desktop\hhub-main\HalicHub\Views\Home\Video.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>
        <div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
            <div class=""modal-dialog"" role=""document"">
                <div class=""modal-content"">


                    <div class=""modal-body"">

                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                        <!-- 16:9 aspect ratio -->
                        <div class=""embed-responsive embed-responsive-16by9"">
                            <iframe class=""embed-responsive-item""");
            BeginWriteAttribute("src", " src=\"", 1239, "\"", 1245, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"video\" allowscriptaccess=\"always\" allow=\"autoplay\"></iframe>\n                        </div>\n\n\n                    </div>\n\n                </div>\n            </div>\n        </div>\n    </div>\n</section>\n");
#nullable restore
#line 41 "C:\Users\muhammetkaya\Desktop\hhub-main\HalicHub\Views\Home\Video.cshtml"
Write(await Html.PartialAsync("_Footer"));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VideoListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
