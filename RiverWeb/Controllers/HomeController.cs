using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RiverWeb.Services;
using RiverWeb.Models;

namespace RiverWeb.Controllers
{
    public class HomeController : Controller
    {
        readonly IRiverApiService riverAPIService;

        public HomeController(IRiverApiService riverAPIService)
        {
            this.riverAPIService = riverAPIService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            //na

            return View();
        }

        public IActionResult FirstExperiment()
        {
            return View();
        }
        public IActionResult SecondExperiment()
        {
            return View();
        }
        public IActionResult ThirdExperiment()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
