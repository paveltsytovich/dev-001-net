using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class DayMode : IVisitor
    {
        public void SetRelay(Relay relay)
        {
            relay.Off();
        }

        public void SetRGB(RGB rgb)
        {
            rgb.setColor(0,0,0);
        }
    }
}
