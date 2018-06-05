﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    interface ISmartServiceFactory
    {
        IRelay CreateRelay();
        IRGB CreateRGB();
    }
}
