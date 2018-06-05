using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            ISmartServiceFactory factory1 = SmartServiceCreator.Instance;
            ISmartServiceFactory factory2 = SmartServiceCreator.Instance;

            if(factory1 == factory2)
                Console.WriteLine("Is one!");
            else
            {
                Console.WriteLine("Ooops!");
            }
        }
    }
}
