using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using rivER_web.Services;
using rivER_web.Models;

namespace rivER_web.Controllers
{
    public class HomeController : Controller
    {
        readonly IRiverAPIService riverAPIService;

        public HomeController(IRiverAPIService riverAPIService)
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

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Secure()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
