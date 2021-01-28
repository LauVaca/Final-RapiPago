using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSim
{
    class Caja
    {
        public string Estado { get; set; }

        public double finAtencion { get; set; }

        public List<Cliente> cola;

        public double tiempoAtender { get; set; }

        private double A = 25.0 / 60.0;
        private double B = 65.0 / 60.0;

        public Caja()
        {
            Estado = "L";
            cola = new List<Cliente>();
            finAtencion = 0;
        }

        public double tiempoAtencion(double RND)
        {
            return Math.Round(RND * (B - A) + A, 2);
        }
    }
}
