using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebRender4.WebRender.Components
{
    interface Context
    {
        string getContext();


        public void interpret(string context);
    }
}
