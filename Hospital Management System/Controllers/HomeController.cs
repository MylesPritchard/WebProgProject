using Hospital_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Hospital_Management_System.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() //homepage
        {
            return View();
        }

        public IActionResult Contact() //contact info
        {
            return View();
        }

		public IActionResult COVID() //covid-19 protocol
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
