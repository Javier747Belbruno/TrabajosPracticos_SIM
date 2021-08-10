using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajosPracticosSIM.TP_1.Entidades
{
    public class GeneradorCongruenteMixto
    {
        private SortedDictionary<int, double> lista = new SortedDictionary<int, double>();
        private int a;
        private int c;
        private int x; //semilla
        private int m; //Cantidad

        public GeneradorCongruenteMixto(int a,int c, int x)
        {
            this.a = a;
            this.c = c;
            this.x = x;
            this.m = 50000; //Por defecto
        }

        public GeneradorCongruenteMixto(int a, int c, int x, int m)
        {
            this.a = a;
            this.c = c;
            this.x = x;
            this.m = m;
        }

        private void LlenarLista()
        {
            int posicion = 0;
            int xi = 0;
            double random = 0.0;
            for (int i = 0; i < m; i++)
            {
                posicion = i + 1;
                xi = Convert.ToInt32((a * x + c) % m);
                random = Utiles.Dividir(xi, m);
                lista.Add(posicion, random);
                x = xi;
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
