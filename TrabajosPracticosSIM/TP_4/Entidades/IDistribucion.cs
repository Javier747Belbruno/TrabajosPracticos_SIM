using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajosPracticosSIM.TP_4.Entidades
{
    public interface IDistribucion
    {
        /// <summary>
        /// Una cola de numeros randoms que esperan ser usados
        /// </summary>
        /// <param name="random"></param>
        /// <returns> Variable Aleatoria</returns>
        double DevolverUnaVariableAleatoria(Queue<double> random);
        string DevolverParams();
        double DevolverParam1();
        double DevolverParam2();
    }
}
