using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebRender4.WebRender
{
    public class CompositeTag
    {
        public string id { get; set; }
        public string className { get; set; }
        public bool hasClosingTag = true;
        public string context;
        public string innerText;
        public string href;
        public string css;
        public string placeholder;
        public List<CompositeTag> composites { get; set; }

        public CompositeTag()
        {
            composites = new List<CompositeTag>();
        }

        public void addComponent(CompositeTag composite)
        {
            composites.Add(composite);
        }

        public string getContext()
        {
            return this.context;
        }

        public string getInnerText()
        {
            return this.innerText;
        }

        public string getHref()
        {
            return this.href;
        }

        public void addCss(String css)
        {
            this.css = css;
        }
    }
}
