using System;

namespace Finance.Domain.Entities
{
    public class Bill 
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        
        public Bill(string description, decimal value) 
        {
            if (value <= 0)
                throw new Exception("Value can't be lower than zero");
            
            Description = description;
            Value = value;
        }
    }
}