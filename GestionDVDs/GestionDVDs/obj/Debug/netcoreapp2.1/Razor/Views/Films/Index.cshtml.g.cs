#pragma checksum "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet_3BonneVerison\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ebc125774900f4361e52e5c14f594995d747609"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Films_Index), @"mvc.1.0.view", @"/Views/Films/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Films/Index.cshtml", typeof(AspNetCore.Views_Films_Index))]
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
#line 1 "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet_3BonneVerison\GestionDVDs\GestionDVDs\Views\_ViewImports.cshtml"
using GestionDVDs;

#line default
#line hidden
#line 2 "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet_3BonneVerison\GestionDVDs\GestionDVDs\Views\_ViewImports.cshtml"
using GestionDVDs.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ebc125774900f4361e52e5c14f594995d747609", @"/Views/Films/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f9c40c50d6b02254a9c1dfed9b7b805da989cea", @"/Views/_ViewImports.cshtml")]
    public class Views_Films_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GestionDVDs.Models.Films>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width: 100%;  max-height : 50%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/poster.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Aucune image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Poster du film"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet_3BonneVerison\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(89, 89, true);
            WriteLiteral("\r\n\r\n<h2></h2>\r\n<br />\r\n\r\n<div class=\"panel-group\">\r\n    <div class=\"row d-inline-flex\">\r\n");
            EndContext();
#line 13 "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet_3BonneVerison\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(227, 251, true);
            WriteLiteral("            <div class=\"col-12 col-sm-6 col-md-4 col-lg-3 p-2\">\r\n                <div class=\"panel panel-primary\">\r\n\r\n                    <div class=\"panel-heading\">\r\n                        <h4 style=\"font-weight:bold;\">\r\n                            ");
            EndContext();
            BeginContext(479, 48, false);
#line 20 "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet_3BonneVerison\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TitreFrancais));

#line default
#line hidden
            EndContext();
            BeginContext(527, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 21 "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet_3BonneVerison\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                              if (item.AnneeSortie != null)
                                {

#line default
#line hidden
            BeginContext(623, 30, true);
            WriteLiteral("<i style=\"font-size:small;\"> (");
            EndContext();
            BeginContext(654, 46, false);
#line 22 "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet_3BonneVerison\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                                                          Write(Html.DisplayFor(modelItem => item.AnneeSortie));

#line default
#line hidden
            EndContext();
            BeginContext(700, 6, true);
            WriteLiteral(") </i>");
            EndContext();
#line 22 "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet_3BonneVerison\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                                                                                                                    }
                            

#line default
#line hidden
            BeginContext(740, 89, true);
            WriteLiteral("                        </h4>\r\n\r\n                        <h5 style=\"font-style: italic\"> ");
            EndContext();
            BeginContext(830, 48, false);
#line 26 "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet_3BonneVerison\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.TitreOriginal));

#line default
#line hidden
            EndContext();
            BeginContext(878, 84, true);
            WriteLiteral(" </h5>\r\n                    </div>\r\n\r\n                    <div class=\"panel-body\">\r\n");
            EndContext();
#line 30 "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet_3BonneVerison\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                          
                            var path = System.IO.Path.GetFullPath("wwwroot/images/" + @item.FilmId + ".jpg");

                            if (!System.IO.File.Exists(path))
                            {

#line default
#line hidden
            BeginContext(1197, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(1229, 154, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6b64c77adc9e4791b99f17e6dc9d5474", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1383, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 37 "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet_3BonneVerison\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(1481, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(1513, 164, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6f2e571f072c4f648e3dd40cc5b7c5cd", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1627, "~/images/", 1627, 9, true);
#line 41 "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet_3BonneVerison\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
AddHtmlAttributeValue("", 1636, item.FilmId, 1636, 14, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 1650, ".jpg", 1650, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1677, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 42 "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet_3BonneVerison\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                            }
                        

#line default
#line hidden
            BeginContext(1737, 57, true);
            WriteLiteral("                        <p>\r\n                            ");
            EndContext();
            BeginContext(1795, 66, false);
#line 45 "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet_3BonneVerison\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.CategorieNavigation.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1861, 89, true);
            WriteLiteral("\r\n                        </p>\r\n                        <p>\r\n                            ");
            EndContext();
            BeginContext(1951, 63, false);
#line 48 "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet_3BonneVerison\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.FormatNavigation.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2014, 32, true);
            WriteLiteral("\r\n                        </p>\r\n");
            EndContext();
#line 50 "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet_3BonneVerison\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                           if (item.Producteur != null)
                            {

#line default
#line hidden
            BeginContext(2134, 84, true);
            WriteLiteral("                                <p>\r\n                                    Produceur: ");
            EndContext();
            BeginContext(2219, 49, false);
#line 53 "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet_3BonneVerison\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                                          Write(Html.DisplayFor(modelItem => item.Producteur.Nom));

#line default
#line hidden
            EndContext();
            BeginContext(2268, 126, true);
            WriteLiteral("\r\n                                </p>\r\n                                <p>\r\n                                    Realisateur: ");
            EndContext();
            BeginContext(2395, 50, false);
#line 56 "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet_3BonneVerison\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                                            Write(Html.DisplayFor(modelItem => item.Realisateur.Nom));

#line default
#line hidden
            EndContext();
            BeginContext(2445, 39, true);
            WriteLiteral("\r\n                                </p> ");
            EndContext();
#line 57 "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet_3BonneVerison\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                                     }
                        

#line default
#line hidden
            BeginContext(2514, 57, true);
            WriteLiteral("                        <p>\r\n                            ");
            EndContext();
            BeginContext(2571, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38c5b22a311a4d0998c983dd56bb8a82", async() => {
                BeginContext(2620, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 60 "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet_3BonneVerison\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                                                   WriteLiteral(item.FilmId);

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
            BeginContext(2628, 32, true);
            WriteLiteral(" |\r\n                            ");
            EndContext();
            BeginContext(2660, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2a5ba0b591449aba25a8be748499f9a", async() => {
                BeginContext(2712, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 61 "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet_3BonneVerison\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                                                      WriteLiteral(item.FilmId);

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
            BeginContext(2723, 32, true);
            WriteLiteral(" |\r\n                            ");
            EndContext();
            BeginContext(2755, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a43aaf6ee11e45e2ab18e489321526e6", async() => {
                BeginContext(2806, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 62 "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet_3BonneVerison\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                                                     WriteLiteral(item.FilmId);

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
            BeginContext(2816, 136, true);
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n                <br /><br />\r\n\r\n            </div>\r\n");
            EndContext();
#line 69 "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet_3BonneVerison\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"

        }

#line default
#line hidden
            BeginContext(2965, 26, true);
            WriteLiteral("\r\n    </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GestionDVDs.Models.Films>> Html { get; private set; }
    }
}
#pragma warning restore 1591
