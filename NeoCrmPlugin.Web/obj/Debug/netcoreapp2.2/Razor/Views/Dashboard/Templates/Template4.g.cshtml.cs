#pragma checksum "E:\Product Development\NeoCrmPlugin\NeoCrmPlugin\NeoCrmPlugin.Web\Views\Dashboard\Templates\Template4.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4102193a1fc563908ae7cd74f2eb93cc2bcb672b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Templates_Template4), @"mvc.1.0.view", @"/Views/Dashboard/Templates/Template4.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dashboard/Templates/Template4.cshtml", typeof(AspNetCore.Views_Dashboard_Templates_Template4))]
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
#line 1 "E:\Product Development\NeoCrmPlugin\NeoCrmPlugin\NeoCrmPlugin.Web\Views\_ViewImports.cshtml"
using NeoCrmPlugin.Web;

#line default
#line hidden
#line 2 "E:\Product Development\NeoCrmPlugin\NeoCrmPlugin\NeoCrmPlugin.Web\Views\_ViewImports.cshtml"
using NeoCrmPlugin.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4102193a1fc563908ae7cd74f2eb93cc2bcb672b", @"/Views/Dashboard/Templates/Template4.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35dec933eabd242049495de997a9c9cb4b22acff", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Templates_Template4 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\Product Development\NeoCrmPlugin\NeoCrmPlugin\NeoCrmPlugin.Web\Views\Dashboard\Templates\Template4.cshtml"
  
    ViewBag.E1Height = "220px";
    ViewBag.DHeight = "250px";

#line default
#line hidden
            BeginContext(72, 834, true);
            WriteLiteral(@"<style>
    .col-lg-1, .col-lg-10, .col-lg-11, .col-lg-12, .col-lg-2, .col-lg-3, .col-lg-4, .col-lg-5, .col-lg-6, .col-lg-7, .col-lg-8, .col-lg-9, .col-md-1, .col-md-10, .col-md-11, .col-md-12, .col-md-2, .col-md-3, .col-md-4, .col-md-5, .col-md-6, .col-md-7, .col-md-8, .col-md-9, .col-sm-1, .col-sm-10, .col-sm-11, .col-sm-12, .col-sm-2, .col-sm-3, .col-sm-4, .col-sm-5, .col-sm-6, .col-sm-7, .col-sm-8, .col-sm-9, .col-xs-1, .col-xs-10, .col-xs-11, .col-xs-12, .col-xs-2, .col-xs-3, .col-xs-4, .col-xs-5, .col-xs-6, .col-xs-7, .col-xs-8, .col-xs-9 {
        padding-left: 20px;
        padding-right: 0px;
    }
    .white-box {
        padding: 20px;
        margin-bottom: 20px;
    }
</style>

<div class=""row m-t-20"" >
    <div class=""col-lg-6 place"" id=""1"">
        <div class=""white-box"" style=""height:300px;"">
");
            EndContext();
#line 19 "E:\Product Development\NeoCrmPlugin\NeoCrmPlugin\NeoCrmPlugin.Web\Views\Dashboard\Templates\Template4.cshtml"
               string t1 = ViewData["Element1"].ToString(); Html.RenderPartial(t1); 

#line default
#line hidden
            BeginContext(993, 131, true);
            WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\"col-lg-6 place p-r-10\" id=\"2\">\r\n        <div class=\"white-box\" style=\"height:300px;\">\r\n");
            EndContext();
#line 24 "E:\Product Development\NeoCrmPlugin\NeoCrmPlugin\NeoCrmPlugin.Web\Views\Dashboard\Templates\Template4.cshtml"
               string t2 = ViewData["Element2"].ToString(); Html.RenderPartial(t2); 

#line default
#line hidden
            BeginContext(1211, 132, true);
            WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\"col-lg-12 place p-r-10\" id=\"3\">\r\n        <div class=\"white-box\" style=\"height:300px;\">\r\n");
            EndContext();
#line 29 "E:\Product Development\NeoCrmPlugin\NeoCrmPlugin\NeoCrmPlugin.Web\Views\Dashboard\Templates\Template4.cshtml"
               string t3 = ViewData["Element3"].ToString(); Html.RenderPartial(t3); 

#line default
#line hidden
            BeginContext(1430, 238, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n<script>\r\n\r\n    $(\'.place\').click(function(event) {\r\n        var place = $(this).attr(\'id\');\r\n        localStorage.setItem(\"placement\", place);\r\n        window.location = \"/Dashboard/ElementList/\"+\'");
            EndContext();
            BeginContext(1669, 23, false);
#line 40 "E:\Product Development\NeoCrmPlugin\NeoCrmPlugin\NeoCrmPlugin.Web\Views\Dashboard\Templates\Template4.cshtml"
                                                Write(ViewData["dashboardId"]);

#line default
#line hidden
            EndContext();
            BeginContext(1692, 702, true);
            WriteLiteral(@"';
    });

    function EnableDisableEditing() {

        if($(""#editing-button"").text() == ""Enable Editing""){
            localStorage.setItem(""dashboard-editing"", 1);
            $(""#editing-button"").text(""Done Editing"");
            $(""#editing-message"").text(""* Dashboard Editing is Enabled, Click on Element to Update."");
        }
        else{
            localStorage.setItem(""dashboard-editing"", 0);
            $(""#editing-button"").text(""Enable Editing"");
            $(""#editing-message"").text(""* Enable Editing to Update Dashboard Elements"");
        }
    }

        function DeleteDashboard(){

        $.ajax(
        {
            type: ""POST"",
            url: '");
            EndContext();
            BeginContext(2395, 42, false);
#line 62 "E:\Product Development\NeoCrmPlugin\NeoCrmPlugin\NeoCrmPlugin.Web\Views\Dashboard\Templates\Template4.cshtml"
             Write(Url.Action("DeleteDashboard", "Dashboard"));

#line default
#line hidden
            EndContext();
            BeginContext(2437, 55, true);
            WriteLiteral("\',\r\n            data: {\r\n                dashboardId: \'");
            EndContext();
            BeginContext(2493, 23, false);
#line 64 "E:\Product Development\NeoCrmPlugin\NeoCrmPlugin\NeoCrmPlugin.Web\Views\Dashboard\Templates\Template4.cshtml"
                         Write(ViewData["dashboardId"]);

#line default
#line hidden
            EndContext();
            BeginContext(2516, 522, true);
            WriteLiteral(@"'
            },
            error: function (result) {
                alert(result);
            },
            success: function (result) {

                if (result.status == true) {
                    
                    swal( ""Done!"", result.message, ""success"");
                    window.location = result.default_dashboard;
                }
                else {
                    swal(""Problem!"", result.message, ""warning"");
                }
            }
        });
    }

</script>");
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
