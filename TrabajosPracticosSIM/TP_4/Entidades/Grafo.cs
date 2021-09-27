using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajosPracticosSIM.TP_4.Entidades;

namespace TrabajosPracticosSIM.TP_4.Entidades
{
    public class Grafo
    {
        //Nodos
        public Nodo nodo1 { get; set; } = new Nodo();
        public Nodo nodo2 { get; set; } = new Nodo();
        public Nodo nodo3 { get; set; } = new Nodo();
        public Nodo nodo4 { get; set; } = new Nodo();

        //Actividades
        public Actividad actividad1 { get; set; } = new Actividad();
        public Actividad actividad2 { get; set; } = new Actividad();
        public Actividad actividad3 { get; set; } = new Actividad();
        public Actividad actividad4 { get; set; } = new Actividad();
        public Actividad actividad5 { get; set; } = new Actividad();

        public Grafo()
        {
            IniciarNodo1();
            IniciarNodo2();
            IniciarNodo3();
            IniciarNodo4();
            IniciarActividad1();
            IniciarActividad2();
            IniciarActividad3();
            IniciarActividad4();
            IniciarActividad5();
            CargarActividadesPredecesoras();
            CargarActividadesSucesoras();
        }
        private void IniciarNodo1()
        {
            nodo1.Id = 1;
            nodo1.EsInicial = true;
        }
        private void IniciarNodo2()
        {
            nodo2.Id = 2;
        }
        private void IniciarNodo3()
        {
            nodo3.Id = 3;
        }
        private void IniciarNodo4()
        {
            nodo4.Id = 4;
            nodo4.EsFinal = true;
        }

        private void CargarActividadesPredecesoras()
        {
            nodo2.Predecesores.Add(actividad1);

            nodo3.Predecesores.Add(actividad4);
            nodo3.Predecesores.Add(actividad2);

            nodo4.Predecesores.Add(actividad5);
            nodo4.Predecesores.Add(actividad3);
        }
        private void CargarActividadesSucesoras()
        {
            nodo1.Sucesores.Add(actividad1);
            nodo1.Sucesores.Add(actividad2);
            nodo1.Sucesores.Add(actividad3);

            nodo2.Sucesores.Add(actividad4);

            nodo3.Sucesores.Add(actividad5);
        }

        private void IniciarActividad1()
        {
            actividad1.Id = 1;
            actividad1.Distr = new Uniforme(20, 30);
        }
        private void IniciarActividad2()
        {
            actividad2.Id = 2;
            actividad2.Distr = new Uniforme(30, 50);
        }
        private void IniciarActividad3()
        {
            actividad3.Id = 3;
            actividad3.Distr = new Exponencial(30);
        }
        private void IniciarActividad4()
        {
            actividad4.Id = 4;
            actividad4.Distr = new Uniforme(10, 20);
        }
        private void IniciarActividad5()
        {
            actividad5.Id = 5;
            actividad5.Distr = new Exponencial(5);
        }
    }
}
