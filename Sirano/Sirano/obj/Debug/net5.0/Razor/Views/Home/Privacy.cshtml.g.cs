#pragma checksum "C:\Users\29\Documents\GitHub\OOAD-G5-Sirano\Sirano\Sirano\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7c5ee95f51d0c240ad480eeb241ac991bbef59f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
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
#line 1 "C:\Users\29\Documents\GitHub\OOAD-G5-Sirano\Sirano\Sirano\Views\_ViewImports.cshtml"
using Sirano;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\29\Documents\GitHub\OOAD-G5-Sirano\Sirano\Sirano\Views\_ViewImports.cshtml"
using Sirano.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7c5ee95f51d0c240ad480eeb241ac991bbef59f", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9378229da277ad5011ea4ab2220744d8c7236276", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Header", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\29\Documents\GitHub\OOAD-G5-Sirano\Sirano\Sirano\Views\Home\Privacy.cshtml"
  
    ViewData["Title"] = "Sirano";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    .container {\r\n        display: flex;\r\n    }\r\n</style>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e7c5ee95f51d0c240ad480eeb241ac991bbef59f3704", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <div class=\"clickable-div\"");
            BeginWriteAttribute("onclick", " onclick=\"", 199, "\"", 278, 3);
            WriteAttributeValue("", 209, "location.href=\'", 209, 15, true);
#nullable restore
#line 14 "C:\Users\29\Documents\GitHub\OOAD-G5-Sirano\Sirano\Sirano\Views\Home\Privacy.cshtml"
WriteAttributeValue("", 224, Url.Action("Index", "Product",new { isMen = false }), 224, 53, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 277, "\'", 277, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" style=""margin-left:100px; margin-right:100px; margin-top:80px; cursor: pointer;"">
        <img src=""/images/woman.png"" width=""400"" height=""400"">
        <p style=""font-family: Playfair Display; font-size: 20px; margin-left:130px; margin-top:10px"">WOMEN'S WEAR</p>
    </div>
    <div class=""clickable-div""");
            BeginWriteAttribute("onclick", " onclick=\"", 589, "\"", 667, 3);
            WriteAttributeValue("", 599, "location.href=\'", 599, 15, true);
#nullable restore
#line 18 "C:\Users\29\Documents\GitHub\OOAD-G5-Sirano\Sirano\Sirano\Views\Home\Privacy.cshtml"
WriteAttributeValue("", 614, Url.Action("Index", "Product",new { isMen = true }), 614, 52, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 666, "\'", 666, 1, true);
            EndWriteAttribute();
            WriteLiteral(" style=\" margin-top:80px; cursor: pointer;\">\r\n        <img src=\"/images/man.png\" width=\"400\" height=\"400\">\r\n        <p style=\"font-family: Playfair Display; font-size: 20px; margin-left:130px; margin-top:10px\">MEN\'S WEAR</p>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
