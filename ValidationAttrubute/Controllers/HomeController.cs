using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ValidationAttrubute.Models;

namespace ValidationAttrubute.Controllers
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
        [HttpPost]
        public IActionResult Index(Student std)
        {
            if(ModelState.IsValid)
            {
                ModelState.Clear();
            } 
            return View();
            //if (ModelState.IsValid)
            //{
            //    return "Name is: " + std.Name;
            //}
            //else
            //{
            //    return "Validaion failed";
            //}
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

        public IActionResult hh()
        {
            return View();
        }


    }
}
