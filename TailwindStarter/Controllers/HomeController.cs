using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TailwindStarter.Models;

namespace TailwindStarter.Controllers
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
            return View();
        }
        public IActionResult Colors()
        {
            return View();
        }
        public IActionResult ContainingSpacing()
        {
            return View();
        }
        public IActionResult Typography()
        {
            return View();
        }
        public IActionResult Sizing()
        {
            return View();
        }
        public IActionResult LayoutPosition()
        {
            return View();
        }
        public IActionResult BackgroundShadow()
        {
            return View();
        }
        public IActionResult Borders()
        {
            return View();
        }
        public IActionResult Filiters()
        {
            return View();
        }
        public IActionResult Interactivity()
        {
            return View();
        }
        public IActionResult Breakpoints()
        {
            return View();
        }
        public IActionResult Columns()
        {
            return View();
        }
        public IActionResult Flex()
        {
            return View();
        }
        public IActionResult Grid()
        {
            return View();
        }
        public IActionResult TransformTransition()
        {
            return View();
        }
        public IActionResult Animation()
        {
            return View();
        }
        public IActionResult Customization()
        {
            return View();
        }
        public IActionResult DarkMode()
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
