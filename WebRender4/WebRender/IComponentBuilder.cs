using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebRender4.WebRender
{
    interface IComponentBuilder
    {
        Component createNewComponent();
        Component GetComponent();
        void setText();
    }
}
