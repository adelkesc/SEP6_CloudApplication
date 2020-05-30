#pragma checksum "D:\Code\SEP6_CloudApplication\SEP6\Pages\Flights.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c457b46f33590266098a718d3b3d206f8bbf358f"
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
#line 3 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Flights.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Flights.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Flights.razor"
using ChartJs.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Flights.razor"
using ChartJs.Blazor.ChartJS.PieChart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Flights.razor"
using ChartJs.Blazor.ChartJS.Common.Properties;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Flights.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/flights")]
    public partial class Flights : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Flights.razor"
       
    private List<FlightModel> flights;
    private string[] months;
    private List<double> count;

    private PieConfig _config;
    private ChartJsPieChart _pieChartJs;

    protected override async Task OnInitializedAsync()
    {
        flights = await model.NoFlightsPerMonthAsync();
        CalculateArrays();

        _config = new PieConfig
        {
            Options = new PieOptions
            {
                Title = new OptionsTitle
                {
                    Display = true,
                    Text = "Sample chart from Blazor"
                },
                Responsive = true,
                Animation = new ArcAnimation
                {
                    AnimateRotate = true,
                    AnimateScale = true
                }
            }
        };

        _config.Data.Labels.AddRange(months);

        var pieSet = new PieDataset
        {
            BackgroundColor = new[] {   ColorUtil.RandomColorString(), ColorUtil.RandomColorString(), 
                                        ColorUtil.RandomColorString(), ColorUtil.RandomColorString(), 
                                        ColorUtil.RandomColorString(), ColorUtil.RandomColorString(), 
                                        ColorUtil.RandomColorString(), ColorUtil.RandomColorString(), 
                                        ColorUtil.RandomColorString(), ColorUtil.RandomColorString(), 
                                        ColorUtil.RandomColorString(), ColorUtil.RandomColorString() },
            BorderWidth = 0,
            HoverBackgroundColor = ColorUtil.RandomColorString(),
            HoverBorderColor = ColorUtil.RandomColorString(),
            HoverBorderWidth = 1,
            BorderColor = "#ffffff",
        };

        pieSet.Data.AddRange(count);
        _config.Data.Datasets.Add(pieSet);
    }

    protected void CalculateArrays()
    {
        months = new[] { "January", "February", "March", "April", "May", "June", "July", "August"
        , "September", "October", "November", "December"};
        count = new List<double>();

        foreach (var flight in flights)
        {
            count.Add((double)flight.Count);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModel model { get; set; }
    }
}
#pragma warning restore 1591
