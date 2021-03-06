#pragma checksum "E:\Product Development\NeoCrmPlugin\NeoCrmPlugin\NeoCrmPlugin.Web\Views\Dashboard\Elements\Element2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5021f6418e592361cad8bdb3cbfde158cd314460"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Elements_Element2), @"mvc.1.0.view", @"/Views/Dashboard/Elements/Element2.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dashboard/Elements/Element2.cshtml", typeof(AspNetCore.Views_Dashboard_Elements_Element2))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5021f6418e592361cad8bdb3cbfde158cd314460", @"/Views/Dashboard/Elements/Element2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35dec933eabd242049495de997a9c9cb4b22acff", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Elements_Element2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 5396, true);
            WriteLiteral(@"
<div class=""box box-success"">
    <div class=""box-header with-border"">
        <h3 class=""box-title"">Top Ten Product</h3>

        <div class=""box-tools pull-right"">
            <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"">
                <i class=""fa fa-minus""></i>
            </button>
            <button type=""button"" class=""btn btn-box-tool"" data-widget=""remove""><i class=""fa fa-times""></i></button>
        </div>
    </div>
    <!-- /.box-header -->
    <div class=""box-body no-padding"">
        <!--Div that will hold the pie chart-->
        <div id=""chart_div""></div>

        <script type=""text/javascript"">

            // Load the Visualization API and the corechart package.
            //google.charts.load('current', { 'packages': ['corechart'] });

            //// Set a callback to run when the Google Visualization API is loaded.
            //google.charts.setOnLoadCallback(drawChart);

            //// Callback that creates and populates a data ta");
            WriteLiteral(@"ble,
            //// instantiates the pie chart, passes in the data and
            //// draws it.
            //function drawChart() {

            //    // Create the data table.
            //    var data = new google.visualization.DataTable();
            //    data.addColumn('string', 'Topping');
            //    data.addColumn('number', 'Slices');
            //    data.addRows([
            //        ['Mushrooms', 3],
            //        ['Onions', 1],
            //        ['Olives', 1],
            //        ['Zucchini', 1],
            //        ['Pepperoni', 2]
            //    ]);

            //    // Set chart options
            //    var options = {
            //        'title': 'How Much Pizza I Ate Last Night',
            //       // 'width': 400,
            //       // 'height': 300
            //    };

            //    // Instantiate and draw our chart, passing in some options.
            //    var chart = new google.visualization.BarChart(document.getEl");
            WriteLiteral(@"ementById('chart_div'));
            //    chart.draw(data, options);
            //}
            google.charts.load('current', { 'packages': ['corechart'] });

            // Set a callback to run when the Google Visualization API is loaded.  
            $(document).ready(function () {
                $.ajax(
                    {
                        type: 'POST',
                        dataType: 'JSON',
                        url: '/api/Dashboard/Top10Product',
                        success:
                        function (response) {
                            // Set chart options  
                            debugger;
                            var options =
                                {
                                    sliceVisibilityThreshold: 0,
                                    legend: { position: ""top"", alignment: ""end"" },
                                    chartArea: { top: 50, height: ""90%"" },
                                    hAxis:
                 ");
            WriteLiteral(@"                   {
                                        slantedText: true,
                                        slantedTextAngle: 18
                                    },
                                    //bar: { groupWidth: ""50%"" },
                                };

                            // Draw.  
                            drawGraph(response.data, options, 'chart_div');
                        }
                    });
            });

            // Callback that creates and populates a data table,  
            // instantiates the pie chart, passes in the data and  
            // draws it.  
            function drawGraph(dataValues, options, elementId) {
                // Initialization.  
                var data = new google.visualization.DataTable();

                // Setting.  
                data.addColumn('string', 'Product Name');
                data.addColumn('number', 'Quantity');
                data.addColumn('number', 'Amount');

          ");
            WriteLiteral(@"      // Processing.  
                for (var i = 0; i < dataValues.length; i++) {
                    // Setting.  
                    data.addRow([dataValues[i].customerName, dataValues[i].leadQuantity, dataValues[i].leadValue]);
                }

                // Setting label.  
                var view = new google.visualization.DataView(data);
                //view.setColumns([0, 1,
                //    {
                //        calc: ""stringify"",
                //        sourceColumn: 1,
                //        type: ""string"",
                //        role: ""annotation""
                //    },
                //    2,
                //    {
                //        calc: ""stringify"",
                //        sourceColumn: 2,
                //        type: ""string"",
                //        role: ""annotation""
                //    }
                //]);

                // Instantiate and draw our chart, passing in some options.  
                var chart =");
            WriteLiteral(@" new google.visualization.BarChart(document.getElementById(elementId));

                // Draw chart.  
                chart.draw(view, options);
            } 
        </script>

        <script>

        </script>
        </div>
    </div>





       
");
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
