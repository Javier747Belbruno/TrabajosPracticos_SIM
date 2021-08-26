using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajosPracticosSIM.TP_1;

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

        public SortedDictionary<int, Random_VarAleatoria> getListaVariablesAleatorias(SortedDictionary<int, double> listaRandoms, SortedDictionary<int, double> listaRandoms2)
        {
            for (int i = 0; i < listaRandoms.Count; i++)
            {
                Random_VarAleatoria rVA = new Random_VarAleatoria();
                rVA.setRandom(listaRandoms.ElementAt(i).Value);
                rVA.setRandom2(listaRandoms2.ElementAt(i).Value);

                double z = Math.Sqrt(-2 * Math.Log(1 - rVA.getRandom())) * Math.Cos(2 * Math.PI * rVA.getRandom2());
                double varAleatoriaUniforme = media + (z * ds);
                rVA.setVarAleatoria(Utiles.Redondear4Decimales(varAleatoriaUniforme));

                rVA.setTieneRandom2(true);
                VariablesAleatoriasNormalLista.Add(i+1, rVA);
            }
            return VariablesAleatoriasNormalLista;
        }

    }
}
