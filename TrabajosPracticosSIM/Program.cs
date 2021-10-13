using System;
using TrabajosPracticosSIM.TP_4;
using TrabajosPracticosSIM.TP_5;

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
            ControladorTP5.GetInstance().Start();
        }
    }
}
