using System;
using System.Collections.Generic;
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


        public double DevolverUnaVariableAleatoria(Queue<double> random)
        {
            return a.DevolverUnaVariableAleatoria(random);
        }
        public double DevolverParam1()
        {
            throw new NotImplementedException();
        }

        public double DevolverParam2()
        {
            throw new NotImplementedException();
        }

        public string DevolverParams()
        {
            throw new NotImplementedException();
        }


    }
}
