#pragma checksum "F:\asu00\Descargas\Universidad\Programacion Avanzada\VS\FE_Pryecto_FInalAPI\FE_Pryecto_FInalAPI\Views\RutaChofer\ListarRutaChofer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2f4e5f32afc4a5b652c7b45e12ca0360e2d2aca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RutaChofer_ListarRutaChofer), @"mvc.1.0.view", @"/Views/RutaChofer/ListarRutaChofer.cshtml")]
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
#nullable restore
#line 1 "F:\asu00\Descargas\Universidad\Programacion Avanzada\VS\FE_Pryecto_FInalAPI\FE_Pryecto_FInalAPI\Views\_ViewImports.cshtml"
using FE_Pryecto_FInalAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\asu00\Descargas\Universidad\Programacion Avanzada\VS\FE_Pryecto_FInalAPI\FE_Pryecto_FInalAPI\Views\_ViewImports.cshtml"
using FE_Pryecto_FInalAPI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2f4e5f32afc4a5b652c7b45e12ca0360e2d2aca", @"/Views/RutaChofer/ListarRutaChofer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75b9e32499e18192d30c83daec1295ae2be98ce2", @"/Views/_ViewImports.cshtml")]
    public class Views_RutaChofer_ListarRutaChofer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FE_Pryecto_FInalAPI.Models.RutaChofer>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AbrirNuevaRutaChofer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "RutaChofer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn bg-info text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\asu00\Descargas\Universidad\Programacion Avanzada\VS\FE_Pryecto_FInalAPI\FE_Pryecto_FInalAPI\Views\RutaChofer\ListarRutaChofer.cshtml"
  
    ViewData["Title"] = "ListarRutaChofer";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Listas de Rutas por Chofer</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2f4e5f32afc4a5b652c7b45e12ca0360e2d2aca4674", async() => {
                WriteLiteral("Nueva Ruta de Chofer");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "F:\asu00\Descargas\Universidad\Programacion Avanzada\VS\FE_Pryecto_FInalAPI\FE_Pryecto_FInalAPI\Views\RutaChofer\ListarRutaChofer.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "F:\asu00\Descargas\Universidad\Programacion Avanzada\VS\FE_Pryecto_FInalAPI\FE_Pryecto_FInalAPI\Views\RutaChofer\ListarRutaChofer.cshtml"
           Write(Html.DisplayNameFor(model => model.CodEmpleado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "F:\asu00\Descargas\Universidad\Programacion Avanzada\VS\FE_Pryecto_FInalAPI\FE_Pryecto_FInalAPI\Views\RutaChofer\ListarRutaChofer.cshtml"
           Write(Html.DisplayNameFor(model => model.NombreRuta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "F:\asu00\Descargas\Universidad\Programacion Avanzada\VS\FE_Pryecto_FInalAPI\FE_Pryecto_FInalAPI\Views\RutaChofer\ListarRutaChofer.cshtml"
           Write(Html.DisplayNameFor(model => model.CantidadPasajeros));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "F:\asu00\Descargas\Universidad\Programacion Avanzada\VS\FE_Pryecto_FInalAPI\FE_Pryecto_FInalAPI\Views\RutaChofer\ListarRutaChofer.cshtml"
           Write(Html.DisplayNameFor(model => model.MontoPasaje));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "F:\asu00\Descargas\Universidad\Programacion Avanzada\VS\FE_Pryecto_FInalAPI\FE_Pryecto_FInalAPI\Views\RutaChofer\ListarRutaChofer.cshtml"
           Write(Html.DisplayNameFor(model => model.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 37 "F:\asu00\Descargas\Universidad\Programacion Avanzada\VS\FE_Pryecto_FInalAPI\FE_Pryecto_FInalAPI\Views\RutaChofer\ListarRutaChofer.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "F:\asu00\Descargas\Universidad\Programacion Avanzada\VS\FE_Pryecto_FInalAPI\FE_Pryecto_FInalAPI\Views\RutaChofer\ListarRutaChofer.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "F:\asu00\Descargas\Universidad\Programacion Avanzada\VS\FE_Pryecto_FInalAPI\FE_Pryecto_FInalAPI\Views\RutaChofer\ListarRutaChofer.cshtml"
           Write(Html.DisplayFor(modelItem => item.CodEmpleado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "F:\asu00\Descargas\Universidad\Programacion Avanzada\VS\FE_Pryecto_FInalAPI\FE_Pryecto_FInalAPI\Views\RutaChofer\ListarRutaChofer.cshtml"
           Write(Html.DisplayFor(modelItem => item.NombreRuta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "F:\asu00\Descargas\Universidad\Programacion Avanzada\VS\FE_Pryecto_FInalAPI\FE_Pryecto_FInalAPI\Views\RutaChofer\ListarRutaChofer.cshtml"
           Write(Html.DisplayFor(modelItem => item.CantidadPasajeros));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "F:\asu00\Descargas\Universidad\Programacion Avanzada\VS\FE_Pryecto_FInalAPI\FE_Pryecto_FInalAPI\Views\RutaChofer\ListarRutaChofer.cshtml"
           Write(Html.DisplayFor(modelItem => item.MontoPasaje));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "F:\asu00\Descargas\Universidad\Programacion Avanzada\VS\FE_Pryecto_FInalAPI\FE_Pryecto_FInalAPI\Views\RutaChofer\ListarRutaChofer.cshtml"
           Write(Html.DisplayFor(modelItem => item.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "F:\asu00\Descargas\Universidad\Programacion Avanzada\VS\FE_Pryecto_FInalAPI\FE_Pryecto_FInalAPI\Views\RutaChofer\ListarRutaChofer.cshtml"
           Write(Html.ActionLink("Modificar", "AbrirModificarRutaChofer", new { id=item.Id, codempleado=item.CodEmpleado, nombreruta=item.NombreRuta, cantidadpasajeros=item.CantidadPasajeros, montopasaje=item.MontoPasaje, total=item.Total }, new { @class = "btn btn-warning mr-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 59 "F:\asu00\Descargas\Universidad\Programacion Avanzada\VS\FE_Pryecto_FInalAPI\FE_Pryecto_FInalAPI\Views\RutaChofer\ListarRutaChofer.cshtml"
           Write(Html.ActionLink("Eliminar", "EliminarRutaChofer", new { codempleado=item.CodEmpleado, nombreruta=item.NombreRuta, montopasaje=item.MontoPasaje }, new { @class = "btn btn-danger ml-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 62 "F:\asu00\Descargas\Universidad\Programacion Avanzada\VS\FE_Pryecto_FInalAPI\FE_Pryecto_FInalAPI\Views\RutaChofer\ListarRutaChofer.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FE_Pryecto_FInalAPI.Models.RutaChofer>> Html { get; private set; }
    }
}
#pragma warning restore 1591