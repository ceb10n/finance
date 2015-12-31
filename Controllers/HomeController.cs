using Microsoft.AspNet.Mvc;

namespace finance.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}