#pragma checksum "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a257c1a3486fc6cb9e6e93cb0bda706cc4a2e9bc"
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
#line 1 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\_ViewImports.cshtml"
using GestionDVDs;

#line default
#line hidden
#line 2 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\_ViewImports.cshtml"
using GestionDVDs.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a257c1a3486fc6cb9e6e93cb0bda706cc4a2e9bc", @"/Views/Films/Index.cshtml")]
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
#line 3 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
  
    ViewData["Title"] = "Catalogue";

#line default
#line hidden
            BeginContext(93, 115, true);
            WriteLiteral("\r\n<br />\r\n<div class=\"container\"  style=\"margin: 20px\">\r\n    <div class=\"panel-group\">\r\n        <div class=\"row\">\r\n");
            EndContext();
#line 11 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(265, 275, true);
            WriteLiteral(@"                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 p-10"">
                    <div class=""panel panel-primary"">

                        <div class=""panel-heading"">
                            <h4 style=""font-weight:bold;"">
                                ");
            EndContext();
            BeginContext(541, 48, false);
#line 18 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.TitreFrancais));

#line default
#line hidden
            EndContext();
            BeginContext(589, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 19 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                                  if (item.AnneeSortie != null)
                                    {

#line default
#line hidden
            BeginContext(693, 30, true);
            WriteLiteral("<i style=\"font-size:small;\"> (");
            EndContext();
            BeginContext(724, 46, false);
#line 20 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                                                              Write(Html.DisplayFor(modelItem => item.AnneeSortie));

#line default
#line hidden
            EndContext();
            BeginContext(770, 6, true);
            WriteLiteral(") </i>");
            EndContext();
#line 20 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                                                                                                                        }
                                

#line default
#line hidden
            BeginContext(814, 97, true);
            WriteLiteral("                            </h4>\r\n\r\n                            <h5 style=\"font-style: italic\"> ");
            EndContext();
            BeginContext(912, 48, false);
#line 24 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.TitreOriginal));

#line default
#line hidden
            EndContext();
            BeginContext(960, 92, true);
            WriteLiteral(" </h5>\r\n                        </div>\r\n\r\n                        <div class=\"panel-body\">\r\n");
            EndContext();
#line 28 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                              
                                var path = System.IO.Path.GetFullPath("wwwroot/images/" + @item.FilmId + ".jpg");

                                if (!System.IO.File.Exists(path))
                                {

#line default
#line hidden
            BeginContext(1303, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(1339, 158, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e1863ed89efb48fe82fa24bcb55d97a3", async() => {
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
            BeginContext(1497, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 35 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(1607, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(1643, 168, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ff540945af87491996c997d288c9d1ff", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1761, "~/images/", 1761, 9, true);
#line 39 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
AddHtmlAttributeValue("", 1770, item.FilmId, 1770, 14, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 1784, ".jpg", 1784, 4, true);
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
            BeginContext(1811, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 40 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                                }
                            

#line default
#line hidden
            BeginContext(1879, 65, true);
            WriteLiteral("                            <p>\r\n                                ");
            EndContext();
            BeginContext(1945, 66, false);
#line 43 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CategorieNavigation.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2011, 101, true);
            WriteLiteral("\r\n                            </p>\r\n                            <p>\r\n                                ");
            EndContext();
            BeginContext(2113, 63, false);
#line 46 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.FormatNavigation.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2176, 36, true);
            WriteLiteral("\r\n                            </p>\r\n");
            EndContext();
#line 48 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                               if (item.Producteur != null)
                                {

#line default
#line hidden
            BeginContext(2308, 92, true);
            WriteLiteral("                                    <p>\r\n                                        Produceur: ");
            EndContext();
            BeginContext(2401, 49, false);
#line 51 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                                              Write(Html.DisplayFor(modelItem => item.Producteur.Nom));

#line default
#line hidden
            EndContext();
            BeginContext(2450, 138, true);
            WriteLiteral("\r\n                                    </p>\r\n                                    <p>\r\n                                        Realisateur: ");
            EndContext();
            BeginContext(2589, 50, false);
#line 54 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                                                Write(Html.DisplayFor(modelItem => item.Realisateur.Nom));

#line default
#line hidden
            EndContext();
            BeginContext(2639, 43, true);
            WriteLiteral("\r\n                                    </p> ");
            EndContext();
#line 55 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                                         }
                            

#line default
#line hidden
            BeginContext(2716, 65, true);
            WriteLiteral("                            <p>\r\n                                ");
            EndContext();
            BeginContext(2781, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bad9d582ca5a496698bbee1806ceb458", async() => {
                BeginContext(2830, 8, true);
                WriteLiteral("Modifier");
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
#line 58 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
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
            BeginContext(2842, 36, true);
            WriteLiteral(" |\r\n                                ");
            EndContext();
            BeginContext(2878, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "702d43c490b0456aa3413e1b0657f65e", async() => {
                BeginContext(2930, 7, true);
                WriteLiteral("Détails");
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
#line 59 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
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
            BeginContext(2941, 36, true);
            WriteLiteral(" |\r\n                                ");
            EndContext();
            BeginContext(2977, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82913000738a415e936d6b77ddfea828", async() => {
                BeginContext(3028, 9, true);
                WriteLiteral("Supprimer");
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
#line 60 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
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
            BeginContext(3041, 156, true);
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n                    <br /><br />\r\n\r\n                </div>\r\n");
            EndContext();
#line 67 "C:\Users\Etudiant\Desktop\420-W56 web-serveur II\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"

            }

#line default
#line hidden
            BeginContext(3214, 38, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
