#pragma checksum "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\FilesUpload.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0abe38ef8cf7441617a4e789dca94ed891bc1c2"
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
#line 1 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\FilesUpload.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\FilesUpload.razor"
using Data;

#line default
#line hidden
#nullable disable
    public partial class FilesUpload : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(0);
            __builder.AddAttribute(1, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\FilesUpload.razor"
                      LoadFiles

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(2, "multiple", true);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(4);
            __builder.AddAttribute(5, "Text", "Continue");
            __builder.AddAttribute(6, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\FilesUpload.razor"
                                      Continue

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenElement(8, "p");
            __builder.AddContent(9, 
#nullable restore
#line 10 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\FilesUpload.razor"
    exceptionMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 12 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\FilesUpload.razor"
 if (isLoading)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, "<p>Loading...</p>");
#nullable restore
#line 15 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\FilesUpload.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\FilesUpload.razor"
 foreach (var (file, content) in loadedFiles)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "div");
            __builder.AddMarkupContent(12, "\r\n        Name: ");
            __builder.AddContent(13, 
#nullable restore
#line 20 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\FilesUpload.razor"
               file.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(14, "\r\n        <br>\r\n        Size (bytes): ");
            __builder.AddContent(15, 
#nullable restore
#line 22 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\FilesUpload.razor"
                       file.Size

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(16, "\r\n        <br>\r\n        <br>");
            __builder.CloseElement();
#nullable restore
#line 26 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\FilesUpload.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\FilesUpload.razor"
       
    private Dictionary<IBrowserFile, string> loadedFiles = new Dictionary<IBrowserFile, string>();
    private long maxFileSize = 1024 * 1500;
    private int maxAllowedFiles = 2;
    private bool isLoading;
    string exceptionMessage;

    [Parameter]
    public Pages.Forecast Forecast { get; set; }

    private void Continue()
    {
        if (loadedFiles.Count == 2)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\FilesUpload.razor"
             foreach (var (file, content) in loadedFiles)
            {
                DataStorage.RawData.Add(new RawData() { Name = file.Name, Content = file.ReadAsList().Result.ToArray() }); 

                if (Forecast != null)
                    Forecast.DataSetup();
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\FilesUpload.razor"
             
        }
        else
        {
            exceptionMessage = "Please select two files";
        }
    }

    async Task LoadFiles(InputFileChangeEventArgs e)
    {
        isLoading = true;
        loadedFiles.Clear();
        exceptionMessage = string.Empty;

        try
        {
            foreach (var file in e.GetMultipleFiles(maxAllowedFiles))
            {
                using var reader =
                    new StreamReader(file.OpenReadStream(maxFileSize));

                loadedFiles.Add(file, await reader.ReadToEndAsync());
            }
        }
        catch (Exception ex)
        {
            exceptionMessage = ex.Message;
        }

        isLoading = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataStorage DataStorage { get; set; }
    }
}
#pragma warning restore 1591
