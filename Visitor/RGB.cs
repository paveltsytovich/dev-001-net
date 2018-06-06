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
            throw new NotImplementedException();
        }

        public void Accept(IVisitor visitor)
        {
            visitor.SetRGB(this);
        }
    }
}
