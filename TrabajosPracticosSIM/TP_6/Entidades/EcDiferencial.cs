using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajosPracticosSIM.TP_4.Entidades;

namespace TrabajosPracticosSIM.TP_6.Entidades
{
    public class EcDiferencial : IDistribucion
    {
        public IMetodoNumerico metodo { get; set; } = new Euler();
        public IDistribucion a { get; set; } = new Uniforme(0.5, 2);
        public IDistribucion b { get; set; } = new Constante(10);
        public IDistribucion c { get; set; } = new Constante(5);
        public double h { get; set; } = 0.05;
        public double x0 { get; set; } = 0;
        public double Dx0 { get; set; } = 0;
        public DataTable EulerDT { get; set; } = new DataTable();
        public DataTable RKDT { get; set; } = new DataTable();


        public double DevolverUnaVariableAleatoria(Queue<double> random)
        {
            return a.DevolverUnaVariableAleatoria(random);
        }
        public double DevolverParam1()
        {
            throw new NotImplementedException();
        }

        public void CalcularEuler()
        {
            if (metodo is Runge_Kutta)
            {
                metodo = new Euler();
            }
            if (metodo is Euler)
            {
                Queue<double> random = GenerarRandoms();
                double a_valor = a.DevolverUnaVariableAleatoria(random);
                double b_valor = b.DevolverUnaVariableAleatoria(random);
                double c_valor = c.DevolverUnaVariableAleatoria(random);
                EulerDT = metodo.Calcular(a_valor, b_valor, c_valor, h,x0,Dx0);
            }
        }

        public double DevolverParam2()
        {
            throw new NotImplementedException();
        }

        public string DevolverParams()
        {
            throw new NotImplementedException();
        }

        public int CantidadDeRandoms()
        {
            int cantidad = a.CantidadDeRandoms() + b.CantidadDeRandoms() + c.CantidadDeRandoms();
            return cantidad;
        }

        public Queue<double> GenerarRandoms()
        {
            Queue<double> random = new Queue<double>();
            Random r = new Random();
            int cantRandoms = CantidadDeRandoms();
            for (int i = 0; i < cantRandoms; i++)
            {
                random.Enqueue(r.NextDouble());
            }
            return random;
        }
    }
}
