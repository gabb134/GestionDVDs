#pragma checksum "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet3_9-12\GestionDVDs\GestionDVDs\Views\Messages\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37d040f4f4342d3d381288b98f239d73450f4ad2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Messages_Delete), @"mvc.1.0.view", @"/Views/Messages/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Messages/Delete.cshtml", typeof(AspNetCore.Views_Messages_Delete))]
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
#line 1 "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet3_9-12\GestionDVDs\GestionDVDs\Views\_ViewImports.cshtml"
using GestionDVDs;

#line default
#line hidden
#line 2 "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet3_9-12\GestionDVDs\GestionDVDs\Views\_ViewImports.cshtml"
using GestionDVDs.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37d040f4f4342d3d381288b98f239d73450f4ad2", @"/Views/Messages/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f9c40c50d6b02254a9c1dfed9b7b805da989cea", @"/Views/_ViewImports.cshtml")]
    public class Views_Messages_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GestionDVDs.Models.Messages>
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
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet3_9-12\GestionDVDs\GestionDVDs\Views\Messages\Delete.cshtml"
  
    ViewData["Title"] = "Supprimer";

#line default
#line hidden
            BeginContext(83, 138, true);
            WriteLiteral("<h3>Etes-vous certain de vouloir supprimer ce message?</h3>\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(222, 48, false);
#line 11 "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet3_9-12\GestionDVDs\GestionDVDs\Views\Messages\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ExpediteurId));

#line default
#line hidden
            EndContext();
            BeginContext(270, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(314, 44, false);
#line 14 "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet3_9-12\GestionDVDs\GestionDVDs\Views\Messages\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ExpediteurId));

#line default
#line hidden
            EndContext();
            BeginContext(358, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(402, 47, false);
#line 17 "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet3_9-12\GestionDVDs\GestionDVDs\Views\Messages\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.RecipientId));

#line default
#line hidden
            EndContext();
            BeginContext(449, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(493, 43, false);
#line 20 "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet3_9-12\GestionDVDs\GestionDVDs\Views\Messages\Delete.cshtml"
       Write(Html.DisplayFor(model => model.RecipientId));

#line default
#line hidden
            EndContext();
            BeginContext(536, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(580, 51, false);
#line 23 "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet3_9-12\GestionDVDs\GestionDVDs\Views\Messages\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TempsExpedition));

#line default
#line hidden
            EndContext();
            BeginContext(631, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(675, 47, false);
#line 26 "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet3_9-12\GestionDVDs\GestionDVDs\Views\Messages\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TempsExpedition));

#line default
#line hidden
            EndContext();
            BeginContext(722, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(766, 41, false);
#line 29 "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet3_9-12\GestionDVDs\GestionDVDs\Views\Messages\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Sujet));

#line default
#line hidden
            EndContext();
            BeginContext(807, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(851, 37, false);
#line 32 "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet3_9-12\GestionDVDs\GestionDVDs\Views\Messages\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Sujet));

#line default
#line hidden
            EndContext();
            BeginContext(888, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(932, 41, false);
#line 35 "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet3_9-12\GestionDVDs\GestionDVDs\Views\Messages\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Corps));

#line default
#line hidden
            EndContext();
            BeginContext(973, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1017, 37, false);
#line 38 "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet3_9-12\GestionDVDs\GestionDVDs\Views\Messages\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Corps));

#line default
#line hidden
            EndContext();
            BeginContext(1054, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1092, 232, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d89485c7ee054427baeb7fe019dbb573", async() => {
                BeginContext(1118, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1128, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d2184193d8604b338fa2e578e08e5115", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 43 "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet3_9-12\GestionDVDs\GestionDVDs\Views\Messages\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MessageId);

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
                BeginContext(1171, 87, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Supprimer\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1258, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b991ec6368a5479382ba845a77c331b5", async() => {
                    BeginContext(1280, 27, true);
                    WriteLiteral("Retour a la boite au lettre");
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
                BeginContext(1311, 6, true);
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
            BeginContext(1324, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GestionDVDs.Models.Messages> Html { get; private set; }
    }
}
#pragma warning restore 1591
