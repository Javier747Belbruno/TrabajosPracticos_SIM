using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajosPracticosSIM.TP_3.Entidades
{
    public class GeneradorAleatoriasPoisson
    {
        private SortedDictionary<int, Random_VarAleatoria> VariablesAleatoriasLista = new SortedDictionary<int, Random_VarAleatoria>();

        private double lambda;

        public GeneradorAleatoriasPoisson(double lambda)
        {
            this.lambda = lambda;
        }

        public SortedDictionary<int, Random_VarAleatoria> getListaVariablesAleatorias(SortedDictionary<int, double> listaRandoms)
        {
            foreach (KeyValuePair<int, double> kvp in listaRandoms)
            {
                Random_VarAleatoria rVA = new Random_VarAleatoria();
                rVA.setRandom(kvp.Value);

                double varAleatoriaUniforme = (Math.Log(1 - kvp.Value)) / -lambda;
                rVA.setVarAleatoria(varAleatoriaUniforme);

                VariablesAleatoriasLista.Add(kvp.Key, rVA);
            }
            return VariablesAleatoriasLista;
        }
    }
}
