using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajosPracticosSIM.TP_5.Entidades
{
    public class ColaDoble : ICola
    {
        public ColaSimple cs1 { get; set; }
        public ColaSimple cs2 { get; set; }

        public void CalcularCola()
        {
            throw new NotImplementedException();
        }

        public void ResetearCola()
        {
            cs1.ResetearCola();
            cs2.ResetearCola();
        }

        public void som()
        {
            cs1.Cantidad = 0;
        }
    }
}
