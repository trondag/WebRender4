using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using WebRender4.WebRender;

//Microsoft.Extensions.Hosting.Abstractions

namespace WebRender4
{
    public class WebsiteSingleton : ICompositeComponentBuilder
    {

        static WebsiteSingleton instance;
        public static void launch(String[] args)
        {
            // HtmlRender().render(getWebsiteInstance);
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

        public void addComponent(Component component)
        {
            throw new NotImplementedException();
        }

        public Component createNewComponent()
        {
            throw new NotImplementedException();
        }

        public Component GetComponent()
        {
            throw new NotImplementedException();
        }

    }
}
