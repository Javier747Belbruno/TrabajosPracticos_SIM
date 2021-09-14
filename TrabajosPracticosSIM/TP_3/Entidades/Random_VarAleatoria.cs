using System;

namespace TrabajosPracticosSIM.TP_3.Entidades
{
    public class Random_VarAleatoria : IComparable
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

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Random_VarAleatoria parametroRandom = obj as Random_VarAleatoria;
            if (parametroRandom != null)
                return this.varAleatoria.CompareTo(parametroRandom.varAleatoria);
            else
                throw new ArgumentException("La varAleatoria rompio todo");
        }
    }
}
