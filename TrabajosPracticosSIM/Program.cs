using System;
using TrabajosPracticosSIM.TP_4;

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
            ControladorTP4.GetInstance().Start();
        }
    }
}
