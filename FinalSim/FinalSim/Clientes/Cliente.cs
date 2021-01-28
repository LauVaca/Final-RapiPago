using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSim
{
    class Cliente
    {
        public int Id { get; set; }

        public string Estado { get; set; }  // SA: siendo atendido - EA: esperando atencion

        public double horaLlegada { get; set; }

        public double horaInicioAtencion { get; set; }

        public double tiempoEspera { get; set; } // = horaInicioAtencion - horaLlegada

        public int tipoServicio { get; set; } // 0: Gas , 1: Telefono 

        private double A;
        private double B;

        public double tiempoAtencion(double RND)
        {
            // Telefono // Generador de num aleatorios con distribucion uniforme
            if (tipoServicio == 1)
            {
                A = 30; B = 170;
                return Math.Round(RND * (B - A) + A, 4);
            }
            
            //Gas // Generador de num aleatorios con distribucion uniforme
            else
            {
                A = 50; B = 110;
                return Math.Round(RND * (B - A) + A, 4);
            }
        }

        public void calcularTiempoDemora()
        {
            tiempoEspera = horaInicioAtencion - horaLlegada;
        }
    }
}
