using Microsoft.AspNetCore.Mvc;

namespace Asp_Net_Core_Empty_App.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}