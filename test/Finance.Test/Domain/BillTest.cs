using Finance.Domain.Entities;
using System;
using Xunit;

namespace Finance.Test 
{
    public class BillTest 
    {
        [Fact]
        public void ShouldCreateNewBill()
        {
            var bill = new Bill("bill", 123m);
            
            Assert.Equal(bill.Description, "bill");
            Assert.Equal(bill.Value, 123m);
        }
        
        [Fact]
        public void ShouldNotAllowValuesLowerOrEqualToZero() 
        {
            Assert.Throws<Exception>(() => new Bill("zero value", 0m));
            Assert.Throws<Exception>(() => new Bill("zero value", -1m));
        }
    }    
}