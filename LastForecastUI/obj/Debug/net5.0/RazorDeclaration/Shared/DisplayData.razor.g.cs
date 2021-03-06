// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LastForecastUI.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\_Imports.razor"
using LastForecastUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\_Imports.razor"
using LastForecastUI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DisplayData.razor"
using Forecast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DisplayData.razor"
using ForecastLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DisplayData.razor"
using Data;

#line default
#line hidden
#nullable disable
    public partial class DisplayData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DisplayData.razor"
       
    private ProcessOutput OpenedProduct { get; set; }

    private Chart Chart { get; set; }

    private RadzenGrid<ProcessOutput> Table { get; set; }

    private int PageSize = 10;

    private string exportLink
    {
        get
        {
            return $"/{ForecastingManager.FileName}";
        }
    }

    protected override void OnInitialized()
    {
        try
        {
            int half = (int)(ComparisonHandler.MaxId / 2);
            comparisonHandler.Comparisons.RemoveAll(o => o.Id < half);
        }
        catch
        {

        }
    }

    private void Compare()
    {
        if (OpenedProduct == null)
        {
            return;
        }

        ComparisonHandler.MaxId++;
        Comparison comparison = new Comparison() { Id = ComparisonHandler.MaxId, Product = OpenedProduct.Product };
        comparisonHandler.Comparisons.Add(comparison);

        try
        {
            JSRuntime.InvokeAsync<object>("open", $"/compare/{ComparisonHandler.MaxId}", "_blank");
        }
        catch
        {

        }
    }

    private void Update()
    {
        InvokeAsync(StateHasChanged);
    }

    private void OpenDetails(string code)
    {
        //NavigationManager.NavigateTo($"/chart/{code}");

        OpenedProduct = ForecastingManager.Results.Where(o => o.Product.Code == code).FirstOrDefault();
        InvokeAsync(StateHasChanged);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IComparisonHandler comparisonHandler { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IForecastingManager ForecastingManager { get; set; }
    }
}
#pragma warning restore 1591
