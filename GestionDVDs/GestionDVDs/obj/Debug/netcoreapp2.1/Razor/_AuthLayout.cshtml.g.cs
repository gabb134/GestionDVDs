#pragma checksum "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet_3BonneVerison\GestionDVDs\GestionDVDs\_AuthLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdc34c08883859437fd30857078a8edf7594b3d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore._AuthLayout), @"mvc.1.0.view", @"/_AuthLayout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/_AuthLayout.cshtml", typeof(AspNetCore._AuthLayout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdc34c08883859437fd30857078a8edf7594b3d4", @"/_AuthLayout.cshtml")]
    public class _AuthLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet_3BonneVerison\GestionDVDs\GestionDVDs\_AuthLayout.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(54, 657, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-6 offset-md-3"">
        <div class=""card login-logout-tab "">
            <div class=""card-header"">
                <ul class=""nav nav-tabs card-header-tabs"">
                    <li class=""nav-item"">
                        <a class=""nav-link"" href='/account/Login'>Connexion</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href='/account/Register'>Inscription</a>
                    </li>
                </ul>
            </div>
            <div class=""card-content"">
                <div class=""col-md-12"">
                    ");
            EndContext();
            BeginContext(712, 12, false);
#line 20 "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet_3BonneVerison\GestionDVDs\GestionDVDs\_AuthLayout.cshtml"
               Write(RenderBody());

#line default
#line hidden
            EndContext();
            BeginContext(724, 84, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(825, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(832, 41, false);
#line 28 "C:\Users\riben\Documents\Programmation web serveur II\Projets\Projet3\Projet_3BonneVerison\GestionDVDs\GestionDVDs\_AuthLayout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(873, 353, true);
                WriteLiteral(@"
    <script>
        $(function () {
            var current = location.pathname;
            $('.nav-tabs li a').each(function () {
                var $this = $(this);
                if (current.indexOf($this.attr('href')) !== -1) {
                    $this.addClass('active');
                }
            })
        })
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
