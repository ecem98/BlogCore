#pragma checksum "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Areas\Admin\Views\Category\ListCategories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b6440708b7c25b988dab1e9f46ebe0bc246a2f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_ListCategories), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/ListCategories.cshtml")]
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
#line 1 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Areas\Admin\Views\Category\ListCategories.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Areas\Admin\Views\Category\ListCategories.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b6440708b7c25b988dab1e9f46ebe0bc246a2f1", @"/Areas/Admin/Views/Category/ListCategories.cshtml")]
    public class Areas_Admin_Views_Category_ListCategories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<EntityLayer.Concrete.Category>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Areas\Admin\Views\Category\ListCategories.cshtml"
  
    ViewData["Title"] = "ListCategories";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<script src=\"https://unpkg.com/sweetalert/dist/sweetalert.min.js\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b6440708b7c25b988dab1e9f46ebe0bc246a2f13827", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<h1>Kategori Listesi</h1>
<table class=""table table-bordered"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Kategori</th>
            <th scope=""col"">Aktif Yap</th>
            <th scope=""col"">Pasif Yap</th>
            <th scope=""col"">Düzenle</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 23 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Areas\Admin\Views\Category\ListCategories.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\" id=\"categoryId\">");
#nullable restore
#line 26 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Areas\Admin\Views\Category\ListCategories.cshtml"
                                           Write(item.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Areas\Admin\Views\Category\ListCategories.cshtml"
               Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 28 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Areas\Admin\Views\Category\ListCategories.cshtml"
                 if (item.CategoryStatus == true)
                {
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td><a href=\"#\" id=\"aktif\" class=\"btn btn-info\">Aktif </a></td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1061, "\"", 1111, 2);
            WriteAttributeValue("", 1068, "/Admin/Category/MakePasive/", 1068, 27, true);
#nullable restore
#line 32 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Areas\Admin\Views\Category\ListCategories.cshtml"
WriteAttributeValue("", 1095, item.CategoryID, 1095, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"pasif\" onclick=\"return confirm(\'Pasif Yapmak İstediğinize Emin misiniz?\');\" class=\"btn btn-outline-danger\">Pasif </a></td>\r\n");
#nullable restore
#line 33 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Areas\Admin\Views\Category\ListCategories.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1327, "\"", 1377, 2);
            WriteAttributeValue("", 1334, "/Admin/Category/MakeActive/", 1334, 27, true);
#nullable restore
#line 36 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Areas\Admin\Views\Category\ListCategories.cshtml"
WriteAttributeValue("", 1361, item.CategoryID, 1361, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Aktif Yapmak İstediğinize Emin misiniz?\');\" class=\"btn btn-outline-info\">Aktif </a></td>\r\n");
            WriteLiteral("                    <td><a href=\"#\" class=\"btn btn-danger\">Pasif </a></td>\r\n");
#nullable restore
#line 39 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Areas\Admin\Views\Category\ListCategories.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("             \r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 1646, "\"", 1700, 2);
            WriteAttributeValue("", 1653, "/Admin/Category/UpdateCategory/", 1653, 31, true);
#nullable restore
#line 41 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Areas\Admin\Views\Category\ListCategories.cshtml"
WriteAttributeValue("", 1684, item.CategoryID, 1684, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"delBtn\" onclick=\"return confirm(\'Güncellemek İstediğinize Emin misiniz?\');\" class=\"btn btn-outline-warning\">Düzenle</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 43 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Areas\Admin\Views\Category\ListCategories.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


    </tbody>
</table>


<div class=""float-right"">
    <a href=""/Admin/Category/ExportStaticExelList"" class=""btn btn-outline-success"">Exel Dosyasını İndir </a>
    <a href=""/Admin/Category/AddCategory"" class=""btn btn-outline-primary"">Yeni Kategori </a>
    <br />
    <br />
    <br />
    ");
#nullable restore
#line 58 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Areas\Admin\Views\Category\ListCategories.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("ListCategories", new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<EntityLayer.Concrete.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
