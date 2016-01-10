using System.Collections.Generic;
using Finance.Domain.Entities;
using Microsoft.AspNet.Mvc;
using Finance.Domain.Contracts.Repositories;
using System;

namespace Finance.Controllers
{
    public class BillController : Controller
    {
        private readonly IBillRepository _billRepository;

        public BillController(IBillRepository billRepository)
        {
            _billRepository = billRepository;
        }

        public IActionResult Index()
        {
            _billRepository.Add(new Bill {
               Date = DateTime.Now,
               Value = 12.2m,
               Description = "Teste"
            });
            
            _billRepository.Add(new Bill {
               Date = DateTime.Now,
               Value = 12.2m,
               Description = "Teste"
            });
            
            _billRepository.Add(new Bill {
               Date = DateTime.Now,
               Value = 12.2m,
               Description = "Teste"
            });
            
            _billRepository.Add(new Bill {
               Date = DateTime.Now,
               Value = 12.2m,
               Description = "Teste"
            });
            
            var bills = _billRepository.List();

            return View(bills);
        }
    }
}
