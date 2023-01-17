using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SmallBootCamp.Models;

namespace SmallBootCamp.Controllers
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
            return View(nameof(BootCamp));
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult BootCamp()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}