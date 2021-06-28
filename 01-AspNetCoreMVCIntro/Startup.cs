using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_AspNetCoreMVCIntro
{
    public class Startup
    {
 
        public void ConfigureServices(IServiceCollection services)
        {
            //bu servisleri ekle
            //CoreMVC olduðunu belirttim..
            services.AddControllersWithViews();
        }

       
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //bu yapýlarý kullan.
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();//css js dosyalarý için tanýmlanýr
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //açýlýr sayfa ayarlamasýný yaptým..
                endpoints.MapControllerRoute(
                    name: "defaults",
                    pattern: "{controller=Home}/{action=Index}/{id?}" //ýd opsiyoneldir
                    );
            });
        }
    }
}
