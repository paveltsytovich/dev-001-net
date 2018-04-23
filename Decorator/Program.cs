using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IControlDevice simpleRelay = new Relay();
            simpleRelay.On();
            IControlDevice relayWithRadio =
                new Radio(simpleRelay);
            relayWithRadio.On();

            IControlDevice extendRelay =
                new ExtendLight(simpleRelay);
            extendRelay.On();
            IControlDevice bigRelay =
                new ExtendLight(
                    new Radio(simpleRelay)
                    );
            bigRelay.On();
            Console.ReadKey();
        }
    }
}
