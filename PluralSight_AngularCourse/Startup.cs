using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
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
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {   /*
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }*/

            /*            app.UseRouting();

                        app.UseEndpoints(endpoints =>
                        {
                            endpoints.MapGet("/", async context => // this "/" sends a request to the root of the web server
                            {
                                await context.Response.WriteAsync("Hello World!");
                            });
                        });*/

            // simply, you could just run this instead of the code above.
            // This doesn't care at all what you through in the URL... this is simply just responding to ANY request.
            app.Run(async context =>
            {
                await context.Response.WriteAsync("HelloooOOOoOOooo!");
            });
        }
    }
}
