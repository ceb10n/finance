using System.Collections.Generic;
using Finance.Domain.Entities;
using Microsoft.AspNet.Mvc;

namespace Finance.Controllers
{
    public class BillController : Controller
    {
        public IActionResult Index()
        {
            var bills = new List<Bill> 
            {
                new Bill ("First Bill", 10.0m),
                new Bill ("Second Bill", 12.0m),
            };
            
            return View(bills);
        }
    }
}
