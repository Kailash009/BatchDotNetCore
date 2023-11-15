using BatchMithilesh11AMWE.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BatchMithilesh11AMWE.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int id)
        {
            return View();
        }

        public int getID(int id)
        {
            return id;
        }
        public string getcity(string city)
        {
            return city;
        }

        public IActionResult Privacy()
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