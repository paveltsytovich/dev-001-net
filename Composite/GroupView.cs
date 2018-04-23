using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class GroupView : IViewObject
    {
        private IList<IViewObject> branches = 
                        new List<IViewObject>();
        public void Draw()
        {
            Console.WriteLine("GroupView:");
            foreach (var item in branches)
            {
                item.Draw();
            }
        }

        public void Add(IViewObject obj)
        {
            if(obj != null && obj != this && 
                !branches.Contains(obj))
             branches.Add(obj);
        }
    }
}
