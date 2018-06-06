using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IAcceptable> repo = new List<IAcceptable>()
            {
                new Relay(),new Relay(),new RGB()
            };
            IVisitor dayMode = new DayMode();
            IVisitor nightMode = new NightMode();
            foreach (var c in repo)
            {
                c.Accept(dayMode);
            }
            Console.WriteLine("-----------------------------------------");
            foreach (var c in repo)
            {
                c.Accept(nightMode);
            }
            Console.ReadKey();
        }
    }
}
