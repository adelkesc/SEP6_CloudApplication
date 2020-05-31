#pragma checksum "D:\Code\SEP6_CloudApplication\SEP6\Pages\CheckTemperature.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4ded3f3804fdd12e407fc8e4a3fd0e16d83a7c8"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 3 "D:\Code\SEP6_CloudApplication\SEP6\Pages\CheckTemperature.razor"
using ChartJs.Blazor.ChartJS.BarChart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Code\SEP6_CloudApplication\SEP6\Pages\CheckTemperature.razor"
using ChartJs.Blazor.ChartJS.BarChart.Axes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Code\SEP6_CloudApplication\SEP6\Pages\CheckTemperature.razor"
using ChartJs.Blazor.ChartJS.Common.Axes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Code\SEP6_CloudApplication\SEP6\Pages\CheckTemperature.razor"
using ChartJs.Blazor.ChartJS.Common.Axes.Ticks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Code\SEP6_CloudApplication\SEP6\Pages\CheckTemperature.razor"
using ChartJs.Blazor.ChartJS.Common.Properties;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Code\SEP6_CloudApplication\SEP6\Pages\CheckTemperature.razor"
using ChartJs.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Code\SEP6_CloudApplication\SEP6\Pages\CheckTemperature.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Code\SEP6_CloudApplication\SEP6\Pages\CheckTemperature.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Code\SEP6_CloudApplication\SEP6\Pages\CheckTemperature.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Code\SEP6_CloudApplication\SEP6\Pages\CheckTemperature.razor"
using ChartJs.Blazor.ChartJS.Common.Wrappers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Code\SEP6_CloudApplication\SEP6\Pages\CheckTemperature.razor"
using ChartJs.Blazor.ChartJS.MixedChart;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/checkweather/temperatures")]
    public partial class CheckTemperature : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "D:\Code\SEP6_CloudApplication\SEP6\Pages\CheckTemperature.razor"
 
    private BarConfig _barChartConfig;
    private ChartJsBarChart _barChart;
    private BarDataset<DoubleWrapper> _barDataSet1;
    private BarDataset<DoubleWrapper> _barDataSet2;
    private BarDataset<DoubleWrapper> _barDataSet3;
    private List<FlightModel> data;

    protected async override Task OnInitializedAsync()
    {
        data = await model.TempPerOriginAsync();

        _barChartConfig = new BarConfig
        {
            Options = new BarOptions
            {
                Title = new OptionsTitle
                {
                    Display = true,
                    Text = "Simple Bar Chart"
                },
                Scales = new BarScales
                {
                    XAxes = new List<CartesianAxis>
        {
                        new BarCategoryAxis
                        {
                            BarThickness = BarThickness.Flex,
                            Stacked = true,
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
            _barChartConfig.Data.Labels.AddRange(data[0].GetDateFormat(data));
            _barDataSet1 = new BarDataset<DoubleWrapper>
            {
                Label = "JFK",
                BackgroundColor = ColorUtil.RandomColorString(),
                BorderWidth = 0,
                HoverBackgroundColor = ColorUtil.RandomColorString(),
                HoverBorderColor = ColorUtil.RandomColorString(),
                HoverBorderWidth = 1,
                BorderColor = "#ffffff"
            };
            var countJFK = (data[0].Temperatures(data, "JFK")).Wrap();
            _barDataSet1.AddRange(countJFK);
            _barDataSet2 = new BarDataset<DoubleWrapper>
            {
                Label = "LGA",
                BackgroundColor = ColorUtil.RandomColorString(),
                BorderWidth = 0,
                HoverBackgroundColor = ColorUtil.RandomColorString(),
                HoverBorderColor = ColorUtil.RandomColorString(),
                HoverBorderWidth = 1,
                BorderColor = "#ffffff"
            };
            var countLGA = (data[0].Temperatures(data, "LGA")).Wrap();
            _barChartConfig.Data.Datasets.Add(_barDataSet1);
            _barDataSet1.AddRange(countLGA);

            _barDataSet3 = new BarDataset<DoubleWrapper>
            {
                Label = "EWR",
                BackgroundColor = ColorUtil.RandomColorString(),
                BorderWidth = 0,
                HoverBackgroundColor = ColorUtil.RandomColorString(),
                HoverBorderColor = ColorUtil.RandomColorString(),
                HoverBorderWidth = 1,
                BorderColor = "#ffffff"
            };
            var countEWR = (data[0].Temperatures(data, "EWR")).Wrap();
            _barChartConfig.Data.Datasets.Add(_barDataSet2);
            _barDataSet1.AddRange(countEWR);

            _barChartConfig.Data.Datasets.Add(_barDataSet3);
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
