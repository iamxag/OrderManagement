using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OrderManagement.UI.Models;

namespace OrderManagement.UI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        private readonly IConfiguration _configuration;
        public Startup(IConfiguration conf)
        {
            _configuration = conf;           
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDbContext<AppDbContext>(options =>
               options.UseSqlServer(_configuration.GetConnectionString("SQLDB")));

            //services.AddScoped<IProductRepository, MockProductRepository>();
            //services.AddScoped<ICategoryRepository, MockCategoryRepository>();
            services.AddScoped<IProductRepository, SQLProductRepository>();
            services.AddScoped<ICategoryRepository, SQLCategoryRepository>();
            //services.AddTransient<IProductRepository, SQLProductRepository>();
            //services.AddSingleton<IProductRepository, SQLProductRepository>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseRouting();
            
            // https://www.ordermangememt.com/Product/List/
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    //website/homecontroller/index/
                    pattern: "{controller=home}/{action=Index}/{id?}");
                //endpoints.MapGet("/", async context =>
                //{
                //await context.Response.WriteAsync(_configuration.GetConnectionString("SQLDB"));
                //await context.Response.WriteAsync("Hi ABDU! \n" + "Hosting Server : " +  System.Diagnostics.Process.GetCurrentProcess().ProcessName );
                //});
            });
        }
    }
}
