﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajosPracticosSIM.TP_1.Entidades
{
    class GeneradorCongruenteMultiplicativo
    {
        private SortedDictionary<int, double> lista = new SortedDictionary<int, double>();
        private int a;
        private int x; //semilla
        private int m; //Cantidad

        public GeneradorCongruenteMultiplicativo(int a, int x)
        {
            this.a = a;
            this.x = x;
            this.m = 50000; //Por defecto
        }

        public GeneradorCongruenteMultiplicativo(int a, int x, int m)
        {
            this.a = a;
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
                xi = Convert.ToInt32((a * x) % m);
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