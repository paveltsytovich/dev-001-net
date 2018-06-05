using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    abstract class Application
    {
        protected abstract ICinema CreateCinema();

        public void Run()
        {
            ICinema cinema =
                   CreateCinema();
            cinema.Show();
            cinema.Stop();
            cinema.Off();
        }
    }
}
