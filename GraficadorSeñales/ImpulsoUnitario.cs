using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficadorSeñales
{
    class ImpulsoUnitario
    {
        public double Amplitud { get; set; }
        public double Fase { get; set; }
        public double Frecuencia { get; set; }

        public List<Muestra> Muestras { get; set; }

        public ImpulsoUnitario()
        {
            Amplitud = 1.0;
            Fase = 0.0;
            Frecuencia = 1.0;
            Muestras = new List<Muestra>();
        }

        public ImpulsoUnitario(double amplitud, double fase, double frecuencia)
        {
            Amplitud = amplitud;
            Fase = fase;
            Frecuencia = frecuencia;
        }

        public double evaluar(double tiempo)
        {
            double resultado;

            if (tiempo == 0)
            {
                resultado = 1.0;
            }

            else
            {
                resultado = 0.0;
            }

            return resultado;
        }
    }
}
