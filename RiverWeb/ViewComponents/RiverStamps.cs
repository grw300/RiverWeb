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
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var stamps = await riverAPIService.GetRiverModelsAsync<Stamp>("?include=owner-personal");
            return View(stamps);
        }
    }
}