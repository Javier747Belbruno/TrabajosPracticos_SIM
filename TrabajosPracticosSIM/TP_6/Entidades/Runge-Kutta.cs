using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajosPracticosSIM.TP_4.Entidades;

namespace TrabajosPracticosSIM.TP_6.Entidades
{
    public class Runge_Kutta : IMetodoNumerico
    {
        public DataTable Calcular(double a, double b, double c, double h, double x0, double dx0)
        {
            //a = 1;
            DataTable dt = new DataTable();
            dt.Columns.Add("t");
            dt.Columns.Add("x1");
            dt.Columns.Add("k1");
            dt.Columns.Add("k2");
            dt.Columns.Add("k3");
            dt.Columns.Add("k4");
            dt.Columns.Add("x2");
            dt.Columns.Add("l1");
            dt.Columns.Add("l2");
            dt.Columns.Add("l3");
            dt.Columns.Add("l4");
            dt.Columns.Add("x'2 (l1/h)");

            //Primera fila
            double t = 0 , t_Anterior = 0;
            double x1 = x0, x1_Anterior = x0;
            double x2 = dx0;
            double x3 = DerivadaSegunda(a, b, c, x1, x2, t);
            double l1 = h * x3;
            double k1 = h * x2;
            double l2 = h * DerivadaSegunda(a, b, c, (x1+0.5*k1), (x2+0.5*l1), (t+0.5*h));
            double k2 = h * (x2+0.5* l1);
            double l3 = h * DerivadaSegunda(a, b, c, (x1 + 0.5 * k2), (x2 + 0.5 * l2), (t + 0.5 * h));
            double k3 = h * (x2 + 0.5 * l2);
            double l4 = h * DerivadaSegunda(a, b, c, (x1 + k3), (x2 + l3), (t + h));
            double k4 = h * (x2 + l3);
            
            dt.Rows.Add(t.ToString("0.00"), x1.ToString("0.0000"), k1.ToString("0.0000")
                                    , k2.ToString("0.0000"), k3.ToString("0.0000"), k4.ToString("0.0000")
                                    , x2.ToString("0.0000"), l1.ToString("0.0000"), l2.ToString("0.0000"),
                                    l3.ToString("0.0000"), l4.ToString("0.0000"), x3.ToString("0.0000"));

            double t_2do_pico = 0;
            double x1_2do_pico = 0;

            int contadorPicoMax = 0;
            double valorPico = 0;
            double valorPico_Anterior = 0;


            while (true)
            {
                valorPico_Anterior = valorPico;
                t_Anterior = t;
                x1_Anterior = x1;


                t = h + t;
                x1 = x1 + (k1 + 2 * k2 + 2 * k3 + k4) / 6;
                x2 = x2 + (l1 + 2 * l2 + 2 * l3 + l4) / 6;
                x3 = DerivadaSegunda(a, b, c, x1, x2, t);
                l1 = h * x3;
                k1 = h * x2;
                l2 = h * DerivadaSegunda(a, b, c, (x1 + 0.5 * k1), (x2 + 0.5 * l1), (t + 0.5 * h));
                k2 = h * (x2 + 0.5 * l1);
                l3 = h * DerivadaSegunda(a, b, c, (x1 + 0.5 * k2), (x2 + 0.5 * l2), (t + 0.5 * h));
                k3 = h * (x2 + 0.5 * l2);
                l4 = h * DerivadaSegunda(a, b, c, (x1 + k3), (x2 + l3), (t + h));
                k4 = h * (x2 + l3);

                dt.Rows.Add(t.ToString("0.00"), x1.ToString("0.0000"), k1.ToString("0.0000")
                                        , k2.ToString("0.0000"), k3.ToString("0.0000"), k4.ToString("0.0000")
                                        , x2.ToString("0.0000"), l1.ToString("0.0000"), l2.ToString("0.0000"),
                                        l3.ToString("0.0000"), l4.ToString("0.0000"), x3.ToString("0.0000"));

                valorPico = Math.Abs(x1) / x2;
                if (valorPico_Anterior > 0 && valorPico < 0)
                {
                    contadorPicoMax++;
                    if (contadorPicoMax == 2)
                    {
                        if (x1_Anterior > x1)
                        {
                            t_2do_pico = t_Anterior;
                            x1_2do_pico = x1_Anterior;
                        }
                        else
                        {
                            t_2do_pico = t;
                            x1_2do_pico = x1;
                        }
                    }
                }
                if (Math.Abs(x1) < 0.01 && Math.Abs(x2) < 0.01 && Math.Abs(x3) < 0.01)
                {
                    break;
                }
                if (dt.Rows.Count > 1000)
                {
                    break;
                }
            }

            dt.Rows.Add(t_2do_pico.ToString("0.00"), x1_2do_pico.ToString("0.0000"), a.ToString("0.00")
                , b.ToString("0.00"), c.ToString("0.00"), h.ToString("0.0000"), x0.ToString("0.00"), dx0.ToString("0.00"));

            return dt;
        }



