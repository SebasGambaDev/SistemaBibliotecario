#pragma checksum "/Users/juansebastiangambajacomussi/Documents/programacion/misiontic-retos/ciclo-3/proyecto/SistemaBibliotecario/SistemaBibliotecario.App.Presentacion/Pages/Usuarios/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18e3f7cf8fff2433ca7cbe0d0ebefe57a6638631"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SistemaBibliotecario.App.Presentacion.Pages.Usuarios.Pages_Usuarios_Delete), @"mvc.1.0.razor-page", @"/Pages/Usuarios/Delete.cshtml")]
namespace SistemaBibliotecario.App.Presentacion.Pages.Usuarios
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
#line 1 "/Users/juansebastiangambajacomussi/Documents/programacion/misiontic-retos/ciclo-3/proyecto/SistemaBibliotecario/SistemaBibliotecario.App.Presentacion/Pages/_ViewImports.cshtml"
using SistemaBibliotecario.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18e3f7cf8fff2433ca7cbe0d0ebefe57a6638631", @"/Pages/Usuarios/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6569c659545d2f48c5c80c9822b58766a80e8485", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Usuarios_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/juansebastiangambajacomussi/Documents/programacion/misiontic-retos/ciclo-3/proyecto/SistemaBibliotecario/SistemaBibliotecario.App.Presentacion/Pages/Usuarios/Delete.cshtml"
  
    int usuarioId = Model.usuario.id;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2 class=\"text-light\">Eliminar usuario <i class=\"text-primary\">");
#nullable restore
#line 7 "/Users/juansebastiangambajacomussi/Documents/programacion/misiontic-retos/ciclo-3/proyecto/SistemaBibliotecario/SistemaBibliotecario.App.Presentacion/Pages/Usuarios/Delete.cshtml"
                                                           Write(Model.usuario.usu_nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></h2>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18e3f7cf8fff2433ca7cbe0d0ebefe57a66386315553", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "18e3f7cf8fff2433ca7cbe0d0ebefe57a66386315813", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 9 "/Users/juansebastiangambajacomussi/Documents/programacion/misiontic-retos/ciclo-3/proyecto/SistemaBibliotecario/SistemaBibliotecario.App.Presentacion/Pages/Usuarios/Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.usuario.id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <div class=\"form-group text-light\">\r\n        <strong> Id en base de datos:</strong> ");
#nullable restore
#line 11 "/Users/juansebastiangambajacomussi/Documents/programacion/misiontic-retos/ciclo-3/proyecto/SistemaBibliotecario/SistemaBibliotecario.App.Presentacion/Pages/Usuarios/Delete.cshtml"
                                          Write(Model.usuario.id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group text-light\">\r\n        <strong>Identificación:</strong> ");
#nullable restore
#line 14 "/Users/juansebastiangambajacomussi/Documents/programacion/misiontic-retos/ciclo-3/proyecto/SistemaBibliotecario/SistemaBibliotecario.App.Presentacion/Pages/Usuarios/Delete.cshtml"
                                    Write(Model.usuario.usu_identificacion);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group text-light\">\r\n        <strong>Nombres:</strong> ");
#nullable restore
#line 17 "/Users/juansebastiangambajacomussi/Documents/programacion/misiontic-retos/ciclo-3/proyecto/SistemaBibliotecario/SistemaBibliotecario.App.Presentacion/Pages/Usuarios/Delete.cshtml"
                             Write(Model.usuario.usu_nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group text-light\">\r\n        <strong>Apellidos:</strong> ");
#nullable restore
#line 20 "/Users/juansebastiangambajacomussi/Documents/programacion/misiontic-retos/ciclo-3/proyecto/SistemaBibliotecario/SistemaBibliotecario.App.Presentacion/Pages/Usuarios/Delete.cshtml"
                               Write(Model.usuario.usu_apellido);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group text-light\">\r\n        <strong>Telefono:</strong> ");
#nullable restore
#line 23 "/Users/juansebastiangambajacomussi/Documents/programacion/misiontic-retos/ciclo-3/proyecto/SistemaBibliotecario/SistemaBibliotecario.App.Presentacion/Pages/Usuarios/Delete.cshtml"
                              Write(Model.usuario.usu_telefono);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group text-light\">\r\n        <strong>E-mail:</strong> ");
#nullable restore
#line 26 "/Users/juansebastiangambajacomussi/Documents/programacion/misiontic-retos/ciclo-3/proyecto/SistemaBibliotecario/SistemaBibliotecario.App.Presentacion/Pages/Usuarios/Delete.cshtml"
                            Write(Model.usuario.usu_email);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group text-light\">\r\n        <strong>Dirección:</strong> ");
#nullable restore
#line 29 "/Users/juansebastiangambajacomussi/Documents/programacion/misiontic-retos/ciclo-3/proyecto/SistemaBibliotecario/SistemaBibliotecario.App.Presentacion/Pages/Usuarios/Delete.cshtml"
                               Write(Model.usuario.usu_direccion);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>    \r\n    \r\n    <br>\r\n    <button type=\"submit\" class=\"btn btn-danger\">Eliminar</button>    \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<br>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18e3f7cf8fff2433ca7cbe0d0ebefe57a663863112043", async() => {
                WriteLiteral("Volver a la Lista de usuarios... ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SistemaBibliotecario.App.Presentacion.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SistemaBibliotecario.App.Presentacion.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SistemaBibliotecario.App.Presentacion.DeleteModel>)PageContext?.ViewData;
        public SistemaBibliotecario.App.Presentacion.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
