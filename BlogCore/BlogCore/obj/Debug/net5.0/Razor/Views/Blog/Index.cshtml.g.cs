#pragma checksum "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39b662c2909792cb394825d1bbccc90fbf922971"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Views\Blog\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39b662c2909792cb394825d1bbccc90fbf922971", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"784938c45a729b1006f16b3b5ebaebddb8e24285", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "39b662c2909792cb394825d1bbccc90fbf9229714209", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<section class=""main-content-w3layouts-agileits"">
    <div class=""container"">
        <h3 class=""tittle"">Blog Posts</h3>
        <div class=""inner-sec"">
            <!--left-->
            <div class=""left-blog-info-w3layouts-agileits text-left"">
                <div class=""row mb-4"">
");
#nullable restore
#line 16 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Views\Blog\Index.cshtml"
                     foreach (var item in Model)
                    {



#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-4 card\" >\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 661, "\"", 698, 2);
            WriteAttributeValue("", 668, "/Blog/BlogReadAll/", 668, 18, true);
#nullable restore
#line 21 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Views\Blog\Index.cshtml"
WriteAttributeValue("", 686, item.BlogID, 686, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 734, "\"", 764, 1);
#nullable restore
#line 22 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Views\Blog\Index.cshtml"
WriteAttributeValue("", 740, item.BlogThumbnailImage, 740, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", "   alt=\"", 796, "\"", 804, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </a>
                        <div class=""card-body"">
                            <ul class=""blog-icons my-4"">
                                <li>
                                    <a href=""#"">
                                        <i class=""far fa-calendar-alt""></i> ");
#nullable restore
#line 28 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Views\Blog\Index.cshtml"
                                                                        Write(((DateTime) item.BlogCreatingDate).ToString("dd-MMM-yy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </a>\r\n                                </li>\r\n                                <li class=\"mx-2\">\r\n                                    <a href=\"#\">\r\n                                        <i class=\"far fa-comment\"></i> ");
#nullable restore
#line 33 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Views\Blog\Index.cshtml"
                                                                  Write(item.BlogCommentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </a>\r\n                                </li>\r\n                                <li>\r\n                                    <a href=\"#\">\r\n");
            WriteLiteral("                                        <i class=\"fa fa-hashtag\"></i> ");
#nullable restore
#line 39 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Views\Blog\Index.cshtml"
                                                                 Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        \r\n                                    </a>\r\n                                </li>\r\n\r\n                            </ul>\r\n                            <h5 class=\"card-title\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2062, "\"", 2099, 2);
            WriteAttributeValue("", 2069, "/Blog/BlogReadAll/", 2069, 18, true);
#nullable restore
#line 46 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2087, item.BlogID, 2087, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 46 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Views\Blog\Index.cshtml"
                                                                    Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </h5>\r\n                            <p class=\"card-text mb-3\">");
#nullable restore
#line 48 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Views\Blog\Index.cshtml"
                                                 Write(item.BlogContent.Substring(0,item.BlogContent.Substring(0,130).LastIndexOf("")));

#line default
#line hidden
#nullable disable
            WriteLiteral("... </p>\r\n\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2333, "\"", 2370, 2);
            WriteAttributeValue("", 2340, "/Blog/BlogReadAll/", 2340, 18, true);
#nullable restore
#line 50 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2358, item.BlogID, 2358, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary read-m\">Devam??n?? oku...</a>\r\n                        </div>\r\n                    </div>\r\n                    <br/>\r\n");
#nullable restore
#line 54 "C:\Users\LENOVO\source\repos\BlogCore\BlogCore\Views\Blog\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    <nav aria-label=""Page navigation example"">
                        <ul class=""pagination justify-content-left mt-4"">
                            <li class=""page-item disabled"">
                                <a class=""page-link"" href=""#"" tabindex=""-1"">Previous</a>
                            </li>
                            <li class=""page-item"">
                                <a class=""page-link"" href=""#"">1</a>
                            </li>
                            <li class=""page-item"">
                                <a class=""page-link"" href=""#"">2</a>
                            </li>
                            <li class=""page-item"">
                                <a class=""page-link"" href=""#"">3</a>
                            </li>
                            <li class=""page-item"">
                                <a class=""page-link"" href=""#"">Next</a>
                            </li>
                        </ul>
                    </nav>
           ");
            WriteLiteral("     </div>\r\n                <!--//left-->\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
