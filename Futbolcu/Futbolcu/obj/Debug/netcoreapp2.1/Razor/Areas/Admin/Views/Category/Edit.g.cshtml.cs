#pragma checksum "C:\Users\ADMIN\source\repos\Futbolcu\Futbolcu\Areas\Admin\Views\Category\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "127c493fa9ab39cce76b641f94852190962915e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Category/Edit.cshtml", typeof(AspNetCore.Areas_Admin_Views_Category_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"127c493fa9ab39cce76b641f94852190962915e0", @"/Areas/Admin/Views/Category/Edit.cshtml")]
    public class Areas_Admin_Views_Category_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Futbolcu.Models.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ADMIN\source\repos\Futbolcu\Futbolcu\Areas\Admin\Views\Category\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(127, 343, true);
            WriteLiteral(@"
<h2>Edit</h2>


<div class=""row"">
    <div class=""col-md-4"">
        <form method=""post"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>

            <div class=""form-group"">
                <label asp-for=""Name"" class=""control-label""></label>
                <input name=""Name"" class=""form-control""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 470, "\"", 489, 1);
#line 18 "C:\Users\ADMIN\source\repos\Futbolcu\Futbolcu\Areas\Admin\Views\Category\Edit.cshtml"
WriteAttributeValue("", 478, Model.Name, 478, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(490, 281, true);
            WriteLiteral(@" />
                <span asp-validation-for=""Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-success"" />
            </div>
        </form>
    </div>
</div>



");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Futbolcu.Models.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
