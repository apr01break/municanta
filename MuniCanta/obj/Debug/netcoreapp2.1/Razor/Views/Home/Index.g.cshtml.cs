#pragma checksum "C:\Users\Alonso\source\repos\MuniCanta\MuniCanta\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d52c592534b3c669755c6554643773e42b166b30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Alonso\source\repos\MuniCanta\MuniCanta\Views\_ViewImports.cshtml"
using MuniCanta;

#line default
#line hidden
#line 2 "C:\Users\Alonso\source\repos\MuniCanta\MuniCanta\Views\_ViewImports.cshtml"
using MuniCanta.Models;

#line default
#line hidden
#line 3 "C:\Users\Alonso\source\repos\MuniCanta\MuniCanta\Views\_ViewImports.cshtml"
using MuniCanta.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d52c592534b3c669755c6554643773e42b166b30", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"102514132f504df6af8995c827242e826986078a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Alonso\source\repos\MuniCanta\MuniCanta\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "_LayoutPrincipal";

#line default
#line hidden
            BeginContext(79, 1066, true);
            WriteLiteral(@"<br />
<h3 class=""full-width"">
    <div class=""wrap"">REGISTRO DE LICENCIA</div>
</h3>
<hr />
<div class="" bg-info"">

</div>
<h5>PERSONA</h5>
<div class=""form-row"">
    <div class=""col-md-6 mb-3"">
        <label for=""validationServer01"">Nombre de persona</label>
        <input type=""text"" class=""form-control"" id=""validationServer01"" placeholder="""" readonly>
    </div>
    <div class=""col-md-2 mb-3"">
        <label for=""validationServer02"">Tipo de documento</label>
        <input type=""text"" class=""form-control"" id=""validationServer02"" placeholder="""" readonly>
    </div>
    <div class=""col-md-2 mb-3"">
        <label for=""validationServer02"">N° de documento</label>
        <input type=""text"" class=""form-control"" id=""validationServer02"" placeholder="""" readonly>
    </div>
    <div class=""col-md-2 mb-3"">
        <label for=""validationServer02"">&nbsp;</label>
        <button class=""btn btn-success form-control"" type=""submit"">Buscar &nbsp;<i class=""fa fa-search""></i></button>
    </div>
</");
            WriteLiteral("div>\r\n<hr />\r\n<h5>DATOS DE LICENCIA</h5>\r\n");
            EndContext();
            BeginContext(1145, 1137, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbe3bae5c9fc47f99c57b05214591ef6", async() => {
                BeginContext(1151, 1124, true);
                WriteLiteral(@"
    <div class=""form-row"">
        <div class=""col-md-6 mb-3"">
            <label for=""validationServer01"">Código Licencia</label>
            <input type=""text"" class=""form-control"" id=""validationServer01"" placeholder=""Ingrese el código de licencia"" required>
        </div>
        <div class=""col-md-6 mb-3"">
            <label for=""validationServer02"">Fecha de renovación</label>
            <input type=""text"" class=""form-control"" id=""validationServer02"" placeholder=""Ingrese la fecha de renovación"" required>
        </div>
    </div>
    <div class=""form-row"">
        <div class=""col-md-6 mb-3"">
            <label for=""validationServer03"">Fecha de inicio</label>
            <input type=""date"" class=""form-control"" id=""validationServer03"" required>
        </div>
        <div class=""col-md-6 mb-3"">
            <label for=""validationServer03"">Fecha de inicio</label>
            <input type=""date"" class=""form-control"" id=""validationServer03"" required>
        </div>
    </div>
    <hr />
 ");
                WriteLiteral("   <button class=\"btn btn-primary\" type=\"submit\">GUARDAR &nbsp;<i class=\"fa fa-save\"></i></button>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
