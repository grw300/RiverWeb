using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using rivER_web.Models;
using rivER_web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rivER_web.ViewComponents
{
    public class RiverStamps : ViewComponent
    {
        readonly IRiverAPIService riverAPIService;
        public RiverStamps(IRiverAPIService riverAPIService)
        {
            this.riverAPIService = riverAPIService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var stamps = await riverAPIService.GetRiverModelsAsync<Stamp>("?include=owner-personal");
            return View(stamps);
        }
    }
}