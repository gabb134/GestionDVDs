#pragma checksum "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77f8a680108763a731ea806c4e63f3b315106a84"
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
#line 1 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDVDs\GestionDVDs\Views\_ViewImports.cshtml"
using GestionDVDs;

#line default
#line hidden
#line 2 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDVDs\GestionDVDs\Views\_ViewImports.cshtml"
using GestionDVDs.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77f8a680108763a731ea806c4e63f3b315106a84", @"/Views/Films/Delete.cshtml")]
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
#line 3 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(77, 166, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Films</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(244, 47, false);
#line 15 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AnneeSortie));

#line default
#line hidden
            EndContext();
            BeginContext(291, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(335, 43, false);
#line 18 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AnneeSortie));

#line default
#line hidden
            EndContext();
            BeginContext(378, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(422, 43, false);
#line 21 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DateMaj));

#line default
#line hidden
            EndContext();
            BeginContext(465, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(509, 39, false);
#line 24 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DateMaj));

#line default
#line hidden
            EndContext();
            BeginContext(548, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(592, 42, false);
#line 27 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Resume));

#line default
#line hidden
            EndContext();
            BeginContext(634, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(678, 38, false);
#line 30 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Resume));

#line default
#line hidden
            EndContext();
            BeginContext(716, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(760, 48, false);
#line 33 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DureeMinutes));

#line default
#line hidden
            EndContext();
            BeginContext(808, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(852, 44, false);
#line 36 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DureeMinutes));

#line default
#line hidden
            EndContext();
            BeginContext(896, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(940, 48, false);
#line 39 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FilmOriginal));

#line default
#line hidden
            EndContext();
            BeginContext(988, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1032, 44, false);
#line 42 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FilmOriginal));

#line default
#line hidden
            EndContext();
            BeginContext(1076, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1120, 49, false);
#line 45 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ImagePochette));

#line default
#line hidden
            EndContext();
            BeginContext(1169, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1213, 45, false);
#line 48 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ImagePochette));

#line default
#line hidden
            EndContext();
            BeginContext(1258, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1302, 45, false);
#line 51 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NbDisques));

#line default
#line hidden
            EndContext();
            BeginContext(1347, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1391, 41, false);
#line 54 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NbDisques));

#line default
#line hidden
            EndContext();
            BeginContext(1432, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1476, 49, false);
#line 57 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TitreFrancais));

#line default
#line hidden
            EndContext();
            BeginContext(1525, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1569, 45, false);
#line 60 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TitreFrancais));

#line default
#line hidden
            EndContext();
            BeginContext(1614, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1658, 49, false);
#line 63 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TitreOriginal));

#line default
#line hidden
            EndContext();
            BeginContext(1707, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1751, 45, false);
#line 66 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TitreOriginal));

#line default
#line hidden
            EndContext();
            BeginContext(1796, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1840, 50, false);
#line 69 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VersionEtendue));

#line default
#line hidden
            EndContext();
            BeginContext(1890, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1934, 46, false);
#line 72 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VersionEtendue));

#line default
#line hidden
            EndContext();
            BeginContext(1980, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2024, 40, false);
#line 75 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Xtra));

#line default
#line hidden
            EndContext();
            BeginContext(2064, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2108, 36, false);
#line 78 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Xtra));

#line default
#line hidden
            EndContext();
            BeginContext(2144, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2188, 55, false);
#line 81 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CategorieNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2243, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2287, 63, false);
#line 84 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CategorieNavigation.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2350, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2394, 52, false);
#line 87 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FormatNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2446, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2490, 60, false);
#line 90 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FormatNavigation.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2550, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2594, 46, false);
#line 93 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Producteur));

#line default
#line hidden
            EndContext();
            BeginContext(2640, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2684, 46, false);
#line 96 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Producteur.Nom));

#line default
#line hidden
            EndContext();
            BeginContext(2730, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2774, 47, false);
#line 99 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Realisateur));

#line default
#line hidden
            EndContext();
            BeginContext(2821, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2865, 47, false);
#line 102 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Realisateur.Nom));

#line default
#line hidden
            EndContext();
            BeginContext(2912, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2956, 50, false);
#line 105 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UtilisateurMaj));

#line default
#line hidden
            EndContext();
            BeginContext(3006, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3050, 55, false);
#line 108 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UtilisateurMaj.Courriel));

#line default
#line hidden
            EndContext();
            BeginContext(3105, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(3143, 211, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bfa763bb5a6a4eba83703f70213e7b3a", async() => {
                BeginContext(3169, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(3179, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "aff7688c912c4cfbb007f8dbd96d3aba", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 113 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Delete.cshtml"
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
                BeginContext(3219, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(3303, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9dda38ee6e4e47ac8602cd6f48f19b37", async() => {
                    BeginContext(3325, 12, true);
                    WriteLiteral("Back to List");
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
                BeginContext(3341, 6, true);
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
            BeginContext(3354, 10, true);
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