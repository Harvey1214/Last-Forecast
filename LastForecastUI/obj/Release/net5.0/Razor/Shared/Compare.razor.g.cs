#pragma checksum "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Compare.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1f61326e0a2856241ce846bed5a1a8d52c9b969"
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
#line 4 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Compare.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Compare.razor"
using Forecast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Compare.razor"
using ForecastLibrary;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/compare")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/compare/{IdText}")]
    public partial class Compare : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 11 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Compare.razor"
 if (Average != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class>𝕬𝖛𝖊𝖗𝖆𝖌𝖊</div>\r\n    ");
            __builder.OpenComponent<LastForecastUI.Shared.Chart>(1);
            __builder.AddAttribute(2, "Product", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ForecastLibrary.ProcessOutput>(
#nullable restore
#line 14 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Compare.razor"
                    Average

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 15 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Compare.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Compare.razor"
 if (ExponentialSmoothing != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<div class=\"algorithmTitle\">ΣXPӨПΣПƬIΛᄂ ƧMӨӨƬΉIПG</div>\r\n    ");
            __builder.OpenComponent<LastForecastUI.Shared.Chart>(4);
            __builder.AddAttribute(5, "Product", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ForecastLibrary.ProcessOutput>(
#nullable restore
#line 20 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Compare.razor"
                    ExponentialSmoothing

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "DisplayDescription", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Compare.razor"
                                                              false

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 21 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Compare.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Compare.razor"
 if (LbfgsPoissonRegression != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<div class=\"algorithmTitle\">🅻🅱🅵🅶🆂 🅿🅾🅸🆂🆂🅾🅽 🆁🅴🅶🆁🅴🆂🆂🅸🅾🅽</div>\r\n    ");
            __builder.OpenComponent<LastForecastUI.Shared.Chart>(8);
            __builder.AddAttribute(9, "Product", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ForecastLibrary.ProcessOutput>(
#nullable restore
#line 26 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Compare.razor"
                    LbfgsPoissonRegression

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "DisplayDescription", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Compare.razor"
                                                                false

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 27 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Compare.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Compare.razor"
 if (FastTreeTweedie != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(11, "<div class=\"algorithmTitle\">₣₳₴₮ ₮ⱤɆɆ ₮₩ɆɆĐłɆ</div>\r\n    ");
            __builder.OpenComponent<LastForecastUI.Shared.Chart>(12);
            __builder.AddAttribute(13, "Product", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ForecastLibrary.ProcessOutput>(
#nullable restore
#line 31 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Compare.razor"
                    FastTreeTweedie

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "DisplayDescription", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 31 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Compare.razor"
                                                         false

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 32 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Compare.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Compare.razor"
 if (FastForest != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(15, "<div class=\"algorithmTitle\">千卂丂ㄒ 千ㄖ尺乇丂ㄒ</div>\r\n    ");
            __builder.OpenComponent<LastForecastUI.Shared.Chart>(16);
            __builder.AddAttribute(17, "Product", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ForecastLibrary.ProcessOutput>(
#nullable restore
#line 36 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Compare.razor"
                    FastForest

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "DisplayDescription", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 36 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Compare.razor"
                                                    false

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 37 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Compare.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Compare.razor"
 if (Sdca != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(19, "<div class=\"algorithmTitle\">S̾d̾c̾a̾</div>\r\n    ");
            __builder.OpenComponent<LastForecastUI.Shared.Chart>(20);
            __builder.AddAttribute(21, "Product", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ForecastLibrary.ProcessOutput>(
#nullable restore
#line 41 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Compare.razor"
                    Sdca

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "DisplayDescription", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 41 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Compare.razor"
                                              false

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 42 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Compare.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\Compare.razor"
       
    [Parameter]
    public string IdText { get; set; }

    private Product Product { get; set; }

    private ProcessOutput Auto;

    private ProcessOutput Average;
    private ProcessOutput ExponentialSmoothing;

    private ProcessOutput LbfgsPoissonRegression;
    private ProcessOutput FastTreeTweedie;
    private ProcessOutput FastForest;
    private ProcessOutput Sdca;

    protected override void OnParametersSet()
    {
        int id = 0;
        bool success = Int32.TryParse(IdText, out id);

        if (success == false)
        {
            return;
        }

        var matchingProducts = ComparisonHandler.Comparisons.Where(o => o.Id == id).ToList();

        if (matchingProducts == null)
        {
            return;
        }
        if (matchingProducts.Count != 1)
        {
            return;
        }

        Product = Portal.CloneJson<Product>(matchingProducts.First().Product);
        PredictForAll();
    }

    private void PredictForAll()
    {
        //Auto = ForecastingManager.FindLatestOrderDay(Product, PredictionAlgorithm.AUTO);

        Average = ForecastingManager.FindLatestOrderDay(Product, PredictionAlgorithm.AVERAGE);
        ExponentialSmoothing = ForecastingManager.FindLatestOrderDay(Product, PredictionAlgorithm.EXPONENTIALSMOOTHING);

        LbfgsPoissonRegression = ForecastingManager.FindLatestOrderDay(Product, PredictionAlgorithm.LBFGSPOISSONREGRESSION);
        FastTreeTweedie = ForecastingManager.FindLatestOrderDay(Product, PredictionAlgorithm.FASTTREETWEEDIE);
        FastForest = ForecastingManager.FindLatestOrderDay(Product, PredictionAlgorithm.FASTFOREST);
        Sdca = ForecastingManager.FindLatestOrderDay(Product, PredictionAlgorithm.SDCA);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IForecastingManager ForecastingManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IComparisonHandler ComparisonHandler { get; set; }
    }
}
#pragma warning restore 1591