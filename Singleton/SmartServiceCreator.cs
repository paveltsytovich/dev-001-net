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
        private static Object dimmy = new object();

        public static ISmartServiceFactory Instance
        {
            get { return instance; }
        }

        static SmartServiceCreator()
        {
            if(instance == null)
                lock (dimmy)
                {
                    if(instance == null)
                        instance = new SmartServiceFactory();
                }
                
        }
    }
}
