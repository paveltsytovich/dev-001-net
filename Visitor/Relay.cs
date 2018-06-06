using System;

namespace Visitor
{
    class Relay : IRelay, IAcceptable
    {
        public void On()
        {
            throw new NotImplementedException();
        }

        public void Off()
        {
            throw new NotImplementedException();
        }

        public void Accept(IVisitor visitor)
        {
            visitor.SetRelay(this);
        }
    }
}