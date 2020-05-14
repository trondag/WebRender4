using System;
using WebRender4;
using WebRender4.WebRender;
using WebRender4.WebRender.Components;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            WebRender4.Program.Main(args);

            /*
            WebsiteSingleton website = WebsiteSingleton.getWebsiteInstance();

            website.addComponent(new Header
            {
                id = "mainHeader",
                text = "Tronds Flotte Website",
                headerLevel = 1
            });


            var contentWrapper = new Div
            {
                id = "hei",
                className = "heihei"
            };

            website.addComponent(contentWrapper);

            contentWrapper.addComponent(new Paragraph
            {
                text = "Dette er min flotte nye website!"
            });

            website.build();
            WebsiteSingleton.launch(args);
            */


        }
    }
}
