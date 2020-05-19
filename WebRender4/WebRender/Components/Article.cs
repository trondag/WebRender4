using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebRender4.WebRender.HTMLelements;

namespace WebRender4.WebRender.Components
{
    public class Article : ArticleTag
    {
        public HTag header;
        public ArticleTag article;
        public Article(string text)
        {
            article = new ArticleTag();
            article.addComponent(new PTag(text));
            composites.Add(article);
        }
    }
}
