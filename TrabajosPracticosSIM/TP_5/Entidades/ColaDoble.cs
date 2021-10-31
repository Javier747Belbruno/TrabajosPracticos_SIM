using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajosPracticosSIM.TP_5.Entidades
{
    public class ColaDoble : ICola
    {
        public ColaSimple Cola1 { get; set; } = new ColaSimple();
        public ColaSimple Cola2 { get; set; } = new ColaSimple();

        public int P4_Cantidad_Maxima { get; set; } = 0;

        public double P5_Tiempo_Acumulado { get; set; } = 0;
        public double P5_Tiempo_Promedio { get; set; } = 0;

        public double P6_Promedio_Pedidos_en_Cola { get; set; } = 0;

        public double P9_Proporcion_Espera_Cola_1 { get; set; } = 0;
        public double P9_Proporcion_Espera_Cola_2 { get; set; } = 0;

        public void CalcularCola(string evento, bool estado_servidor)
        {
            Cola1.Cantidad_Anterior = Cola1.Cantidad;
            if (evento == Cola1.EventoEncolador)
            {
                if (Cola2.Cantidad > 0 && !estado_servidor)
                {

                }
                else
                {
                    Cola1.Cantidad++;
                }
            }
            if (evento == Cola2.EventoEncolador)
            {
                if (Cola2.Cantidad == 0 &&
                    Cola1.Cantidad > 0 &&
                     !estado_servidor)
                {
                    Cola1.Cantidad--;
                }
            }
            if (evento == Cola1.EventoDecolador)
            {
                if (Cola1.Cantidad == 0 || (Cola1.Cantidad > 0 && Cola2.Cantidad == 0))
                {

                }
                else
                {
                    Cola1.Cantidad--;
                }
            }
            ////////////////////////////////////////////
            Cola2.Cantidad_Anterior = Cola2.Cantidad;
            if (evento == Cola2.EventoEncolador)
            {
                if (Cola1.Cantidad_Anterior > 0 && !estado_servidor)
                {

                }
                else
                {
                    Cola2.Cantidad++;
                }
            }
            if (evento == Cola1.EventoEncolador)
            {
                if (Cola1.Cantidad_Anterior == 0 &&
                    Cola2.Cantidad > 0 &&
                     !estado_servidor)
                {
                    Cola2.Cantidad--;
                }
            }
            if (evento == Cola2.EventoDecolador)
            {
                if (Cola2.Cantidad == 0 || (Cola2.Cantidad > 0 && Cola1.Cantidad_Anterior == 0))
                {

                }
                else
                {
                    Cola2.Cantidad--;
                }
            }

        }

        public void ResetearCola()
        {
            Cola1.ResetearCola();
            Cola2.ResetearCola();
            P4_Cantidad_Maxima = 0;

            P5_Tiempo_Acumulado = 0;
            P5_Tiempo_Promedio = 0;

            P6_Promedio_Pedidos_en_Cola  = 0;

            P9_Proporcion_Espera_Cola_1  = 0;
            P9_Proporcion_Espera_Cola_2 = 0;
    }
        /// <summary>
        /// Solo para la cola 6
        /// </summary>
        public void EncastreFinal(string evento)
        {
            Cola1.Cantidad_Anterior = Cola1.Cantidad;
            if (evento == Cola1.EventoEncolador)
            {
                if (Cola2.Cantidad_Anterior == 0)
                {
                    Cola1.Cantidad++;
                }
            }
            if (evento == Cola2.EventoEncolador)
            {
                if (Cola1.Cantidad_Anterior > 0 && Cola2.Cantidad_Anterior == 0)
                {
                    Cola1.Cantidad--;
                }
            }
            //////////////////////////////////////////////
            Cola2.Cantidad_Anterior = Cola2.Cantidad;
            if (evento == Cola2.EventoEncolador)
            {
                if (Cola1.Cantidad_Anterior == 0)
                {
                    Cola2.Cantidad++;
                }
            }
            if (evento == Cola1.EventoEncolador)
            {
                if (Cola2.Cantidad_Anterior > 0 && Cola1.Cantidad_Anterior == 0)
                {
                    Cola2.Cantidad--;
                }
            }
        }

        public void CalcularMaxCantEnCola()
        {
            if ((Cola1.Cantidad + Cola2.Cantidad) > P4_Cantidad_Maxima)
                P4_Cantidad_Maxima = (Cola1.Cantidad + Cola2.Cantidad);
        }

        public void CalcularTiempoAcumuladoEnCola(double reloj_anterior, double reloj)
        {
            P5_Tiempo_Acumulado = (Cola1.Cantidad + Cola2.Cantidad) * (reloj - reloj_anterior) + P5_Tiempo_Acumulado;
            //Calculo los tiempos de las colas separadas (Para punto 9)
            Cola1.CalcularTiempoAcumuladoEnCola(reloj_anterior, reloj);
            Cola2.CalcularTiempoAcumuladoEnCola(reloj_anterior, reloj);
        }

        public void CalcularTiempoPromedioEnCola(double reloj_anterior, double reloj, int p3_pedidos_solicitados)
        {
            CalcularTiempoAcumuladoEnCola(reloj_anterior,reloj);
            P5_Tiempo_Promedio = P5_Tiempo_Acumulado / (double)p3_pedidos_solicitados;
        }

        public void CalcularCantPromedioEnCola(double reloj)
        {
            P6_Promedio_Pedidos_en_Cola = P5_Tiempo_Acumulado / reloj;
        }

        public void CalcularProporcionesDeEspera()
        {
            if(P5_Tiempo_Acumulado != 0)
            {
                P9_Proporcion_Espera_Cola_1 = (Cola1.P5_Tiempo_Acumulado / P5_Tiempo_Acumulado)*100;
                P9_Proporcion_Espera_Cola_2 = (Cola2.P5_Tiempo_Acumulado / P5_Tiempo_Acumulado)*100;
            }
            else
            {
                P9_Proporcion_Espera_Cola_1 = 0;
                P9_Proporcion_Espera_Cola_2 = 0;
            }
        }
    }
}
