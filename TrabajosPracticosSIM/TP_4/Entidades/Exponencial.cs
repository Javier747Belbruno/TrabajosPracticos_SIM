using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajosPracticosSIM.TP_1;

namespace TrabajosPracticosSIM.TP_4.Entidades
{
    public class Exponencial : IDistribucion
    {
        public double Media { get; set; }

        public Exponencial(double media)
        {
            Media = media;
        }

        public string DevolverParams()
        {
            return Media.ToString();
        }
        public double DevolverUnaVariableAleatoria(Queue<double> random)
        {
            double varAleat = -Media * Math.Log(1 - random.Dequeue());
            varAleat = Utiles.RedondearDecimales(varAleat, 4);
            return varAleat;
        }
    }
}
