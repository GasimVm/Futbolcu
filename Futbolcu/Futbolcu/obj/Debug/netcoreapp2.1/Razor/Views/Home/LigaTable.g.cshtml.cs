#pragma checksum "C:\Users\ADMIN\source\repos\Futbolcu\Futbolcu\Views\Home\LigaTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10fbc947360297b645aaa8eaeb42f6a7023b5123"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_LigaTable), @"mvc.1.0.view", @"/Views/Home/LigaTable.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/LigaTable.cshtml", typeof(AspNetCore.Views_Home_LigaTable))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10fbc947360297b645aaa8eaeb42f6a7023b5123", @"/Views/Home/LigaTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b6fcfadefea48fd1492de2e1e4ad65cfbeb2b7e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_LigaTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Futbolcu.Models.Country>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\ADMIN\source\repos\Futbolcu\Futbolcu\Views\Home\LigaTable.cshtml"
  
    ViewData["Title"] = "LigaTable";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(137, 254, true);
            WriteLiteral("\r\n<section class=\"product\">\r\n    <div class=\"container\">\r\n        <div class=\"row \" style=\"margin-top:20px;     margin-left: 180px;\">\r\n            <div class=\"col-sm-8 col-md-offset-2 col-md-8 col-md-offset-2 col-lg-8 col-lg-offset-2 \">\r\n                ");
            EndContext();
            BeginContext(391, 609, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "030e07482f3e4c1ab698920f243bd8bf", async() => {
                BeginContext(397, 200, true);
                WriteLiteral("\r\n                    <div class=\"form-group\">\r\n                        <label for=\"sel1\">Select list Country</label>\r\n                        <select class=\"form-control\" id=\"sel1\" name=\"sellist1\">\r\n");
                EndContext();
#line 15 "C:\Users\ADMIN\source\repos\Futbolcu\Futbolcu\Views\Home\LigaTable.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
                BeginContext(686, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(718, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a79931aa4224dafae73aeb778effd12", async() => {
                    BeginContext(744, 9, false);
#line 17 "C:\Users\ADMIN\source\repos\Futbolcu\Futbolcu\Views\Home\LigaTable.cshtml"
                                                    Write(item.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 17 "C:\Users\ADMIN\source\repos\Futbolcu\Futbolcu\Views\Home\LigaTable.cshtml"
AddHtmlAttributeValue("", 733, item.Id, 733, 8, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(762, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 18 "C:\Users\ADMIN\source\repos\Futbolcu\Futbolcu\Views\Home\LigaTable.cshtml"
                            }

#line default
#line hidden
                BeginContext(795, 198, true);
                WriteLiteral("\r\n\r\n                        </select>\r\n\r\n                    </div>\r\n                    <button type=\"submit\" style=\"margin-left: 180px;\" class=\"btn btn-primary\">Secim et</button>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1000, 5675, true);
            WriteLiteral(@"
            </div>
        </div>
        <div class=""row"" style=""margin-top:20px;     margin-left: 180px;"">
            <div class=""col-sm-8 col-md-offset-2 col-md-8 col-md-offset-2 col-lg-8 col-lg-offset-2 "">
                <iframe style=""display:none"" id=""10"" frameborder=""0"" scrolling=""no"" width=""520"" height=""600"" src=""https://www.fctables.com/england/premier-league/iframe/?type=table&lang_id=22&country=67&template=10&timezone=Asia/Baku&time=24&po=1&ma=1&wi=1&dr=1&los=1&gf=1&ga=1&gd=1&pts=1&ng=0&form=0&width=520&height=700&font=Verdana&fs=12&lh=22&bg=f0d3ad&fc=000000&logo=1&tlink=1&ths=1&thb=1&thba=f2cf77&thc=000000&bc=dddddd&hob=fcfcfc&hobc=e3c73b&lc=333333&sh=1&hfb=1&hbc=f06a58&hfc=0a090a""></iframe><div style=""text-align:center;""></div>
                <iframe style=""display:none"" id=""7"" frameborder=""0"" scrolling=""no"" width=""520"" height=""600"" src=""https://www.fctables.com/netherlands/eredivisie/iframe/?type=table&lang_id=22&country=155&template=19&timezone=Asia/Baku&time=24&po=1&ma=1&wi=1&dr=1&lo");
            WriteLiteral(@"s=1&gf=1&ga=1&gd=1&pts=1&ng=0&form=0&width=520&height=700&font=Verdana&fs=12&lh=22&bg=f0d3ad&fc=000000&logo=1&tlink=1&ths=1&thb=1&thba=f2cf77&thc=000000&bc=dddddd&hob=fcfcfc&hobc=e3c73b&lc=333333&sh=1&hfb=1&hbc=f06a58&hfc=0a090a""></iframe><div style=""text-align:center;""></div>
                <iframe style=""display:none"" id=""8"" frameborder=""0"" scrolling=""no"" width=""520"" height=""600"" src=""https://www.fctables.com/portugal/liga-zon-sagres/iframe/?type=table&lang_id=22&country=175&template=23&timezone=Asia/Baku&time=24&po=1&ma=1&wi=1&dr=1&los=1&gf=1&ga=1&gd=1&pts=1&ng=0&form=0&width=520&height=700&font=Verdana&fs=12&lh=22&bg=f0d3ad&fc=000000&logo=1&tlink=1&ths=1&thb=1&thba=f2cf77&thc=000000&bc=dddddd&hob=fcfcfc&hobc=e3c73b&lc=333333&sh=1&hfb=1&hbc=f06a58&hfc=0a090a""></iframe><div style=""text-align:center;""></div>
                <iframe style=""display:none"" id=""9"" frameborder=""0"" scrolling=""no"" width=""520"" height=""600"" src=""https://www.fctables.com/russia/premier-league/iframe/?type=table&lang_id=22&country=17");
            WriteLiteral(@"9&template=25&timezone=Asia/Baku&time=24&po=1&ma=1&wi=1&dr=1&los=1&gf=1&ga=1&gd=1&pts=1&ng=0&form=0&width=520&height=700&font=Verdana&fs=12&lh=22&bg=f0d3ad&fc=000000&logo=1&tlink=1&ths=1&thb=1&thba=f2cf77&thc=000000&bc=dddddd&hob=fcfcfc&hobc=e3c73b&lc=333333&sh=1&hfb=1&hbc=f06a58&hfc=0a090a""></iframe><div style=""text-align:center;""></div>
                <iframe style=""display:none"" id=""6"" frameborder=""0"" scrolling=""no"" width=""520"" height=""600"" src=""https://www.fctables.com/azerbaijan/premier-league/iframe/?type=table&lang_id=22&country=15&template=177&timezone=Asia/Baku&time=24&po=1&ma=1&wi=1&dr=1&los=1&gf=1&ga=1&gd=1&pts=1&ng=0&form=0&width=520&height=700&font=Verdana&fs=12&lh=22&bg=f0d3ad&fc=000000&logo=1&tlink=1&ths=1&thb=1&thba=f2cf77&thc=000000&bc=dddddd&hob=fcfcfc&hobc=e3c73b&lc=333333&sh=1&hfb=1&hbc=f06a58&hfc=0a090a""></iframe><div style=""text-align:center;""></div>
                <iframe style=""display:none"" id=""5"" frameborder=""0"" scrolling=""no"" width=""520"" height=""600"" src=""https://www.fctables.co");
            WriteLiteral(@"m/turkey/super-lig/iframe/?type=table&lang_id=22&country=220&template=33&timezone=Asia/Baku&time=24&po=1&ma=1&wi=1&dr=1&los=1&gf=1&ga=1&gd=1&pts=1&ng=0&form=0&width=520&height=700&font=Verdana&fs=12&lh=22&bg=f0d3ad&fc=000000&logo=1&tlink=1&ths=1&thb=1&thba=f2cf77&thc=000000&bc=dddddd&hob=fcfcfc&hobc=e3c73b&lc=333333&sh=1&hfb=1&hbc=f06a58&hfc=0a090a""></iframe><div style=""text-align:center;""></div>
                <iframe style=""display:none"" id=""4"" frameborder=""0"" scrolling=""no"" width=""520"" height=""600"" src=""https://www.fctables.com/france/ligue-1/iframe/?type=table&lang_id=22&country=77&template=15&timezone=Asia/Baku&time=24&po=1&ma=1&wi=1&dr=1&los=1&gf=1&ga=1&gd=1&pts=1&ng=0&form=0&width=520&height=700&font=Verdana&fs=12&lh=22&bg=f0d3ad&fc=000000&logo=1&tlink=1&ths=1&thb=1&thba=f2cf77&thc=000000&bc=dddddd&hob=fcfcfc&hobc=e3c73b&lc=333333&sh=1&hfb=1&hbc=f06a58&hfc=0a090a""></iframe><div style=""text-align:center;""></div>
                <iframe style=""display:none"" id=""3"" frameborder=""0"" scrolling=""no"" width=");
            WriteLiteral(@"""520"" height=""600"" src=""https://www.fctables.com/germany/1-bundesliga/iframe/?type=table&lang_id=22&country=83&template=16&timezone=Asia/Baku&time=24&po=1&ma=1&wi=1&dr=1&los=1&gf=1&ga=1&gd=1&pts=1&ng=0&form=0&width=520&height=700&font=Verdana&fs=12&lh=22&bg=f0d3ad&fc=000000&logo=1&tlink=1&ths=1&thb=1&thba=f2cf77&thc=000000&bc=dddddd&hob=fcfcfc&hobc=e3c73b&lc=333333&sh=1&hfb=1&hbc=f06a58&hfc=0a090a""></iframe><div style=""text-align:center;""></div>
                <iframe style=""display:none"" id=""1"" frameborder=""0"" scrolling=""no"" width=""520"" height=""600"" src=""https://www.fctables.com/italy/serie-a/iframe/?type=table&lang_id=22&country=108&template=17&timezone=Asia/Baku&time=24&po=1&ma=1&wi=1&dr=1&los=1&gf=1&ga=1&gd=1&pts=1&ng=0&form=0&width=520&height=700&font=Verdana&fs=12&lh=22&bg=f0d3ad&fc=000000&logo=1&tlink=1&ths=1&thb=1&thba=f2cf77&thc=000000&bc=dddddd&hob=fcfcfc&hobc=e3c73b&lc=333333&sh=1&hfb=1&hbc=f06a58&hfc=0a090a""></iframe><div style=""text-align:center;""></div>
                <iframe style=""display:");
            WriteLiteral(@"none"" id=""2"" frameborder=""0"" scrolling=""no"" width=""520"" height=""600"" src=""https://www.fctables.com/italy/serie-a/iframe/?type=table&lang_id=22&country=108&template=43&timezone=Asia/Baku&time=24&po=1&ma=1&wi=1&dr=1&los=1&gf=1&ga=1&gd=1&pts=1&ng=0&form=0&width=520&height=700&font=Verdana&fs=12&lh=22&bg=f0d3ad&fc=000000&logo=1&tlink=1&ths=1&thb=1&thba=f2cf77&thc=000000&bc=dddddd&hob=fcfcfc&hobc=e3c73b&lc=333333&sh=1&hfb=1&hbc=f06a58&hfc=0a090a""></iframe><div style=""text-align:center;""></div>
            </div>
        </div>
    </div>
</section>
");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(6692, 154, true);
                WriteLiteral("\r\n    <script>\r\n        $(\'#sel1\').change(function () {\r\n            var dey = $(\"#sel1 option:selected\").attr(\"class\");\r\n            for (var i = 1; i < ");
                EndContext();
                BeginContext(6847, 13, false);
#line 48 "C:\Users\ADMIN\source\repos\Futbolcu\Futbolcu\Views\Home\LigaTable.cshtml"
                           Write(Model.Count());

#line default
#line hidden
                EndContext();
                BeginContext(6860, 272, true);
                WriteLiteral(@"+1; i++) {
                if (dey == $(""#"" + i).attr(""id"")) {
                    $(""#"" + dey).css(""display"", ""block"");
                } else {
                    $(""#"" + i).css(""display"", ""none"");
                }
            }
        });


    </script>
");
                EndContext();
            }
            );
            BeginContext(7135, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Futbolcu.Models.Country>> Html { get; private set; }
    }
}
#pragma warning restore 1591
