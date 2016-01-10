using Finance.Data.Context;
using Finance.Domain.Contracts.Repositories;
using Finance.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Finance.Data.Repositories
{
    public class BillRepository : IBillRepository
    {
        private readonly FinanceContext _context;

        public BillRepository(FinanceContext context)
        {
            _context = context;
        }

        public void Add(Bill bill) 
        {
            _context.Bills.Add(bill);
            _context.SaveChanges();    
        }

        public IList<Bill> List()
        {
            return _context.Bills.ToList();
        }
    }
}