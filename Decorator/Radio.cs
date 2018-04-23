using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Radio : RelayDecorator
    {
        public Radio(IControlDevice nd) : base(nd)
        {          
        }
        public override void On()
        {
            Console.WriteLine("Radio is on");
            base.On();
        }
        public override void Off()
        {
            Console.WriteLine("Radio is off");
            base.Off();
        }

    }
}
