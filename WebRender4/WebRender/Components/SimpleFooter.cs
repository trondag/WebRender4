using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebRender.WebRender.HTMLelements;
using WebRender4.WebRender;
using WebRender4.WebRender.Components;

namespace WebRender.WebRender.Components
{
    public class SimpleFooter : FooterTag
    {
        public SimpleFooter(params CompositeTag[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                elements[i].addCss("display: inline-block");
                composites.Add(elements[i]);
            }
            css = "margin: 0 auto;";
        }
    }
}
