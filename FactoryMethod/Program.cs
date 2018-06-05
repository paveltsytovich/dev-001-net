using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    enum CinemaType { flat, cottadge};
    enum EquipmentType { Noolite, ZWave};
    class Program
    {
        static ICinema CreateCinema(CinemaType ct,
                                    EquipmentType et)
        {
            IRelay projector, lamp1, lamp2;
            IEngine engine1, engine2;
            if (et == EquipmentType.Noolite)
            {
                projector = new RelayNoolite();
                lamp1 = new RelayNoolite();
                lamp2 = new RelayZWave();
                engine1 = new StepMotor();
                engine2 = new StepMotor();
            }
            else
            {
                projector = new RelayZWave();
                lamp1 = new RelayZWave();
                lamp2 = new RelayZWave();
                engine1 = new Motor();
                engine2 = new Motor();
            }
            if (ct == CinemaType.flat)
            {
                return new CinemaFlat(lamp1, projector, engine1);    
            }
            else if (ct == CinemaType.cottadge)
            {
                return new CinemaCottadge(projector, lamp1, lamp2,
                    engine1, engine2);
            }
            else
                return null;
        }
        static void Main(string[] args)
        {
            FlatWithNoolite flat = new FlatWithNoolite();
            flat.Run();
            Console.WriteLine("--------------------------------------------------------------------------");

            CottageWithNoolite cottage  = new CottageWithNoolite();
            cottage.Run();

            Console.ReadKey();
        }
    }
}
