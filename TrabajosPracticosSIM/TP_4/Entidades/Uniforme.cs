using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajosPracticosSIM.TP_1;

namespace TrabajosPracticosSIM.TP_4.Entidades
{
    public class Uniforme : IDistribucion
    {
        public double A { get; set; }
        public double B { get; set; }

        public Uniforme(double a, double b)
        {
            A = a;
            B = b;
        }
        public string DevolverParams()
        {
            return "a: "+ A + ",b: " + B;
        }
        /// <summary>
        /// Sacar el primer random de la lista
        /// </summary>
        /// <param name="random"></param>
        /// <returns></returns>
        public double DevolverUnaVariableAleatoria(Queue<double> random)
        {
            double varAleat = A + random.Dequeue() * (B - A);
            varAleat = Utiles.RedondearDecimales(varAleat, 4);
            return varAleat;
        }

        public double DevolverParam1()
        {
            return A;
        }

        public double DevolverParam2()
        {
            return B;
        }

    }
}
