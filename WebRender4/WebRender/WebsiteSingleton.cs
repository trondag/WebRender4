using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

    //Microsoft.Extensions.Hosting.Abstractions

namespace WebRender4
{
    public class WebsiteSingleton
    {

        static WebsiteSingleton instance;
        public WebsiteSingleton()
        {
        }
        public static void launch(String[] args)
        {
            Console.WriteLine("heeeeei" + args);
            CreateHostBuilder(args).Build().Run();
        }

        public static WebsiteSingleton getWebsiteInstance()
        {
            if (instance == null)
            {
                instance = new WebsiteSingleton();
            }
            return instance;
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
