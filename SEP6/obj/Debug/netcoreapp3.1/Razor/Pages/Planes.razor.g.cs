#pragma checksum "D:\Code\SEP6_CloudApplication\SEP6\Pages\Planes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4cc621ee31f1218d331c216fa999b22f7f605e0"
// <auto-generated/>
#pragma warning disable 1591
namespace SEP6.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Code\SEP6_CloudApplication\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Code\SEP6_CloudApplication\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Code\SEP6_CloudApplication\SEP6\_Imports.razor"
using SEP6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Code\SEP6_CloudApplication\SEP6\_Imports.razor"
using SEP6.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Code\SEP6_CloudApplication\SEP6\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Code\SEP6_CloudApplication\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Code\SEP6_CloudApplication\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Code\SEP6_CloudApplication\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Code\SEP6_CloudApplication\SEP6\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Code\SEP6_CloudApplication\SEP6\_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Code\SEP6_CloudApplication\SEP6\_Imports.razor"
using ChartJs.Blazor.ChartJS.Common.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Planes.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Planes.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Planes.razor"
using ChartJs.Blazor.ChartJS.BarChart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Planes.razor"
using ChartJs.Blazor.ChartJS.BarChart.Axes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Planes.razor"
using ChartJs.Blazor.ChartJS.Common.Axes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Planes.razor"
using ChartJs.Blazor.ChartJS.Common.Axes.Ticks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Planes.razor"
using ChartJs.Blazor.ChartJS.Common.Properties;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Planes.razor"
using ChartJs.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Planes.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Planes.razor"
using ChartJs.Blazor.ChartJS.Common.Wrappers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/planes")]
    public partial class Planes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Number of Flights per Manufacturer</h3>\r\n<br>\r\n");
#nullable restore
#line 19 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Planes.razor"
 if (data == null && data1 == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p>Loading...</p>\r\n");
#nullable restore
#line 22 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Planes.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenComponent<ChartJs.Blazor.Charts.ChartJsBarChart>(4);
            __builder.AddAttribute(5, "Config", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ChartJs.Blazor.ChartJS.BarChart.BarConfig>(
#nullable restore
#line 25 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Planes.razor"
                                                 _config

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 25 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Planes.razor"
                                                                 600

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 25 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Planes.razor"
                                                                              300

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(8, (__value) => {
#nullable restore
#line 25 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Planes.razor"
                           _barChartJs = (ChartJs.Blazor.Charts.ChartJsBarChart)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.AddMarkupContent(10, "    <br>\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(11, "<h3>Manufacturers that have more than 200 planes.</h3>\r\n    ");
            __builder.OpenElement(12, "table");
            __builder.AddAttribute(13, "class", "table table-striped");
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.AddMarkupContent(15, "<thead>\r\n            <tr>\r\n                <th>Manufacturer</th>\r\n                <th>Number Of Operating Planes</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(16, "tbody");
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 38 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Planes.razor"
             foreach (var flight in data)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "                ");
            __builder.OpenElement(19, "tr");
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 41 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Planes.razor"
                         flight.Manufacturer

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 42 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Planes.razor"
                         flight.Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
#nullable restore
#line 44 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Planes.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(28, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    <br>\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(31, "<h3>The number of planes of each Airbus Model</h3>\r\n    ");
            __builder.OpenElement(32, "table");
            __builder.AddAttribute(33, "class", "table table-striped");
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.AddMarkupContent(35, "<thead>\r\n            <tr>\r\n                <th>Manufacturer</th>\r\n                <th>Number Of Operating Planes</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(36, "tbody");
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 58 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Planes.razor"
             foreach (var flight in data1)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "                ");
            __builder.OpenElement(39, "tr");
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, 
#nullable restore
#line 61 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Planes.razor"
                         flight.Manufacturer

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.OpenElement(44, "td");
            __builder.AddContent(45, 
#nullable restore
#line 62 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Planes.razor"
                         flight.Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n");
#nullable restore
#line 64 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Planes.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(48, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n    <br>\r\n    <br>\r\n");
#nullable restore
#line 69 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Planes.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Planes.razor"
       
    private List<FlightModel> data;
    private List<FlightModel> data1;
    private List<FlightModel> data2;
    private BarConfig _config;
    private string[] companies;
    private List<double> count;

    private BarDataset<DoubleWrapper> _barDataSet;
    private ChartJsBarChart _barChartJs;

    protected async override Task OnInitializedAsync()
    {
        data = await model.ManufacturersWithShitLoadOfPlanesAsync();
        data1 = await model.NoOfAirbusesPerModelAsync();
        data2 = await model.FlightsPerBigManufacturerAsync();

        _config = new BarConfig
        {
            Options = new BarOptions
            {
                Title = new OptionsTitle
                {
                    Display = true,
                    Text = "Number Of Flights Which The Top Manufacturers Are Responsible For"
                },
                Scales = new BarScales
                {
                    XAxes = new List<CartesianAxis>
{
                        new BarCategoryAxis
                        {
                            BarThickness = BarThickness.Flex
                        }
                    },
                    YAxes = new List<CartesianAxis>
{
                        new BarLinearCartesianAxis
                        {
                            Ticks = new LinearCartesianTicks
                            {
                                BeginAtZero = true
                            }
                        }
                    }
                }
            }
        };

        if (data2 != null)
        {


            string[] names = model.ManuNames();
            _config.Data.Labels.AddRange(names);
            double[] flights = data2[0].ManufacturerFlights(data2);


            var barSet1 = new BarDataset<DoubleWrapper>
            {
                Label = "Total flights per manufacturer",
                BackgroundColor = "#1fd7da",
                BorderWidth = 1,
                HoverBackgroundColor = "#1fd7da",
                HoverBorderColor = "#1fd7da",
                HoverBorderWidth = 1,
                BorderColor = "#ffffff",
            };

            barSet1.AddRange(flights.Wrap());
            _config.Data.Datasets.Add(barSet1);
        }
        this.StateHasChanged();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModel model { get; set; }
    }
}
#pragma warning restore 1591
