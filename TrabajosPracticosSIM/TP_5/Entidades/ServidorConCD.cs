using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajosPracticosSIM.TP_4.Entidades;

namespace TrabajosPracticosSIM.TP_5.Entidades
{
    public class ServidorConCD : IServidor
    {
        Random r = new Random();
        public ColaDoble Cola { get; set; } = new ColaDoble();
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

        public double P9_Tiempo_Bloqueado_Acumulado { get; set; } = 0;

        public double P9_Proporcion_Bloqueado_Ocupado { get; set; } = 0;

        //Parte 2
        double p9_tiempo_en_cola_acum_a5 = 0;
        double p9_tiempo_en_cola_acum_a3 = 0;
        double p9_proporcion_a5 = 0;
        double p9_proporcion_a3 = 0;

        public void ResetearServidor()
        {
            Cola.ResetearCola();
            Ocupado = false;
            Nro_Pedido = null;
            Random = null;
            Tiempo = null;
            TiempoProx = null;
        }

        public void CalcularCola(string evento)
        {
            Cola.CalcularCola(evento, Ocupado);
        }

        public void CalcularEstado(string evento)
        {
            Ocupado_Anterior = Ocupado;
            if (evento == Cola.Cola2.EventoEncolador)
            {
                if (Cola.Cola1.Cantidad_Anterior > 0 && !Ocupado)
                {
                    Ocupado = true;
                }
            }
            if (evento == Cola.Cola1.EventoEncolador)
            {
                if (Cola.Cola2.Cantidad_Anterior > 0 && !Ocupado)
                {
                    Ocupado = true;
                }
            }
            if (evento == Cola.Cola1.EventoDecolador)
            {
                if(Cola.Cola1.Cantidad_Anterior>0 && Cola.Cola2.Cantidad_Anterior > 0)
                {
                    Ocupado = true;
                }
                else
                {
                    Ocupado = false;
                }
            }
        }

        public void CalcularNroPedidoEnAtencion(string evento, int? nro_pedido)
        {
            Nro_Pedido_Anterior = Nro_Pedido;
            if (!Ocupado)
            {
                Nro_Pedido = null;
            }
            else
            {
                if((!Ocupado_Anterior && evento == Cola.Cola2.EventoEncolador)
                    || (!Ocupado_Anterior && evento == Cola.Cola1.EventoEncolador))
                {
                    Nro_Pedido = nro_pedido;
                }
                else
                {
                    if(Ocupado && evento == Cola.Cola1.EventoDecolador)
                    {
                        Nro_Pedido++;
                    }
                }
            }
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

        public void CalcularPorcentajeOcupacionServidor(double reloj, double reloj_anterior)
        {
            if (Ocupado_Anterior)
            {
                P8_Tiempo_Ocupado_Acumulado = reloj - reloj_anterior + P8_Tiempo_Ocupado_Acumulado;
            }

            P8_Porcentaje_Tiempo_Ocupado = (P8_Tiempo_Ocupado_Acumulado / reloj) * 100;
        }

        public void CalcularProporcionBloqueadoOcupado(double reloj, double reloj_anterior)
        {
            if(!Ocupado_Anterior && (Cola.Cola1.Cantidad_Anterior > 0 || Cola.Cola2.Cantidad_Anterior > 0))
            {
                P9_Tiempo_Bloqueado_Acumulado = reloj - reloj_anterior + P9_Tiempo_Bloqueado_Acumulado;
            }

            if(P8_Tiempo_Ocupado_Acumulado != 0)
            {
                P9_Proporcion_Bloqueado_Ocupado = (P9_Tiempo_Bloqueado_Acumulado / P8_Tiempo_Ocupado_Acumulado)*100;
            }
        }

    }
}
