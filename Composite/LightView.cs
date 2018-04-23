using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class LightView : IViewObject
    {
        public void Draw()
        {
            Console.WriteLine("Light View");
        }

        public void Add(IViewObject obj)
        {
         
        }
    }
}
