using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajosPracticosSIM.TP_3.Entidades
{
    public class Random_VarAleatoria
    {
        private double random;
        private double varAleatoria;

        public void setRandom(double random)
        {
            this.random = random;
        }
        public void setVarAleatoria(double varAleatoria)
        {
            this.varAleatoria = varAleatoria;
        }

        public double getVarAleatoria()
        {
            return varAleatoria;
        }
        public double getRandom()
        {
            return random;
        }
    }
}
