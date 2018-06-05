using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class CottageWithNoolite : Application
    {
        protected override ICinema CreateCinema()
        {

            IRelay projector, lamp1, lamp2;
            IEngine engine1, engine2;
            projector = new RelayNoolite();
            lamp1 = new RelayNoolite();
            lamp2 = new RelayNoolite();
            engine1 = new StepMotor();
            engine2 = new StepMotor();
            return new CinemaCottadge(projector, lamp1, lamp2,engine1, engine2);
        }
    }
}
