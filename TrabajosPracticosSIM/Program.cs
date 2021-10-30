using System;
using TrabajosPracticosSIM.TP_4;
using TrabajosPracticosSIM.TP_6;

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
            //Inicio Controlador TP(Elegir)
            ControladorTP6.GetInstance().Start();
        }
    }
}
