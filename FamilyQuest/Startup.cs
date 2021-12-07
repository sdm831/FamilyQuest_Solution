using FamilyQuest.Models;
using FamilyQuest.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FamilyQuest
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
                
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IAuthorsRepository, UsersInMemoryRepository>();            
            services.AddSingleton<ISqlRepository, SqlInMemoryRepository>();
            services.Add(new ServiceDescriptor(typeof(GameDbContext), new GameDbContext(Configuration.GetConnectionString("DbConnection"))));

            services.AddControllersWithViews();
        }
                
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {            
            app.UseStaticFiles();

            app.UseRouting();
                        
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
