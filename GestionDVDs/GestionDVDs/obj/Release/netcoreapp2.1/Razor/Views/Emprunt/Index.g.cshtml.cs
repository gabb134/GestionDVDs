#pragma checksum "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Emprunt\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "317442c1a421e480cb57ea6460e77ddb04f2dae9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Emprunt_Index), @"mvc.1.0.view", @"/Views/Emprunt/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Emprunt/Index.cshtml", typeof(AspNetCore.Views_Emprunt_Index))]
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
#line 1 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\_ViewImports.cshtml"
using GestionDVDs;

#line default
#line hidden
#line 2 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\_ViewImports.cshtml"
using GestionDVDs.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"317442c1a421e480cb57ea6460e77ddb04f2dae9", @"/Views/Emprunt/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f9c40c50d6b02254a9c1dfed9b7b805da989cea", @"/Views/_ViewImports.cshtml")]
    public class Views_Emprunt_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GestionDVDs.Models.Films>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Emprunter", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Emprunt\Index.cshtml"
  
    ViewData["Title"] = "Emprunt";

#line default
#line hidden
            BeginContext(78, 45, true);
            WriteLiteral("\r\n<h3>Emprunt</h3>\r\n\r\n<div>\r\n    <hr />\r\n    ");
            EndContext();
            BeginContext(123, 3531, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e86f40f325b44e53acb9f28bbfe545fd", async() => {
                BeginContext(152, 72, true);
                WriteLiteral("\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(225, 47, false);
#line 14 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Emprunt\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AnneeSortie));

#line default
#line hidden
                EndContext();
                BeginContext(272, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(328, 43, false);
#line 17 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Emprunt\Index.cshtml"
           Write(Html.DisplayFor(model => model.AnneeSortie));

#line default
#line hidden
                EndContext();
                BeginContext(371, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(427, 43, false);
#line 20 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Emprunt\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DateMaj));

#line default
#line hidden
                EndContext();
                BeginContext(470, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(526, 39, false);
#line 23 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Emprunt\Index.cshtml"
           Write(Html.DisplayFor(model => model.DateMaj));

#line default
#line hidden
                EndContext();
                BeginContext(565, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(621, 42, false);
#line 26 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Emprunt\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Resume));

#line default
#line hidden
                EndContext();
                BeginContext(663, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(719, 38, false);
#line 29 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Emprunt\Index.cshtml"
           Write(Html.DisplayFor(model => model.Resume));

#line default
#line hidden
                EndContext();
                BeginContext(757, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(813, 48, false);
#line 32 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Emprunt\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DureeMinutes));

#line default
#line hidden
                EndContext();
                BeginContext(861, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(917, 44, false);
#line 35 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Emprunt\Index.cshtml"
           Write(Html.DisplayFor(model => model.DureeMinutes));

#line default
#line hidden
                EndContext();
                BeginContext(961, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1017, 48, false);
#line 38 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Emprunt\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FilmOriginal));

#line default
#line hidden
                EndContext();
                BeginContext(1065, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1121, 44, false);
#line 41 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Emprunt\Index.cshtml"
           Write(Html.DisplayFor(model => model.FilmOriginal));

#line default
#line hidden
                EndContext();
                BeginContext(1165, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1221, 49, false);
#line 44 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Emprunt\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ImagePochette));

#line default
#line hidden
                EndContext();
                BeginContext(1270, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1326, 45, false);
#line 47 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Emprunt\Index.cshtml"
           Write(Html.DisplayFor(model => model.ImagePochette));

#line default
#line hidden
                EndContext();
                BeginContext(1371, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1427, 45, false);
#line 50 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Emprunt\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NbDisques));

#line default
#line hidden
                EndContext();
                BeginContext(1472, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1528, 41, false);
#line 53 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Emprunt\Index.cshtml"
           Write(Html.DisplayFor(model => model.NbDisques));

#line default
#line hidden
                EndContext();
                BeginContext(1569, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1625, 49, false);
#line 56 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Emprunt\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TitreFrancais));

#line default
#line hidden
                EndContext();
                BeginContext(1674, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1730, 45, false);
#line 59 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Emprunt\Index.cshtml"
           Write(Html.DisplayFor(model => model.TitreFrancais));

#line default
#line hidden
                EndContext();
                BeginContext(1775, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1831, 49, false);
#line 62 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Emprunt\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TitreOriginal));

#line default
#line hidden
                EndContext();
                BeginContext(1880, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1936, 45, false);
#line 65 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Emprunt\Index.cshtml"
           Write(Html.DisplayFor(model => model.TitreOriginal));

#line default
#line hidden
                EndContext();
                BeginContext(1981, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(2037, 50, false);
#line 68 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Emprunt\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VersionEtendue));

#line default
#line hidden
                EndContext();
                BeginContext(2087, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(2143, 46, false);
#line 71 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Emprunt\Index.cshtml"
           Write(Html.DisplayFor(model => model.VersionEtendue));

#line default
#line hidden
                EndContext();
                BeginContext(2189, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(2245, 40, false);
#line 74 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Emprunt\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Xtra));

#line default
#line hidden
                EndContext();
                BeginContext(2285, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(2341, 36, false);
#line 77 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Emprunt\Index.cshtml"
           Write(Html.DisplayFor(model => model.Xtra));

#line default
#line hidden
                EndContext();
                BeginContext(2377, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(2433, 55, false);
#line 80 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Emprunt\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CategorieNavigation));

#line default
#line hidden
                EndContext();
                BeginContext(2488, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(2544, 63, false);
#line 83 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Emprunt\Index.cshtml"
           Write(Html.DisplayFor(model => model.CategorieNavigation.Description));

#line default
#line hidden
                EndContext();
                BeginContext(2607, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(2663, 52, false);
#line 86 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Emprunt\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FormatNavigation));

#line default
#line hidden
                EndContext();
                BeginContext(2715, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(2771, 60, false);
#line 89 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Emprunt\Index.cshtml"
           Write(Html.DisplayFor(model => model.FormatNavigation.Description));

#line default
#line hidden
                EndContext();
                BeginContext(2831, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(2887, 46, false);
#line 92 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Emprunt\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Producteur));

#line default
#line hidden
                EndContext();
                BeginContext(2933, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(2989, 46, false);
#line 95 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Emprunt\Index.cshtml"
           Write(Html.DisplayFor(model => model.Producteur.Nom));

#line default
#line hidden
                EndContext();
                BeginContext(3035, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(3091, 47, false);
#line 98 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Emprunt\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Realisateur));

#line default
#line hidden
                EndContext();
                BeginContext(3138, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(3194, 47, false);
#line 101 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Emprunt\Index.cshtml"
           Write(Html.DisplayFor(model => model.Realisateur.Nom));

#line default
#line hidden
                EndContext();
                BeginContext(3241, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(3297, 50, false);
#line 104 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Emprunt\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UtilisateurMaj));

#line default
#line hidden
                EndContext();
                BeginContext(3347, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(3403, 52, false);
#line 107 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Emprunt\Index.cshtml"
           Write(Html.DisplayFor(model => model.UtilisateurMaj.Email));

#line default
#line hidden
                EndContext();
                BeginContext(3455, 44, true);
                WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n        ");
                EndContext();
                BeginContext(3499, 68, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14abdde16fc14182918857d5523a6157", async() => {
                    BeginContext(3554, 9, true);
                    WriteLiteral("Emprunter");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 110 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Emprunt\Index.cshtml"
                                    WriteLiteral(Model.FilmId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3567, 3, true);
                WriteLiteral(" | ");
                EndContext();
                BeginContext(3570, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1078f541bd44c6b81f656ac0f2f219c", async() => {
                    BeginContext(3610, 27, true);
                    WriteLiteral("Retourner vers le catalogue");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3641, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3654, 10, true);
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
