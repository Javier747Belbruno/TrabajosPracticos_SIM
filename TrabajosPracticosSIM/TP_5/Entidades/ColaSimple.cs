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
            Cantidad_Anterior = 0;
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

        public void CalcularMaxCantEnCola()
        {
            if(Cantidad > P4_Cantidad_Maxima)
                P4_Cantidad_Maxima = Cantidad;
        }

        public void CalcularTiempoAcumuladoEnCola(double reloj_anterior, double reloj)
        {
            P5_Tiempo_Acumulado = Cantidad * (reloj - reloj_anterior) + P5_Tiempo_Acumulado;
        }
        public void CalcularTiempoPromedioEnCola(double reloj_anterior,double reloj, int p3_pedidos_solicitados)
        {
            CalcularTiempoAcumuladoEnCola(reloj_anterior, reloj);
            P5_Tiempo_Promedio = P5_Tiempo_Acumulado / (double)p3_pedidos_solicitados;
        }

        public void CalcularCantPromedioEnCola(double reloj)
        {
            P6_Promedio_Pedidos_en_Cola = P5_Tiempo_Acumulado / reloj;
        }
    }
}
