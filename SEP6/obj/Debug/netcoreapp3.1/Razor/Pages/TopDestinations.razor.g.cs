#pragma checksum "D:\Code\SEP6_CloudApplication\SEP6\Pages\TopDestinations.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "548a4cd6ac0c77a7821de26815123c07c75f725a"
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
#line 3 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TopDestinations.razor"
using ChartJs.Blazor.ChartJS.BarChart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TopDestinations.razor"
using ChartJs.Blazor.ChartJS.Common.Axes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TopDestinations.razor"
using ChartJs.Blazor.ChartJS.Common.Axes.Ticks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TopDestinations.razor"
using ChartJs.Blazor.ChartJS.Common.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TopDestinations.razor"
using ChartJs.Blazor.ChartJS.Common.Properties;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TopDestinations.razor"
using ChartJs.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TopDestinations.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TopDestinations.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TopDestinations.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TopDestinations.razor"
using ChartJs.Blazor.ChartJS.Common.Wrappers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TopDestinations.razor"
using ChartJs.Blazor.ChartJS.BarChart.Axes;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/topDestinations")]
    public partial class TopDestinations : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 16 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TopDestinations.razor"
 if (data == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<p>Loading...</p>\r\n");
#nullable restore
#line 19 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TopDestinations.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.OpenComponent<ChartJs.Blazor.Charts.ChartJsBarChart>(3);
            __builder.AddAttribute(4, "Config", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ChartJs.Blazor.ChartJS.BarChart.BarConfig>(
#nullable restore
#line 23 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TopDestinations.razor"
                              _barChartConfig

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 24 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TopDestinations.razor"
                            600

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 25 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TopDestinations.razor"
                             300

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(7, (__value) => {
#nullable restore
#line 22 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TopDestinations.razor"
                           _barChart = (ChartJs.Blazor.Charts.ChartJsBarChart)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.AddContent(9, "    ");
            __builder.OpenElement(10, "table");
            __builder.AddAttribute(11, "class", "table table-striped");
            __builder.AddMarkupContent(12, "\r\n\r\n        ");
            __builder.AddMarkupContent(13, "<thead>\r\n\r\n            <tr>\r\n\r\n                <th>Origin</th>\r\n\r\n                <th>Destination</th>\r\n\r\n                <th>Mean Air Time</th>\r\n\r\n            </tr>\r\n\r\n        </thead>\r\n\r\n        ");
            __builder.OpenElement(14, "tbody");
            __builder.AddMarkupContent(15, "\r\n\r\n");
#nullable restore
#line 45 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TopDestinations.razor"
             foreach (var flight in data)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "                ");
            __builder.OpenElement(17, "tr");
            __builder.AddMarkupContent(18, "\r\n\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 49 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TopDestinations.razor"
                         flight.Origin

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 51 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TopDestinations.razor"
                         flight.Dest

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n                    ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 53 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TopDestinations.razor"
                         Math.Round(flight.Air_time,2)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(27, " Minutes");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 56 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TopDestinations.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
#nullable restore
#line 61 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TopDestinations.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TopDestinations.razor"
       

    private BarConfig _barChartConfig;
    private ChartJsBarChart _barChart;
    private BarDataset<DoubleWrapper> _barDataSet;
    private List<FlightModel> data;

    protected async override void OnInitialized()
    {
        data = await model.FlightsPerTopDestAsync();
        _barChartConfig = new BarConfig
        {
            Options = new BarOptions
            {
                Title = new OptionsTitle
                {
                    Display = true,
                    Text = "Total Flights Towards Top Ten Destinations"
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

        if (data != null)
        {
            string[] destinations = model.TopDestinationsNames();
            _barChartConfig.Data.Labels.AddRange(destinations);

            double[] countJFK = data[0].TotalFlights(data, "JFK");
            double[] countEWR = data[0].TotalFlights(data, "EWR");
            double[] countLGA = data[0].TotalFlights(data, "LGA");

            var barSet1 = new BarDataset<DoubleWrapper>
            {
                Label = "JFK",
                BackgroundColor = ColorUtil.RandomColorString(),
                BorderWidth = 1,
                HoverBackgroundColor = ColorUtil.ColorString(0, 0, 0, 0.1),
                HoverBorderColor = ColorUtil.RandomColorString(),
                HoverBorderWidth = 1,
                BorderColor = "#ffffff",
            };

            _barChartConfig.Data.Datasets.Add(barSet1);

            var barSet2 = new BarDataset<DoubleWrapper>
            {
                Label = "EWR",
                BackgroundColor = ColorUtil.RandomColorString(),
                BorderWidth = 1,
                HoverBackgroundColor = ColorUtil.ColorString(0, 0, 0, 0.1),
                HoverBorderColor = ColorUtil.RandomColorString(),
                HoverBorderWidth = 1,
                BorderColor = "#ffffff",
            };

            _barChartConfig.Data.Datasets.Add(barSet2);

            var barSet3 = new BarDataset<DoubleWrapper>
            {
                Label = "LGA",
                BackgroundColor = ColorUtil.RandomColorString(),
                BorderWidth = 1,
                HoverBackgroundColor = ColorUtil.ColorString(0, 0, 0, 0.1),
                HoverBorderColor = ColorUtil.RandomColorString(),
                HoverBorderWidth = 1,
                BorderColor = "#ffffff",
            };

            _barChartConfig.Data.Datasets.Add(barSet3);

            int index1 = 0;
            int index2 = 0;
            int index3 = 0;
            if (data != null)
            {
                foreach (var flight in countJFK)
                {

                    barSet1.Add(countJFK[index1]);
                    index1++;
                }
                foreach (var flight in countEWR)
                {

                    barSet2.Add(countEWR[index2]);
                    index2++;
                }
                foreach (var flight in countLGA)
                {

                    barSet3.Add(countLGA[index3]);
                    index3++;
                }
            }
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
