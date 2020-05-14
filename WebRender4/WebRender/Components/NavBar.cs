using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebRender4.WebRender.HTMLelements;

namespace WebRender4.WebRender.Components
{
    public class NavBar : NavTag
    {
        public NavBar(params ATag[] aTags)
        {
            for (int i = 0; i < aTags.Length; i++)
            {
            composites.Add(aTags[i]);
            }
        }
    }
}
