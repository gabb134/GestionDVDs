#pragma checksum "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4ddde86d8a046f50966672a31fe7293a939420a"
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
#line 1 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\_ViewImports.cshtml"
using GestionDVDs;

#line default
#line hidden
#line 2 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\_ViewImports.cshtml"
using GestionDVDs.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4ddde86d8a046f50966672a31fe7293a939420a", @"/Views/Films/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f9c40c50d6b02254a9c1dfed9b7b805da989cea", @"/Views/_ViewImports.cshtml")]
    public class Views_Films_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GestionDVDs.Models.Films>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width:200px;  max-height : 200px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/poster.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Aucune image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Poster du film"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
  
    ViewData["Title"] = "Catalogue";

#line default
#line hidden
            BeginContext(93, 115, true);
            WriteLiteral("\r\n<br />\r\n<div class=\"container\"  style=\"margin: 20px\">\r\n    <div class=\"panel-group\">\r\n        <div class=\"row\">\r\n");
            EndContext();
#line 11 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(265, 300, true);
            WriteLiteral(@"                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 p-10"">
                    <div class=""panel panel-primary"">

                        <div class=""panel-heading"" style=""min-height:110px"">
                            <h4 style=""font-weight:bold;"">
                                ");
            EndContext();
            BeginContext(566, 48, false);
#line 18 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.TitreFrancais));

#line default
#line hidden
            EndContext();
            BeginContext(614, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 19 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                                  if (item.AnneeSortie != null)
                                    {

#line default
#line hidden
            BeginContext(718, 30, true);
            WriteLiteral("<i style=\"font-size:small;\"> (");
            EndContext();
            BeginContext(749, 46, false);
#line 20 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                                                              Write(Html.DisplayFor(modelItem => item.AnneeSortie));

#line default
#line hidden
            EndContext();
            BeginContext(795, 6, true);
            WriteLiteral(") </i>");
            EndContext();
#line 20 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                                                                                                                        }
                                

#line default
#line hidden
            BeginContext(839, 97, true);
            WriteLiteral("                            </h4>\r\n\r\n                            <h5 style=\"font-style: italic\"> ");
            EndContext();
            BeginContext(937, 48, false);
#line 24 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.TitreOriginal));

#line default
#line hidden
            EndContext();
            BeginContext(985, 117, true);
            WriteLiteral(" </h5>\r\n                        </div>\r\n\r\n                        <div class=\"panel-body\" style=\"max-height:250px\">\r\n");
            EndContext();
#line 28 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                              
                                var path = System.IO.Path.GetFullPath("wwwroot/images/" + @item.FilmId + ".jpg");

                                if (!System.IO.File.Exists(path))
                                {

#line default
#line hidden
            BeginContext(1353, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(1389, 300, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3ce931cebe846dd8f76a7182f8b359a", async() => {
                BeginContext(1441, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(1483, 164, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "78458e2347f44e29896c1d249842e30e", async() => {
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
                BeginContext(1647, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 33 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
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
            BeginContext(1689, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 37 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(1799, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(1835, 310, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf02be00e1494045bbeb1bcbe08962a4", async() => {
                BeginContext(1887, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(1929, 174, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2727497a71c14e03b79bac68e363cba0", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2053, "~/images/", 2053, 9, true);
#line 42 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
AddHtmlAttributeValue("", 2062, item.FilmId, 2062, 14, false);

#line default
#line hidden
                AddHtmlAttributeValue("", 2076, ".jpg", 2076, 4, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2103, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 40 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
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
            BeginContext(2145, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 44 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                                }
                                

#line default
#line hidden
            BeginContext(2217, 73, true);
            WriteLiteral("                                <p>\r\n                                    ");
            EndContext();
            BeginContext(2291, 66, false);
#line 47 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.CategorieNavigation.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2357, 113, true);
            WriteLiteral("\r\n                                </p>\r\n                                <p>\r\n                                    ");
            EndContext();
            BeginContext(2471, 63, false);
#line 50 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.FormatNavigation.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2534, 40, true);
            WriteLiteral("\r\n                                </p>\r\n");
            EndContext();
#line 52 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                                   if (item.Producteur != null)
                                    {

#line default
#line hidden
            BeginContext(2678, 100, true);
            WriteLiteral("                                        <p>\r\n                                            Produceur: ");
            EndContext();
            BeginContext(2779, 49, false);
#line 55 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                                                  Write(Html.DisplayFor(modelItem => item.Producteur.Nom));

#line default
#line hidden
            EndContext();
            BeginContext(2828, 150, true);
            WriteLiteral("\r\n                                        </p>\r\n                                        <p>\r\n                                            Realisateur: ");
            EndContext();
            BeginContext(2979, 50, false);
#line 58 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                                                    Write(Html.DisplayFor(modelItem => item.Realisateur.Nom));

#line default
#line hidden
            EndContext();
            BeginContext(3029, 47, true);
            WriteLiteral("\r\n                                        </p> ");
            EndContext();
#line 59 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
                                             }
                                

#line default
#line hidden
            BeginContext(3114, 73, true);
            WriteLiteral("                                <p>\r\n                                    ");
            EndContext();
            BeginContext(3187, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7a21f5090184c609aa18ab493ff9931", async() => {
                BeginContext(3236, 8, true);
                WriteLiteral("Modifier");
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
#line 62 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
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
            BeginContext(3248, 40, true);
            WriteLiteral(" |\r\n                                    ");
            EndContext();
            BeginContext(3288, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97c7650bf0ec4faa9b9e408c70f44a21", async() => {
                BeginContext(3339, 9, true);
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
#line 63 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
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
            BeginContext(3352, 158, true);
            WriteLiteral("\r\n                                </p>\r\n                        </div>\r\n                    </div>\r\n                    <br /><br />\r\n                </div>\r\n");
            EndContext();
#line 69 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Films\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(3525, 36, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
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