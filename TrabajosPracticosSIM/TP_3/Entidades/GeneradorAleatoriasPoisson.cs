using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics;
using TrabajosPracticosSIM.TP_1;

namespace TrabajosPracticosSIM.TP_3.Entidades
{
    public class GeneradorAleatoriasPoisson
    {
        private SortedDictionary<int, Random_VarAleatoria> VariablesAleatoriasLista = new SortedDictionary<int, Random_VarAleatoria>();

        private double lambda;

        private ArrayList probabilidadesAcumuladas = new ArrayList();
        private ArrayList funcionDeProbabilidad = new ArrayList();

        public GeneradorAleatoriasPoisson(double lambda)
        {
            this.lambda = lambda;
        }

        public ArrayList getProbabilidadesAcumladas()
        {
            return probabilidadesAcumuladas;
        }

        public ArrayList getFuncionDeProbabilidad()
        {
            return funcionDeProbabilidad;
        }

        public SortedDictionary<int, Random_VarAleatoria> getListaVariablesAleatorias(SortedDictionary<int, double> listaRandoms)
        {
            //Con la formula hacer un array de probabilidades acumuladas.
            int i = 0;
            do
            {
                //Funcion de distribucion de probabilidad.
                double fdeDistribProb = Utiles.RedondearDecimales((double)(Math.Pow(lambda, i) * Math.Exp(-lambda)) / SpecialFunctions.Factorial(i),4);
                //Guardo La primera.
                if(probabilidadesAcumuladas.Count == 0)
                {
                    funcionDeProbabilidad.Add(fdeDistribProb);
                    probabilidadesAcumuladas.Add(fdeDistribProb);
                    
                }
                else 
                {
                    funcionDeProbabilidad.Add(fdeDistribProb);
                    double acumulada = Utiles.RedondearDecimales(fdeDistribProb + (double)probabilidadesAcumuladas[i - 1],4);
                    probabilidadesAcumuladas.Add(acumulada);
                }

                i++;

            } while ((double)probabilidadesAcumuladas[i - 1] < 0.9999);
           


            foreach (KeyValuePair<int, double> kvp in listaRandoms)
            {
                Random_VarAleatoria rVA = new Random_VarAleatoria();
                rVA.setRandom(kvp.Value);

                double itemAnterior = -1;
                double varAleatoriaUniforme = 0;
                for (int j = 0; j < probabilidadesAcumuladas.Count; j++)
                {
                    if (kvp.Value >= itemAnterior && kvp.Value < (double)probabilidadesAcumuladas[j])
                    {
                        varAleatoriaUniforme = j;
                        break;
                    }
                    itemAnterior = (double)probabilidadesAcumuladas[j];
                }

                
                
                rVA.setVarAleatoria(varAleatoriaUniforme);

                VariablesAleatoriasLista.Add(kvp.Key, rVA);
            }
            return VariablesAleatoriasLista;
        }
    }
}
