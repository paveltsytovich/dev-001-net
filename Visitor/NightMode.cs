using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class NightMode : IVisitor
    {
        public void SetRelay(Relay relay)
        {
            relay.On();
        }

        public void SetRGB(RGB rgb)
        {
            rgb.setColor(0,255,0);
        }
    }
}
