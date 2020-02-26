using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebRender4.WebRender
{
    interface ICompositeComponentBuilder : IComponentBuilder
    {
        void addComponent(Component component);
    }
}
