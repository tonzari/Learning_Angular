using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PluralSight_AngularCourse.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PluralSight_AngularCourse
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IMailService, NullMailService>(); // custom service made for a mail service

            services.AddControllersWithViews()
                .AddRazorRuntimeCompilation(); // Needs a NuGet package: Mvc.Razor.RuntimeComp...
            services.AddRazorPages(); // this is needed to use Razor Pages. Make sure to also opt in to Razor Pages in the Endpoint config below
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
                app.UseExceptionHandler("/error"); // this will be handled with a Razor Page (not a view!)
            }

            // middleware
            // app.UseDefaultFiles(); // this will find your index.html file (but DOES NOT serve it)
            app.UseStaticFiles(); // this doesn't find anything, but gives you the ability to serve the static site

            // Enabling MVC

            app.UseRouting();

            app.UseEndpoints(cfg =>
            {
                cfg.MapRazorPages(); // Needed to enable Razor Pages

                cfg.MapControllerRoute("Default",
                    "/{controller}/{action}/{id?}",
                    new { controller = "App", action = "Index" });
            });
        }
    }
}
