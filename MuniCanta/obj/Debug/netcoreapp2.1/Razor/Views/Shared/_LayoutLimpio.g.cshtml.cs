#pragma checksum "C:\Users\Alonso\source\repos\MuniCanta\MuniCanta\Views\Shared\_LayoutLimpio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2914b8f4abe8030856ce8ec2c73e537690b300c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LayoutLimpio), @"mvc.1.0.view", @"/Views/Shared/_LayoutLimpio.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_LayoutLimpio.cshtml", typeof(AspNetCore.Views_Shared__LayoutLimpio))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2914b8f4abe8030856ce8ec2c73e537690b300c6", @"/Views/Shared/_LayoutLimpio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"102514132f504df6af8995c827242e826986078a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LayoutLimpio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 2615, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66770db3d92e4bf78db2e66987cb4476", async() => {
                BeginContext(31, 121, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
                EndContext();
                BeginContext(153, 17, false);
#line 6 "C:\Users\Alonso\source\repos\MuniCanta\MuniCanta\Views\Shared\_LayoutLimpio.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(170, 2463, true);
                WriteLiteral(@" - MuniCanta</title>
    <!-- Compiled and minified CSS -->
    <link href=""https://fonts.googleapis.com/icon?family=Material+Icons"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/css/materialize.min.css"">
    <style>
        /* label color */
       .input-field label {
         color: #000;
       }
       .cabeza input {
         color: #FFFFFF !important;
         font-weight: bold;
       }
       .cabeza label {
         color: #FFFFFF !important;
       }
       /* label focus color */
       .input-field input[type=text]:focus + label {
         color: #A74186 !important;
       }
       /* label focus color */
       .input-field input[type=datetime]:focus + label {
         color: #A74186 !important;
       }
       .input-field input[type=date]:focus + label {
         color: #A74186 !important;
       }
       .input-field input[type=datetime-local]:focus + label {
         color: #A74186 !important;
       }");
                WriteLiteral(@"
       /* label underline focus color */
       .input-field input[type=text]:focus {
         border-bottom: 1px solid #A74186 !important;
         box-shadow: 0 1px 0 0 #A74186 !important;
       }
       .cabeza input[type=text]:focus {
         border-bottom: 1px solid #FFFFFF !important;
         box-shadow: 0 1px 0 0 #FFFFFF !important;
       }
       .input-field input[type=date]:focus {
         border-bottom: 1px solid #A74186 !important;
         box-shadow: 0 1px 0 0 #A74186 !important;
       }
       .input-field input[type=datetime]:focus {
         border-bottom: 1px solid #A74186 !important;
         box-shadow: 0 1px 0 0 #A74186 !important;
       }
       .input-field input[type=datetime-local]:focus {
         border-bottom: 1px solid #A74186 !important;
         box-shadow: 0 1px 0 0 #A74186 !important;
       }
       /* valid color */
       .input-field input[type=text].valid {
         border-bottom: 1px solid #A74186 !important;
         box-shadow: 0 1px 0 ");
                WriteLiteral(@"0 #A74186 !important;
       }
       /* invalid color */
       .input-field input[type=text].invalid {
         border-bottom: 1px solid #A74186 !important;
         box-shadow: 0 1px 0 0 #A74186 !important;
       }
       /* icon prefix focus color */
       .input-field .prefix.active {
         color: #A74186 !important;
       }
       span{
           font-size:17px;
       }
    </style>
");
                EndContext();
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
            EndContext();
            BeginContext(2640, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2642, 536, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "360bca8981d54ecea12e94c67bdc7e8f", async() => {
                BeginContext(2648, 54, true);
                WriteLiteral("\r\n\r\n    <div class=\"container body-content\">\r\n        ");
                EndContext();
                BeginContext(2703, 12, false);
#line 79 "C:\Users\Alonso\source\repos\MuniCanta\MuniCanta\Views\Shared\_LayoutLimpio.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(2715, 412, true);
                WriteLiteral(@"
    </div>

    <!-- Compiled and minified JavaScript -->
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/js/materialize.min.js""></script>
    <script>
        document.addEventListener('DOMContentLoaded', function() {
            var elems = document.querySelectorAll('.tooltipped');
            var instances = M.Tooltip.init(elems, null);
          });
    </script>
    ");
                EndContext();
                BeginContext(3128, 41, false);
#line 90 "C:\Users\Alonso\source\repos\MuniCanta\MuniCanta\Views\Shared\_LayoutLimpio.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(3169, 2, true);
                WriteLiteral("\r\n");
                EndContext();
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
            EndContext();
            BeginContext(3178, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
