#pragma checksum "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDesDVDs\GestionDesDVDs\Views\Films\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a7f0bec059f3469ae5a8aa8c230a278654e04ec"
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
#line 1 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDesDVDs\GestionDesDVDs\Views\_ViewImports.cshtml"
using GestionDesDVDs;

#line default
#line hidden
#line 2 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDesDVDs\GestionDesDVDs\Views\_ViewImports.cshtml"
using GestionDesDVDs.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a7f0bec059f3469ae5a8aa8c230a278654e04ec", @"/Views/Films/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e477ef5d2cb1761d82eaf3766ee8f1c92eb536f", @"/Views/_ViewImports.cshtml")]
    public class Views_Films_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GestionDesDVDs.Models.Films>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDesDVDs\GestionDesDVDs\Views\Films\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(92, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(121, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de7f52d618ed410d96282f2054a87d1f", async() => {
                BeginContext(144, 10, true);
                WriteLiteral("Create New");
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
            BeginContext(158, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(251, 47, false);
#line 16 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDesDVDs\GestionDesDVDs\Views\Films\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AnneeSortie));

#line default
#line hidden
            EndContext();
            BeginContext(298, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(354, 43, false);
#line 19 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDesDVDs\GestionDesDVDs\Views\Films\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DateMaj));

#line default
#line hidden
            EndContext();
            BeginContext(397, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(453, 42, false);
#line 22 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDesDVDs\GestionDesDVDs\Views\Films\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Resume));

#line default
#line hidden
            EndContext();
            BeginContext(495, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(551, 48, false);
#line 25 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDesDVDs\GestionDesDVDs\Views\Films\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DureeMinutes));

#line default
#line hidden
            EndContext();
            BeginContext(599, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(655, 48, false);
#line 28 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDesDVDs\GestionDesDVDs\Views\Films\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FilmOriginal));

#line default
#line hidden
            EndContext();
            BeginContext(703, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(759, 49, false);
#line 31 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDesDVDs\GestionDesDVDs\Views\Films\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ImagePochette));

#line default
#line hidden
            EndContext();
            BeginContext(808, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(864, 45, false);
#line 34 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDesDVDs\GestionDesDVDs\Views\Films\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NbDisques));

#line default
#line hidden
            EndContext();
            BeginContext(909, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(965, 49, false);
#line 37 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDesDVDs\GestionDesDVDs\Views\Films\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TitreFrancais));

#line default
#line hidden
            EndContext();
            BeginContext(1014, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1070, 49, false);
#line 40 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDesDVDs\GestionDesDVDs\Views\Films\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TitreOriginal));

#line default
#line hidden
            EndContext();
            BeginContext(1119, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1175, 50, false);
#line 43 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDesDVDs\GestionDesDVDs\Views\Films\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VersionEtendue));

#line default
#line hidden
            EndContext();
            BeginContext(1225, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1281, 40, false);
#line 46 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDesDVDs\GestionDesDVDs\Views\Films\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Xtra));

#line default
#line hidden
            EndContext();
            BeginContext(1321, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1377, 55, false);
#line 49 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDesDVDs\GestionDesDVDs\Views\Films\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CategorieNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1432, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1488, 52, false);
#line 52 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDesDVDs\GestionDesDVDs\Views\Films\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FormatNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1540, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1596, 58, false);
#line 55 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDesDVDs\GestionDesDVDs\Views\Films\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NoProducteurNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1654, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1710, 59, false);
#line 58 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDesDVDs\GestionDesDVDs\Views\Films\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NoRealisateurNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1769, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1825, 62, false);
#line 61 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDesDVDs\GestionDesDVDs\Views\Films\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NoUtilisateurMajNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1887, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 67 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDesDVDs\GestionDesDVDs\Views\Films\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(2005, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2054, 46, false);
#line 70 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDesDVDs\GestionDesDVDs\Views\Films\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AnneeSortie));

#line default
#line hidden
            EndContext();
            BeginContext(2100, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2156, 42, false);
#line 73 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDesDVDs\GestionDesDVDs\Views\Films\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateMaj));

#line default
#line hidden
            EndContext();
            BeginContext(2198, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2254, 41, false);
#line 76 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDesDVDs\GestionDesDVDs\Views\Films\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Resume));

#line default
#line hidden
            EndContext();
            BeginContext(2295, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2351, 47, false);
#line 79 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDesDVDs\GestionDesDVDs\Views\Films\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DureeMinutes));

#line default
#line hidden
            EndContext();
            BeginContext(2398, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2454, 47, false);
#line 82 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDesDVDs\GestionDesDVDs\Views\Films\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FilmOriginal));

#line default
#line hidden
            EndContext();
            BeginContext(2501, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2557, 48, false);
#line 85 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDesDVDs\GestionDesDVDs\Views\Films\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ImagePochette));

#line default
#line hidden
            EndContext();
            BeginContext(2605, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2661, 44, false);
#line 88 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDesDVDs\GestionDesDVDs\Views\Films\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NbDisques));

#line default
#line hidden
            EndContext();
            BeginContext(2705, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2761, 48, false);
#line 91 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDesDVDs\GestionDesDVDs\Views\Films\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TitreFrancais));

#line default
#line hidden
            EndContext();
            BeginContext(2809, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2865, 48, false);
#line 94 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDesDVDs\GestionDesDVDs\Views\Films\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TitreOriginal));

#line default
#line hidden
            EndContext();
            BeginContext(2913, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2969, 49, false);
#line 97 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDesDVDs\GestionDesDVDs\Views\Films\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.VersionEtendue));

#line default
#line hidden
            EndContext();
            BeginContext(3018, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3074, 39, false);
#line 100 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDesDVDs\GestionDesDVDs\Views\Films\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Xtra));

#line default
#line hidden
            EndContext();
            BeginContext(3113, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3169, 66, false);
#line 103 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDesDVDs\GestionDesDVDs\Views\Films\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CategorieNavigation.Description));

#line default
#line hidden
            EndContext();
            BeginContext(3235, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3291, 63, false);
#line 106 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDesDVDs\GestionDesDVDs\Views\Films\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FormatNavigation.Description));

#line default
#line hidden
            EndContext();
            BeginContext(3354, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3410, 61, false);
#line 109 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDesDVDs\GestionDesDVDs\Views\Films\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NoProducteurNavigation.Nom));

#line default
#line hidden
            EndContext();
            BeginContext(3471, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3527, 62, false);
#line 112 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDesDVDs\GestionDesDVDs\Views\Films\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NoRealisateurNavigation.Nom));

#line default
#line hidden
            EndContext();
            BeginContext(3589, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3645, 70, false);
#line 115 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDesDVDs\GestionDesDVDs\Views\Films\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NoUtilisateurMajNavigation.Courriel));

#line default
#line hidden
            EndContext();
            BeginContext(3715, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3770, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0827568aa5a4146ba5eca6337bc8b80", async() => {
                BeginContext(3819, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 118 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDesDVDs\GestionDesDVDs\Views\Films\Index.cshtml"
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
            BeginContext(3827, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3847, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13f9e0ae54d84c938e39dc8961d64281", async() => {
                BeginContext(3899, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 119 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDesDVDs\GestionDesDVDs\Views\Films\Index.cshtml"
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
            BeginContext(3910, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3930, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea9750100be344958cee2861704fa266", async() => {
                BeginContext(3981, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 120 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDesDVDs\GestionDesDVDs\Views\Films\Index.cshtml"
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
            BeginContext(3991, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 123 "C:\Users\GabrielMarrero\Documents\GestionDVDs\GestionDesDVDs\GestionDesDVDs\Views\Films\Index.cshtml"
}

#line default
#line hidden
            BeginContext(4030, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GestionDesDVDs.Models.Films>> Html { get; private set; }
    }
}
#pragma warning restore 1591
