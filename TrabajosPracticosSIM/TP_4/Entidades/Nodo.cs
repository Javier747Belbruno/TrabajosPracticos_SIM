using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajosPracticosSIM.TP_4.Entidades
{
    public class Nodo
    {
        public int Id { get; set; }

        public bool EsInicial { get; set; } = false;

        public bool EsFinal { get; set; }

        public List<Actividad> Predecesores { get; set; } = new List<Actividad>();

        public List<Actividad> Sucesores { get; set; } = new List<Actividad>();
    }
}
