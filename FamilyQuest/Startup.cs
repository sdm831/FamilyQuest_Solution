using FamilyQuest.Models;
using FamilyQuest.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            //services.AddSingleton<ITaskPointsRepository, TaskPointsInMemoryRepository>();            
            //services.AddSingleton<IGamesRepository, GamesInMemoryRepository>();
            services.AddSingleton<ISqlRepository, SqlInMemoryRepository>();
            services.Add(new ServiceDescriptor(typeof(GameDbContext), new GameDbContext(Configuration.GetConnectionString("DefaultConnection"))));

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
