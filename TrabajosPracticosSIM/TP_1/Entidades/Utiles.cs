using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajosPracticosSIM.TP_1
{
    public static class Utiles
    {
        public static double Dividir(int xi, double m)
        {
            double valor = (double)(xi / m);
            return Redondear4Decimales(valor);
        }
        public static double Redondear4Decimales(double valor)
        {
            double valorRedondeado = Math.Round(valor, 4, MidpointRounding.AwayFromZero);
            return valorRedondeado;
        }
        public static double RedondearDecimales(double valor,int cantidadDecimales)
        {
            double valorRedondeado = Math.Round(valor, cantidadDecimales, MidpointRounding.AwayFromZero);
            return valorRedondeado;
        }
    }
}
