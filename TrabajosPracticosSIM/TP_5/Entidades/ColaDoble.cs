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



        public void CalcularCola(string evento, bool estado_servidor)
        {
            Cola1.Cantidad_Anterior = Cola1.Cantidad;
            if (evento == Cola1.EventoEncolador)
            {
                if(Cola2.Cantidad_Anterior==0 && !estado_servidor)
                {
                    Cola1.Cantidad++;
                }
            }
            if(evento == Cola2.EventoEncolador)
            {
                if(Cola2.Cantidad_Anterior == 0 && 
                    Cola1.Cantidad > 0 &&
                     !estado_servidor)
                {
                    Cola1.Cantidad--;
                }
            }
            if(evento == Cola1.EventoDecolador)
            {
                if (Cola1.Cantidad > 0)
                {
                    Cola1.Cantidad--;
                }
            }
            ////////////////////////////////////////////
            Cola2.Cantidad_Anterior = Cola2.Cantidad;
            if (evento == Cola2.EventoEncolador)
            {
                if (Cola1.Cantidad_Anterior == 0 && !estado_servidor)
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
                if (Cola2.Cantidad > 0)
                {
                    Cola2.Cantidad--;
                }
            }

        }

        public void ResetearCola()
        {
            Cola1.ResetearCola();
            Cola2.ResetearCola();
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
    }
}
