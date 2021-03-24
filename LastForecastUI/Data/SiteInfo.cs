using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LastForecastUI.Data
{
    public class SiteInfo : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public SiteInfo(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            string webRootPath = _webHostEnvironment.WebRootPath;
            string contentRootPath = _webHostEnvironment.ContentRootPath;

            string path = "";
            path = Path.Combine(webRootPath);
            //or path = Path.Combine(contentRootPath , "wwwroot" ,"CSS" );
            return View();
        }
    }
}
