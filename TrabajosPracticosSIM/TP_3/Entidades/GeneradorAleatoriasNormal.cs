using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajosPracticosSIM.TP_3.Entidades
{
    public class GeneradorAleatoriasNormal
    {
        private SortedDictionary<int, Random_VarAleatoria> VariablesAleatoriasNormalLista = new SortedDictionary<int, Random_VarAleatoria>();

        private double media;
        private double ds;

        public GeneradorAleatoriasNormal(double media, double ds)
        {
            this.media = media;
            this.ds = ds;
        }

        public SortedDictionary<int, Random_VarAleatoria> getListaVariablesAleatorias(SortedDictionary<int, double> listaRandoms)
        {
            foreach (KeyValuePair<int, double> kvp in listaRandoms)
            {
                Random_VarAleatoria rVA = new Random_VarAleatoria();
                rVA.setRandom(kvp.Value);

                double varAleatoriaUniforme = media + kvp.Value * (media - media);
                rVA.setVarAleatoria(varAleatoriaUniforme);

                VariablesAleatoriasNormalLista.Add(kvp.Key, rVA);
            }
            return VariablesAleatoriasNormalLista;
        }

    }
}
