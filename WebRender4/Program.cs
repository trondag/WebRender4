using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using WebRender4.WebRender.Components;
using WebRender4.WebRender.HTML;
using WebRender4.WebRender.HTMLelements;

namespace WebRender4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Website website = new Website();

            website.addComponent(new HTag
            {
                id = "mainHeader",
                innerText = "Tronds Flotte Website",
                headerLevel = 1
            });

            website.addComponent(new NavBar(new ATag("Hjem", "index.html"), new ATag("Om oss", "om_oss.html")));
            website.addComponent(new Article(File.ReadAllText("dummy-text.txt")));


            HtmlWriter.writeToFile(website);


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
