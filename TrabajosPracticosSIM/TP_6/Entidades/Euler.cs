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
            //a = 1;
            DataTable dt = new DataTable();
            dt.Columns.Add("t");
            dt.Columns.Add("x1");
            dt.Columns.Add("x2");
            dt.Columns.Add("x'2");

            //Primera fila
            double t = 0;
            double t_Anterior = 0;
            double x1 = x0;
            double x1_Anterior = x0;
            double x2 = dx0;
            double x3 = DerivadaSegunda(a,b,c,x1,x2,t);
            dt.Rows.Add(t, x1, x2, x3);

            double t_2do_pico = 0;
            double x1_2do_pico = 0;

            int contadorPicoMax = 0;
            double valorPico = 0;
            double valorPico_Anterior = 0;
            
            
            while(true)
            {
                valorPico_Anterior = valorPico;
                t_Anterior = t;
                x1_Anterior = x1;


                t = h + t;
                x1 = x1 + h * x2;
                x2 = x2 + h * x3;
                x3 = DerivadaSegunda(a, b, c, x1, x2, t);
                dt.Rows.Add(t.ToString("0.00"), x1.ToString("0.0000"), x2.ToString("0.0000"), x3.ToString("0.0000"));

                valorPico = Math.Abs(x1) / x2;
                if(valorPico_Anterior > 0 && valorPico< 0)
                {
                    contadorPicoMax++;
                    if(contadorPicoMax == 2)
                    {
                        if(Math.Abs(valorPico_Anterior) > Math.Abs(valorPico))
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

            dt.Rows.Add(t_2do_pico.ToString("0.00"), x1_2do_pico.ToString("0.0000"), a.ToString("0.0000"), "");
            
            return dt;
        }

        private double DerivadaSegunda(double a, double b, double c, double x1, double x2, double t)
        {
            return -(a * x2) - (b * x1) + Math.Exp(-c*t);
        }

        public double CalcularTiempo2doPicoMaximo(double a, double b, double c, double h, double x0, double dx0)
        {
            //Primera fila
            double t = 0;
            double t_Anterior = 0;
            double x1 = x0;
            double x1_Anterior = x0;
            double x2 = dx0;
            double x3 = DerivadaSegunda(a, b, c, x1, x2, t);

            int contadorPicoMax = 0;
            double valorPico = 0;
            double valorPico_Anterior = 0;


            while (true)
            {
                valorPico_Anterior = valorPico;
                t_Anterior = t;
                x1_Anterior = x1;


                t = h + t;
                x1 = x1 + h * x2;
                x2 = x2 + h * x3;
                x3 = DerivadaSegunda(a, b, c, x1, x2, t);

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
