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

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IUsersRepository, UsersInMemoryRepository>();
            services.AddSingleton<IExercisesRepository, ExercisesInMemoryRepository>();
            services.AddSingleton<IGamesRepository, GamesInMemoryRepository>();
            services.Add(new ServiceDescriptor(typeof(GameDbContext), new GameDbContext(Configuration.GetConnectionString()));
            //services.Add(new ServiceDescriptor(typeof(GameDbContext), new GameDbContext(Configuration.GetConnectionString("DefaultConnection"))));

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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