        private double DerivadaSegunda(double a, double b, double c, double x1, double x2, double t)
        {
            return -(a * x2) - (b * x1) + Math.Exp(-c * t);
        }

        public double CalcularTiempo2doPicoMaximo(double a, double b, double c, double h, double x0, double dx0)
        {
            //Primera fila
            double t = 0, t_Anterior = 0;
            double x1 = x0, x1_Anterior = x0;
            double x2 = dx0;
            double x3 = DerivadaSegunda(a, b, c, x1, x2, t);
            double l1 = h * x3;
            double k1 = h * x2;
            double l2 = h * DerivadaSegunda(a, b, c, (x1 + 0.5 * k1), (x2 + 0.5 * l1), (t + 0.5 * h));
            double k2 = h * (x2 + 0.5 * l1);
            double l3 = h * DerivadaSegunda(a, b, c, (x1 + 0.5 * k2), (x2 + 0.5 * l2), (t + 0.5 * h));
            double k3 = h * (x2 + 0.5 * l2);
            double l4 = h * DerivadaSegunda(a, b, c, (x1 + k3), (x2 + l3), (t + h));
            double k4 = h * (x2 + l3);


            int contadorPicoMax = 0;
            double valorPico = 0;
            double valorPico_Anterior = 0;


            while (true)
            {
                valorPico_Anterior = valorPico;
                t_Anterior = t;
                x1_Anterior = x1;


                t = h + t;
                x1 = x1 + (k1 + 2 * k2 + 2 * k3 + k4) / 6;
                x2 = x2 + (l1 + 2 * l2 + 2 * l3 + l4) / 6;
                x3 = DerivadaSegunda(a, b, c, x1, x2, t);
                l1 = h * x3;
                k1 = h * x2;
                l2 = h * DerivadaSegunda(a, b, c, (x1 + 0.5 * k1), (x2 + 0.5 * l1), (t + 0.5 * h));
                k2 = h * (x2 + 0.5 * l1);
                l3 = h * DerivadaSegunda(a, b, c, (x1 + 0.5 * k2), (x2 + 0.5 * l2), (t + 0.5 * h));
                k3 = h * (x2 + 0.5 * l2);
                l4 = h * DerivadaSegunda(a, b, c, (x1 + k3), (x2 + l3), (t + h));
                k4 = h * (x2 + l3);


                valorPico = Math.Abs(x1) / x2;
                if (valorPico_Anterior > 0 && valorPico < 0)
                {
                    contadorPicoMax++;
                    if (contadorPicoMax == 2)
                    {
                        if (Math.Abs(valorPico_Anterior) > Math.Abs(valorPico))
                        {
                            return t_Anterior;
                        }
                        else
                        {
                            return t;
                        }
                    }
                }
            }
        }
    }
}
