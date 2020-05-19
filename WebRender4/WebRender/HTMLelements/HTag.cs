using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebRender4.WebRender.Components
{
    public class HTag : CompositeTag,  Context
    {

        public int headerLevel { get; set; }

        public HTag()
        {
            context = "h1";

            if (headerLevel > 6 || headerLevel < 1)
            {
                Console.WriteLine("Headerlevel must be between 1 and 6");
                return;
            }
            
            if (headerLevel == 1)
            {
                context = "h1";
            }
        }

        public HTag(int headerLevel, string innerText)
        {
            this.headerLevel = headerLevel;
            context = "h" + headerLevel;
            this.innerText = innerText;
        }

        public void interpret(string context)
        {
            throw new NotImplementedException();
        }

        public void setHeaderLevel(int level)
        {
            throw new NotImplementedException();
        }

    }
}
