using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajosPracticosSIM.TP_4.Entidades;

namespace TrabajosPracticosSIM.TP_5.Entidades
{
    public class Llegadas
    {
        Random r = new Random();
        public int? Prox_Nro_Pedido { get; set; } = null;
        public IDistribucion Distr { get; set; }
        public Queue<double> Random { get; set; } = null;
        public double? Tiempo { get; set; } = null;
        public double? Tiempo_Prox { get; set; } = null;


        public void CalcularProxNroPedido(int? nro_pedido)
        {
            if (nro_pedido.HasValue)
            {
                if (Prox_Nro_Pedido == nro_pedido)
                    Prox_Nro_Pedido++;
            }
            else
                Prox_Nro_Pedido = 1;
        }

        public void CalcularRandom(string evento)
        {
            Queue<double> q = new Queue<double>();
            if (evento == Evento.Inicio || evento == Evento.Llegada_Pedido)
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
    }
}
