using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace ASP_tut_1
{
    public class Startup
    {
        public Startup()
        {
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseMiddleware<ErrorHandlingMiddleware>();
            //app.UseMiddleware<TokenMiddleware>();
            app.UseToken("555");



            /*app.Map("/home", home =>
            {
                home.Map("/about", About);
            });

            app.Map("/index", (appBuilder) =>
            {
                appBuilder.Run(async (context) => await context.Response.WriteAsync("<h2>Home Page</h2>"));
            });*/


            //app.UseMvc();


            //app.Map("/about", About);

            /*app.Use(async (context, next) =>
            {
                await next();
                await context.Response.WriteAsync(
                $"<h3>Hello!</h3>"
                );
            });*/

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(Handle);
        }


        /*private void About(IApplicationBuilder app)
        {
            app.Run(async (context) => await context.Response.WriteAsync("<h2>About Page</h2>"));
        }*/


        private async Task Handle(HttpContext context)
        {
            var req = context.Request;
            string host = req.Host.Value;
            string path = req.Path;
            string query = req.QueryString.Value;

            context.Response.ContentType = "text/html;charset=utf-8";
            await context.Response.WriteAsync(
                $"<h3>Hello!</h3>" +
                $"<h3>host :{host}</h3>" +
                $"<h3>path :{path}</h3>" +
                $"<h3>query :{query}</h3>"
                );
        }
    }
}
