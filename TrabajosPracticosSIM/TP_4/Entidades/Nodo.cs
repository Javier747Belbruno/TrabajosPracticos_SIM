using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajosPracticosSIM.TP_4.Entidades
{
    public class Nodo
    {
        public int Id { get; set; } = 0;

        public bool EsInicial { get; set; } = false;

        public bool EsFinal { get; set; }

        public List<Actividad> Predecesores { get; set; } = new List<Actividad>();

        public List<Actividad> Sucesores { get; set; } = new List<Actividad>();

        public double TiempoFinalizacion { get; set; } = 0;

        public double CalcularTiempoFinalizacion()
        {
            TiempoFinalizacion = 0;
            foreach (Actividad a in Predecesores)
            {
                if(a.Tiempo + a.Predecesor.TiempoFinalizacion > TiempoFinalizacion)
                {
                    TiempoFinalizacion = a.Tiempo + a.Predecesor.TiempoFinalizacion;
                }
                
            }
            return TiempoFinalizacion;
        }

    }
}
