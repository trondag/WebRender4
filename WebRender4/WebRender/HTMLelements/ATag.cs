using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebRender4.WebRender.HTMLelements
{
    public class ATag : CompositeTag
    {
        public ATag()
        {
            context = "a";
        }

        public ATag(string innerText, string href)
        {
            context = "a";
            this.innerText = innerText;
            this.href = href;
        }
    }
}
