using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.AspNetCore.Server.IISIntegration;

namespace ASP_tut_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //using ( var host = WebHost.Start("http://localhost:8080", context => context.Response.WriteAsync("Hello World!")))
            //{
            //    Console.WriteLine("Application has been started");
            //    host.WaitForShutdown();
            //}


            //BuildWebHost(args).Run();


            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .CaptureStartupErrors(true)
                .UseSetting("detailedErrors", "true")
                .Build();

            host.Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args) //IWebHostBuilder
                .UseStartup<Startup>()
                .UseIISIntegration()
                .Build();
    }
}
