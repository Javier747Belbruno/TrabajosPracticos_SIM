using System.Collections.Generic;
using TrabajosPracticosSIM.TP_1;

namespace TrabajosPracticosSIM.TP_3.Entidades
{
    public class GeneradorAleatoriasUniforme
    {
        private SortedDictionary<int, Random_VarAleatoria> VariablesAleatoriasUniformeLista = new SortedDictionary<int, Random_VarAleatoria>();

        private double a;
        private double b;

        public GeneradorAleatoriasUniforme(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public SortedDictionary<int, Random_VarAleatoria> getListaVarUniformes(SortedDictionary<int, double> listaRandoms)
        {
            foreach (KeyValuePair<int, double> kvp in listaRandoms)
            {
                Random_VarAleatoria rVA = new Random_VarAleatoria();
                rVA.setRandom(kvp.Value);

                double varAleatoriaUniforme = a + kvp.Value * (b - a);
                rVA.setVarAleatoria(Utiles.Redondear4Decimales(varAleatoriaUniforme));

                VariablesAleatoriasUniformeLista.Add(kvp.Key, rVA);
            }
            return VariablesAleatoriasUniformeLista;
        }
    }
}
