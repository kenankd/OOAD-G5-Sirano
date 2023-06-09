#pragma checksum "C:\Users\29\Documents\GitHub\OOAD-G5-Sirano\Sirano\Sirano\Views\Home\Map.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35cd07215fa8cbd1a7d693b66f888103de2e30d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Map), @"mvc.1.0.view", @"/Views/Home/Map.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35cd07215fa8cbd1a7d693b66f888103de2e30d4", @"/Views/Home/Map.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9378229da277ad5011ea4ab2220744d8c7236276", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Map : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\29\Documents\GitHub\OOAD-G5-Sirano\Sirano\Sirano\Views\Home\Map.cshtml"
  
    ViewData["Title"] = "Map";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<style>
    .dugmic {
        background-color: rgba(3,3,3,0);
        border: none;
        border-radius: 65px;
        padding: 0px 0px;
        text-align: center;
        font-weight: 100;
        color: rgba(3,3,3,0.59);
        font-family: Playfair Display;
        display: inline-block;
        font-size: 65px;
        cursor: pointer;
        white-space: nowrap;
        flex-grow: 1;
    }
</style>
    <div class=""container"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35cd07215fa8cbd1a7d693b66f888103de2e30d44263", async() => {
                WriteLiteral("\r\n            <button type=\"submit\" class=\"dugmic\">SIRANO</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>

    <div style=""margin-top: 2%; margin-bottom: 2% "">
        <div id=""myMap""
             style=""position:relative;width:1100px;height:550px; margin-left:20px;""></div>
    </div>

<script type='text/javascript' src='https://www.bing.com/api/maps/mapcontrol?callback=GetMap' async defer></script>

<script type='text/javascript'>
    function GetMap() {
        var map = new Microsoft.Maps.Map('#myMap', {
            credentials: 'Akb5vJt0fBD0ePX_Np5KBiDTX1693LC-SnUU5C0LiYjbulZGgKd29X5BbiFqY5nG',
            center: new Microsoft.Maps.Location(43.8563, 18.4131),
            mapTypeId: Microsoft.Maps.MapTypeId.aerial,
            zoom: 10
        });

        infobox = new Microsoft.Maps.Infobox(map.getCenter(), {
            visible: false
        });

        infobox.setMap(map);

        

        var sirano = new Microsoft.Maps.Location(43.85845337613034, 18.421765596913584);
        var scc = new Microsoft.Maps.Location(43.85550024503063, 18.408050523893746);
       ");
            WriteLiteral(@" var hrasnica = new Microsoft.Maps.Location(43.79743985518899, 18.311820758044114);
        var bojnik = new Microsoft.Maps.Location(43.88012387910122, 18.26929604396326);
        var ciglane = new Microsoft.Maps.Location(43.867333069591034, 18.41072743924081);
        var otoka = new Microsoft.Maps.Location(43.8482660806474, 18.367555686448537);
        var aneks = new Microsoft.Maps.Location(43.842143726204725, 18.37093519864013);
        var bihac = new Microsoft.Maps.Location(44.81137335998627, 15.868521493673024);
        var bl = new Microsoft.Maps.Location(44.77100740981597, 17.194834070104875);
        var zenica = new Microsoft.Maps.Location(44.20332688346574, 17.911331262301506);
        var mostar = new Microsoft.Maps.Location(43.343186327955266, 17.80853946051036);
        var zavidovici = new Microsoft.Maps.Location(44.443770489731435, 18.145092171807743);

        var pin1 = new Microsoft.Maps.Pushpin(sirano);
        var pin2 = new Microsoft.Maps.Pushpin(scc);
        var pin3 = ne");
            WriteLiteral(@"w Microsoft.Maps.Pushpin(hrasnica);
        var pin4 = new Microsoft.Maps.Pushpin(bojnik);
        var pin5 = new Microsoft.Maps.Pushpin(ciglane);
        var pin6 = new Microsoft.Maps.Pushpin(otoka);
        var pin7 = new Microsoft.Maps.Pushpin(aneks);
        var pin8 = new Microsoft.Maps.Pushpin(bihac);
        var pin9 = new Microsoft.Maps.Pushpin(bl);
        var pin10 = new Microsoft.Maps.Pushpin(zenica);
        var pin11 = new Microsoft.Maps.Pushpin(mostar);
        var pin12 = new Microsoft.Maps.Pushpin(zavidovici);

        pin1.metadata = {
            title: 'Boutique Sirano',
            description: 'Stari Grad, Sarajevo'
        };

        pin2.metadata = {
            title: 'Boutique Sirano',
            description: 'Sarajevo City Centar'
        };

        pin3.metadata = {
            title: 'Boutique Sirano',
            description: 'Hrasnica, Sarajevo'
        };

        pin4.metadata = {
            title: 'Boutique Sirano',
            description: 'Boj");
            WriteLiteral(@"nik, Sarajevo'
        };

        pin5.metadata = {
            title: 'Boutique Sirano',
            description: 'Ciglane, Sarajevo'
        };

        pin6.metadata = {
            title: 'Boutique Sirano',
            description: 'Otoka, Sarajevo'
        };

        pin7.metadata = {
            title: 'Boutique Sirano',
            description: 'Aneks, Sarajevo'
        };

        pin8.metadata = {
            title: 'Boutique Sirano',
            description: 'Bihać, Bosnia and Herzegovina'
        };

        pin9.metadata = {
            title: 'Boutique Sirano',
            description: 'Banja Luka, Bosnia and Herzegovina'
        };

        pin10.metadata = {
            title: 'Boutique Sirano',
            description: 'Zenica, Bosnia and Herzegovina'
        };

        pin11.metadata = {
            title: 'Boutique Sirano',
            description: 'Mostar, Bosnia and Herzegovina'
        };

        pin12.metadata = {
            title: 'Boutique Si");
            WriteLiteral(@"rano',
            description: 'Zavidovići, Bosnia and Herzegovina'
        };



        Microsoft.Maps.Events.addHandler(pin1, 'click', pushpinClicked);
        Microsoft.Maps.Events.addHandler(pin2, 'click', pushpinClicked);
        Microsoft.Maps.Events.addHandler(pin3, 'click', pushpinClicked);
        Microsoft.Maps.Events.addHandler(pin4, 'click', pushpinClicked);
        Microsoft.Maps.Events.addHandler(pin5, 'click', pushpinClicked);
        Microsoft.Maps.Events.addHandler(pin6, 'click', pushpinClicked);
        Microsoft.Maps.Events.addHandler(pin7, 'click', pushpinClicked);
        Microsoft.Maps.Events.addHandler(pin8, 'click', pushpinClicked);
        Microsoft.Maps.Events.addHandler(pin9, 'click', pushpinClicked);
        Microsoft.Maps.Events.addHandler(pin10, 'click', pushpinClicked);
        Microsoft.Maps.Events.addHandler(pin11, 'click', pushpinClicked);
        Microsoft.Maps.Events.addHandler(pin12, 'click', pushpinClicked);

        map.entities.push(pin1);
        ");
            WriteLiteral(@"map.entities.push(pin2);
        map.entities.push(pin3);
        map.entities.push(pin4);
        map.entities.push(pin5);
        map.entities.push(pin6);
        map.entities.push(pin7);
        map.entities.push(pin8);
        map.entities.push(pin9);
        map.entities.push(pin10);
        map.entities.push(pin11);
        map.entities.push(pin12);

    }

    function pushpinClicked(e) {
        if (e.target.metadata) {
            infobox.setOptions({
                location: e.target.getLocation(),
                title: e.target.metadata.title,
                description: e.target.metadata.description,
                visible: true
            });
        }
    }
</script>");
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
