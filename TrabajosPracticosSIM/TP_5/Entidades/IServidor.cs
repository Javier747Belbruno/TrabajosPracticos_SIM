using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajosPracticosSIM.TP_5.Entidades
{
    public interface IServidor
    {
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
