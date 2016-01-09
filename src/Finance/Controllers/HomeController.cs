using Microsoft.AspNet.Mvc;

namespace Finance.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}