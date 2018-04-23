using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Motor : IEngine
    {
        public void turnForward()
        {
            Console.WriteLine("Motor::turnForward");
        }

        public void turnBack()
        {
            Console.WriteLine("Motor::turnBack");
        }
    }
}
