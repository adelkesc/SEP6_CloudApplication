#pragma checksum "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\BlazorChartsTestProj\BlazorAppTutorial\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09db8c7c43b258056ca5ae97498e421243777d94"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAppTutorial.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\BlazorChartsTestProj\BlazorAppTutorial\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\BlazorChartsTestProj\BlazorAppTutorial\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\BlazorChartsTestProj\BlazorAppTutorial\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\BlazorChartsTestProj\BlazorAppTutorial\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\BlazorChartsTestProj\BlazorAppTutorial\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\BlazorChartsTestProj\BlazorAppTutorial\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\BlazorChartsTestProj\BlazorAppTutorial\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\BlazorChartsTestProj\BlazorAppTutorial\_Imports.razor"
using BlazorAppTutorial;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\BlazorChartsTestProj\BlazorAppTutorial\_Imports.razor"
using BlazorAppTutorial.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\BlazorChartsTestProj\BlazorAppTutorial\_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n<br>\r\n<br>\r\n<br>\r\n");
            __builder.OpenComponent<BlazorAppTutorial.Pages.Counter>(1);
            __builder.AddAttribute(2, "IncrementAmount", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 9 "C:\Users\adand\Documents\6th_semester_2020\SEP6\SEP6Project\ProjectVC\BlazorChartsTestProj\BlazorAppTutorial\Pages\Index.razor"
                          10

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenComponent<BlazorAppTutorial.Shared.SurveyPrompt>(4);
            __builder.AddAttribute(5, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
