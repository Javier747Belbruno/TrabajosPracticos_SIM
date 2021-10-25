using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajosPracticosSIM.TP_4.Entidades;

namespace TrabajosPracticosSIM.TP_5.Entidades
{
    public class Modelo
    {
        //Actividades
        public Llegadas llegadas { get; set; } = new Llegadas();
        public ServidorConCS s1 { get; set; } = new ServidorConCS();
        public ServidorConCS s2 { get; set; } = new ServidorConCS();
        public ServidorConCS s3 { get; set; } = new ServidorConCS();
        public ServidorConCS s4 { get; set; } = new ServidorConCS();
        public ServidorConCS s5 { get; set; } = new ServidorConCS();

        public ColaSimple c1 { get; set; } = new ColaSimple();
        public ColaSimple c2 { get; set; } = new ColaSimple();
        public ColaSimple c3 { get; set; } = new ColaSimple();
        public ColaSimple c4 { get; set; } = new ColaSimple();
        public ColaSimple c5a { get; set; } = new ColaSimple();
        public ColaSimple c5b { get; set; } = new ColaSimple();
        public ColaSimple c6a { get; set; } = new ColaSimple();
        public ColaSimple C6b { get; set; } = new ColaSimple();


        public Modelo()
        {
            IniciarLlegadas();
            IniciarServidor1();
            IniciarServidor2();
            IniciarServidor3();
            IniciarServidor4();
            IniciarServidor5();
        }
        private void IniciarLlegadas()
        {
            llegadas.Distr = new Exponencial(20);
        }
        private void IniciarServidor1()
        {
            s1.Distr = new Uniforme(20, 30);
        }
        private void IniciarServidor2()
        {
            s2.Distr = new Uniforme(30, 50);
        }
        private void IniciarServidor3()
        {
            s3.Distr = new Exponencial(30);
        }
        private void IniciarServidor4()
        {
            s4.Distr = new Uniforme(10, 20);
        }
        private void IniciarServidor5()
        {
            s5.Distr = new Exponencial(5);
        }
    }


}
