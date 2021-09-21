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
        public IConfiguration _confString { get; }
        public IConfigurationRoot _confString2;
        public Startup(IConfiguration configuration, IHostEnvironment hostEnv) //IHostEnvironment hostEnv
        {
            _confString2 = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
            _confString = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Подключение к БД
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confString2.GetConnectionString("DefaultConnection")));
            // Подключение к БД
            services.AddDbContext<CESSDBContent>(options => options.UseSqlServer(_confString2.GetConnectionString("DefaultConnectionCESS")));
            // Подключение к БД
            services.AddDbContext<eCESSDBContent>(options => options.UseSqlServer(_confString2.GetConnectionString("DefaultConnectionCESS")));
            // Подключение к БД
            services.AddDbContext<OdinDBContent>(options => options.UseSqlServer(_confString2.GetConnectionString("DefaultConnectionODIN")));
            // Подключение к БД
            services.AddDbContext<BPdev1DBContent>(options => options.UseSqlServer(_confString2.GetConnectionString("DefaultConnectionBPdev1")));
            // Подключение к БД
            services.AddDbContext<CPD003DBContent>(options => options.UseSqlServer(_confString2.GetConnectionString("ConnectionCPD003")));
            // Подключение к БД
            services.AddDbContext<VALHALLADBContent>(options => options.UseSqlServer(_confString2.GetConnectionString("ValhallaConnection")));


            services.AddTransient<IALLids, QueueItemRepository>();
            //services.AddTransient<ITest, TestRepository>();
            services.AddTransient<ICessReport, CessReportRepository>();
            services.AddScoped<Cess76DoSol>();
            services.AddScoped<Access>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddMemoryCache();
            services.AddSession();
            services.AddAuthentication(IISDefaults.AuthenticationScheme);
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });

            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();
            // авторизация
            app.UseMvcWithDefaultRoute();
            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}");
                //routes.MapRoute(name: "categoryFilter", template: "{Car}/{action}/{category?}", defaults: new { Controller = "Car", action = "List" });
            });

            //using (var scope = app.ApplicationServices.CreateScope())
            //{
            //    AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
            //    DBObjects.Initial(content);
            //}
        }
    }
}
