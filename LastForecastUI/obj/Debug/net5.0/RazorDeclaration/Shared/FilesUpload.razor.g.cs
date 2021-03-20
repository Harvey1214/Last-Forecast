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
    public Pages.Forecast Forecast { get; set; }

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
                string[] lines = content.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
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
