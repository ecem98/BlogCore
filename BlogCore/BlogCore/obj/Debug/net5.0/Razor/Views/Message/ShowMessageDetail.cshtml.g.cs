#pragma checksum "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Views\Message\ShowMessageDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47eba704e48eedadbce9b2048d3ff016686ef7a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_ShowMessageDetail), @"mvc.1.0.view", @"/Views/Message/ShowMessageDetail.cshtml")]
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
#line 1 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Views\_ViewImports.cshtml"
using BlogCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Views\_ViewImports.cshtml"
using BlogCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47eba704e48eedadbce9b2048d3ff016686ef7a0", @"/Views/Message/ShowMessageDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"784938c45a729b1006f16b3b5ebaebddb8e24285", @"/Views/_ViewImports.cshtml")]
    public class Views_Message_ShowMessageDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Message2>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Views\Message\ShowMessageDetail.cshtml"
  
    ViewData["Title"] = "ShowMessageDetail";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-md-12\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">");
#nullable restore
#line 9 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Views\Message\ShowMessageDetail.cshtml"
                              Write(Model.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <div><h6 class=\"card-subtitle mb-2 text-muted\">");
#nullable restore
#line 10 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Views\Message\ShowMessageDetail.cshtml"
                                                      Write(Model.SenderUser.WriterName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"mailbox-read-time float-right\">");
#nullable restore
#line 10 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Views\Message\ShowMessageDetail.cshtml"
                                                                                                                                Write(((DateTime) Model.MessageDate).ToString("dd-MMM-yy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h6></div>\r\n            <p class=\"card-text\">");
#nullable restore
#line 11 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Views\Message\ShowMessageDetail.cshtml"
                            Write(Model.MessageDetails);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <a href=\"Message/InBox\" class=\"btn btn-outline-success btn-sm\"><i class=\"mdi mdi-share\"></i> Mesajlara Dön</a>\r\n            \r\n        </div>\r\n    </div>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Message2> Html { get; private set; }
    }
}
#pragma warning restore 1591
