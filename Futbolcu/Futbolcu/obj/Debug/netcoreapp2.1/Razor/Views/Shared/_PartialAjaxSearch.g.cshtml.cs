#pragma checksum "C:\Users\ADMIN\source\repos\Futbolcu\Futbolcu\Views\Shared\_PartialAjaxSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89ee60e294b6731cd10ca26d4e2f04d3f6b77a66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PartialAjaxSearch), @"mvc.1.0.view", @"/Views/Shared/_PartialAjaxSearch.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_PartialAjaxSearch.cshtml", typeof(AspNetCore.Views_Shared__PartialAjaxSearch))]
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
#line 1 "C:\Users\ADMIN\source\repos\Futbolcu\Futbolcu\Views\_ViewImports.cshtml"
using Futbolcu;

#line default
#line hidden
#line 2 "C:\Users\ADMIN\source\repos\Futbolcu\Futbolcu\Views\_ViewImports.cshtml"
using Futbolcu.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89ee60e294b6731cd10ca26d4e2f04d3f6b77a66", @"/Views/Shared/_PartialAjaxSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b6fcfadefea48fd1492de2e1e4ad65cfbeb2b7e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PartialAjaxSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Futbolcu.Models.PostVM.PostVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("AL-nın finalına bilet satışından əldə olunan vəsait UEFA-ya gedəcək"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%;height:170px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onerror", new global::Microsoft.AspNetCore.Html.HtmlString("this.onerror=null;this.src=\'images/default-image.html\';"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ADMIN\source\repos\Futbolcu\Futbolcu\Views\Shared\_PartialAjaxSearch.cshtml"
 foreach (var item in Model.Posts)
{

#line default
#line hidden
            BeginContext(79, 111, true);
            WriteLiteral("    <div class=\"col-sm-12 col-md-6 col-lg-4 \">\r\n        <div class=\"item\" style=\"height:auto;\">\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 190, "\"", 222, 2);
            WriteAttributeValue("", 197, "/Home/Details?id=", 197, 17, true);
#line 7 "C:\Users\ADMIN\source\repos\Futbolcu\Futbolcu\Views\Shared\_PartialAjaxSearch.cshtml"
WriteAttributeValue("", 214, item.Id, 214, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(223, 82, true);
            WriteLiteral(">\r\n\r\n                <div class=\"caption\">\r\n                    <div class=\"date\">");
            EndContext();
            BeginContext(306, 9, false);
#line 10 "C:\Users\ADMIN\source\repos\Futbolcu\Futbolcu\Views\Shared\_PartialAjaxSearch.cshtml"
                                 Write(item.Date);

#line default
#line hidden
            EndContext();
            BeginContext(315, 93, true);
            WriteLiteral("</div>\r\n                    <div class=\"wrap\"></div>\r\n                    <h3 class=\"title\"> ");
            EndContext();
            BeginContext(409, 10, false);
#line 12 "C:\Users\ADMIN\source\repos\Futbolcu\Futbolcu\Views\Shared\_PartialAjaxSearch.cshtml"
                                  Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(419, 88, true);
            WriteLiteral("</h3>\r\n\r\n                </div>\r\n                <div class=\"img\">\r\n                    ");
            EndContext();
            BeginContext(507, 233, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4aa28f61bfb8417bb180c6066f232f96", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 591, "~/images/", 591, 9, true);
#line 16 "C:\Users\ADMIN\source\repos\Futbolcu\Futbolcu\Views\Shared\_PartialAjaxSearch.cshtml"
AddHtmlAttributeValue("", 600, item.Image, 600, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(740, 67, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"show__count\">");
            EndContext();
            BeginContext(808, 10, false);
#line 19 "C:\Users\ADMIN\source\repos\Futbolcu\Futbolcu\Views\Shared\_PartialAjaxSearch.cshtml"
                                    Write(item.Count);

#line default
#line hidden
            EndContext();
            BeginContext(818, 54, true);
            WriteLiteral("</div>\r\n            </a>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 23 "C:\Users\ADMIN\source\repos\Futbolcu\Futbolcu\Views\Shared\_PartialAjaxSearch.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Futbolcu.Models.PostVM.PostVM> Html { get; private set; }
    }
}
#pragma warning restore 1591