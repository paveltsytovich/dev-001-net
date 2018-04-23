using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    interface IRelay
    {
        void On();
        void Off();
        DateTime GetOnTime();
    }
}
