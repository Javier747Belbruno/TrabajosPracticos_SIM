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
        public Llegadas Llegadas { get; set; } = new Llegadas();
        public ServidorConCS S1 { get; set; } = new ServidorConCS();
        public ServidorConCS S2 { get; set; } = new ServidorConCS();
        public ServidorConCS S3 { get; set; } = new ServidorConCS();
        public ServidorConCS S4 { get; set; } = new ServidorConCS();
        public ServidorConCD S5 { get; set; } = new ServidorConCD();

        public ColaDoble C6 { get; set; } = new ColaDoble();

        public List<IServidor> ListaServidores { get; set; } = new List<IServidor>();

        public List<ICola> ListaColas { get; set; } = new List<ICola>();
        public Modelo()
        {
            IniciarLlegadas();
            IniciarServidor1();
            IniciarServidor2();
            IniciarServidor3();
            IniciarServidor4();
            IniciarServidor5();
            IniciarCola6();
            IniciarListaServidores();
            IniciarListaColas();
        }
        private void IniciarListaServidores()
        {
            ListaServidores.Add(S1);
            ListaServidores.Add(S2);
            ListaServidores.Add(S3);
            ListaServidores.Add(S4);
            ListaServidores.Add(S5);
        }
        private void IniciarListaColas()
        {
            ListaColas.Add(S1.Cola);
            ListaColas.Add(S2.Cola);
            ListaColas.Add(S3.Cola);
            ListaColas.Add(S4.Cola);
            ListaColas.Add(S5.Cola);
            ListaColas.Add(C6);
        }
        private void IniciarLlegadas()
        {
            Llegadas.Distr = new Exponencial(20);
        }
        private void IniciarServidor1()
        {
            S1.Distr = new Uniforme(20, 30);
            S1.Cola.EventoEncolador = Evento.Llegada_Pedido;
            S1.Cola.EventoDecolador = Evento.Fin_Actividad_1;
        }
        private void IniciarServidor2()
        {
            S2.Distr = new Uniforme(30, 50);
            S2.Cola.EventoEncolador = Evento.Llegada_Pedido;
            S2.Cola.EventoDecolador = Evento.Fin_Actividad_2;
        }
        private void IniciarServidor3()
        {
            S3.Distr = new Exponencial(30);
            S3.Cola.EventoEncolador = Evento.Llegada_Pedido;
            S3.Cola.EventoDecolador = Evento.Fin_Actividad_3;
        }
        private void IniciarServidor4()
        {
            S4.Distr = new Uniforme(10, 20);
            S4.Cola.EventoEncolador = Evento.Fin_Actividad_1;
            S4.Cola.EventoDecolador = Evento.Fin_Actividad_4;
        }
        private void IniciarServidor5()
        {
            S5.Distr = new Exponencial(5);
            S5.Cola.Cola1.EventoEncolador = Evento.Fin_Actividad_4;
            S5.Cola.Cola1.EventoDecolador = Evento.Fin_Actividad_5;
            S5.Cola.Cola2.EventoEncolador = Evento.Fin_Actividad_2;
            S5.Cola.Cola2.EventoDecolador = Evento.Fin_Actividad_5;
        }
        private void IniciarCola6()
        {
            C6.Cola1.EventoEncolador = Evento.Fin_Actividad_5;
            C6.Cola2.EventoEncolador = Evento.Fin_Actividad_3;
        }
    }


}
