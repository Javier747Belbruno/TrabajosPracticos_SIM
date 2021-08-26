using System;
using TrabajosPracticosSIM.TP_3;

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
            //Inicio Controlador TP (Elegir)
            ControladorTP3.GetInstance().Start();
        }
    }
}
