using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajosPracticosSIM.TP_4.Entidades;

namespace TrabajosPracticosSIM.TP_5.Entidades
{
    public interface IServidor
    {
        IDistribucion Distr { get; set; }
        void ResetearServidor();
        void CalcularCola(string evento);
        void CalcularEstado(string evento);
        void CalcularNroPedidoEnAtencion(string evento, int? nro_pedido);
        void CalcularRandom();
        void CalcularTiempo();
        void CalcularTiempoProx(double reloj);
        void CalcularPorcentajeOcupacionServidor(double reloj, double reloj_anterior);
    }
}
