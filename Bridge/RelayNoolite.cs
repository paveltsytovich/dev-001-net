using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class RelayNoolite : IRelay
    {
        public void On()
        {
            Console.WriteLine("RelayNoolite::On");
        }

        public void Off()
        {
            Console.WriteLine("RelayNoolite::Off");
        }
    }
}
