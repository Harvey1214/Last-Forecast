#pragma checksum "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Chart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "964265fbc7b438dd59eac2135374d11d94425be8"
// <auto-generated/>
#pragma warning disable 1591
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
#nullable restore
#line 10 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Chart.razor"
 if (Visible)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Chart.razor"
     if (Product != null && DisplayDescription)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddContent(1, 
#nullable restore
#line 15 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Chart.razor"
             Product.Product.Code

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(2, "\r\n            &nbsp;&nbsp;&nbsp;&nbsp;\r\n            ");
            __builder.AddContent(3, 
#nullable restore
#line 17 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Chart.razor"
             Product.Product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(4, "\r\n            &nbsp;&nbsp;&nbsp;&nbsp;\r\n            Days until stockout: ");
            __builder.AddContent(5, 
#nullable restore
#line 19 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Chart.razor"
                                  Product.DaysToOrder

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(6, "\r\n            &nbsp;&nbsp;&nbsp;&nbsp;\r\n            Monthly Sales: ");
            __builder.AddContent(7, 
#nullable restore
#line 21 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Chart.razor"
                            Product.MonthlySales

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(8, "\r\n            &nbsp;&nbsp;&nbsp;&nbsp;\r\n            Inventory: ");
            __builder.AddContent(9, 
#nullable restore
#line 23 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Chart.razor"
                        Product.Product.Inventory

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(10, "\r\n            &nbsp;&nbsp;&nbsp;&nbsp;\r\n            Prediction Algorithm: ");
            __builder.AddContent(11, 
#nullable restore
#line 25 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Chart.razor"
                                   Product.PredictionAlgorithm.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 27 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Chart.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "row");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-md-6 col-sm-12 p-4");
            __builder.OpenComponent<Radzen.Blazor.RadzenChart>(16);
            __builder.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __Blazor.LastForecastUI.Shared.Chart.TypeInference.CreateRadzenAreaSeries_0(__builder2, 18, 19, 
#nullable restore
#line 32 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Chart.razor"
                                           smooth

#line default
#line hidden
#nullable disable
                , 20, 
#nullable restore
#line 32 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Chart.razor"
                                                          Data

#line default
#line hidden
#nullable disable
                , 21, "Date", 22, "Sold", 23, "Quantity");
                __builder2.AddMarkupContent(24, "\r\n                ");
                __Blazor.LastForecastUI.Shared.Chart.TypeInference.CreateRadzenAreaSeries_1(__builder2, 25, 26, 
#nullable restore
#line 34 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Chart.razor"
                                           smooth

#line default
#line hidden
#nullable disable
                , 27, 
#nullable restore
#line 34 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Chart.razor"
                                                          PredictedData

#line default
#line hidden
#nullable disable
                , 28, "Date", 29, "Prediction", 30, "Quantity", 31, 
#nullable restore
#line 34 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Chart.razor"
                                                                                                                                                       LineType.Dashed

#line default
#line hidden
#nullable disable
                , 32, 
#nullable restore
#line 34 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Chart.razor"
                                                                                                                                                                                        1

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(33, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenCategoryAxis>(34);
                __builder2.AddAttribute(35, "Padding", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 36 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Chart.razor"
                                             20

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "FormatString", "{0:MMM}");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenValueAxis>(38);
                __builder2.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridLines>(40);
                    __builder3.AddAttribute(41, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 38 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Chart.razor"
                                              true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(42, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenAxisTitle>(43);
                    __builder3.AddAttribute(44, "Text", "Quantity");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(45, (__value) => {
#nullable restore
#line 31 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Chart.razor"
                               SalesChart = (Radzen.Blazor.RadzenChart)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 48 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Chart.razor"
}

#line default
#line hidden
#nullable disable
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
namespace __Blazor.LastForecastUI.Shared.Chart
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenAreaSeries_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.Collections.Generic.IEnumerable<TItem> __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenAreaSeries<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Smooth", __arg0);
        __builder.AddAttribute(__seq1, "Data", __arg1);
        __builder.AddAttribute(__seq2, "CategoryProperty", __arg2);
        __builder.AddAttribute(__seq3, "Title", __arg3);
        __builder.AddAttribute(__seq4, "ValueProperty", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateRadzenAreaSeries_1<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.Collections.Generic.IEnumerable<TItem> __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::Radzen.Blazor.LineType __arg5, int __seq6, global::System.Int32 __arg6)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenAreaSeries<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Smooth", __arg0);
        __builder.AddAttribute(__seq1, "Data", __arg1);
        __builder.AddAttribute(__seq2, "CategoryProperty", __arg2);
        __builder.AddAttribute(__seq3, "Title", __arg3);
        __builder.AddAttribute(__seq4, "ValueProperty", __arg4);
        __builder.AddAttribute(__seq5, "LineType", __arg5);
        __builder.AddAttribute(__seq6, "RenderingOrder", __arg6);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
