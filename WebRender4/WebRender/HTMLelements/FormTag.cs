using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebRender4.WebRender;
using WebRender4.WebRender.Components;

namespace WebRender.WebRender.HTMLelements
{
    public class FormTag : CompositeTag
    {
        public FormTag()
        {
            context = "form";
        }
    }
}
