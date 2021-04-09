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
#nullable restore
#line 2 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\ChooseAlgorithm.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\ChooseAlgorithm.razor"
using System.IO;

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
#line 56 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\ChooseAlgorithm.razor"
       
    [Parameter]
    public Pages.ForecastPage Forecast { get; set; }

    private List<string> algorithms = new List<string>() { "Auto All", "Auto (recommended)", "Average", "Exponential Smoothing", "Lbfgs Poisson Regression", "Fast Tree Tweedie", "Fast Forest", "Sdca" };
    private List<string> MLAlgorithms = new List<string>() { "Lbfgs Poisson Regression", "Fast Tree Tweedie", "Fast Forest", "Sdca" };
    private List<string> simpleAlgorithms = new List<string>() { "Average", "Exponential Smoothing" };

    private RadzenDropDown<string> algorithmDropDown;

    private RadzenDropDown<string> bigDataDropDown;
    private RadzenDropDown<string> smallDataDropDown;

    private bool loading = false;

    private void Continue()
    {
        string selectedAlgorithmText = "Auto (recommended)";
        string selectedBigDataAlgorithmText = "Fast Tree Tweedie";
        string selectedSmallDataAlgorithmText = "Exponential Smoothing";

        if (algorithmDropDown.SelectedItem != null)
            selectedAlgorithmText = algorithmDropDown.SelectedItem.ToString();

        if (bigDataDropDown != null)
            if (bigDataDropDown.SelectedItem != null)
                selectedBigDataAlgorithmText = bigDataDropDown.SelectedItem.ToString();

        if (smallDataDropDown != null)
            if (smallDataDropDown.SelectedItem != null)
                selectedSmallDataAlgorithmText = smallDataDropDown.SelectedItem.ToString();

        ForecastingManager.PredictionAlgorithm = GetAlgorithmFromText(selectedAlgorithmText);
        ForecastingManager.MLPredictionAlgorithm = GetAlgorithmFromText(selectedBigDataAlgorithmText);
        ForecastingManager.SafePredictionAlgorithm = GetAlgorithmFromText(selectedSmallDataAlgorithmText);

        loading = true;
        InvokeAsync(StateHasChanged);

        Task.Run(() => InitiateForecast());
    }

    private void Update()
    {
        InvokeAsync(StateHasChanged);
    }

    private ForecastLibrary.PredictionAlgorithm GetAlgorithmFromText(string text)
    {
        switch (text)
        {
            case "Average":
                return ForecastLibrary.PredictionAlgorithm.AVERAGE;
            case "Exponential Smoothing":
                return ForecastLibrary.PredictionAlgorithm.EXPONENTIALSMOOTHING;
            case "Fast Tree Tweedie":
                return ForecastLibrary.PredictionAlgorithm.FASTTREETWEEDIE;
            case "Fast Forest":
                return ForecastLibrary.PredictionAlgorithm.FASTFOREST;
            case "Lbfgs Poisson Regression":
                return ForecastLibrary.PredictionAlgorithm.LBFGSPOISSONREGRESSION;
            case "Sdca":
                return ForecastLibrary.PredictionAlgorithm.SDCA;
            case "Auto (recommended)":
                return ForecastLibrary.PredictionAlgorithm.AUTO;
            case "Auto All":
                return ForecastLibrary.PredictionAlgorithm.AUTOALL;
            default:
                return ForecastLibrary.PredictionAlgorithm.AVERAGE;
        }
    }

    private void InitiateForecast()
    {
        ForecastingManager.FindLatestOrderDays();

        ExportToCSV();

        Forecast.DisplayResults();
    }

    private void ExportToCSV()
    {
        //string path = AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.IndexOf("\\bin"));
        string path = (string)AppDomain.CurrentDomain.GetData("WebRootPath");
        string fileName = $"Forecast{DateTime.Now.Ticks}.csv";
        ForecastingManager.FileName = fileName;

        File.WriteAllText($"{path}/{fileName}", ListToText(GenerateCSVContent()));
    }

    private string ListToText(List<string> list)
    {
        string text = "";
        foreach (var line in list)
        {
            text += $"{line}{Environment.NewLine}";
        }

        return text;
    }

    private List<string> GenerateCSVContent()
    {
        List<string> content = new List<string>();

        string separatorChar = ForecastingManager.SeparatorCharacter;

        string header = $"product_code{separatorChar}product_title{separatorChar}until_stockout{separatorChar}monthly_sales{separatorChar}inventory{separatorChar}lead_time{separatorChar}month_to_date_qty{separatorChar}last_month_qty";
        content.Add(header);

        foreach (var product in ForecastingManager.Results)
        {
            string line = $"{product.Product.Code}{separatorChar}{product.Product.Title}{separatorChar}{product.DaysToOrder}{separatorChar}{product.MonthlySales}{separatorChar}{product.Product.Inventory}{separatorChar}{product.Product.LeadTime}{separatorChar}{product.Product.MonthToDateSales}{separatorChar}{product.Product.LastMonthSales}";
            content.Add(line);
        }

        return content;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SiteInfo SiteInfo { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IForecastingManager ForecastingManager { get; set; }
    }
}
#pragma warning restore 1591
