using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajosPracticosSIM
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada para la aplicacion.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Creamos controlador de TP1
            var c = new ControladorTP1();
            c.Start();
        }
    }
}
