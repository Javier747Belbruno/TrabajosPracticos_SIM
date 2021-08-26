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
        private double random2;
        private double varAleatoria;
        private Boolean tieneRandom2 = false;

        public void setRandom(double random)
        {
            this.random = random;
        }
        public void setVarAleatoria(double varAleatoria)
        {
            this.varAleatoria = varAleatoria;
        }
        public void setRandom2(double random2)
        {
            this.random2 = random2;
        }

        public double getVarAleatoria()
        {
            return varAleatoria;
        }
        public double getRandom()
        {
            return random;
        }
        public double getRandom2()
        {
            return random2;
        }

        public void setTieneRandom2(Boolean tieneRandom2)
        {
            this.tieneRandom2 = tieneRandom2;
        }

        public Boolean getTieneRandom2()
        {
            return tieneRandom2;
        }
    }
}
