using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class RelayRepository : IEnumerable<IRelay>
    {
        private IList<IRelay> relays = new List<IRelay>();
        public void Add(IRelay relay)
        {
            relays.Add(relay);
        }
        public IEnumerator<IRelay> GetEnumerator()
        {
            return new RelayIterator(relays,TimeSpan.FromSeconds(10));
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return new RelayIterator(relays,TimeSpan.FromSeconds(10));
        }
    }
}
