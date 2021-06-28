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
            //CoreMVC oldu�unu belirttim..
            services.AddControllersWithViews();
        }

       
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //bu yap�lar� kullan.
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();//css js dosyalar� i�in tan�mlan�r
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //a��l�r sayfa ayarlamas�n� yapt�m..
                endpoints.MapControllerRoute(
                    name: "defaults",
                    pattern: "{controller=Home}/{action=Index}/{id?}" //�d opsiyoneldir
                    );
            });
        }
    }
}
