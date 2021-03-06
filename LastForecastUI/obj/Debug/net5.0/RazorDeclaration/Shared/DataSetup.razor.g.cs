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
#line 1 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DataSetup.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DataSetup.razor"
using Forecast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DataSetup.razor"
using ForecastLibrary;

#line default
#line hidden
#nullable disable
    public partial class DataSetup : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 131 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DataSetup.razor"
       
    [Parameter]
    public Pages.ForecastPage Forecast { get; set; }

    private RadzenDropDown<string> inventoryFileChooseDropDown;
    private RadzenDropDown<string> salesFileChooseDropDown;
    private RadzenDropDown<string> separatorCharacterDropDown;

    private RadzenNumeric<int> productIdInventory;
    private RadzenNumeric<int> productTitle;
    private RadzenNumeric<int> inventoryOnHand;
    private RadzenNumeric<int> leadTime;

    private RadzenNumeric<int> productIdSales;
    private RadzenNumeric<int> date;
    private RadzenNumeric<int> unitsSold;

    private bool standardDate = true;
    private string dateFormat = "yyyy-MM-dd";

    private void Continue()
    {
        ImportManager importManager = new ImportManager(
            splitBy: char.Parse(separatorCharacterDropDown.SelectedItem.ToString()),
            forecastingManager: ForecastingManager,
            standardDate:standardDate,
            nonStandardDateFormat:dateFormat);

        string selectedInventoryFile = inventoryFileChooseDropDown.SelectedItem.ToString();
        string selectedSalesFile = salesFileChooseDropDown.SelectedItem.ToString();
        foreach (var file in DataStorage.RawData)
        {
            if (file.Name == selectedInventoryFile)
            {
                importManager.InventoryFileContent = file.Content;
            }
            else if (file.Name == selectedSalesFile)
            {
                importManager.SalesFileContent = file.Content;
            }
        }

        importManager.ImportData(
            productIdInventory.Value,
            inventoryOnHand.Value,
            leadTime.Value,
            productIdSales.Value,
            date.Value,
            unitsSold.Value,
            productTitle.Value);

        Forecast.ChooseAlgorithm();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IForecastingManager ForecastingManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataStorage DataStorage { get; set; }
    }
}
#pragma warning restore 1591
