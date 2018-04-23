using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class ExtendLight : RelayDecorator
    {
        public ExtendLight(IControlDevice nd) : base(nd)
        {

        }
        public override void On()
        {
            Console.WriteLine("Extend light is on");
            base.On();
        }
        public override void Off()
        {
            Console.WriteLine("Extend light is off");
            base.Off();
        }
    }
}
