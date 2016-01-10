using Finance.Domain.Entities;
using Microsoft.Data.Entity;
using Microsoft.Extensions.Configuration;

namespace Finance.Data.Context
{
    public class FinanceContext : DbContext
    {
        public FinanceContext() 
        {
            Database.EnsureCreated();    
        }
        
        public DbSet<Bill> Bills { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("config.json");
                
            var configuration = builder.Build();
            var connectionString = configuration["Data:ConnectionString"];

            optionsBuilder.UseSqlServer(connectionString);
            
            base.OnConfiguring(optionsBuilder);
        } 
    }  
}