#pragma checksum "C:\Users\anita\source\repos\T1-Diars\T1-Diars\Views\Persona\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9b34f6f51133d0f3c83645f9d6c7ffbfc4a38d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Persona_Create), @"mvc.1.0.view", @"/Views/Persona/Create.cshtml")]
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
#line 1 "C:\Users\anita\source\repos\T1-Diars\T1-Diars\Views\_ViewImports.cshtml"
using T1_Diars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\anita\source\repos\T1-Diars\T1-Diars\Views\_ViewImports.cshtml"
using T1_Diars.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9b34f6f51133d0f3c83645f9d6c7ffbfc4a38d0", @"/Views/Persona/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c42e4a42ad06899ad7618791232a2a77dda01ce2", @"/Views/_ViewImports.cshtml")]
    public class Views_Persona_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Femenino", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Masculino", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/persona/create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\anita\source\repos\T1-Diars\T1-Diars\Views\Persona\Create.cshtml"
  
    var persona = (Persona)Model;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Crear Cuenta</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9b34f6f51133d0f3c83645f9d6c7ffbfc4a38d04805", async() => {
                WriteLiteral("\r\n    Nombre <input required name=\"Nombre\" />\r\n    ");
#nullable restore
#line 9 "C:\Users\anita\source\repos\T1-Diars\T1-Diars\Views\Persona\Create.cshtml"
Write(Html.ValidationMessage("Nombre"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    Apellido <input required name=\"Apellido\" />\r\n    ");
#nullable restore
#line 12 "C:\Users\anita\source\repos\T1-Diars\T1-Diars\Views\Persona\Create.cshtml"
Write(Html.ValidationMessage("Apellido"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    FNacimiento <input required name=\"FNacimiento\" />\r\n    ");
#nullable restore
#line 15 "C:\Users\anita\source\repos\T1-Diars\T1-Diars\Views\Persona\Create.cshtml"
Write(Html.ValidationMessage("FNacimiento"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    DNI <input required name=\"DNI\" />\r\n    ");
#nullable restore
#line 18 "C:\Users\anita\source\repos\T1-Diars\T1-Diars\Views\Persona\Create.cshtml"
Write(Html.ValidationMessage("DNI"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    Genero <select name=\"Genero\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9b34f6f51133d0f3c83645f9d6c7ffbfc4a38d06293", async() => {
                    WriteLiteral("Femenino");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9b34f6f51133d0f3c83645f9d6c7ffbfc4a38d07526", async() => {
                    WriteLiteral("Masculino");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </select>\r\n\r\n    Ciudad <input required name=\"Ciudad\" />\r\n    ");
#nullable restore
#line 26 "C:\Users\anita\source\repos\T1-Diars\T1-Diars\Views\Persona\Create.cshtml"
Write(Html.ValidationMessage("Ciudad"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    Direccion <input required name=\"Direccion\" />\r\n    ");
#nullable restore
#line 29 "C:\Users\anita\source\repos\T1-Diars\T1-Diars\Views\Persona\Create.cshtml"
Write(Html.ValidationMessage("Direccion"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    Correo <input required name=\"Correo\" />\r\n    ");
#nullable restore
#line 32 "C:\Users\anita\source\repos\T1-Diars\T1-Diars\Views\Persona\Create.cshtml"
Write(Html.ValidationMessage("Correo"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    Username <input required name=\"username\" />\r\n    ");
#nullable restore
#line 35 "C:\Users\anita\source\repos\T1-Diars\T1-Diars\Views\Persona\Create.cshtml"
Write(Html.ValidationMessage("username"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    Password <input required name=\"Password\" />\r\n    ");
#nullable restore
#line 38 "C:\Users\anita\source\repos\T1-Diars\T1-Diars\Views\Persona\Create.cshtml"
Write(Html.ValidationMessage("Password"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <button>Guardar</button>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
