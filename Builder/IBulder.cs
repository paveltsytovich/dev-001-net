using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    interface IBulder
    {
        IRele CreateRele();
        IPost CreatePost();
        IScenario CreateScenario();
        IHandler CreateHandler();
    }
}
