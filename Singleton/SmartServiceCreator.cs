using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class SmartServiceCreator
    {
        private static ISmartServiceFactory instance;

        public static ISmartServiceFactory Instance
        {
            get { return instance; }
        }

        static SmartServiceCreator()
        {
            instance = new SmartServiceFactory();
        }
    }
}
