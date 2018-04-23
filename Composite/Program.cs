using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            IViewObject flat = new GroupView();
            IViewObject dinnerRoom = new GroupView();
            flat.Add(dinnerRoom);
            flat.Add(new LightView());
            dinnerRoom.Add(new LightView());
            dinnerRoom.Add(new LightView());
            flat.Draw();
            Console.ReadKey();
        }
    }
}
