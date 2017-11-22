using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RiverWeb.Models;
using RiverWeb.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiverWeb.ViewComponents
{
    public class RiverStamps : ViewComponent
    {
        readonly IRiverApiService riverAPIService;
        public RiverStamps(IRiverApiService riverAPIService)
        {
            this.riverAPIService = riverAPIService;
        }
        public async Task<IViewComponentResult> InvokeAsync(string personnel)
        {
            var personal = await riverAPIService.GetRiverModelsAsync<Personal>($"?filter[name]=eq:{personnel}");
            var stamps = await riverAPIService.GetRiverModelByLinkAsync<Stamp>(
                personal?.FirstOrDefault().Stamps.Links["related"].Href + "?include=owner-personal");
            
            return View(stamps.OrderBy(s => s.Time));
        }
    }
}