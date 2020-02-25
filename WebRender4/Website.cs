using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

    //Microsoft.Extensions.Hosting.Abstractions

namespace WebRender4
{
    public class Website
    {
        public Website(String[] args)
        {
        }
        public static void launch(String[] args)
        {
            Console.WriteLine("heeeeei" + args);
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
