#pragma checksum "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Areas\Admin\Views\Shared\Components\Statistic2\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "207ce1ea158c27906658ed596a0b39aa494334ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_Statistic2_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/Statistic2/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"207ce1ea158c27906658ed596a0b39aa494334ed", @"/Areas/Admin/Views/Shared/Components/Statistic2/Default.cshtml")]
    public class Areas_Admin_Views_Shared_Components_Statistic2_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-6"">
        <div class=""widget navy-bg no-padding"">
            <div class=""p-m"">
                <h1 class=""m-xs"">Dashboard</h1>
                <h3 class=""font-bold no-margins"">
                    Asp.Net Core
                </h3>
                <small>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its.</small>
            </div>
            <div class=""flot-chart"">
                <div class=""flot-chart-content"" id=""flot-chart1""></div>
            </div>
        </div>
    </div>
    <div class=""col-lg-3"">
        <div class=""widget lazur-bg no-padding"">
            <div class=""p-m"">
                <h1 class=""m-xs"">Son Blog</h1>

                <h4 class=""font-bold no-margins"">
                    ");
#nullable restore
#line 26 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Areas\Admin\Views\Shared\Components\Statistic2\Default.cshtml"
               Write(ViewBag.v1);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </h4>
                <small><a href=""/Blog/Index"" style=""color:white"">Tüm Bloglar  <i class=""fa fa-arrow-circle-right""></i> </a></small>
            </div>
            <div class=""flot-chart"">
                <div class=""flot-chart-content"" id=""flot-chart2""></div>
            </div>
        </div>
    </div>
    <div class=""col-lg-3"">
        <div class=""widget yellw-bg no-padding"">
            <div class=""p-m"">
                <h1 class=""m-xs"">$ 50,992</h1>

                <h3 class=""font-bold no-margins"">
                    Half-year revenue margin
                </h3>
                <small>Sales marketing.</small>
            </div>
            <div class=""flot-chart"">
                <div class=""flot-chart-content"" id=""flot-chart3""></div>
            </div>
        </div>
    </div>
</div>");
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