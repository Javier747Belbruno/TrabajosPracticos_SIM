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
    }
}
