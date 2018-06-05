using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class FlatWithNoolite : Application
    {
        protected override ICinema CreateCinema()
        {
            IRelay projector, lamp1;
            IEngine engine1;
            projector = new RelayNoolite();
            lamp1 = new RelayNoolite();
            engine1 = new StepMotor();
            return new CinemaFlat(lamp1, projector, engine1);
        }
    }
}
