using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajosPracticosSIM.TP_4.Entidades;
using TrabajosPracticosSIM.TP_6.Entidades;

namespace TrabajosPracticosSIM.TP_7.Entidades
{
    public class EcuacionDiferencial : IDistribucion
    {
        public IMetodoNumerico metodo { get; set; } = new Euler();
        public IDistribucion a { get; set; } = new Uniforme(0.5, 2);
        public IDistribucion b { get; set; } = new Constante(10);
        public IDistribucion c { get; set; } = new Constante(5);
        public IDistribucion h { get; set; } = new Constante(0.05);
        public IDistribucion x0 { get; set; } = new Constante(0);
        public IDistribucion Dx0 { get; set; } = new Constante(0);
        public DataTable EulerDT { get; set; } = new DataTable();
        public DataTable RKDT { get; set; } = new DataTable();
        public double a_fijo_euler { get; set; } = 1;
        public double a_fijo_rk { get; set; } = 1;

        /// <summary>
        /// Calcular el tiempo del segundo pico maximo con Runge Kutta.
        /// </summary>
        /// <param name="random"></param>
        /// <returns></returns>
        public double DevolverUnaVariableAleatoria(Queue<double> random)
        {
            double variable_aleatoria = 0;
            if (metodo is Euler)
            {
                metodo = new Runge_Kutta();
            }
            if (metodo is Runge_Kutta)
            {
                random = GenerarRandoms();
                double a_valor = a.DevolverUnaVariableAleatoria(random);
                double b_valor = b.DevolverUnaVariableAleatoria(random);
                double c_valor = c.DevolverUnaVariableAleatoria(random);
                double h_valor = h.DevolverUnaVariableAleatoria(random);
                double x0_valor = x0.DevolverUnaVariableAleatoria(random);
                double Dx0_valor = Dx0.DevolverUnaVariableAleatoria(random);

                variable_aleatoria = metodo.CalcularTiempo2doPicoMaximo(a_valor, b_valor, c_valor, h_valor, x0_valor, Dx0_valor);
            }
            return variable_aleatoria;
        }
        /// <summary>
        /// MMMM
        /// </summary>
        /// <returns></returns>
        public double DevolverParam1()
        {
            return a_fijo_euler;
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
                double h_valor = h.DevolverUnaVariableAleatoria(random);
                double x0_valor = x0.DevolverUnaVariableAleatoria(random);
                double Dx0_valor = Dx0.DevolverUnaVariableAleatoria(random);
                if (a_fijo_euler != a_fijo_rk)
                {
                    a_valor = a_fijo_rk;
                }
                EulerDT = metodo.Calcular(a_valor, b_valor, c_valor, h_valor, x0_valor,Dx0_valor);
                a_fijo_euler = a_valor;
            }
        }

        public void CalcularRK()
        {
            if (metodo is Euler)
            {
                metodo = new Runge_Kutta();
            }
            if (metodo is Runge_Kutta)
            {
                Queue<double> random = GenerarRandoms();
                double a_valor = a.DevolverUnaVariableAleatoria(random);
                double b_valor = b.DevolverUnaVariableAleatoria(random);
                double c_valor = c.DevolverUnaVariableAleatoria(random);
                double h_valor = h.DevolverUnaVariableAleatoria(random);
                double x0_valor = x0.DevolverUnaVariableAleatoria(random);
                double Dx0_valor = Dx0.DevolverUnaVariableAleatoria(random);
                if (a_fijo_euler != a_fijo_rk)
                {
                    a_valor = a_fijo_euler;
                }
                RKDT = metodo.Calcular(a_valor, b_valor, c_valor, h_valor, x0_valor, Dx0_valor);
                a_fijo_rk = a_valor;
            }
        }

        public double DevolverParam2()
        {
            return a_fijo_euler;
        }

        public string DevolverParams()
        {
            return a.DevolverParams()+" "+ b.DevolverParams() + " " + c.DevolverParams() 
                + " " + h.DevolverParams() + " " + x0.DevolverParams() + " " + Dx0.DevolverParams();
        }

        public int CantidadDeRandoms()
        {
            int cantidad = a.CantidadDeRandoms() + b.CantidadDeRandoms()
                + c.CantidadDeRandoms() + h.CantidadDeRandoms() + x0.CantidadDeRandoms()
                 + Dx0.CantidadDeRandoms() ;
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
