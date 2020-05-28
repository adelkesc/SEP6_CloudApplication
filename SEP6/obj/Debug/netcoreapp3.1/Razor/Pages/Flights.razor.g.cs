#pragma checksum "D:\Code\SEP6_CloudApplication\SEP6\Pages\Flights.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bd67dd9418b34a6f106897fac847b573ca0492f"
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
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Code\SEP6_CloudApplication\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Code\SEP6_CloudApplication\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Code\SEP6_CloudApplication\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Code\SEP6_CloudApplication\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Code\SEP6_CloudApplication\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Code\SEP6_CloudApplication\SEP6\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Code\SEP6_CloudApplication\SEP6\_Imports.razor"
using SEP6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Code\SEP6_CloudApplication\SEP6\_Imports.razor"
using SEP6.Shared;

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
            __builder.AddMarkupContent(0, "<h3>Flights</h3>\r\n\r\n");
#nullable restore
#line 14 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Flights.razor"
 if (flights is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 17 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Flights.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenComponent<ChartJs.Blazor.Charts.ChartJsPieChart>(4);
            __builder.AddAttribute(5, "Config", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ChartJs.Blazor.ChartJS.PieChart.PieConfig>(
#nullable restore
#line 20 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Flights.razor"
                                                 _config

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 20 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Flights.razor"
                                                                 600

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 20 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Flights.razor"
                                                                              300

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(8, (__value) => {
#nullable restore
#line 20 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Flights.razor"
                           _pieChartJs = (ChartJs.Blazor.Charts.ChartJsPieChart)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 21 "D:\Code\SEP6_CloudApplication\SEP6\Pages\Flights.razor"
}

#line default
#line hidden
#nullable disable
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
        flights = await model.GetFlightsAsync();
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
            BackgroundColor = new[] { ColorUtil.RandomColorString(), ColorUtil.RandomColorString(), ColorUtil.RandomColorString(), ColorUtil.RandomColorString(), ColorUtil.RandomColorString(), ColorUtil.RandomColorString(), ColorUtil.RandomColorString(), ColorUtil.RandomColorString(), ColorUtil.RandomColorString(), ColorUtil.RandomColorString(), ColorUtil.RandomColorString(), ColorUtil.RandomColorString() },
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
