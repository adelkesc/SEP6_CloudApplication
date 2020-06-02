#pragma checksum "D:\Code\SEP6_CloudApplication\SEP6\Pages\Temperatures.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab9d23d2467a8c55c8b5b7917453d6d993cc4f1d"
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
#line 3 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Temperatures.razor"
using ChartJs.Blazor.ChartJS.BarChart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Temperatures.razor"
using ChartJs.Blazor.ChartJS.BarChart.Axes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Temperatures.razor"
using ChartJs.Blazor.ChartJS.Common.Axes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Temperatures.razor"
using ChartJs.Blazor.ChartJS.Common.Axes.Ticks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Temperatures.razor"
using ChartJs.Blazor.ChartJS.Common.Properties;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Temperatures.razor"
using ChartJs.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Temperatures.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Temperatures.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Temperatures.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Temperatures.razor"
using ChartJs.Blazor.ChartJS.Common.Wrappers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/temperatures")]
    public partial class Temperatures : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Number of Weather Observations per Origin</h3>\r\n\r\n");
#nullable restore
#line 18 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Temperatures.razor"
 if (data == null && data2 == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p>Loading...</p>\r\n");
#nullable restore
#line 21 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Temperatures.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "btn btn-primary");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Temperatures.razor"
                                              Switch

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(7, " Switch ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "table");
            __builder.AddAttribute(10, "class", "table table-striped text-center");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.AddMarkupContent(12, "<thead>\r\n            <tr>\r\n                <th>Origin</th>\r\n                <th>Number of Weather Observations</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(13, "tbody");
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "tr");
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.AddMarkupContent(17, "<td>JFK</td>\r\n                ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 35 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Temperatures.razor"
                     countJFK.Count()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "tr");
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.AddMarkupContent(24, "<td>LGA</td>\r\n                ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 39 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Temperatures.razor"
                     countLGA.Count()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.OpenElement(29, "tr");
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.AddMarkupContent(31, "<td>EWR</td>\r\n                ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 43 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Temperatures.razor"
                     countEWR.Count()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
            __builder.AddContent(38, "        ");
            __builder.OpenComponent<ChartJs.Blazor.Charts.ChartJsBarChart>(39);
            __builder.AddAttribute(40, "Config", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ChartJs.Blazor.ChartJS.BarChart.BarConfig>(
#nullable restore
#line 49 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Temperatures.razor"
                                  _barChartConfig

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 50 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Temperatures.razor"
                                600

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 51 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Temperatures.razor"
                                 300

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(43, (__value) => {
#nullable restore
#line 48 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Temperatures.razor"
                               _barChart = (ChartJs.Blazor.Charts.ChartJsBarChart)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 52 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Temperatures.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Temperatures.razor"
       
    private List<FlightModel> data;
    private List<FlightModel> data2;

    private bool change = true;

    private BarConfig _barChartConfig;
    private ChartJsBarChart _barChart;
    private BarDataset<DoubleWrapper> _barDataSet11, _barDataSet12, _barDataSet13;

    private BarConfig _barChartConfig2;
    private ChartJsBarChart _barChart2;
    private BarDataset<DoubleWrapper> _barDataSet21, _barDataSet22, _barDataSet23;

    private double[] countJFK, countLGA, countEWR;
    private double[] count1JFK, count2LGA, count3EWR;

    public Task Switch()
    {

        if (change)
        {
            _barChartConfig.Data.Labels.Clear();
            _barChartConfig.Data.Labels.AddRange(data2[0].GetDateFormat(data2));
            _barChartConfig.Data.Datasets[0] = _barDataSet11;
            _barChartConfig.Data.Datasets[1] = _barDataSet12;
            _barChartConfig.Data.Datasets[2] = _barDataSet13;
        }
        else
        {
            _barChartConfig.Data.Labels.Clear();
            _barChartConfig.Data.Labels.AddRange(data[0].GetDateFormat(data));
            _barChartConfig.Data.Datasets[0] = _barDataSet21;
            _barChartConfig.Data.Datasets[1] = _barDataSet22;
            _barChartConfig.Data.Datasets[2] = _barDataSet23;
        }
        change = !change;
        return Task.CompletedTask;
    }

    protected override async Task OnInitializedAsync()
    {
        data = await model.TempPerOriginAsync();
        data2 = await model.MeanTempPerOriginAsync();

        _barChartConfig = new BarConfig
        {
            Options = new BarOptions
            {
                Title = new OptionsTitle
                {
                    Display = true,
                    Text = "Hourly Precise Temperatures in 2013"
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
        _barDataSet11 = new BarDataset<DoubleWrapper>
        {
            Label = "JFK",
            BackgroundColor = ColorUtil.RandomColorString(),
            BorderWidth = 0,
            HoverBackgroundColor = ColorUtil.RandomColorString(),
            HoverBorderColor = ColorUtil.RandomColorString(),
            HoverBorderWidth = 1,
            BorderColor = "#ffffff"
        };
        _barDataSet12 = new BarDataset<DoubleWrapper>
        {
            Label = "LGA",
            BackgroundColor = ColorUtil.RandomColorString(),
            BorderWidth = 0,
            HoverBackgroundColor = ColorUtil.RandomColorString(),
            HoverBorderColor = ColorUtil.RandomColorString(),
            HoverBorderWidth = 1,
            BorderColor = "#ffffff"
        };
        _barDataSet13 = new BarDataset<DoubleWrapper>
        {
            Label = "EWR",
            BackgroundColor = ColorUtil.RandomColorString(),
            BorderWidth = 0,
            HoverBackgroundColor = ColorUtil.RandomColorString(),
            HoverBorderColor = ColorUtil.RandomColorString(),
            HoverBorderWidth = 1,
            BorderColor = "#ffffff"
        };

        _barDataSet21 = new BarDataset<DoubleWrapper>
        {
            Label = "JFK",
            BackgroundColor = ColorUtil.RandomColorString(),
            BorderWidth = 0,
            HoverBackgroundColor = ColorUtil.RandomColorString(),
            HoverBorderColor = ColorUtil.RandomColorString(),
            HoverBorderWidth = 1,
            BorderColor = "#ffffff"
        };
        _barDataSet22 = new BarDataset<DoubleWrapper>
        {
            Label = "LGA",
            BackgroundColor = ColorUtil.RandomColorString(),
            BorderWidth = 0,
            HoverBackgroundColor = ColorUtil.RandomColorString(),
            HoverBorderColor = ColorUtil.RandomColorString(),
            HoverBorderWidth = 1,
            BorderColor = "#ffffff"
        };
        _barDataSet23 = new BarDataset<DoubleWrapper>
        {
            Label = "EWR",
            BackgroundColor = ColorUtil.RandomColorString(),
            BorderWidth = 0,
            HoverBackgroundColor = ColorUtil.RandomColorString(),
            HoverBorderColor = ColorUtil.RandomColorString(),
            HoverBorderWidth = 1,
            BorderColor = "#ffffff"
        };

        if (data != null)
        {
            _barChartConfig.Data.Labels.AddRange(data[0].GetDateFormat(data));
            countJFK = (data[0].Temperatures(data, "JFK"));
            countLGA = (data[0].Temperatures(data, "LGA"));
            countEWR = (data[0].Temperatures(data, "EWR"));
            _barDataSet11.AddRange(countJFK.Wrap());
            _barDataSet12.AddRange(countLGA.Wrap());
            _barDataSet13.AddRange(countEWR.Wrap());
            _barChartConfig.Data.Datasets.Add(_barDataSet11);
            _barChartConfig.Data.Datasets.Add(_barDataSet12);
            _barChartConfig.Data.Datasets.Add(_barDataSet13);
        }

        if (data2 != null)
        {
            count1JFK = (data2[0].Temperatures(data2, "JFK"));
            count2LGA = (data2[0].Temperatures(data2, "LGA"));
            count3EWR = (data2[0].Temperatures(data2, "EWR"));
            _barDataSet21.AddRange(countJFK.Wrap());
            _barDataSet22.AddRange(countLGA.Wrap());
            _barDataSet23.AddRange(countEWR.Wrap());
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
