#pragma checksum "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\Home\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9b6af14af1a19bf3e13e67ed2ca06c004bfc6c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Detail.cshtml", typeof(AspNetCore.Views_Home_Detail))]
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
#line 1 "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\_ViewImports.cshtml"
using Projeto;

#line default
#line hidden
#line 2 "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\_ViewImports.cshtml"
using Projeto.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9b6af14af1a19bf3e13e67ed2ca06c004bfc6c8", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d4dfd97469170fe8b85a6370378ea67b5320a14", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Projeto.Models.FichaMedicaViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/cadastroStyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/logo_simp.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\Home\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(88, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(92, 160, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9b6af14af1a19bf3e13e67ed2ca06c004bfc6c86313", async() => {
                BeginContext(98, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(108, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b9b6af14af1a19bf3e13e67ed2ca06c004bfc6c86702", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
                BeginContext(174, 71, true);
                WriteLiteral("\r\n        <meta charset=\"utf-8\">\r\n        <title>MedMob</title>\r\n\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(252, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(258, 7044, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9b6af14af1a19bf3e13e67ed2ca06c004bfc6c89001", async() => {
                BeginContext(264, 160, true);
                WriteLiteral("\r\n        <div id=\"header\">\r\n            <div class=\"navbar\">\r\n                <!-- chama a action Index do controller ao clicar em Voltar -->\r\n                ");
                EndContext();
                BeginContext(424, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9b6af14af1a19bf3e13e67ed2ca06c004bfc6c89552", async() => {
                    BeginContext(446, 6, true);
                    WriteLiteral("Voltar");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(456, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(474, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b9b6af14af1a19bf3e13e67ed2ca06c004bfc6c811026", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(522, 242, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <h1 class=\"top\">Ficha Médica</h1>\r\n\r\n        <div>\r\n            <hr />\r\n            <div class=\"row\">\r\n                <div>\r\n                    <label class=\"hidden\">\r\n                        ");
                EndContext();
                BeginContext(765, 38, false);
#line 28 "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\Home\Detail.cshtml"
                   Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
                EndContext();
                BeginContext(803, 99, true);
                WriteLiteral("\r\n                    </label>\r\n                    <span class=\"hidden\">\r\n                        ");
                EndContext();
                BeginContext(903, 34, false);
#line 31 "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\Home\Detail.cshtml"
                   Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
                EndContext();
                BeginContext(937, 170, true);
                WriteLiteral("\r\n                    </span>\r\n                </div>\r\n                <br />\r\n                <div>\r\n                    <label class=\"detail\">\r\n                        ");
                EndContext();
                BeginContext(1108, 38, false);
#line 37 "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\Home\Detail.cshtml"
                   Write(Html.DisplayNameFor(model => model.Rg));

#line default
#line hidden
                EndContext();
                BeginContext(1146, 102, true);
                WriteLiteral("\r\n                    </label>\r\n                    <span class=\"datatable\">\r\n                        ");
                EndContext();
                BeginContext(1249, 34, false);
#line 40 "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\Home\Detail.cshtml"
                   Write(Html.DisplayFor(model => model.Rg));

#line default
#line hidden
                EndContext();
                BeginContext(1283, 170, true);
                WriteLiteral("\r\n                    </span>\r\n                </div>\r\n                <br />\r\n                <div>\r\n                    <label class=\"detail\">\r\n                        ");
                EndContext();
                BeginContext(1454, 48, false);
#line 46 "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\Home\Detail.cshtml"
                   Write(Html.DisplayNameFor(model => model.NomeCompleto));

#line default
#line hidden
                EndContext();
                BeginContext(1502, 84, true);
                WriteLiteral("\r\n                    </label>\r\n                    <span>\r\n                        ");
                EndContext();
                BeginContext(1587, 44, false);
#line 49 "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\Home\Detail.cshtml"
                   Write(Html.DisplayFor(model => model.NomeCompleto));

#line default
#line hidden
                EndContext();
                BeginContext(1631, 170, true);
                WriteLiteral("\r\n                    </span>\r\n                </div>\r\n                <br />\r\n                <div>\r\n                    <label class=\"detail\">\r\n                        ");
                EndContext();
                BeginContext(1802, 48, false);
#line 55 "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\Home\Detail.cshtml"
                   Write(Html.DisplayNameFor(model => model.NomeConvenio));

#line default
#line hidden
                EndContext();
                BeginContext(1850, 84, true);
                WriteLiteral("\r\n                    </label>\r\n                    <span>\r\n                        ");
                EndContext();
                BeginContext(1935, 44, false);
#line 58 "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\Home\Detail.cshtml"
                   Write(Html.DisplayFor(model => model.NomeConvenio));

#line default
#line hidden
                EndContext();
                BeginContext(1979, 170, true);
                WriteLiteral("\r\n                    </span>\r\n                </div>\r\n                <br />\r\n                <div>\r\n                    <label class=\"detail\">\r\n                        ");
                EndContext();
                BeginContext(2150, 50, false);
#line 64 "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\Home\Detail.cshtml"
                   Write(Html.DisplayNameFor(model => model.NumeroConvenio));

#line default
#line hidden
                EndContext();
                BeginContext(2200, 84, true);
                WriteLiteral("\r\n                    </label>\r\n                    <span>\r\n                        ");
                EndContext();
                BeginContext(2285, 46, false);
#line 67 "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\Home\Detail.cshtml"
                   Write(Html.DisplayFor(model => model.NumeroConvenio));

#line default
#line hidden
                EndContext();
                BeginContext(2331, 170, true);
                WriteLiteral("\r\n                    </span>\r\n                </div>\r\n                <br />\r\n                <div>\r\n                    <label class=\"detail\">\r\n                        ");
                EndContext();
                BeginContext(2502, 49, false);
#line 73 "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\Home\Detail.cshtml"
                   Write(Html.DisplayNameFor(model => model.DoencaCronica));

#line default
#line hidden
                EndContext();
                BeginContext(2551, 84, true);
                WriteLiteral("\r\n                    </label>\r\n                    <span>\r\n                        ");
                EndContext();
                BeginContext(2636, 45, false);
#line 76 "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\Home\Detail.cshtml"
                   Write(Html.DisplayFor(model => model.DoencaCronica));

#line default
#line hidden
                EndContext();
                BeginContext(2681, 170, true);
                WriteLiteral("\r\n                    </span>\r\n                </div>\r\n                <br />\r\n                <div>\r\n                    <label class=\"detail\">\r\n                        ");
                EndContext();
                BeginContext(2852, 49, false);
#line 82 "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\Home\Detail.cshtml"
                   Write(Html.DisplayNameFor(model => model.TipoSanguineo));

#line default
#line hidden
                EndContext();
                BeginContext(2901, 84, true);
                WriteLiteral("\r\n                    </label>\r\n                    <span>\r\n                        ");
                EndContext();
                BeginContext(2986, 45, false);
#line 85 "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\Home\Detail.cshtml"
                   Write(Html.DisplayFor(model => model.TipoSanguineo));

#line default
#line hidden
                EndContext();
                BeginContext(3031, 170, true);
                WriteLiteral("\r\n                    </span>\r\n                </div>\r\n                <br />\r\n                <div>\r\n                    <label class=\"detail\">\r\n                        ");
                EndContext();
                BeginContext(3202, 50, false);
#line 91 "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\Home\Detail.cshtml"
                   Write(Html.DisplayNameFor(model => model.DataNascimento));

#line default
#line hidden
                EndContext();
                BeginContext(3252, 84, true);
                WriteLiteral("\r\n                    </label>\r\n                    <span>\r\n                        ");
                EndContext();
                BeginContext(3337, 46, false);
#line 94 "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\Home\Detail.cshtml"
                   Write(Html.DisplayFor(model => model.DataNascimento));

#line default
#line hidden
                EndContext();
                BeginContext(3383, 170, true);
                WriteLiteral("\r\n                    </span>\r\n                </div>\r\n                <br />\r\n                <div>\r\n                    <label class=\"detail\">\r\n                        ");
                EndContext();
                BeginContext(3554, 44, false);
#line 100 "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\Home\Detail.cshtml"
                   Write(Html.DisplayNameFor(model => model.Endereco));

#line default
#line hidden
                EndContext();
                BeginContext(3598, 84, true);
                WriteLiteral("\r\n                    </label>\r\n                    <span>\r\n                        ");
                EndContext();
                BeginContext(3683, 40, false);
#line 103 "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\Home\Detail.cshtml"
                   Write(Html.DisplayFor(model => model.Endereco));

#line default
#line hidden
                EndContext();
                BeginContext(3723, 170, true);
                WriteLiteral("\r\n                    </span>\r\n                </div>\r\n                <br />\r\n                <div>\r\n                    <label class=\"detail\">\r\n                        ");
                EndContext();
                BeginContext(3894, 42, false);
#line 109 "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\Home\Detail.cshtml"
                   Write(Html.DisplayNameFor(model => model.Numero));

#line default
#line hidden
                EndContext();
                BeginContext(3936, 84, true);
                WriteLiteral("\r\n                    </label>\r\n                    <span>\r\n                        ");
                EndContext();
                BeginContext(4021, 38, false);
#line 112 "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\Home\Detail.cshtml"
                   Write(Html.DisplayFor(model => model.Numero));

#line default
#line hidden
                EndContext();
                BeginContext(4059, 170, true);
                WriteLiteral("\r\n                    </span>\r\n                </div>\r\n                <br />\r\n                <div>\r\n                    <label class=\"detail\">\r\n                        ");
                EndContext();
                BeginContext(4230, 42, false);
#line 118 "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\Home\Detail.cshtml"
                   Write(Html.DisplayNameFor(model => model.Cidade));

#line default
#line hidden
                EndContext();
                BeginContext(4272, 84, true);
                WriteLiteral("\r\n                    </label>\r\n                    <span>\r\n                        ");
                EndContext();
                BeginContext(4357, 38, false);
#line 121 "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\Home\Detail.cshtml"
                   Write(Html.DisplayFor(model => model.Cidade));

#line default
#line hidden
                EndContext();
                BeginContext(4395, 170, true);
                WriteLiteral("\r\n                    </span>\r\n                </div>\r\n                <br />\r\n                <div>\r\n                    <label class=\"detail\">\r\n                        ");
                EndContext();
                BeginContext(4566, 38, false);
#line 127 "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\Home\Detail.cshtml"
                   Write(Html.DisplayNameFor(model => model.UF));

#line default
#line hidden
                EndContext();
                BeginContext(4604, 84, true);
                WriteLiteral("\r\n                    </label>\r\n                    <span>\r\n                        ");
                EndContext();
                BeginContext(4689, 34, false);
#line 130 "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\Home\Detail.cshtml"
                   Write(Html.DisplayFor(model => model.UF));

#line default
#line hidden
                EndContext();
                BeginContext(4723, 170, true);
                WriteLiteral("\r\n                    </span>\r\n                </div>\r\n                <br />\r\n                <div>\r\n                    <label class=\"detail\">\r\n                        ");
                EndContext();
                BeginContext(4894, 40, false);
#line 136 "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\Home\Detail.cshtml"
                   Write(Html.DisplayNameFor(model => model.Pais));

#line default
#line hidden
                EndContext();
                BeginContext(4934, 84, true);
                WriteLiteral("\r\n                    </label>\r\n                    <span>\r\n                        ");
                EndContext();
                BeginContext(5019, 36, false);
#line 139 "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\Home\Detail.cshtml"
                   Write(Html.DisplayFor(model => model.Pais));

#line default
#line hidden
                EndContext();
                BeginContext(5055, 170, true);
                WriteLiteral("\r\n                    </span>\r\n                </div>\r\n                <br />\r\n                <div>\r\n                    <label class=\"detail\">\r\n                        ");
                EndContext();
                BeginContext(5226, 44, false);
#line 145 "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\Home\Detail.cshtml"
                   Write(Html.DisplayNameFor(model => model.Telefone));

#line default
#line hidden
                EndContext();
                BeginContext(5270, 84, true);
                WriteLiteral("\r\n                    </label>\r\n                    <span>\r\n                        ");
                EndContext();
                BeginContext(5355, 40, false);
#line 148 "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\Home\Detail.cshtml"
                   Write(Html.DisplayFor(model => model.Telefone));

#line default
#line hidden
                EndContext();
                BeginContext(5395, 170, true);
                WriteLiteral("\r\n                    </span>\r\n                </div>\r\n                <br />\r\n                <div>\r\n                    <label class=\"detail\">\r\n                        ");
                EndContext();
                BeginContext(5566, 43, false);
#line 154 "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\Home\Detail.cshtml"
                   Write(Html.DisplayNameFor(model => model.NomePai));

#line default
#line hidden
                EndContext();
                BeginContext(5609, 84, true);
                WriteLiteral("\r\n                    </label>\r\n                    <span>\r\n                        ");
                EndContext();
                BeginContext(5694, 39, false);
#line 157 "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\Home\Detail.cshtml"
                   Write(Html.DisplayFor(model => model.NomePai));

#line default
#line hidden
                EndContext();
                BeginContext(5733, 170, true);
                WriteLiteral("\r\n                    </span>\r\n                </div>\r\n                <br />\r\n                <div>\r\n                    <label class=\"detail\">\r\n                        ");
                EndContext();
                BeginContext(5904, 43, false);
#line 163 "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\Home\Detail.cshtml"
                   Write(Html.DisplayNameFor(model => model.NomeMae));

#line default
#line hidden
                EndContext();
                BeginContext(5947, 84, true);
                WriteLiteral("\r\n                    </label>\r\n                    <span>\r\n                        ");
                EndContext();
                BeginContext(6032, 39, false);
#line 166 "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\Home\Detail.cshtml"
                   Write(Html.DisplayFor(model => model.NomeMae));

#line default
#line hidden
                EndContext();
                BeginContext(6071, 228, true);
                WriteLiteral("\r\n                    </span>\r\n                </div>\r\n            </div>\r\n            <br />\r\n            <hr />\r\n            <!-- caso o paciente possua alguma alergia, cria-se uma tabela onde são listadas cada uma delas -->\r\n");
                EndContext();
#line 173 "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\Home\Detail.cshtml"
             if (Model.Alergias.Count > 0)
            {

#line default
#line hidden
                BeginContext(6358, 317, true);
                WriteLiteral(@"                <table>
                    <thead>
                        <tr>
                            <td class=""detail"">
                                Alergia aos medicamentos:
                            </td>
                        </tr>
                    </thead>
                    <tbody>
");
                EndContext();
#line 184 "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\Home\Detail.cshtml"
                         foreach (var item in Model.Alergias)
                        {

#line default
#line hidden
                BeginContext(6765, 70, true);
                WriteLiteral("                            <tr>\r\n                                <td>");
                EndContext();
                BeginContext(6836, 20, false);
#line 187 "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\Home\Detail.cshtml"
                               Write(item.NomeMedicamento);

#line default
#line hidden
                EndContext();
                BeginContext(6856, 42, true);
                WriteLiteral("</td>\r\n                            </tr>\r\n");
                EndContext();
#line 189 "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\Home\Detail.cshtml"
                        }

#line default
#line hidden
                BeginContext(6925, 56, true);
                WriteLiteral("                    </tbody>\r\n                </table>\r\n");
                EndContext();
#line 192 "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\Home\Detail.cshtml"
            }

#line default
#line hidden
                BeginContext(6996, 130, true);
                WriteLiteral("        </div>\r\n        <br />\r\n        <div>\r\n            <!-- chama action Edit ao clicar em Adicionar Alergia -->\r\n            ");
                EndContext();
                BeginContext(7127, 98, false);
#line 197 "C:\Users\ADMIN\Documents\Barbara -Projeto\Projeto_V7\Projeto\Views\Home\Detail.cshtml"
       Write(Html.ActionLink("Adicionar Alergia", "Edit", new { id = Model.Id }, new {@class = "botao_padrao"}));

#line default
#line hidden
                EndContext();
                BeginContext(7225, 70, true);
                WriteLiteral("\r\n        </div>\r\n        <br />\r\n        <br />\r\n        <br />\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7302, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Projeto.Models.FichaMedicaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
