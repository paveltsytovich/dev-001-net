using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class RelayIterator : IEnumerator<IRelay>
    {
        private IList<IRelay> relayList;
        private TimeSpan time;
        private int currentRelay=0;
        public RelayIterator(IList<IRelay> rl,TimeSpan t)
        {
            relayList = rl;
            time = t;
        }
        public IRelay Current
        {
            get { return relayList[currentRelay]; }
        }

        public void Dispose()
        {        
        }

        object System.Collections.IEnumerator.Current
        {
            get { return relayList[currentRelay]; }
        }

        public bool MoveNext()
        {
            while (currentRelay < relayList.Count())
            {
             if(DateTime.Now - relayList[currentRelay].
                                GetOnTime() > time)
               return true;
             currentRelay++;
            } 
            return false;
        }

        public void Reset()
        {
            currentRelay = 0 ;
        }
    }
}
