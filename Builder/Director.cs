using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Director
    {
        private IRele Relay;
        private IPost Post;
        private IHandler Handler;
        private IScenario Scenario;

        private IBulder builder;
        public Director(IBulder b)
        {
            builder = b;
        }
        public void Construct()
        {
            Relay = builder.CreateRele();
            Post = builder.CreatePost();
            Handler = builder.CreateHandler();
            Scenario = builder.CreateScenario();
        }
        public Application GetResult()
        {
            return new Application(Relay, Handler,
                Post, Scenario);
        }
    }
}
