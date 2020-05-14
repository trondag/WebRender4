using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebRender4.WebRender.Components;

namespace WebRender4.WebRender.HTML
{
    public static class HtmlWriter
    {
        private static readonly StringBuilder content = new StringBuilder();
        private static readonly StringBuilder beforeAndAfter = new StringBuilder();
        private static Stack<string> endTags = new Stack<string>();
       
        private static StringBuilder writer(CompositeTag compositeComponent)
        {
            
            content.Append("<" + compositeComponent.getContext());
            if (compositeComponent.id != null)
            {
                content.Append(" id='" + compositeComponent.id + "'");
            }
            if (compositeComponent.className != null)
            {
                content.Append(" class='" + compositeComponent.className + "'");
            }
            if (compositeComponent.href != null)
            {
                content.Append(" href='" + compositeComponent.href + "'");
            }
            content.Append(">\n");

            if (compositeComponent.innerText != null)
            {
                content.Append(compositeComponent.getInnerText());
            }

            endTags.Push(compositeComponent.getContext());

            foreach (CompositeTag component in compositeComponent.composites)
            {
                writer(component);
            }

            content.Append("</" + compositeComponent.getContext() + ">");

            return content;
        }

        public static void writeToFile(CompositeTag composite)
        {
            beforeAndAfter.Append("<html>\n<head>\n<meta charset='utf-8' />\n<meta name = 'viewport' content='width=device-width, initial-scale=1.0' />\n<title>\n</title><link rel = 'stylesheet' href='~/lib/bootstrap/dist/css/bootstrap.min.css' />\n<link rel = 'stylesheet' href='~/css/site.css' />\n</head>");
            beforeAndAfter.Append(writer(composite));
            beforeAndAfter.Append("<div class='container'>\n<main role = 'main' class='pb-3'>@{ IgnoreBody(); }</main>\n</div>\n</html>");
            string sb = beforeAndAfter.ToString();
            System.IO.File.WriteAllText(@"C:\Users\Trond Arne Graabræk\source\repos\trondag\WebRender4\WebRender4\Views\Shared\_Layout.cshtml", sb);
        }
    }
}
