using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class CinemaCottadge : ICinema
    {
        private IRelay projector;
        private IRelay lampInRoom, lampInHall;
        private IEngine wall, windowBlindes;
        public CinemaCottadge(IRelay p, IRelay lr,
            IRelay lh, IEngine w, IEngine wb)
        {
            projector = p;
            lampInRoom = lr;
            lampInHall = lh;
            wall = w;
            windowBlindes = wb;
        }
        public void Show()
        {
            lampInHall.Off();
            lampInRoom.On();
            wall.turnForward();
            windowBlindes.turnForward();
        }

        public void Stop()
        {
            lampInHall.On();
            windowBlindes.turnBack();
        }

        public void Off()
        {
            projector.Off();
            lampInHall.On();
            lampInRoom.On();
            wall.turnBack();
            windowBlindes.turnBack();
        }
    }
}
