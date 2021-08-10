using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajosPracticosSIM.TP_1.Entidades
{
    public class Subintervalo
    {
        private double limite_inferior;
        private double limite_superior;
        private double frecuencia;
        private double media_intervalo;

        public Subintervalo(double limite_inferior,double limite_superior)
        {
            this.limite_inferior = limite_inferior;
            this.limite_superior = limite_superior;
            this.media_intervalo = Utiles.Redondear4Decimales((limite_superior + limite_inferior) / 2);
        }
        public void setLimite_inferior(double limite_inferior)
        {
            this.limite_inferior = limite_inferior;
        }
        public double getLimite_inferior()
        {
            return limite_inferior;
        }
        public double getLimite_superior()
        {
            return limite_superior;
        }
        public void setLimite_superior(double limite_superior)
        {
            this.limite_superior = limite_superior;
        }
        public double getFrecuencia()
        {
            return frecuencia;
        }
        public void setFrecuencia(double frecuencia)
        {
            this.frecuencia = frecuencia;
        }
        public double getMedia_intervalo()
        {
            return media_intervalo;
        }
        public void setMedia_intervalo(double media_intervalo)
        {
            this.media_intervalo = media_intervalo;
        }
    }
}
