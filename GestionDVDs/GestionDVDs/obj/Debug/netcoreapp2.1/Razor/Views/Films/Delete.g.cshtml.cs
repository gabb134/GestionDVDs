#pragma checksum "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bb609875471615e41a1f1aa663a4baf9f2d3610"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Films_Delete), @"mvc.1.0.view", @"/Views/Films/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Films/Delete.cshtml", typeof(AspNetCore.Views_Films_Delete))]
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
#line 1 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\_ViewImports.cshtml"
using GestionDVDs;

#line default
#line hidden
#line 2 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\_ViewImports.cshtml"
using GestionDVDs.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bb609875471615e41a1f1aa663a4baf9f2d3610", @"/Views/Films/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f9c40c50d6b02254a9c1dfed9b7b805da989cea", @"/Views/_ViewImports.cshtml")]
    public class Views_Films_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GestionDVDs.Models.Films>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
  
    ViewData["Title"] = "Supprimer";

#line default
#line hidden
            BeginContext(80, 138, true);
            WriteLiteral("\r\n<h3>Êtes-vous certains de vouloir supprimer ce film?</h3>\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(219, 47, false);
#line 12 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AnneeSortie));

#line default
#line hidden
            EndContext();
            BeginContext(266, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(310, 43, false);
#line 15 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AnneeSortie));

#line default
#line hidden
            EndContext();
            BeginContext(353, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(397, 43, false);
#line 18 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DateMaj));

#line default
#line hidden
            EndContext();
            BeginContext(440, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(484, 39, false);
#line 21 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DateMaj));

#line default
#line hidden
            EndContext();
            BeginContext(523, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(567, 42, false);
#line 24 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Resume));

#line default
#line hidden
            EndContext();
            BeginContext(609, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(653, 38, false);
#line 27 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Resume));

#line default
#line hidden
            EndContext();
            BeginContext(691, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(735, 48, false);
#line 30 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DureeMinutes));

#line default
#line hidden
            EndContext();
            BeginContext(783, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(827, 44, false);
#line 33 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DureeMinutes));

#line default
#line hidden
            EndContext();
            BeginContext(871, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(915, 48, false);
#line 36 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FilmOriginal));

#line default
#line hidden
            EndContext();
            BeginContext(963, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1007, 44, false);
#line 39 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FilmOriginal));

#line default
#line hidden
            EndContext();
            BeginContext(1051, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1095, 49, false);
#line 42 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ImagePochette));

#line default
#line hidden
            EndContext();
            BeginContext(1144, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1188, 45, false);
#line 45 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ImagePochette));

#line default
#line hidden
            EndContext();
            BeginContext(1233, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1277, 45, false);
#line 48 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NbDisques));

#line default
#line hidden
            EndContext();
            BeginContext(1322, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1366, 41, false);
#line 51 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NbDisques));

#line default
#line hidden
            EndContext();
            BeginContext(1407, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1451, 49, false);
#line 54 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TitreFrancais));

#line default
#line hidden
            EndContext();
            BeginContext(1500, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1544, 45, false);
#line 57 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TitreFrancais));

#line default
#line hidden
            EndContext();
            BeginContext(1589, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1633, 49, false);
#line 60 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TitreOriginal));

#line default
#line hidden
            EndContext();
            BeginContext(1682, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1726, 45, false);
#line 63 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TitreOriginal));

#line default
#line hidden
            EndContext();
            BeginContext(1771, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1815, 50, false);
#line 66 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VersionEtendue));

#line default
#line hidden
            EndContext();
            BeginContext(1865, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1909, 46, false);
#line 69 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VersionEtendue));

#line default
#line hidden
            EndContext();
            BeginContext(1955, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1999, 40, false);
#line 72 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Xtra));

#line default
#line hidden
            EndContext();
            BeginContext(2039, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2083, 36, false);
#line 75 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Xtra));

#line default
#line hidden
            EndContext();
            BeginContext(2119, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2163, 55, false);
#line 78 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CategorieNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2218, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2262, 63, false);
#line 81 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CategorieNavigation.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2325, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2369, 52, false);
#line 84 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FormatNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2421, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2465, 60, false);
#line 87 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FormatNavigation.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2525, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2569, 46, false);
#line 90 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Producteur));

#line default
#line hidden
            EndContext();
            BeginContext(2615, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2659, 46, false);
#line 93 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Producteur.Nom));

#line default
#line hidden
            EndContext();
            BeginContext(2705, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2749, 47, false);
#line 96 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Realisateur));

#line default
#line hidden
            EndContext();
            BeginContext(2796, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2840, 47, false);
#line 99 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Realisateur.Nom));

#line default
#line hidden
            EndContext();
            BeginContext(2887, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2931, 50, false);
#line 102 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UtilisateurMaj));

#line default
#line hidden
            EndContext();
            BeginContext(2981, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3025, 52, false);
#line 105 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UtilisateurMaj.Email));

#line default
#line hidden
            EndContext();
            BeginContext(3077, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(3115, 229, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa6f0e228f904b9a8a713e88c16ea589", async() => {
                BeginContext(3141, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(3151, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c85153a736134a23bd34fd6cb1a8adb8", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 110 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FilmId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3191, 87, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Supprimer\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(3278, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe1dc06a0f044021b3275580c91ccde4", async() => {
                    BeginContext(3300, 27, true);
                    WriteLiteral("Retourner vers le catalogue");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3331, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3344, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GestionDVDs.Models.Films> Html { get; private set; }
    }
}
#pragma warning restore 1591
