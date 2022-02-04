using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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

        private IConfiguration _configuration;
        private IProductRepository _productRepository;
        public Startup(IConfiguration conf)
        {
            _configuration = conf;           
        }
        public void ConfigureServices(IServiceCollection services)
        {
            //IProductRepository productRepository = new MockProductRepository();
            //ICategoryRepository categoryRepository = new MockCategoryRepository();
            services.AddControllersWithViews();
            services.AddScoped<IProductRepository, MockProductRepository>();
            services.AddScoped<ICategoryRepository, MockCategoryRepository>();
            //services.AddTransient<ICategoryRepository, MockCategoryRepository>();
            //services.AddSingleton<ICategoryRepository, MockCategoryRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("MiddleWare1: Incomming Request\n");
            //    await next();
            //    await context.Response.WriteAsync("MiddleWare1: Outcomming Request\n");
            //});
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("MiddleWare2: Incomming Request\n");
            //    await next();
            //    await context.Response.WriteAsync("MiddleWare2: Outcomming Request\n");
            //});
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("MiddleWare3: Incomming Request\n");
            //    await next();
            //    await context.Response.WriteAsync("MiddleWare3: Outcomming Request\n");
            //});

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            // https://www.ordermangememt.com/Product/List/
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
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
