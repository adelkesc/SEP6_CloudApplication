#pragma checksum "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\Pages\TotalFlights.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c69464798c2eb84f229d2d3cae9cc00e95dfa968"
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
#line 1 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\_Imports.razor"
using SEP6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\_Imports.razor"
using SEP6.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\Pages\TotalFlights.razor"
using ChartJs.Blazor.ChartJS.BarChart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\Pages\TotalFlights.razor"
using ChartJs.Blazor.ChartJS.Common.Axes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\Pages\TotalFlights.razor"
using ChartJs.Blazor.ChartJS.Common.Axes.Ticks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\Pages\TotalFlights.razor"
using ChartJs.Blazor.ChartJS.Common.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\Pages\TotalFlights.razor"
using ChartJs.Blazor.ChartJS.Common.Properties;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\Pages\TotalFlights.razor"
using ChartJs.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\Pages\TotalFlights.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\Pages\TotalFlights.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\Pages\TotalFlights.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\Pages\TotalFlights.razor"
using ChartJs.Blazor.ChartJS.Common.Wrappers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\Pages\TotalFlights.razor"
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
            __builder.AddMarkupContent(0, "<h3>Total Number of Flights</h3>\r\n<br>\r\n");
#nullable restore
#line 17 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\Pages\TotalFlights.razor"
 if (data == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p>Loading...</p>\r\n");
#nullable restore
#line 20 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\Pages\TotalFlights.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "type", "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\Pages\TotalFlights.razor"
                                                            Change

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Switch Stacked Chart Model");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    <br>\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "btn-group d-flex justify-content-center");
            __builder.AddAttribute(12, "role", "group");
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.AddMarkupContent(14, "<button type=\"button\" class=\"btn btn-secondary\">Frequency</button> \r\n        ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "type", "button");
            __builder.AddAttribute(17, "class", "btn btn-secondary");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\Pages\TotalFlights.razor"
                                                                  ShowStackedFrequent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, "Frequency Stacked");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "type", "button");
            __builder.AddAttribute(23, "class", "btn btn-secondary");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\Pages\TotalFlights.razor"
                                                                  ShowStackedPercent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, "Percent Stacked");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        \r\n        ");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "type", "button");
            __builder.AddAttribute(29, "class", "btn btn-secondary");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\Pages\TotalFlights.razor"
                                                                  ShowTotalFlights

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(31, "Total Flights per Month");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n    <br>\r\n    ");
            __builder.OpenComponent<ChartJs.Blazor.Charts.ChartJsBarChart>(34);
            __builder.AddAttribute(35, "Config", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ChartJs.Blazor.ChartJS.BarChart.BarConfig>(
#nullable restore
#line 34 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\Pages\TotalFlights.razor"
                              _barChartConfig

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 35 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\Pages\TotalFlights.razor"
                            600

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 36 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\Pages\TotalFlights.razor"
                             300

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(38, (__value) => {
#nullable restore
#line 33 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\Pages\TotalFlights.razor"
                           _barChart = (ChartJs.Blazor.Charts.ChartJsBarChart)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(39, "\r\n    <br>\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(40, "<h3>Departure and Arrival Delays</h3>\r\n    ");
            __builder.OpenElement(41, "table");
            __builder.AddAttribute(42, "class", "table table-striped");
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.AddMarkupContent(44, @"<thead>
            <tr>
                <th class=""text-center"">Origin</th>
                <th class=""text-center"">Average Arrival Delay</th>
                <th class=""text-center"">Average Departure Delay</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(45, "tbody");
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 49 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\Pages\TotalFlights.razor"
             foreach (var flight in data2)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(47, "                ");
            __builder.OpenElement(48, "tr");
            __builder.AddMarkupContent(49, "\r\n                    ");
            __builder.OpenElement(50, "td");
            __builder.AddAttribute(51, "class", "text-center");
            __builder.AddContent(52, 
#nullable restore
#line 52 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\Pages\TotalFlights.razor"
                                             flight.Origin

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                    ");
            __builder.OpenElement(54, "td");
            __builder.AddAttribute(55, "class", "text-center");
            __builder.AddContent(56, 
#nullable restore
#line 53 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\Pages\TotalFlights.razor"
                                             Math.Round(flight.Avg_arr, 2)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(57, " Minutes");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                    ");
            __builder.OpenElement(59, "td");
            __builder.AddAttribute(60, "class", "text-center");
            __builder.AddContent(61, 
#nullable restore
#line 54 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\Pages\TotalFlights.razor"
                                             Math.Round(flight.Avg_dep, 2)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(62, " Minutes");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n");
#nullable restore
#line 56 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\Pages\TotalFlights.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(65, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n    <br>\r\n    <br>\r\n");
#nullable restore
#line 61 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\Pages\TotalFlights.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\Pages\TotalFlights.razor"
       
    private BarConfig _barChartConfig;
    private ChartJsBarChart _barChart;
    private BarDataset<DoubleWrapper> _barDataSet;
    private List<FlightModel> data;
    private List<FlightModel> data1;
    private List<FlightModel> data2;
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

    //Total number of flights from 3 Origins (Frequency Stacked)
    public void ShowStackedFrequent()
    {
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

    }

    //Total number of flights from 3 Origins (Percentage Stacked)
    public void ShowStackedPercent()
    {
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
    }

    //Total number of flights per month
    public void ShowTotalFlights()
    {
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

    /*
    public void ShowJFKFlights()
    {
        var datasetTotal = new BarDataset<DoubleWrapper>
        {
            Label = "JFK Flights",
            BackgroundColor = "#6682ea",
            BorderWidth = 0,
            HoverBackgroundColor = "#6682ea",
            HoverBorderColor = "#6682ea",
            HoverBorderWidth = 1,
            BorderColor = "#ffffff"
        };
        double[] countJFK = data[0].TotalFlights(data, "JFK");
        _barChartConfig.Data.Datasets.Clear();
        datasetTotal.AddRange(countJFK.Wrap());

        _barChartConfig.Data.Datasets.Add(datasetTotal);
    }
    */

    protected async override void OnInitialized()
    {
        data = await model.NoFlightsPerMonthPerOriginAsync();
        data1 = await model.TotalFlightsMonthAsync();
        data2 = await model.MeanDelayPerOriginAsync();

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
