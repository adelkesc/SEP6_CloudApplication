#pragma checksum "D:\Code\SEP6_CloudApplication\SEP6\Pages\TotalFlights.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb4f3612f554f27023279d20a8aebf060a724655"
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
#line 2 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TotalFlights.razor"
using ChartJs.Blazor.ChartJS.BarChart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TotalFlights.razor"
using ChartJs.Blazor.ChartJS.Common.Axes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TotalFlights.razor"
using ChartJs.Blazor.ChartJS.Common.Axes.Ticks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TotalFlights.razor"
using ChartJs.Blazor.ChartJS.Common.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TotalFlights.razor"
using ChartJs.Blazor.ChartJS.Common.Properties;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TotalFlights.razor"
using ChartJs.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TotalFlights.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TotalFlights.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TotalFlights.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TotalFlights.razor"
using ChartJs.Blazor.ChartJS.Common.Wrappers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TotalFlights.razor"
using ChartJs.Blazor.ChartJS.BarChart.Axes;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/totalFlights")]
    public partial class TotalFlights : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 15 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TotalFlights.razor"
 if (data == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<p>Loading...</p>\r\n");
#nullable restore
#line 18 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TotalFlights.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "class", "btn btn-primary");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TotalFlights.razor"
                                              Change

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(6, "Change Chart");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenComponent<ChartJs.Blazor.Charts.ChartJsBarChart>(8);
            __builder.AddAttribute(9, "Config", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ChartJs.Blazor.ChartJS.BarChart.BarConfig>(
#nullable restore
#line 23 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TotalFlights.razor"
                              _barChartConfig

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 24 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TotalFlights.razor"
                            600

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 25 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TotalFlights.razor"
                             300

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(12, (__value) => {
#nullable restore
#line 22 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TotalFlights.razor"
                           _barChart = (ChartJs.Blazor.Charts.ChartJsBarChart)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 26 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TotalFlights.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TotalFlights.razor"
       
    private BarConfig _barChartConfig;
    private ChartJsBarChart _barChart;
    private BarDataset<DoubleWrapper> _barDataSet;
    private List<FlightModel> data;
    private bool change = true;

    public void Change()
    {
        change = !change;
        _barChartConfig.Options.Scales.XAxes = new List<CartesianAxis>
            {
                new BarCategoryAxis
                {
                    BarThickness = BarThickness.Flex,
                    Stacked = change
                }
            };
        this.StateHasChanged();
    }

    protected async override void OnInitialized()
    {
        data = await model.NoFlightsPerMonthPerOriginAsync();
        _barChartConfig = new BarConfig
        {
            Options = new BarOptions
            {
                Title = new OptionsTitle
                {
                    Display = true,
                    Text = "Total Flights per Month"
                },
                Scales = new BarScales
                {
                    XAxes = new List<CartesianAxis>
                    {
                        new BarCategoryAxis
                        {
                            BarThickness = BarThickness.Flex,
                            Stacked = true
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


        string[] months;
        months = new[] { "January", "February", "March", "April", "May", "June", "July", "August"
        , "September", "October", "November", "December"};
        _barChartConfig.Data.Labels.AddRange(months);


        if(data != null)
        {
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


            barSet1.AddRange(countJFK.Wrap());
            barSet2.AddRange(countEWR.Wrap());
            barSet3.AddRange(countLGA.Wrap());
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
