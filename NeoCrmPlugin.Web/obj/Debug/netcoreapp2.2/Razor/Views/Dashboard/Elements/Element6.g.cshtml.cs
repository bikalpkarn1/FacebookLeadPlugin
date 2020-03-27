#pragma checksum "E:\Product Development\NeoCrmPlugin\NeoCrmPlugin\NeoCrmPlugin.Web\Views\Dashboard\Elements\Element6.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26a45d28cf99f265203cc3c663199534c9e103af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Elements_Element6), @"mvc.1.0.view", @"/Views/Dashboard/Elements/Element6.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dashboard/Elements/Element6.cshtml", typeof(AspNetCore.Views_Dashboard_Elements_Element6))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26a45d28cf99f265203cc3c663199534c9e103af", @"/Views/Dashboard/Elements/Element6.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35dec933eabd242049495de997a9c9cb4b22acff", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Elements_Element6 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4261, true);
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-md-3 col-sm-6 col-xs-12"">
        <div class=""info-box bg-aqua"">
            <span class=""info-box-icon""><i class=""fa fa-bookmark-o""></i></span>

            <div class=""info-box-content"">
                <span class=""info-box-text"">Total Customer</span>
                <span class=""info-box-number"" data-bind=""text: totalCustomer"">41,410</span>

                <div class=""progress"">
                    <div class=""progress-bar"" style=""width: 70%""></div>
                </div>
                <span class=""progress-description"">
                    10% Increase in 30 Days
                </span>
            </div>
            <!-- /.info-box-content -->
        </div>
        <!-- /.info-box -->
    </div>
    <!-- /.col -->
    <div class=""col-md-3 col-sm-6 col-xs-12"">
        <div class=""info-box bg-green"">
            <span class=""info-box-icon""><i class=""fa fa-thumbs-o-up""></i></span>

            <div class=""info-box-content"">
           ");
            WriteLiteral(@"     <span class=""info-box-text"">MTD Cusomter</span>
                <span class=""info-box-number"" data-bind=""text: ThisMonthCustomer"">41,410</span>

                <div class=""progress"">
                    <div class=""progress-bar"" style=""width: 70%""></div>
                </div>
                <span class=""progress-description"">
                    70% Increase in 30 Days
                </span>
            </div>
            <!-- /.info-box-content -->
        </div>
        <!-- /.info-box -->
    </div>
    <!-- /.col -->
    <div class=""col-md-3 col-sm-6 col-xs-12"">
        <div class=""info-box bg-yellow"">
            <span class=""info-box-icon""><i class=""fa fa-calendar""></i></span>

            <div class=""info-box-content"">
                <span class=""info-box-text"">Last Month</span>
                <span class=""info-box-number"" data-bind=""text: LastMonthCustomer"">41,410</span>

                <div class=""progress"">
                    <div class=""progress-bar"" style=""widt");
            WriteLiteral(@"h: 70%""></div>
                </div>
                <span class=""progress-description"">
                    70% Increase in 30 Days
                </span>
            </div>
            <!-- /.info-box-content -->
        </div>
        <!-- /.info-box -->
    </div>
    <!-- /.col -->
    <div class=""col-md-3 col-sm-6 col-xs-12"">
        <div class=""info-box bg-red"">
            <span class=""info-box-icon""><i class=""fa fa-comments-o""></i></span>

            <div class=""info-box-content"">
                <span class=""info-box-text"">Today Customers</span>
                <span class=""info-box-number"" data-bind=""text: TodayCustomer"">41,410</span>

                <div class=""progress"">
                    <div class=""progress-bar"" style=""width: 70%""></div>
                </div>
                <span class=""progress-description"">
                    70% Increase in 30 Days
                </span>
            </div>
            <!-- /.info-box-content -->
        </div>
        <!");
            WriteLiteral(@"-- /.info-box -->
    </div>
    <!-- /.col -->
</div>

<script>
    function vm() {
    var self = this;

    // Properties
    self.totalCustomer = ko.observable();
    self.ThisMonthCustomer = ko.observable();
    self.LastMonthCustomer = ko.observable();
    self.TodayCustomer = ko.observable();
    // consists of entryPostedDate, blogEntryLink, title, body
    var blogApi = ""/api/Dashboard/DashboardWidgets"";
 $.ajax(
        {
            type: ""get"",
            url: blogApi,
            
            error: function (result) {
                alert(""error"");
            },
            success: function (result) {
                debugger;
                self.totalCustomer(result.data.totalCustomer);
                self.ThisMonthCustomer(result.data.thisMonthCustomer);
                self.LastMonthCustomer(result.data.lastMonthCustomer);
                self.TodayCustomer(result.data.todayCustomer);
            }
        });

    // Load data
    //$.getJSON(blogApi)");
            WriteLiteral("\n    //    .success(function (data) {\r\n    //        debugger;\r\n    //        self.totalCustomer(data);\r\n    //    });\r\n    }\r\nko.applyBindings(new vm());\r\n</script>");
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
