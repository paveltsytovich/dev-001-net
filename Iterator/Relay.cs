using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Relay : IRelay
    {
        private DateTime onTime;
        public void On()
        {
            Console.WriteLine("Relay::On");
            onTime = DateTime.Now;
        }

        public void Off()
        {
            Console.WriteLine("Relay::Off");
            onTime = DateTime.MaxValue;
        }

        public DateTime GetOnTime()
        {
            return onTime;
        }
    }
}
