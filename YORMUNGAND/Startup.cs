using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using YORMUNGAND.Data;
using YORMUNGAND.Data.Interfaces;
using Microsoft.Extensions.Hosting;
using YORMUNGAND.Data.Repository;
using YORMUNGAND.Data.Models;
using Microsoft.AspNetCore.Server.IISIntegration;


namespace YORMUNGAND
{
    public class Startup
    {
        // Конфигурация
        private IConfigurationRoot _confString;
        public Startup(IHostEnvironment hostEnv)
        {
            _confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Подключение к БД
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));
            services.AddTransient<IALLids, QueueItemRepository>();
            //services.AddTransient<Ids, QueueItemRepository>();
            services.AddScoped<Cess76DoSol>();

            //services.AddTransient<Icess76int, Cess76IntRepository>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //services.AddScoped(sp => ShopCart.GetCart(sp));

            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddMemoryCache();
            services.AddSession();
            services.AddAuthentication(IISDefaults.AuthenticationScheme);


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();
            // авторизация
            app.UseAuthorization();
            app.UseMvcWithDefaultRoute();
            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}");
                routes.MapRoute(name: "categoryFilter", template: "{Car}/{action}/{category?}", defaults: new { Controller = "Car", action = "List" });
            });

            //using (var scope = app.ApplicationServices.CreateScope())
            //{
            //    AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
            //    DBObjects.Initial(content);
            //}
        }
    }
}
