using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebRender4.WebRender.Components
{
    public class PTag : CompositeTag
    {

        public PTag()
        {
            context = "p";
        }

        public PTag(string innerText)
        {
            context = "p";
            this.innerText = innerText;
        }
    }
}
