using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajosPracticosSIM.TP_1.Entidades
{
    public class EstructuraFrecuencias
    {
        private SortedDictionary<int, double> lista;
        private int cant_intervalos;
        private int cant_numeros;
        private SortedDictionary<double, Subintervalo> intervalos_observados = new SortedDictionary<double, Subintervalo>();
        private SortedDictionary<double, Subintervalo> intervalos_esperados = new SortedDictionary<double, Subintervalo>();

        public EstructuraFrecuencias(SortedDictionary<int, double> lista, int cant_Nros, int cant_intervalos)
        {
            this.lista = lista;
            this.cant_numeros = cant_Nros;
            this.cant_intervalos = cant_intervalos;
        }

        public void construirEstructura()
        {
            //Hagamos primero el esperado.
            construirFrecuenciasEsperadas();
            construirFrecuenciasObservadas();


            //Con la cantidad de intervalos tengo que hacer los intervalos observados.

        }

        public SortedDictionary<double, Subintervalo> getIntervalosEsperados()
        {
            return intervalos_esperados;
        }
        public SortedDictionary<double, Subintervalo> getIntervalosObservados()
        {
            return intervalos_observados;
        }

        public void construirFrecuenciasEsperadas()
        {
            double tam_subintervalo = Utiles.Redondear4Decimales(1 / (double)cant_intervalos);
            double subinterv_limite_inf = 0;
            double subinterv_limite_sup = tam_subintervalo;
            double fe = cant_numeros / cant_intervalos;
            for (int i = 0; i < cant_intervalos; i++)
            {
                Subintervalo sub = new Subintervalo(subinterv_limite_inf, subinterv_limite_sup);
                sub.setFrecuencia(fe);

                intervalos_esperados.Add(sub.getMedia_intervalo(), sub);

                subinterv_limite_inf = subinterv_limite_sup;
                subinterv_limite_sup = Utiles.Redondear4Decimales(subinterv_limite_sup + tam_subintervalo);
            }

        }

        public void construirFrecuenciasObservadas()
        {
            double tam_subintervalo = Utiles.Redondear4Decimales(1 / (double)cant_intervalos);
            double subinterv_limite_inf = 0;
            double subinterv_limite_sup = tam_subintervalo;
            double fo = 0;
            for (int i = 0; i < cant_intervalos; i++)
            {
                Subintervalo sub = new Subintervalo(subinterv_limite_inf, subinterv_limite_sup);

                foreach (KeyValuePair<int, double> kvp in lista)
                {
                    if (kvp.Value >= subinterv_limite_inf && kvp.Value <= subinterv_limite_sup)
                        fo++;
                }
                
                sub.setFrecuencia(fo);

                intervalos_observados.Add(sub.getMedia_intervalo(), sub);

                subinterv_limite_inf = subinterv_limite_sup;
                subinterv_limite_sup = Utiles.Redondear4Decimales(subinterv_limite_sup + tam_subintervalo);
                fo = 0;
            }

        }


    }
}
