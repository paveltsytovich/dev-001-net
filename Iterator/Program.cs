using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            RelayRepository repo = new RelayRepository();
            IRelay relay = new Relay();
            relay.On();
            repo.Add(relay);
            relay = new Relay();
            relay.On();
            repo.Add(relay);

            Thread.Sleep(20000);

            relay = new Relay();
            relay.On();
            repo.Add(relay);
            relay = new Relay();
            relay.On();
            repo.Add(relay);
            
            foreach (var item in repo)
            {
                item.Off();
            }
        }
    }
}
