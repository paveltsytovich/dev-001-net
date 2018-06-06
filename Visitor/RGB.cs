using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class RGB : IRgb, IAcceptable
    {
        public void setColor(int r, int b, int c)
        {
            Console.WriteLine("RGB::Set color to  {0},{1},{2}",r,b,c);
            
        }

        public void Accept(IVisitor visitor)
        {
            visitor.SetRGB(this);
        }
    }
}
