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
        Random r = new Random();
        public ColaSimple Cola { get; set; } = new ColaSimple();
        public bool Ocupado { get; set; } = false;
        public bool Ocupado_Anterior { get; set; } = false;
        public int? Nro_Pedido { get; set; } = null;
        public int? Nro_Pedido_Anterior { get; set; } = null; 
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
            Ocupado_Anterior = false;
            Nro_Pedido = null;
            Nro_Pedido_Anterior = null;
            Random = null;
            Tiempo = null;
            TiempoProx = null;
            P8_Tiempo_Ocupado_Acumulado  = 0;
            P8_Porcentaje_Tiempo_Ocupado = 0;
        }

        public void CalcularCola(string evento)
        {
            Cola.CalcularCola(evento, Ocupado);
        }

        public void CalcularRandom()
        {
 
            Queue<double> q = new Queue<double>();
            if (Nro_Pedido.HasValue && Nro_Pedido != Nro_Pedido_Anterior)
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

        public void CalcularTiempoProx(double reloj)
        {
            if (Tiempo.HasValue)
                TiempoProx = Tiempo + reloj;
            else
                if (!Ocupado)
                    TiempoProx = null;
        }

        public void CalcularEstado(string evento)
        {
            Ocupado_Anterior = Ocupado;
            if (evento == Cola.EventoEncolador && !Ocupado )
                Ocupado = true;
            if (evento == Cola.EventoDecolador && Cola.Cantidad_Anterior == 0)
                Ocupado = false;
        }

        public void CalcularNroPedidoEnAtencion(string evento,int? nro_pedido)
        {
            Nro_Pedido_Anterior = Nro_Pedido;
            if (!Ocupado)
                Nro_Pedido = null;
            else
            {
                if (!Ocupado_Anterior && evento == Cola.EventoEncolador)
                    Nro_Pedido = nro_pedido;
                else{
                    if (evento == Cola.EventoDecolador && Cola.Cantidad_Anterior > 0)
                        Nro_Pedido++;
                }
            }
        }

        public void CalcularPorcentajeOcupacionServidor(double reloj, double reloj_anterior)
        {
            if (Ocupado_Anterior)
            {
                P8_Tiempo_Ocupado_Acumulado = reloj - reloj_anterior + P8_Tiempo_Ocupado_Acumulado;
            }

            P8_Porcentaje_Tiempo_Ocupado = (P8_Tiempo_Ocupado_Acumulado / reloj) * 100;
        }
    }
}
