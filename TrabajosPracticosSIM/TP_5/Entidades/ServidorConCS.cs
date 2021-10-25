using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajosPracticosSIM.TP_4.Entidades;

namespace TrabajosPracticosSIM.TP_5.Entidades
{
    /// <summary>
    /// Servidor Con Cola Simple
    /// </summary>
    public class ServidorConCS : IServidor
    {
        public ColaSimple Cola { get; set; } = new ColaSimple();
        public bool Ocupado { get; set; } = false;
        public int? Nro_Pedido { get; set; } = null;
        public IDistribucion Distr { get; set; }
        public Queue<double> Random { get; set; } = null;
        public double? Tiempo { get; set; } = null;
        public double? TiempoProx { get; set; } = null;
        public double P8_Tiempo_Ocupado_Acumulado { get; set; } = 0;
        public double P8_Porcentaje_Tiempo_Ocupado { get; set; } = 0;

        


        public void ResetearServidor()
        {
            Cola.ResetearCola();
            Ocupado = false;
            Nro_Pedido = null;
            Random = null;
            Tiempo = null;
            TiempoProx = null;
        }

        public void CalcularCola()
        {
            Cola.CalcularCola();
        }



            public void CalcularTiempo()
        {
            double t = Distr.DevolverUnaVariableAleatoria(Random);
            if (t < 0)
                t = 0;
            Tiempo = t;
        }

        public void CalcularTiempoProx(double reloj)
        {
            if (Random != null)
                TiempoProx = Tiempo + reloj;
            else
            {
                if (!Ocupado)
                    TiempoProx = null;
            }
        }

    }
}
