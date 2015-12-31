using Microsoft.AspNet.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace finance
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
        }
        
        static void Main(string[] args) => Microsoft.AspNet.Hosting.WebApplication.Run<Startup>(args);
    }
}
