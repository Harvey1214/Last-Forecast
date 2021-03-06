#pragma checksum "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DataSetup.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85037ca330223ffdd6bd957f4f38656941bc85b7"
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
            __builder.OpenComponent<Radzen.Blazor.RadzenFieldset>(0);
            __builder.AddAttribute(1, "Text", "General");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "block");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "col-md-4 align-items-center d-flex");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(7);
                __builder2.AddAttribute(8, "Text", "Inventory File");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "col-md-8");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDropDown<string>>(12);
                __builder2.AddAttribute(13, "AllowClear", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DataSetup.razor"
                                        false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.IEnumerable>(
#nullable restore
#line 15 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DataSetup.razor"
                                   DataStorage.GetFileNames()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddComponentReferenceCapture(15, (__value) => {
#nullable restore
#line 14 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DataSetup.razor"
                                                                     inventoryFileChooseDropDown = (Radzen.Blazor.RadzenDropDown<string>)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n    ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "block");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "col-md-4 align-items-center d-flex");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(21);
                __builder2.AddAttribute(22, "Text", "Sales File");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n        ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "col-md-8");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDropDown<string>>(26);
                __builder2.AddAttribute(27, "AllowClear", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DataSetup.razor"
                                        false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.IEnumerable>(
#nullable restore
#line 24 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DataSetup.razor"
                                   DataStorage.GetFileNames()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddComponentReferenceCapture(29, (__value) => {
#nullable restore
#line 23 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DataSetup.razor"
                                                                     salesFileChooseDropDown = (Radzen.Blazor.RadzenDropDown<string>)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n    ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "block");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "col-md-4 align-items-center d-flex");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(35);
                __builder2.AddAttribute(36, "Text", "Separator Char");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "col-md-8");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDropDown<string>>(40);
                __builder2.AddAttribute(41, "AllowClear", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DataSetup.razor"
                                        false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.IEnumerable>(
#nullable restore
#line 33 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DataSetup.razor"
                                   new List<string>() {",", ";"}

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddComponentReferenceCapture(43, (__value) => {
#nullable restore
#line 32 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DataSetup.razor"
                                                                     separatorCharacterDropDown = (Radzen.Blazor.RadzenDropDown<string>)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(44, "\r\n\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenFieldset>(45);
            __builder.AddAttribute(46, "Text", "Inventory");
            __builder.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "block");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "col-md-4 align-items-center d-flex");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(52);
                __builder2.AddAttribute(53, "Text", "Product code");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n        ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "col-md-8");
                __builder2.OpenComponent<Radzen.Blazor.RadzenNumeric<int>>(57);
                __builder2.AddComponentReferenceCapture(58, (__value) => {
#nullable restore
#line 44 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DataSetup.razor"
                                              productIdInventory = (Radzen.Blazor.RadzenNumeric<int>)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n    ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "block");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "col-md-4 align-items-center d-flex");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(64);
                __builder2.AddAttribute(65, "Text", "Product Title");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n        ");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "col-md-8");
                __builder2.OpenComponent<Radzen.Blazor.RadzenNumeric<int>>(69);
                __builder2.AddComponentReferenceCapture(70, (__value) => {
#nullable restore
#line 52 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DataSetup.razor"
                                              productTitle = (Radzen.Blazor.RadzenNumeric<int>)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n    ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "block");
                __builder2.OpenElement(74, "div");
                __builder2.AddAttribute(75, "class", "col-md-4 align-items-center d-flex");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(76);
                __builder2.AddAttribute(77, "Text", "Inventory on hand");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n        ");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "col-md-8");
                __builder2.OpenComponent<Radzen.Blazor.RadzenNumeric<int>>(81);
                __builder2.AddComponentReferenceCapture(82, (__value) => {
#nullable restore
#line 60 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DataSetup.razor"
                                              inventoryOnHand = (Radzen.Blazor.RadzenNumeric<int>)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n    ");
                __builder2.OpenElement(84, "div");
                __builder2.AddAttribute(85, "class", "block");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "col-md-4 align-items-center d-flex");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(88);
                __builder2.AddAttribute(89, "Text", "Lead time");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n        ");
                __builder2.OpenElement(91, "div");
                __builder2.AddAttribute(92, "class", "col-md-8");
                __builder2.OpenComponent<Radzen.Blazor.RadzenNumeric<int>>(93);
                __builder2.AddComponentReferenceCapture(94, (__value) => {
#nullable restore
#line 68 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DataSetup.razor"
                                              leadTime = (Radzen.Blazor.RadzenNumeric<int>)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(95, "\r\n\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenFieldset>(96);
            __builder.AddAttribute(97, "Text", "Sales");
            __builder.AddAttribute(98, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(99, "div");
                __builder2.AddAttribute(100, "class", "block");
                __builder2.OpenElement(101, "div");
                __builder2.AddAttribute(102, "class", "col-md-4 align-items-center d-flex");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(103);
                __builder2.AddAttribute(104, "Text", "Product code");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n        ");
                __builder2.OpenElement(106, "div");
                __builder2.AddAttribute(107, "class", "col-md-8");
                __builder2.OpenComponent<Radzen.Blazor.RadzenNumeric<int>>(108);
                __builder2.AddComponentReferenceCapture(109, (__value) => {
#nullable restore
#line 79 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DataSetup.razor"
                                              productIdSales = (Radzen.Blazor.RadzenNumeric<int>)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\r\n    ");
                __builder2.OpenElement(111, "div");
                __builder2.AddAttribute(112, "class", "block");
                __builder2.OpenElement(113, "div");
                __builder2.AddAttribute(114, "class", "col-md-4 align-items-center d-flex");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(115);
                __builder2.AddAttribute(116, "Text", "Date");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(117, "\r\n        ");
                __builder2.OpenElement(118, "div");
                __builder2.AddAttribute(119, "class", "col-md-8");
                __builder2.OpenComponent<Radzen.Blazor.RadzenNumeric<int>>(120);
                __builder2.AddComponentReferenceCapture(121, (__value) => {
#nullable restore
#line 87 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DataSetup.razor"
                                              date = (Radzen.Blazor.RadzenNumeric<int>)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\r\n    ");
                __builder2.OpenElement(123, "div");
                __builder2.AddAttribute(124, "class", "block");
                __builder2.OpenElement(125, "div");
                __builder2.AddAttribute(126, "class", "col-md-4 align-items-center d-flex");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(127);
                __builder2.AddAttribute(128, "Text", "Units sold");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(129, "\r\n        ");
                __builder2.OpenElement(130, "div");
                __builder2.AddAttribute(131, "class", "col-md-8");
                __builder2.OpenComponent<Radzen.Blazor.RadzenNumeric<int>>(132);
                __builder2.AddComponentReferenceCapture(133, (__value) => {
#nullable restore
#line 95 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DataSetup.razor"
                                              unitsSold = (Radzen.Blazor.RadzenNumeric<int>)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(134, "\r\n\r\n");
            __builder.OpenElement(135, "div");
            __builder.AddAttribute(136, "class", "continueButton");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(137);
            __builder.AddAttribute(138, "Text", "Continue");
            __builder.AddAttribute(139, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 101 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DataSetup.razor"
                                         Continue

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 104 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\DataSetup.razor"
       
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

    private void Continue()
    {
        ImportManager importManager = new ImportManager(
            splitBy: char.Parse(separatorCharacterDropDown.SelectedItem.ToString()),
            forecastingManager: ForecastingManager);

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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ForecastingManager ForecastingManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataStorage DataStorage { get; set; }
    }
}
#pragma warning restore 1591
