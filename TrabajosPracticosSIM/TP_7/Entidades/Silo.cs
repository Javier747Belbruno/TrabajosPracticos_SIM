using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajosPracticosSIM.TP_4.Entidades;

namespace TrabajosPracticosSIM.TP_7.Entidades
{
    public class Silo
    {
        Random r = new Random();
        public double Capacidad_actual { get; set; } = 0;
        public double Capacidad_actual_anterior { get; set; } = 0;
        public string Estado { get; set; } = Estados.Disponible;
        public string Estado_Anterior { get; set; } = "-";
        public int? Nro_Camion { get; set; } = null;
        public int? Nro_Camion_Anterior { get; set; } = null;
        public double? Capacidad_Camion_Inicial { get; set; } = null;
        public double? Tasa_de_Descarga { get; set; } = null;
        public double? Capacidad_Camion_Final { get; set; } = null;
        public IDistribucion Distr { get; set; }
        public Queue<double> Random { get; set; } = null;
        public double? Tiempo_Fin_Llenado_Silo { get; set; } = null;
        public double? Prox_Fin_Llenado_Silo { get; set; } = null;
        public double? Tiempo_Fin_Descarga { get; set; } = null;
        public double? Prox_Fin_Descarga { get; set; } = null;
        public double? Prox_Fin_Suministro { get; set; } = null;

        public void CalcularRandom()
        {
        }

    }
}
