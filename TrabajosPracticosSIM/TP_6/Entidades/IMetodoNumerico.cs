using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajosPracticosSIM.TP_4.Entidades;

namespace TrabajosPracticosSIM.TP_6.Entidades
{
    public interface IMetodoNumerico
    {
        DataTable Calcular(double a, double b, double c, double h, double x0, double dx0);
        double CalcularTiempo2doPicoMaximo(double a_valor, double b_valor, double c_valor, double h_valor, double x0_valor, double dx0_valor);
    }
}
