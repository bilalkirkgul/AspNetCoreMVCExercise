using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_CustomRoute
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "homePage",
                    pattern: "HomePage",
                    defaults:new { controller = "Product", action = "HomePage" });
                endpoints.MapControllerRoute(
                    name: "blog",
                    pattern: "Blog",
                    defaults: new { controller = "Product", action = "Blog" });
                endpoints.MapControllerRoute(
                   name: "about",
                   pattern: "About",
                   defaults: new { controller = "Product", action = "About" });
                endpoints.MapControllerRoute(
                   name: "default",
                   pattern: "Index2",
                   defaults: new { controller = "Home", action = "Index2" });

                endpoints.MapControllerRoute(
                    name:"defaults",
                    pattern:"{Controller=Home}/{action=Index}/{id?}"
                    );
            });
        }
    }
}
