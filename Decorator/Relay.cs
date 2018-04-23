using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Relay : IControlDevice
    {
        public void On()
        {
            Console.WriteLine("Relay::On");
        }

        public void Off()
        {
            Console.WriteLine("Relay::Off");
        }
    }
}
