#pragma checksum "C:\Users\ADMIN\source\repos\Futbolcu\Futbolcu\Areas\Admin\Views\Category\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a27b4b5539d812c329e5b3dbec852bcb0b746270"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Category/Create.cshtml", typeof(AspNetCore.Areas_Admin_Views_Category_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a27b4b5539d812c329e5b3dbec852bcb0b746270", @"/Areas/Admin/Views/Category/Create.cshtml")]
    public class Areas_Admin_Views_Category_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Futbolcu.Models.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ADMIN\source\repos\Futbolcu\Futbolcu\Areas\Admin\Views\Category\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(129, 646, true);
            WriteLiteral(@"
<h2>Create</h2>



<div class=""row"">
    <div class=""col-md-4"">
        <form method=""post"" action=""Create"" >
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>

            <div class=""form-group"">
                <label asp-for=""Name"" class=""control-label""></label>
                <input name=""Name"" class=""form-control"" />
                <span asp-validation-for=""Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit""  value=""Create"" class=""btn btn-success"" />
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