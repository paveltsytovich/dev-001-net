using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class StepMotor : IEngine
    {
        public void turnForward()
        {
            Console.WriteLine("StepMotor::turnForward");
        }

        public void turnBack()
        {
            Console.WriteLine("StepMotor::Back");
        }
    }
}
