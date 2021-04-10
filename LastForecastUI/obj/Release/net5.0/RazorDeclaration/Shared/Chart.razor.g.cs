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
#line 4 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Chart.razor"
using Forecast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Chart.razor"
using ForecastLibrary;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/chart")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/chart/{code}")]
    public partial class Chart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Chart.razor"
       
    bool smooth = true;

    [Parameter]
    public ProcessOutput Product { get; set; }

    [Parameter]
    public string code { get; set; }

    [Parameter]
    public bool Visible { get; set; } = true;

    [Parameter]
    public bool DisplayDescription { get; set; } = true;

    private RadzenChart SalesChart { get; set; }

    private List<DataItem> Data = new List<DataItem>();
    private List<DataItem> PredictedData = new List<DataItem>();

    protected override void OnParametersSet()
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Chart.razor"
                           
    }

    protected override void OnInitialized()
    {
        if (Product != null)
            Update();
    }

    private void GoBack()
    {
        NavigationManager.NavigateTo("/forecast");
    }

    public void Update()
    {
        Data.Clear();

        DateTime startDate = DateTime.Now;

        foreach (var sale in Product.Product.Sales)
        {
            DateTime date = new DateTime();
            date = date.AddDays(sale.Day);
            date = date.AddMonths(Convert.ToInt32(sale.Month));
            date = date.AddYears(Convert.ToInt32(sale.Year));

            if (date < startDate)
            {
                startDate = date;
            }
        }

        startDate = startDate.AddYears(-1);
        startDate = startDate.AddMonths(-1);
        while (startDate < DateTime.Now)
        {
            DataItem item = new DataItem();
            var salesInMonth = Product.Product.Sales.Where(o => o.Year == startDate.Year && o.Month == startDate.Month);

            int totalSoldInMonth = 0;
            foreach (var sale in salesInMonth)
            {
                totalSoldInMonth += Convert.ToInt32(sale.Quantity);
            }

            item.Date = new DateTime(year: startDate.Year, month: startDate.Month, day: 1);
            item.Quantity = totalSoldInMonth;

            Data.Add(item);

            startDate = startDate.AddMonths(1);
        }

        DateTime now = new DateTime(year: DateTime.Now.Year, month: DateTime.Now.Month, day: 1);

        try
        {
            PredictedData.Add(new DataItem() { Date = now, Quantity = Convert.ToInt32(Product.PredictedMonthlySales[0]) });
            PredictedData.Add(new DataItem() { Date = now.AddMonths(1), Quantity = Convert.ToInt32(Product.PredictedMonthlySales[1]) });
            PredictedData.Add(new DataItem() { Date = now.AddMonths(2), Quantity = Convert.ToInt32(Product.PredictedMonthlySales[2]) });
            PredictedData.Add(new DataItem() { Date = now.AddMonths(3), Quantity = Convert.ToInt32(Product.PredictedMonthlySales[3]) });
        }
        catch
        {

        }

        /*
        PredictedData.Add(new DataItem() { Date = now, Quantity = Convert.ToInt32(Product.MonthlySales) });
        PredictedData.Add(new DataItem() { Date = now.AddMonths(1), Quantity = Convert.ToInt32(Product.MonthlySales) });
        PredictedData.Add(new DataItem() { Date = now.AddMonths(2), Quantity = Convert.ToInt32(Product.MonthlySales) });
        PredictedData.Add(new DataItem() { Date = now.AddMonths(3), Quantity = Convert.ToInt32(Product.MonthlySales) });
        */
    }

    class DataItem
    {
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IForecastingManager ForecastingManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
