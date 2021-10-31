using System.Collections.Generic;
using TrabajosPracticosSIM.TP_4.Entidades;

namespace TrabajosPracticosSIM.TP_6.Entidades
{
    public class Constante : IDistribucion
    {
        public double valor { get; set; } = 0;
        public Constante(double valor)
        {
            this.valor = valor;
        }

        public double DevolverParam1()
        {
            return valor;
        }

        public double DevolverParam2()
        {
            return valor;
        }

        public string DevolverParams()
        {
            return "valor: " + valor.ToString();
        }

        public double DevolverUnaVariableAleatoria(Queue<double> random)
        {
            return valor;
        }
    }
}