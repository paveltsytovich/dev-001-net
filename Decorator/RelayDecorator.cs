using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class RelayDecorator : IControlDevice
    {
        private IControlDevice nextDevice;
        public RelayDecorator(IControlDevice nd)
        {
            if (nd == null || nd == this)
                throw new ArgumentException();
            nextDevice = nd;
        }
        public virtual void On()
        {
            nextDevice.On();
        }

        public virtual void Off()
        {
            nextDevice.Off();
        }
    }
}
