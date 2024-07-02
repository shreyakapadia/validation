using Microsoft.AspNetCore.Mvc;

namespace ValidationAttrubute.Controllers
{
    public class s : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
