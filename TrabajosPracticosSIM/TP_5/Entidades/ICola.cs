using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajosPracticosSIM.TP_5.Entidades
{
    public interface ICola
    {
        void ResetearCola();
        void CalcularCola(string evento,bool estado_servidor);
        void CalcularMaxCantEnCola();
        void CalcularTiempoPromedioEnCola(double reloj_anterior, double reloj, int p3_pedidos_solicitados);
        void CalcularCantPromedioEnCola(double reloj);
        void CalcularTiempoAcumuladoEnCola(double reloj_anterior, double reloj);
    }
}
