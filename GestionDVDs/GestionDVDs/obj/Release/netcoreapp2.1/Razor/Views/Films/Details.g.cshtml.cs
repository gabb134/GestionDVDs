#pragma checksum "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8942d3b992a0f75286585819b7892e585dfb585"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Films_Details), @"mvc.1.0.view", @"/Views/Films/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Films/Details.cshtml", typeof(AspNetCore.Views_Films_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8942d3b992a0f75286585819b7892e585dfb585", @"/Views/Films/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f9c40c50d6b02254a9c1dfed9b7b805da989cea", @"/Views/_ViewImports.cshtml")]
    public class Views_Films_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GestionDVDs.Models.Films>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(78, 6, true);
            WriteLiteral("\r\n<h3>");
            EndContext();
            BeginContext(85, 45, false);
#line 7 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Details.cshtml"
Write(Html.DisplayFor(model => model.TitreFrancais));

#line default
#line hidden
            EndContext();
            BeginContext(130, 37, true);
            WriteLiteral("</h3>\r\n<h4 style=\"font-style:italic\">");
            EndContext();
            BeginContext(168, 45, false);
#line 8 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Details.cshtml"
                         Write(Html.DisplayFor(model => model.TitreOriginal));

#line default
#line hidden
            EndContext();
            BeginContext(213, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(216, 43, false);
#line 8 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Details.cshtml"
                                                                         Write(Html.DisplayFor(model => model.AnneeSortie));

#line default
#line hidden
            EndContext();
            BeginContext(259, 87, true);
            WriteLiteral(")</h4>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(347, 42, false);
#line 14 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Resume));

#line default
#line hidden
            EndContext();
            BeginContext(389, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(433, 38, false);
#line 17 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Details.cshtml"
       Write(Html.DisplayFor(model => model.Resume));

#line default
#line hidden
            EndContext();
            BeginContext(471, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(515, 48, false);
#line 20 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DureeMinutes));

#line default
#line hidden
            EndContext();
            BeginContext(563, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(607, 44, false);
#line 23 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Details.cshtml"
       Write(Html.DisplayFor(model => model.DureeMinutes));

#line default
#line hidden
            EndContext();
            BeginContext(651, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(695, 48, false);
#line 26 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FilmOriginal));

#line default
#line hidden
            EndContext();
            BeginContext(743, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(787, 44, false);
#line 29 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Details.cshtml"
       Write(Html.DisplayFor(model => model.FilmOriginal));

#line default
#line hidden
            EndContext();
            BeginContext(831, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(875, 49, false);
#line 32 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ImagePochette));

#line default
#line hidden
            EndContext();
            BeginContext(924, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(968, 45, false);
#line 35 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Details.cshtml"
       Write(Html.DisplayFor(model => model.ImagePochette));

#line default
#line hidden
            EndContext();
            BeginContext(1013, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1057, 45, false);
#line 38 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NbDisques));

#line default
#line hidden
            EndContext();
            BeginContext(1102, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1146, 41, false);
#line 41 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Details.cshtml"
       Write(Html.DisplayFor(model => model.NbDisques));

#line default
#line hidden
            EndContext();
            BeginContext(1187, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1231, 50, false);
#line 44 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VersionEtendue));

#line default
#line hidden
            EndContext();
            BeginContext(1281, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1325, 46, false);
#line 47 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Details.cshtml"
       Write(Html.DisplayFor(model => model.VersionEtendue));

#line default
#line hidden
            EndContext();
            BeginContext(1371, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1415, 40, false);
#line 50 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Xtra));

#line default
#line hidden
            EndContext();
            BeginContext(1455, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1499, 36, false);
#line 53 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Details.cshtml"
       Write(Html.DisplayFor(model => model.Xtra));

#line default
#line hidden
            EndContext();
            BeginContext(1535, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1579, 55, false);
#line 56 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CategorieNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1634, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1678, 63, false);
#line 59 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Details.cshtml"
       Write(Html.DisplayFor(model => model.CategorieNavigation.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1741, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1785, 52, false);
#line 62 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FormatNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1837, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1881, 60, false);
#line 65 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Details.cshtml"
       Write(Html.DisplayFor(model => model.FormatNavigation.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1941, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1985, 46, false);
#line 68 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Producteur));

#line default
#line hidden
            EndContext();
            BeginContext(2031, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2075, 46, false);
#line 71 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Details.cshtml"
       Write(Html.DisplayFor(model => model.Producteur.Nom));

#line default
#line hidden
            EndContext();
            BeginContext(2121, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2165, 47, false);
#line 74 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Realisateur));

#line default
#line hidden
            EndContext();
            BeginContext(2212, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2256, 47, false);
#line 77 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Details.cshtml"
       Write(Html.DisplayFor(model => model.Realisateur.Nom));

#line default
#line hidden
            EndContext();
            BeginContext(2303, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2347, 50, false);
#line 80 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UtilisateurMaj));

#line default
#line hidden
            EndContext();
            BeginContext(2397, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2441, 52, false);
#line 83 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Details.cshtml"
       Write(Html.DisplayFor(model => model.UtilisateurMaj.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2493, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2537, 43, false);
#line 86 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateMaj));

#line default
#line hidden
            EndContext();
            BeginContext(2580, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2624, 39, false);
#line 89 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateMaj));

#line default
#line hidden
            EndContext();
            BeginContext(2663, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2710, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14ca8f8da58f40e4ab74cf9c14b82a46", async() => {
                BeginContext(2760, 8, true);
                WriteLiteral("Modifier");
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
#line 94 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Details.cshtml"
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
            BeginContext(2772, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2780, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb20014c980949879827cb609b003b2e", async() => {
                BeginContext(2802, 27, true);
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
            BeginContext(2833, 10, true);
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
