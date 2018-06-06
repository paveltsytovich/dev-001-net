using System;

namespace Visitor
{
    class Relay : IRelay, IAcceptable
    {
        public void On()
        {
           Console.WriteLine("Relay::On");
        }

        public void Off()
        {
            Console.WriteLine("Relay::Off");
        }

        public void Accept(IVisitor visitor)
        {
            visitor.SetRelay(this);
        }
    }
}