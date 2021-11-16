using System;
using TrabajosPracticosSIM.TP_7;

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
            ControladorTP7.GetInstance().Start();
        }
    }
}
