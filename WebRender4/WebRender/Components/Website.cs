using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using WebRender4.WebRender;
using WebRender4.WebRender.Components;
using WebRender4.WebRender.HTML;

//Microsoft.Extensions.Hosting.Abstractions

namespace WebRender4
{
    public class Website : CompositeTag, Context
    {


        public Website()
        {
            context = "body";
        }

        public void interpret(string context)
        {

        }
    }
}
