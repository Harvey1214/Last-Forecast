#pragma checksum "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\FilesUpload.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef7d2083612ab5aa9ee1a728d85e74acfa67bcb0"
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
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\FilesUpload.razor"
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
            __builder.AddAttribute(1, "class", "cursor");
            __builder.AddAttribute(2, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\FilesUpload.razor"
                                     LoadFiles

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "multiple", true);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(5);
            __builder.AddAttribute(6, "Text", "Continue");
            __builder.AddAttribute(7, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\FilesUpload.razor"
                                      Continue

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n\r\n");
            __builder.OpenElement(9, "p");
            __builder.AddContent(10, 
#nullable restore
#line 11 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\FilesUpload.razor"
    exceptionMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 13 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\FilesUpload.razor"
 if (isLoading)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(11, "<p>Loading...</p>");
#nullable restore
#line 16 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\FilesUpload.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\FilesUpload.razor"
 foreach (var (file, content) in loadedFiles)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "div");
            __builder.AddMarkupContent(13, "\r\n        Name: ");
            __builder.AddContent(14, 
#nullable restore
#line 21 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\FilesUpload.razor"
               file.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(15, "\r\n        <br>\r\n        Size (bytes): ");
            __builder.AddContent(16, 
#nullable restore
#line 23 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\FilesUpload.razor"
                       file.Size

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(17, "\r\n        <br>\r\n        <br>");
            __builder.CloseElement();
#nullable restore
#line 27 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\FilesUpload.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\FilesUpload.razor"
       
    private Dictionary<IBrowserFile, string> loadedFiles = new Dictionary<IBrowserFile, string>();
    private long maxFileSize = 1024 * 1500;
    private int maxAllowedFiles = 2;
    private bool isLoading;
    string exceptionMessage;

    [Parameter]
    public Pages.ForecastPage Forecast { get; set; }

    private void Continue()
    {
        if (loadedFiles.Count == 2)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\FilesUpload.razor"
             foreach (var (file, content) in loadedFiles)
            {
                string[] lines = content.Split(new[] { Environment.NewLine, "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);
                DataStorage.RawData.Add(new RawData() { Name = file.Name, Content = lines});

                if (Forecast != null)
                    Forecast.DataSetup();
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\mikuh\source\repos\LastForecast\LastForecastUI\Shared\FilesUpload.razor"
             
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
