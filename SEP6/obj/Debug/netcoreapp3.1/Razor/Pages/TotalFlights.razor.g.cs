#pragma checksum "D:\Code\SEP6_CloudApplication\SEP6\Pages\TotalFlights.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e849dad423c75a7cf09a54676effb44d5bda5bf"
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
            __builder.AddAttribute(4, "type", "button");
            __builder.AddAttribute(5, "class", "btn btn-primary");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TotalFlights.razor"
                                                            Change

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(7, "Switch Stacked Chart Model");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenComponent<ChartJs.Blazor.Charts.ChartJsBarChart>(9);
            __builder.AddAttribute(10, "Config", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ChartJs.Blazor.ChartJS.BarChart.BarConfig>(
#nullable restore
#line 23 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TotalFlights.razor"
                              _barChartConfig

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 24 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TotalFlights.razor"
                            600

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 25 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TotalFlights.razor"
                             300

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(13, (__value) => {
#nullable restore
#line 22 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TotalFlights.razor"
                           _barChart = (ChartJs.Blazor.Charts.ChartJsBarChart)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n    <br>\r\n    <br>\r\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "btn-group d-flex justify-content-center");
            __builder.AddAttribute(17, "role", "group");
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "type", "button");
            __builder.AddAttribute(21, "class", "btn btn-secondary");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TotalFlights.razor"
                                                                  ShowTotalFlights

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(23, "Total Flights per Month");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "type", "button");
            __builder.AddAttribute(27, "class", "btn btn-secondary");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TotalFlights.razor"
                                                                  ShowStackedFlights

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(29, 
#nullable restore
#line 30 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TotalFlights.razor"
                                                                                       buttonName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    <br>\r\n    <br>\r\n");
#nullable restore
#line 34 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TotalFlights.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "D:\Code\SEP6_CloudApplication\SEP6\Pages\TotalFlights.razor"
       
    private BarConfig _barChartConfig;
    private ChartJsBarChart _barChart;
    private BarDataset<DoubleWrapper> _barDataSet;
    private List<FlightModel> data;
    private List<FlightModel> data1;
    private bool change = true;
    private bool change1 = true;
    private string buttonName = "Total Flighs Frequency In Percentages";

    private BarDataset<DoubleWrapper> _barDataSetTotal;


    public void Change()
    {

        this.StateHasChanged();
        change = !change;
        _barChartConfig.Options.Scales.XAxes = new List<CartesianAxis>
        {
                new BarCategoryAxis
                {
                    BarThickness = BarThickness.Flex,
                    Stacked = change
                }
            };
    }

    public void ShowStackedFlights()
    {
        if (!change1)
        {
            buttonName = "Total Flighs Frequency In Percentages";
            var barSet1 = new BarDataset<DoubleWrapper>
            {
                Label = "JFK",
                BackgroundColor = "#892514",
                BorderWidth = 1,
                HoverBackgroundColor = "#892514",
                HoverBorderColor = "#892514",
                HoverBorderWidth = 1,
                BorderColor = "#ffffff",
            };
            var barSet2 = new BarDataset<DoubleWrapper>
            {
                Label = "EWR",
                BackgroundColor = "#2cac19",
                BorderWidth = 1,
                HoverBackgroundColor = "#2cac19",
                HoverBorderColor = "#2cac19",
                HoverBorderWidth = 1,
                BorderColor = "#ffffff",
            };
            var barSet3 = new BarDataset<DoubleWrapper>
            {
                Label = "LGA",
                BackgroundColor = "#154591",
                BorderWidth = 1,
                HoverBackgroundColor = "#154591",
                HoverBorderColor = "#154591",
                HoverBorderWidth = 1,
                BorderColor = "#ffffff",
            };
            _barChartConfig.Options.Title.Text = "Total Flighs Frequency Stacked In Numbers";
            double[] countJFK = data[0].TotalFlights(data, "JFK");
            double[] countEWR = data[0].TotalFlights(data, "EWR");
            double[] countLGA = data[0].TotalFlights(data, "LGA");
            _barChartConfig.Data.Datasets.Clear();
            barSet1.AddRange(countJFK.Wrap());
            barSet2.AddRange(countEWR.Wrap());
            barSet3.AddRange(countLGA.Wrap());
            _barChartConfig.Data.Datasets.Add(barSet1);
            _barChartConfig.Data.Datasets.Add(barSet2);
            _barChartConfig.Data.Datasets.Add(barSet3);
            change1 = !change1;
        }
        else
        {
            buttonName = "Total Flighs Frequency In Numbers";
            var barSet1 = new BarDataset<DoubleWrapper>
            {
                Label = "JFK",
                BackgroundColor = "#892514",
                BorderWidth = 1,
                HoverBackgroundColor = "#892514",
                HoverBorderColor = "#892514",
                HoverBorderWidth = 1,
                BorderColor = "#ffffff",
            };
            var barSet2 = new BarDataset<DoubleWrapper>
            {
                Label = "EWR",
                BackgroundColor = "#2cac19",
                BorderWidth = 1,
                HoverBackgroundColor = "#2cac19",
                HoverBorderColor = "#2cac19",
                HoverBorderWidth = 1,
                BorderColor = "#ffffff",
            };
            var barSet3 = new BarDataset<DoubleWrapper>
            {
                Label = "LGA",
                BackgroundColor = "#154591",
                BorderWidth = 1,
                HoverBackgroundColor = "#154591",
                HoverBorderColor = "#154591",
                HoverBorderWidth = 1,
                BorderColor = "#ffffff",
            };
            _barChartConfig.Options.Title.Text = "Total Flighs Frequency Stacked In Percentages";
            double[] countJFK = model.Percentage(data, "JFK");
            double[] countEWR = model.Percentage(data, "EWR");
            double[] countLGA = model.Percentage(data, "LGA");
            _barChartConfig.Data.Datasets.Clear();
            barSet1.AddRange(countJFK.Wrap());
            barSet2.AddRange(countEWR.Wrap());
            barSet3.AddRange(countLGA.Wrap());
            _barChartConfig.Data.Datasets.Add(barSet1);
            _barChartConfig.Data.Datasets.Add(barSet2);
            _barChartConfig.Data.Datasets.Add(barSet3);
            change1 = !change1;
        }

    }

    public void ShowTotalFlights()
    {
        //Total Flights
        var datasetTotal = new BarDataset<DoubleWrapper>
        {
            Label = "All Flights",
            BackgroundColor = "#6682ea",
            BorderWidth = 0,
            HoverBackgroundColor = "#6682ea",
            HoverBorderColor = "#6682ea",
            HoverBorderWidth = 1,
            BorderColor = "#ffffff"
        };

        _barChartConfig.Data.Datasets.Clear();
        datasetTotal.AddRange(data[0].TotalFlights(data, "all").Wrap());

        _barChartConfig.Data.Datasets.Add(datasetTotal);
    }

    protected async override void OnInitialized()
    {
        data = await model.NoFlightsPerMonthPerOriginAsync();
        data1 = await model.TotalFlightsMonthAsync();

        _barChartConfig = new BarConfig
        {
            Options = new BarOptions
            {
                Title = new OptionsTitle
                {
                    Display = true,
                    Text = "Total Flighs Frequency Stacked In Numbers"
                },
                Scales = new BarScales
                {
                    XAxes = new List<CartesianAxis>
                {
                        new BarCategoryAxis
                        {
                            BarThickness = BarThickness.Flex,
                            Stacked = false
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


        if (data != null)
        {
            double[] countJFK = data[0].TotalFlights(data, "JFK");
            double[] countEWR = data[0].TotalFlights(data, "EWR");
            double[] countLGA = data[0].TotalFlights(data, "LGA");

            var barSet1 = new BarDataset<DoubleWrapper>
            {
                Label = "JFK",
                BackgroundColor = "#892514",
                BorderWidth = 1,
                HoverBackgroundColor = "#892514",
                HoverBorderColor = "#892514",
                HoverBorderWidth = 1,
                BorderColor = "#ffffff",
            };

            _barChartConfig.Data.Datasets.Add(barSet1);

            var barSet2 = new BarDataset<DoubleWrapper>
            {
                Label = "EWR",
                BackgroundColor = "#2cac19",
                BorderWidth = 1,
                HoverBackgroundColor = "#2cac19",
                HoverBorderColor = "#2cac19",
                HoverBorderWidth = 1,
                BorderColor = "#ffffff",
            };

            _barChartConfig.Data.Datasets.Add(barSet2);

            var barSet3 = new BarDataset<DoubleWrapper>
            {
                Label = "LGA",
                BackgroundColor = "#154591",
                BorderWidth = 1,
                HoverBackgroundColor = "#154591",
                HoverBorderColor = "#154591",
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
