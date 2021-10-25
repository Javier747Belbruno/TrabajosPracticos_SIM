using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajosPracticosSIM.TP_5.Entidades
{
    public class ColaSimple : ICola
    {

        public int Cantidad { get; set; } = 0;
        public int Cantidad_Anterior { get; set; } = 0;
        public string EventoEncolador { get; set; }

        public string EventoDecolador { get; set; }

        public int P4_Cantidad_Maxima { get; set; } = 0;

        public double P5_Tiempo_Acumulado { get; set; } = 0;
        public double P5_Tiempo_Promedio { get; set; } = 0;

        public double P6_Promedio_Pedidos_en_Cola { get; set; } = 0;

        public void ResetearCola()
        {
            Cantidad = 0;
            P4_Cantidad_Maxima = 0;
            P5_Tiempo_Acumulado = 0;
            P5_Tiempo_Promedio = 0;
            P6_Promedio_Pedidos_en_Cola = 0;
        }

        public void CalcularCola(string evento,bool estado_ocupado)
        {
            Cantidad_Anterior = Cantidad;
            if(evento == EventoEncolador)
                if (estado_ocupado)
                    Cantidad++;
            if (evento == EventoDecolador)
                if (Cantidad > 0)
                    Cantidad--;
        }
    }
}
