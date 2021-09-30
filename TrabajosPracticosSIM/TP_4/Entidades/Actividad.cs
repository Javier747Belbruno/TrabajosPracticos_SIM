using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TrabajosPracticosSIM.TP_4.Entidades
{
    public class Actividad
    {
        /// <summary>
        /// No se si lo voy a usar al ID, despues lo podemos sacar.
        /// </summary>
        public int Id { get; set; }
        public IDistribucion Distr { get; set; }
        public double Tiempo { get; set; }

        public Nodo Predecesor { get; set; } = new Nodo();

        public Nodo Sucesor { get; set; } = new Nodo();

        public double CalcularTiempo(Queue<double> random)
        {
            double t = Distr.DevolverUnaVariableAleatoria(random);
            if(t < 0)
                t = 0;
            Tiempo =  t;
            return Tiempo;
        }


    }
}
