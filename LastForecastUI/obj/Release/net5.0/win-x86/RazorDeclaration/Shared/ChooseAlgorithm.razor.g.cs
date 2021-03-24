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
#line 1 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\ChooseAlgorithm.razor"
using Forecast;

#line default
#line hidden
#nullable disable
    public partial class ChooseAlgorithm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\ChooseAlgorithm.razor"
       
    [Parameter]
    public Pages.ForecastPage Forecast { get; set; }

    private RadzenDropDown<string> algorithmDropDown;

    private void Continue()
    {
        string selectedAlgorithmText = "";

        if (algorithmDropDown.SelectedItem != null)
            selectedAlgorithmText = algorithmDropDown.SelectedItem.ToString();

        switch (selectedAlgorithmText)
        {
            case "Average":
                ForecastingManager.PredictionAlgorithm = ForecastLibrary.PredictionAlgorithm.AVERAGE;
                break;
            case "Fast Tree Tweedie":
                ForecastingManager.PredictionAlgorithm = ForecastLibrary.PredictionAlgorithm.FASTTREETWEEDIE;
                break;
            case "Fast Forest":
                ForecastingManager.PredictionAlgorithm = ForecastLibrary.PredictionAlgorithm.FASTFOREST;
                break;
            case "Lbfgs Poisson Regression":
                ForecastingManager.PredictionAlgorithm = ForecastLibrary.PredictionAlgorithm.LBFGSPOISSONREGRESSION;
                break;
            case "Sdca":
                ForecastingManager.PredictionAlgorithm = ForecastLibrary.PredictionAlgorithm.SDCA;
                break;
            case "Auto (recommended)":
                ForecastingManager.PredictionAlgorithm = ForecastLibrary.PredictionAlgorithm.AUTO;
                break;
            default:
                ForecastingManager.PredictionAlgorithm = ForecastLibrary.PredictionAlgorithm.AVERAGE;
                break;
        }

        ForecastingManager.FindLatestOrderDays();

        Forecast.DisplayResults();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ForecastingManager ForecastingManager { get; set; }
    }
}
#pragma warning restore 1591