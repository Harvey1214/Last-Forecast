#pragma checksum "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DisplayData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea357fa73e64349302aa951eb992500dee642495"
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
#nullable restore
#line 8 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DisplayData.razor"
 if (ForecastingManager.Results != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DisplayData.razor"
     foreach (var product in ForecastingManager.Results)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DisplayData.razor"
         if (product.Equals(OpenedProduct))
        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<LastForecastUI.Shared.Chart>(0);
            __builder.AddAttribute(1, "Product", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ForecastLibrary.ProcessOutput>(
#nullable restore
#line 14 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DisplayData.razor"
                             product

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DisplayData.razor"
                                               true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 15 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DisplayData.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<LastForecastUI.Shared.Chart>(3);
            __builder.AddAttribute(4, "Product", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ForecastLibrary.ProcessOutput>(
#nullable restore
#line 18 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DisplayData.razor"
                             product

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DisplayData.razor"
                                               false

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 19 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DisplayData.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DisplayData.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "block");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-md-4 align-items-center d-flex");
            __builder.OpenComponent<Radzen.Blazor.RadzenLabel>(10);
            __builder.AddAttribute(11, "Text", "Page Size");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col-md-8");
            __Blazor.LastForecastUI.Shared.DisplayData.TypeInference.CreateRadzenNumeric_0(__builder, 15, 16, 
#nullable restore
#line 26 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DisplayData.razor"
                                1

#line default
#line hidden
#nullable disable
            , 17, 
#nullable restore
#line 26 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DisplayData.razor"
                                        5000

#line default
#line hidden
#nullable disable
            , 18, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DisplayData.razor"
                                                                                Update

#line default
#line hidden
#nullable disable
            ), 19, 
#nullable restore
#line 26 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DisplayData.razor"
                                                           PageSize

#line default
#line hidden
#nullable disable
            , 20, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => PageSize = __value, PageSize)), 21, () => PageSize);
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n        <br>");
            __builder.CloseElement();
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "block");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "col-md-12");
            __builder.OpenComponent<Radzen.Blazor.RadzenLink>(27);
            __builder.AddAttribute(28, "Text", "Export to CSV");
            __builder.AddAttribute(29, "Path", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DisplayData.razor"
                                                    exportLink

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "Target", "_blank");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n        <br>");
            __builder.CloseElement();
            __builder.OpenComponent<Radzen.Blazor.RadzenGrid<ProcessOutput>>(32);
            __builder.AddAttribute(33, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 38 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DisplayData.razor"
                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 38 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DisplayData.razor"
                                                             FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 38 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DisplayData.razor"
                                                                                                                FilterMode.Advanced

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 38 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DisplayData.razor"
                                                                                                                                                  true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 38 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DisplayData.razor"
                                                                                                                                                                  PageSize

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 39 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DisplayData.razor"
                              true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<ProcessOutput>>(
#nullable restore
#line 39 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DisplayData.razor"
                                           ForecastingManager.Results

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "AllowColumnResize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 39 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DisplayData.razor"
                                                                                                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<ProcessOutput>>(42);
                __builder2.AddAttribute(43, "Property", "Product.Code");
                __builder2.AddAttribute(44, "Title", "Code");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<ProcessOutput>>(46);
                __builder2.AddAttribute(47, "Property", "Product.Title");
                __builder2.AddAttribute(48, "Title", "Title");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(49, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<ProcessOutput>>(50);
                __builder2.AddAttribute(51, "Property", "DaysToOrder");
                __builder2.AddAttribute(52, "Title", "Days until Stockout");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<ProcessOutput>>(54);
                __builder2.AddAttribute(55, "Property", "MonthlySales");
                __builder2.AddAttribute(56, "Title", "Monthly Sales");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(57, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<ProcessOutput>>(58);
                __builder2.AddAttribute(59, "Property", "Product.MonthToDateSales");
                __builder2.AddAttribute(60, "Title", "Month to date (qty)");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(61, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<ProcessOutput>>(62);
                __builder2.AddAttribute(63, "Property", "Product.LastMonthSales");
                __builder2.AddAttribute(64, "Title", "Last Month (qty)");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<ProcessOutput>>(66);
                __builder2.AddAttribute(67, "Property", "Product.Inventory");
                __builder2.AddAttribute(68, "Title", "Inventory");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(69, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<ProcessOutput>>(70);
                __builder2.AddAttribute(71, "Property", "Product.LeadTime");
                __builder2.AddAttribute(72, "Title", "Lead Time");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(73, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<ProcessOutput>>(74);
                __builder2.AddAttribute(75, "Property", "Product.Code");
                __builder2.AddAttribute(76, "Title", "Open");
                __builder2.AddAttribute(77, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 49 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DisplayData.razor"
                                                                                                     false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(78, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 49 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DisplayData.razor"
                                                                                                                      false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(79, "Template", (Microsoft.AspNetCore.Components.RenderFragment<ProcessOutput>)((data) => (__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(80);
                    __builder3.AddAttribute(81, "Text", "Open");
                    __builder3.AddAttribute(82, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DisplayData.razor"
                                                       args => OpenDetails(data.Product.Code)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(83, (__value) => {
#nullable restore
#line 39 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DisplayData.razor"
                                                                                                                            Table = (Radzen.Blazor.RadzenGrid<ProcessOutput>)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
#nullable restore
#line 56 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DisplayData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DisplayData.razor"
       
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ForecastingManager ForecastingManager { get; set; }
    }
}
namespace __Blazor.LastForecastUI.Shared.DisplayData
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenNumeric_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Decimal? __arg0, int __seq1, global::System.Decimal? __arg1, int __seq2, global::System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Min", __arg0);
        __builder.AddAttribute(__seq1, "Max", __arg1);
        __builder.AddAttribute(__seq2, "onchange", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
