#pragma checksum "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Views\Message\InBox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6bb5476909d5b8ee36a261032e92fcf9c7149e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_InBox), @"mvc.1.0.view", @"/Views/Message/InBox.cshtml")]
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
#nullable restore
#line 1 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Views\Message\InBox.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6bb5476909d5b8ee36a261032e92fcf9c7149e8", @"/Views/Message/InBox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"784938c45a729b1006f16b3b5ebaebddb8e24285", @"/Views/_ViewImports.cshtml")]
    public class Views_Message_InBox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message2>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Views\Message\InBox.cshtml"
  
    ViewData["Title"] = "InBox";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Gelen Kutusu</h1>

<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Konu</th>
            <th scope=""col"">Gönderen</th>
            <th scope=""col"">Tarih</th>
            <th scope=""col"">Mesajı Aç</th>
        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 22 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Views\Message\InBox.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th scope=\"row\">");
#nullable restore
#line 25 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Views\Message\InBox.cshtml"
                       Write(item.MessageID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Views\Message\InBox.cshtml"
           Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Views\Message\InBox.cshtml"
           Write(item.SenderUser.WriterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Views\Message\InBox.cshtml"
            Write(((DateTime) item.MessageDate).ToString("dd-MMM-yy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 764, "\"", 813, 2);
            WriteAttributeValue("", 771, "/Message/ShowMessageDetail/", 771, 27, true);
#nullable restore
#line 29 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Views\Message\InBox.cshtml"
WriteAttributeValue("", 798, item.MessageID, 798, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning btn-sm\">Mesajı Aç <i class=\"mdi mdi-email\"></i></a></td>\r\n        </tr>\r\n");
#nullable restore
#line 31 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Views\Message\InBox.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </tbody>\r\n</table>\r\n<a href=\"/Message/ShowMessageDetail/\" class=\"btn btn-outline-primary btn-sm\">Yeni Mesaj Oluştur <i class=\"mdi mdi-lead-pencil\"></i> </a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message2>> Html { get; private set; }
    }
}
#pragma warning restore 1591
