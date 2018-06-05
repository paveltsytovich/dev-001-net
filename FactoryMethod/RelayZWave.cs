using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class RelayZWave : IRelay
    {
        public void On()
        {
            Console.WriteLine("RelayZWave::On");
        }

        public void Off()
        {
            Console.WriteLine("RelayZWave::Off");
        }
    }
}
