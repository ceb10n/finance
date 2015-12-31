using System;
using Microsoft.AspNet.Mvc;

namespace finance.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            throw new Exception();
            return View();
        }
    }
}