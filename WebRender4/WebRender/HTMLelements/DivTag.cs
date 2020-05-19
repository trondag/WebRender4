using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebRender4.WebRender.HTMLelements
{
    public class DivTag : CompositeTag
    {

        public DivTag()
        {
            context = "div";
        }

        public DivTag(string classname)
        {
            context = "div";
            className = classname;
        }

        public DivTag(params CompositeTag[] elements)
        {
            context = "div";
            foreach (CompositeTag element in elements)
            {
                composites.Add(element);
            }
        }

        public DivTag(string classname, params CompositeTag[] elements)
        {
            context = "div";
            className = classname;
            foreach (CompositeTag element in elements)
            {
                composites.Add(element);
            }
        }

        public void interpret(string context)
        {
            
        }

    }
}
