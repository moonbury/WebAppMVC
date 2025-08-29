using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class HomeController : Controller
    {
        [ViewData]
        public string Title { get; set; }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View("Error");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult About()
        {
            Title = "About Us";
            ViewData["Message"] = "Your application description page.";

            return View();
        }

    }
}
