using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajosPracticosSIM.TP_1.Entidades
{
    class GeneradorLenguaje
    {
        private SortedDictionary<int, double> lista = new SortedDictionary<int, double>();

        private int m; // Cantidad

        private Random random = new Random();
        public GeneradorLenguaje(int m)
        {
            this.m = m;
        }

        private void LlenarLista()
        {
            int posicion = 0;
            double nroRandom = 0.0;
            for (int i = 0; i < m; i++)
            {
                posicion = i + 1;
                nroRandom = Utiles.Redondear4Decimales(random.NextDouble());
                lista.Add(posicion, nroRandom);
            }
        }

        public SortedDictionary<int, double> getLista()
        {
            LlenarLista();
            return lista;
        }

        private void LimpiarLista()
        {
            lista.Clear();
        }


    }
}
