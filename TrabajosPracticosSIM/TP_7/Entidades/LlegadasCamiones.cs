using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajosPracticosSIM.TP_4.Entidades;

namespace TrabajosPracticosSIM.TP_7.Entidades
{
    public class LlegadasCamiones
    {
        Random r = new Random();
        public int? Prox_Nro_Camion { get; set; } = null;
        public IDistribucion Distr { get; set; }
        public Queue<double> Random { get; set; } = null;
        public double? Tiempo { get; set; } = null;
        public double? Tiempo_Prox { get; set; } = null;
        public int Capacidad_Camion { get; set; } = 0;


        public void CalcularProxNroCamion(int? p_nro_camion)
        {
            if (p_nro_camion.HasValue)
            {
                if (Prox_Nro_Camion == p_nro_camion)
                    Prox_Nro_Camion++;
            }
            else
                Prox_Nro_Camion = 1;
        }

        public void CalcularRandom(string evento)
        {
            Queue<double> q = new Queue<double>();
            if (evento == EventosFabrica.Inicio || evento == EventosFabrica.Llegada)
            {
                double r1 = r.NextDouble();
                q.Enqueue(r1);
                if (Distr.GetType().Name == "Normal")
                {
                    double r2 = r.NextDouble();
                    q.Enqueue(r2);
                }
                Random = q;
            }
            else
                Random = null;
        }

        public void CalcularTiempo()
        {
            if (Random != null)
                Tiempo = Distr.DevolverUnaVariableAleatoria(Random);
            else
                Tiempo = null;
        }

        public void CalcularProxTiempo(double reloj)
        {
            if (Tiempo != null)
                Tiempo_Prox = Tiempo + reloj;
        }

        public void CalcularCapacidadCamion()
        {
            if (Tiempo != null)
            {
                if (r.NextDouble() <= 0.5)
                {
                    Capacidad_Camion = 10;
                }
                else
                {
                    Capacidad_Camion = 12;
                }
            }
        }

        public void Resetear()
        {
            Prox_Nro_Camion = null;
            Random = null;
            Tiempo = null;
            Tiempo_Prox = null;
            Capacidad_Camion = 0;
        }
    
    }
}
