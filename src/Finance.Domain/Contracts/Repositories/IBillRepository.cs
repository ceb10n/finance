using Finance.Domain.Entities;
using System.Collections.Generic;

namespace Finance.Domain.Contracts.Repositories
{
    public interface IBillRepository 
    {
        void Add(Bill bill);
        IList<Bill> List();
    }
}