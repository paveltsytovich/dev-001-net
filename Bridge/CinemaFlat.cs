using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class CinemaFlat : ICinema
    {
        private IRelay lightInRoom;
        private IRelay projector;
        private IEngine windowBlinds;

        public CinemaFlat(IRelay lr,IRelay p, IEngine wb)
        {
            lightInRoom = lr;
            projector = p;
            windowBlinds = wb;
        }
        public void Show()
        {
            lightInRoom.Off();
            windowBlinds.turnBack();
            projector.On();
        }

        public void Stop()
        {
            projector.Off();
        }

        public void Off()
        {
            lightInRoom.On();
            windowBlinds.turnForward();
            projector.Off();
        }
    }
}
