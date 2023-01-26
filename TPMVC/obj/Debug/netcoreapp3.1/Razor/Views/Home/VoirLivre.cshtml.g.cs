#pragma checksum "C:\Users\Marie\Documents\ISIKA\Cours Pierre - ASP.NET MVC\JA2 - 30112022\TPMVC_MarieCDA21\TPMVC\Views\Home\VoirLivre.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "211ede12e6f1d5cdecf2f0b546146a4ea564e342"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_VoirLivre), @"mvc.1.0.view", @"/Views/Home/VoirLivre.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"211ede12e6f1d5cdecf2f0b546146a4ea564e342", @"/Views/Home/VoirLivre.cshtml")]
    #nullable restore
    public class Views_Home_VoirLivre : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TPMVC.ViewModel.HomeViewModel>
    #nullable disable
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "211ede12e6f1d5cdecf2f0b546146a4ea564e3422878", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <link href=""/css/style.css"" rel=""stylesheet"" type=""text/css"" />
    <link rel=""preconnect"" href=""https://fonts.googleapis.com"">
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
    <link href=""https://fonts.googleapis.com/css2?family=Solway:wght@300&display=swap"" rel=""stylesheet"">
    <title>Liste Livres</title>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "211ede12e6f1d5cdecf2f0b546146a4ea564e3424271", async() => {
                WriteLiteral("\r\n    <div class=\"pres\">\r\n        <h1>FLAC</h1>\r\n        <h2>La liste des livres disponibles</h2>\r\n    </div>\r\n    <table>\r\n        <tr>\r\n            <th>Titre</th>\r\n            <th>Auteur</th>\r\n            <th>Nombre de pages</th>\r\n        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\Marie\Documents\ISIKA\Cours Pierre - ASP.NET MVC\JA2 - 30112022\TPMVC_MarieCDA21\TPMVC\Views\Home\VoirLivre.cshtml"
         foreach (var livre in @Model.Livres)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\Marie\Documents\ISIKA\Cours Pierre - ASP.NET MVC\JA2 - 30112022\TPMVC_MarieCDA21\TPMVC\Views\Home\VoirLivre.cshtml"
               Write(livre.Titre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\Marie\Documents\ISIKA\Cours Pierre - ASP.NET MVC\JA2 - 30112022\TPMVC_MarieCDA21\TPMVC\Views\Home\VoirLivre.cshtml"
               Write(livre.Auteur);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td class=\"page\">");
#nullable restore
#line 34 "C:\Users\Marie\Documents\ISIKA\Cours Pierre - ASP.NET MVC\JA2 - 30112022\TPMVC_MarieCDA21\TPMVC\Views\Home\VoirLivre.cshtml"
                            Write(livre.NbPages);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 36 "C:\Users\Marie\Documents\ISIKA\Cours Pierre - ASP.NET MVC\JA2 - 30112022\TPMVC_MarieCDA21\TPMVC\Views\Home\VoirLivre.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    </table>
    <br/>
    <div class=""ajoutSupp"">
        Pour ajouter un livre : <span><a href=""https://localhost:5001/Home/FormulaireAjout"">ICI</a> !</span><br /><br />
        Pour supprimer un livre, veuillez indiquer le titre du livre concerné :
");
#nullable restore
#line 42 "C:\Users\Marie\Documents\ISIKA\Cours Pierre - ASP.NET MVC\JA2 - 30112022\TPMVC_MarieCDA21\TPMVC\Views\Home\VoirLivre.cshtml"
         using (Html.BeginForm("Supp", "Home", FormMethod.Get))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\Marie\Documents\ISIKA\Cours Pierre - ASP.NET MVC\JA2 - 30112022\TPMVC_MarieCDA21\TPMVC\Views\Home\VoirLivre.cshtml"
       Write(Html.DropDownList("titre", new SelectList(@Model.Titres, "titre"), "[Sélectionner un titre]"));

#line default
#line hidden
#nullable disable
                WriteLiteral("        <input class=\"btnsup\" type=\"submit\" value=\"Supprimer\"/>\r\n");
#nullable restore
#line 54 "C:\Users\Marie\Documents\ISIKA\Cours Pierre - ASP.NET MVC\JA2 - 30112022\TPMVC_MarieCDA21\TPMVC\Views\Home\VoirLivre.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n\r\n    <div class=\"retour\">\r\n        <a href=\"https://localhost:5001/Home/Index\">Retour</a>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TPMVC.ViewModel.HomeViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
