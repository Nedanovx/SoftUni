using Microsoft.AspNetCore.Mvc;
using MVC_Demo.Models;
using System.Diagnostics;
using static MVC_Demo.Seeding.ProductsData;
namespace MVC_Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Message = "Hello World";
            return View(Products);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            ViewBag.Message = "This is an ASP.NET Core MVC app.";
            return View();
        }
        [HttpGet]
        public IActionResult Numbers()
        {
            return View();
        }
        public IActionResult NumbersToN(int count = -1)
        {
            ViewBag.Count = count;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
