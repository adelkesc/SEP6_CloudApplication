#pragma checksum "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\Pages\TemperaturesJFK.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a97921756662b415139ccffd9d8ac2db27baed0"
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
#line 16 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\_Imports.razor"
using ChartJs.Blazor.ChartJS.Common.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\Pages\TemperaturesJFK.razor"
using ChartJs.Blazor.ChartJS.BarChart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\Pages\TemperaturesJFK.razor"
using ChartJs.Blazor.ChartJS.BarChart.Axes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\Pages\TemperaturesJFK.razor"
using ChartJs.Blazor.ChartJS.Common.Axes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\Pages\TemperaturesJFK.razor"
using ChartJs.Blazor.ChartJS.Common.Axes.Ticks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\Pages\TemperaturesJFK.razor"
using ChartJs.Blazor.ChartJS.Common.Properties;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\Pages\TemperaturesJFK.razor"
using ChartJs.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\Pages\TemperaturesJFK.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\Pages\TemperaturesJFK.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\Pages\TemperaturesJFK.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\Pages\TemperaturesJFK.razor"
using ChartJs.Blazor.ChartJS.Common.Wrappers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/temperaturesJFK")]
    public partial class TemperaturesJFK : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\SEP6\Pages\TemperaturesJFK.razor"
       
    private List<FlightModel> data;
    private List<FlightModel> data2;
    private string button = "Show Precise Temperature at JFK";
    private string button1 = "Mean Daily Temperature at JFK";

    private bool change = true;

    private BarDataset<DoubleWrapper> _barDataSetTemp, _barDataSetAverage;

    private BarConfig _barChartConfig;
    private ChartJsBarChart _barChart;

    public void ShowPreciseJFK()
    {
        _barChartConfig.Data.Labels.Clear();
        _barChartConfig.Data.Datasets.Clear();

        _barChartConfig.Options.Title.Text = "Hourly Precise Temperature at JFK";
    }

    public void ShowMeanTempJFK()
    {
        _barChartConfig.Data.Labels.Clear();
        _barChartConfig.Data.Datasets.Clear();
        _barChartConfig.Options.Title.Text = "Daily Mean Temperatures at JFK (Month/Day)";
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModel model { get; set; }
    }
}
#pragma warning restore 1591
