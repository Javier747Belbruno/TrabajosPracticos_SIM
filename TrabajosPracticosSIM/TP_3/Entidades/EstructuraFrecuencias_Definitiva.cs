using System;
using System.Collections;
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
        private string distrSeleccionada;
        private SortedDictionary<int, Random_VarAleatoria> lista;
        private int cant_intervalos;
        private int cant_numeros;
        private SortedDictionary<double, Subintervalo> intervalos = new SortedDictionary<double, Subintervalo>();
        private double chi_cuadrado;

        public EstructuraFrecuencias_General(string distrSeleccionada,SortedDictionary<int, Random_VarAleatoria> lista, int cant_Nros, int cant_intervalos)
        {
            this.distrSeleccionada = distrSeleccionada;
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

        private double getFrecuenciaEsperada(double limite_inf, double limite_sup)
        {
            switch (distrSeleccionada)
            {
                case "Uniforme":
                    return cant_numeros / (double)cant_intervalos;
                case "Exponencial":
                    double lambda = ControladorTP3.GetInstance().getLambda();
                    double prob_en_intervaloExp = Exponential.CDF(lambda, limite_sup) - Exponential.CDF(lambda, limite_inf);
                    return prob_en_intervaloExp * cant_numeros; 
                case "Poisson":
                    return getFEPoisson(limite_inf,limite_sup);
                case "Normal":
                    double media = ControladorTP3.GetInstance().getMedia();
                    double ds = ControladorTP3.GetInstance().getDS();
                    double prob_en_intervalo = Normal.CDF(media,ds, limite_sup) - Normal.CDF(media, ds, limite_inf);
                    return prob_en_intervalo * cant_numeros;
                default:
                    break;
            }
            return 0.0;
        }

        private double getFEPoisson(double limite_inf, double limite_sup)
        {
            ArrayList prob = ControladorTP3.GetInstance().getFuncDeDistribPoisson(); 
            ArrayList probAcum = ControladorTP3.GetInstance().getFuncDeDistribPoissonAcum();
            double FEPoissonintervalo = 0.0;
            for (int i = 0; i < probAcum.Count; i++)
            {
                if (i >= limite_inf && i < limite_sup)
                    FEPoissonintervalo = FEPoissonintervalo + ((double)prob[i] * cant_numeros);
            }
            return FEPoissonintervalo;
        }

        public void construirEstructuraFrecuencias()
        {
            //Saco el paso
            double paso = (lista.Values.Max().getVarAleatoria()- lista.Values.Min().getVarAleatoria()) / (double)cant_intervalos;
            //Defino los limites del primer intervalo.
            double subinterv_limite_inf = lista.Values.Min().getVarAleatoria();
            double subinterv_limite_sup = paso + subinterv_limite_inf;
            //Inicializo frecuencia.
            double fe = 0;
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
                    if (kvp.Value.getVarAleatoria() >= subinterv_limite_inf && kvp.Value.getVarAleatoria() < subinterv_limite_sup)
                        fo++;
                }
                fe = getFrecuenciaEsperada(subinterv_limite_inf, subinterv_limite_sup);
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