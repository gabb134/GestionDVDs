#pragma checksum "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Account\ListUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11db617197d1f6c5d9e07b18432b555504827486"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ListUsers), @"mvc.1.0.view", @"/Views/Account/ListUsers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/ListUsers.cshtml", typeof(AspNetCore.Views_Account_ListUsers))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11db617197d1f6c5d9e07b18432b555504827486", @"/Views/Account/ListUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f9c40c50d6b02254a9c1dfed9b7b805da989cea", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ListUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApplicationUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/delete.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Account\ListUsers.cshtml"
  
    ViewBag.Title = "Tous les utilisateurs";

#line default
#line hidden
            BeginContext(92, 66, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h3> Liste des utilisateurs </h3>\r\n");
            EndContext();
#line 9 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Account\ListUsers.cshtml"
     if (ViewBag.LOL != null)
    {

#line default
#line hidden
            BeginContext(196, 89, true);
            WriteLiteral("        <h3 class=\"danger\">Tu ne peux pas supprimer un compte administrateur. lol </h3>\r\n");
            EndContext();
#line 12 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Account\ListUsers.cshtml"
    }

#line default
#line hidden
            BeginContext(292, 17, true);
            WriteLiteral("    <p>\r\n        ");
            EndContext();
            BeginContext(309, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e909c1900513467a81bb51c86ba908da", async() => {
                BeginContext(334, 30, true);
                WriteLiteral("Ajouter un nouveau utilisateur");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(368, 72, true);
            WriteLiteral("\r\n    </p>\r\n\r\n    <div class=\"panel-group\">\r\n        <div class=\"row\">\r\n");
            EndContext();
#line 19 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Account\ListUsers.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(497, 99, true);
            WriteLiteral("                <div class=\"col-lg-3 col-md-4 col-sm-6 col-xs-12 p-10\">\r\n\r\n                    <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 596, "\"", 609, 1);
#line 23 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Account\ListUsers.cshtml"
WriteAttributeValue("", 601, item.Id, 601, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 610, "\"", 693, 2);
            WriteAttributeValue("", 618, "panel", 618, 5, true);
#line 23 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Account\ListUsers.cshtml"
WriteAttributeValue(" ", 623, User.Identity.Name==item.UserName? "panel-primary" : "panel-info" , 624, 69, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(694, 171, true);
            WriteLiteral(" style=\"max-height:280px; min-height:280px; width:275px\">\r\n\r\n                        <div class=\"panel-heading\">\r\n                            <h4 style=\"font-weight:bold\">");
            EndContext();
            BeginContext(866, 13, false);
#line 26 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Account\ListUsers.cshtml"
                                                    Write(item.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(879, 68, true);
            WriteLiteral("</h4>\r\n                            <i style=\"font-size:smaller\">Id: ");
            EndContext();
            BeginContext(948, 7, false);
#line 27 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Account\ListUsers.cshtml"
                                                        Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(955, 119, true);
            WriteLiteral(" </i>\r\n                        </div>\r\n\r\n                        <div class=\"panel-body\">\r\n                            ");
            EndContext();
            BeginContext(1075, 10, false);
#line 31 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Account\ListUsers.cshtml"
                       Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1085, 47, true);
            WriteLiteral(" <br /><br />\r\n                            <i> ");
            EndContext();
            BeginContext(1134, 80, false);
#line 32 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Account\ListUsers.cshtml"
                            Write(item.PhoneNumber != null ? "Téléphone: " + item.PhoneNumber : "Pas de téléphone");

#line default
#line hidden
            EndContext();
            BeginContext(1215, 121, true);
            WriteLiteral(" </i>\r\n                        </div>\r\n\r\n                        <div class=\"panel-footer\">\r\n                            ");
            EndContext();
            BeginContext(1336, 267, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b1cdb5038ff431789ae23883b3acfe9", async() => {
                BeginContext(1397, 199, true);
                WriteLiteral("\r\n                                <button type=\"submit\" class=\"btn btn-warning\">\r\n                                    Modifier\r\n                                </button>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 36 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Account\ListUsers.cshtml"
                                                                   WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1603, 37, true);
            WriteLiteral(" <br />\r\n                            ");
            EndContext();
            BeginContext(1640, 848, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d7113a8366040cfa7c8a6559cd42ef8", async() => {
                BeginContext(1704, 39, true);
                WriteLiteral("\r\n                                <span");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 1743, "\"", 1769, 2);
                WriteAttributeValue("", 1748, "confirmeSpan_", 1748, 13, true);
#line 42 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Account\ListUsers.cshtml"
WriteAttributeValue("", 1761, item.Id, 1761, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1770, 226, true);
                WriteLiteral(" style=\"display:none\">\r\n                                    <span>Êtes-vous certain?</span>\r\n                                    <button type=\"submit\" class=\"btn btn-danger\">Oui</button>\r\n                                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1996, "\"", 2012, 2);
                WriteAttributeValue("", 2003, "#", 2003, 1, true);
#line 45 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Account\ListUsers.cshtml"
WriteAttributeValue("", 2004, item.Id, 2004, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2013, 24, true);
                WriteLiteral(" class=\"btn btn-primary\"");
                EndContext();
                BeginWriteAttribute("onclick", " \r\n                                       onclick=\"", 2037, "\"", 2120, 4);
                WriteAttributeValue("", 2088, "confirmDelete(\'", 2088, 15, true);
#line 46 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Account\ListUsers.cshtml"
WriteAttributeValue("", 2103, item.Id, 2103, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 2111, "\',", 2111, 2, true);
                WriteAttributeValue(" ", 2113, "false)", 2114, 7, true);
                EndWriteAttribute();
                BeginContext(2121, 88, true);
                WriteLiteral(">Non</a>\r\n                                </span>\r\n                                <span");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 2209, "\"", 2235, 2);
                WriteAttributeValue("", 2214, "supprimeSpan_", 2214, 13, true);
#line 48 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Account\ListUsers.cshtml"
WriteAttributeValue("", 2227, item.Id, 2227, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2236, 41, true);
                WriteLiteral(">\r\n                                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2277, "\"", 2293, 2);
                WriteAttributeValue("", 2284, "#", 2284, 1, true);
#line 49 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Account\ListUsers.cshtml"
WriteAttributeValue("", 2285, item.Id, 2285, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2294, 23, true);
                WriteLiteral(" class=\"btn btn-danger\"");
                EndContext();
                BeginWriteAttribute("onclick", "\r\n                                       onclick=\"", 2317, "\"", 2398, 4);
                WriteAttributeValue("", 2367, "confirmDelete(\'", 2367, 15, true);
#line 50 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Account\ListUsers.cshtml"
WriteAttributeValue("", 2382, item.Id, 2382, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 2390, "\',", 2390, 2, true);
                WriteAttributeValue(" ", 2392, "true)", 2393, 6, true);
                EndWriteAttribute();
                BeginContext(2399, 82, true);
                WriteLiteral(">Delete</a>\r\n                                </span>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 41 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Account\ListUsers.cshtml"
                                                                      WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2488, 118, true);
            WriteLiteral("\r\n                        </div>\r\n\r\n                    </div>\r\n\r\n                    <br />\r\n                </div>\r\n");
            EndContext();
#line 59 "C:\Users\Ankit-PC\Gerald-Godin\Programmation Serveur 2\VS Projects\GestionDVDs\GestionDVDs\GestionDVDs\Views\Account\ListUsers.cshtml"
            }

#line default
#line hidden
            BeginContext(2621, 38, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2677, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2683, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30f5e5e4e7c04a79a072eb3a9aeff55a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2721, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591