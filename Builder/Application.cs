using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Application
    {
        private IRele Relay;
        private IHandler Handler;
        private IPost Post;
        private IScenario Scenario;

        public Application(IRele r, IHandler h,
            IPost p, IScenario s)
        {
            Relay = r;
            Handler = h;
            Post = p;
            Scenario = s;
        }
        // TO DO (not complete class!)
    }
}
