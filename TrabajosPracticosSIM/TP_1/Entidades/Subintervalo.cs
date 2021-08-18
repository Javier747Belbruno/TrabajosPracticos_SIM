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
        private double frecuencia_observada;
        private double frecuencia_esperada;
        private double intervalo_chi_cuadrado;

        public Subintervalo(double limite_inferior,double limite_superior)
        {
            this.limite_inferior = limite_inferior;
            this.limite_superior = limite_superior;
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
        public double getFrecuenciaObservada()
        {
            return frecuencia_observada;
        }
        public void setFrecuenciaEsperada(double frecuencia_esperada)
        {
            this.frecuencia_esperada = frecuencia_esperada;
        }
        public double getFrecuenciaEsperada()
        {
            return frecuencia_esperada;
        }
        public void setFrecuenciaObservada(double frecuencia_observada)
        {
            this.frecuencia_observada = frecuencia_observada;
        }
        public void setIntervalo_chi_cuadrado(double intervalo_chi_cuadrado)
        {
            this.intervalo_chi_cuadrado = intervalo_chi_cuadrado;
        }
        public double getIntervalo_chi_cuadrado()
        {
            return intervalo_chi_cuadrado;
        }
    }
}
