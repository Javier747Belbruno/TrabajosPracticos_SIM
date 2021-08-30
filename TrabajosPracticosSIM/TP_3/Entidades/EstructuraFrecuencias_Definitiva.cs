using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Distributions;
using TrabajosPracticosSIM.TP_1.Entidades;

namespace TrabajosPracticosSIM.TP_3.Entidades
{
    public class EstructuraFrecuencias_General //Uniforme, Normal, Exponencial y Oberti gato mira lo que hice hoy* 
    {
        private SortedDictionary<int, Random_VarAleatoria> lista;
        private int cant_intervalos;
        private int cant_numeros;
        private SortedDictionary<double, Subintervalo> intervalos = new SortedDictionary<double, Subintervalo>();
        private double chi_cuadrado;

        public EstructuraFrecuencias_General(SortedDictionary<int, Random_VarAleatoria> lista, int cant_Nros, int cant_intervalos)
        {
            this.lista = lista;
            this.cant_numeros = cant_Nros;
            this.cant_intervalos = cant_intervalos;
            this.chi_cuadrado = 0;
        }

        public void CalcularChiCuadrado()
        {
            foreach (KeyValuePair<double, Subintervalo> kvp in intervalos)
            {
                this.chi_cuadrado += kvp.Value.getIntervalo_chi_cuadrado();
            }
        }

        public SortedDictionary<double, Subintervalo> getIntervalos()
        {
            return intervalos;
        }

        public double getChi_cuadrado()
        {
            return chi_cuadrado;
        }

        public int getCant_Intervalos()
        {
            return cant_intervalos;
        }




        public void construirEstructuraFrecuencias()
        {
            //Saco el paso
            double paso = (((double)lista.Values.Max().getVarAleatoria())- ((double)lista.Values.Min().getVarAleatoria())) / (double)cant_intervalos;
            //Defino los limites del primer intervalo.
            double subinterv_limite_inf = lista.Values.Min().getVarAleatoria();
            double subinterv_limite_sup = paso + subinterv_limite_inf;
            //Frecuencia esperada por cada intervalo.
            double fe = (double)cant_numeros / cant_intervalos;
            double fo = 0;
            //Recorrer por cada intervalo todos los valores para ver si caen dentro de cada uno.
            for (int i = 0; i < cant_intervalos; i++)
            {
                //Creo objeto subintervalo.
                Subintervalo sub = new Subintervalo(subinterv_limite_inf, subinterv_limite_sup);

                //Marca de Clase
                double marca_de_clase = (subinterv_limite_inf + subinterv_limite_sup) / 2;
                //Recorro la lista de numeros randoms
                foreach (KeyValuePair<int, Random_VarAleatoria> kvp in lista)
                {
                    /*if (kvp.Value >= subinterv_limite_inf && kvp.Value < subinterv_limite_sup)
                        fo++;*/
                }
                //Seteo los valores
                sub.setFrecuenciaEsperada(fe);
                sub.setFrecuenciaObservada(fo);
                sub.setIntervalo_chi_cuadrado((Math.Pow(fe - fo, 2)) / fe);

                //Agrego intervalo
                intervalos.Add(marca_de_clase, sub);

                //Calculo para el siguiente intervalo.
                subinterv_limite_inf = subinterv_limite_sup;
                subinterv_limite_sup += paso;
                fo = 0;
            }

        }

    }
}

//*con un poquito de ayuda de javi