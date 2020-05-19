using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.IO;
using WebRender.WebRender.Components;
using WebRender.WebRender.HTMLelements;
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

            website.addComponent(new HTag(1, "Min Webside"));

            website.addComponent(new NavBar(new ATag("Hjem", "index.html"), new ATag("Om oss", "om_oss.html")));

            FormTag form = new FormTag();
            InputTag nameInput = new InputTag(InputType.TEXT_INPUT, "Navnet ditt her");
            form.addComponent(nameInput);
            InputTag telephoneInput = new InputTag(InputType.NUMBER_INPUT, "Ditt nummer her");
            form.addComponent(telephoneInput);
            website.addComponent(form);


            DivTag mor = new DivTag("row");
            DivTag barn1 = new DivTag("col-6", new PTag(File.ReadAllText("dummy-text.txt")));
            mor.addComponent(barn1);
            DivTag barn2 = new DivTag("col-6", new PTag(File.ReadAllText("dummy-text.txt")));
            mor.addComponent(barn2);
            website.addComponent(mor);


            website.addComponent(new SimpleFooter(new PTag("mob: 12345678"), new PTag("adr: Siste Reis 45a")));

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
