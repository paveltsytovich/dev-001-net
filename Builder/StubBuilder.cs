using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class StubBuilder : IBulder
    {
        public IRele CreateRele()
        {
            throw new NotImplementedException();
        }

        public IPost CreatePost()
        {
            throw new NotImplementedException();
        }

        public IScenario CreateScenario()
        {
            throw new NotImplementedException();
        }

        public IHandler CreateHandler()
        {
            throw new NotImplementedException();
        }
    }
}
