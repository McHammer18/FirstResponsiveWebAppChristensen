using FirstResponsiveWebAppChristensen.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstResponsiveWebAppChristensen.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Age = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(UserAgeModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Name = model.Name;
                ViewBag.Age = model.AgeThisYear();
            }
            else
            {
                ViewBag.Age = 0;
            }
            
            return View(model);
        }
    }
}