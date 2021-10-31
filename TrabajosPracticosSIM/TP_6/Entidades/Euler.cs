using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajosPracticosSIM.TP_4.Entidades;

namespace TrabajosPracticosSIM.TP_6.Entidades
{
    public class Euler : IMetodoNumerico
    {
        public DataTable Calcular(double a, double b, double c, double h, double x0, double dx0)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("t");
            dt.Columns.Add("x1");
            dt.Columns.Add("x2");
            dt.Columns.Add("x'2");

            //Primera fila
            double t = 0;
            double x1 = x0;
            double x2 = dx0;
            double x3 = DerivadaSegunda(a,b,c,x1,x2,t);

            double t2dopico = 0;
            double x2dopico = 0;

            while (x3 > 0.0001)
            {
                t = h + t;
                x1 = x1 + h * x2;
                x2 = x2 + h * x3;
                x3 = DerivadaSegunda(a, b, c, x1, x2, t);
                dt.Rows.Add(t, x1, x2, x3);

            }
            dt.Rows.Add(t2dopico, x2dopico, "", "");
            return dt;

        }

        private double DerivadaSegunda(double a, double b, double c, double x1, double x2, double t)
        {
            return -(a * x2) - (b * x1) + Math.Exp(-c*t);
        }
    }
}
