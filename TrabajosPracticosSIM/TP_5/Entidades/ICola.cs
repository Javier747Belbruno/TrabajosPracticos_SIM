using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajosPracticosSIM.TP_5.Entidades
{
    public interface ICola
    {
        void ResetearCola();
        void CalcularCola(string evento,bool estado_servidor);
    }
}
