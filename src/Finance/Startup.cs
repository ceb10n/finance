using Finance.Data.Repositories;
using Finance.Domain.Contracts.Repositories;
using Microsoft.AspNet.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Finance.Data.Context;

namespace Finance
{
    public class Startup
    {   
        private readonly IConfigurationRoot _configuration;
        
        public Startup()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("config.json");
                
            _configuration = builder.Build();
        }
        
        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(_configuration.GetSection("Logging"));
            
            app.UseStaticFiles();
            
            app.UseDeveloperExceptionPage();
            
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddEntityFramework()
                    .AddSqlServer()
                    .AddDbContext<FinanceContext>();

            services.AddTransient<IBillRepository, BillRepository>();
        }
        
        static void Main(string[] args) => Microsoft.AspNet.Hosting.WebApplication.Run<Startup>(args);
    }
}
