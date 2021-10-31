using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajosPracticosSIM.TP_4.Entidades;
using TrabajosPracticosSIM.TP_5.Entidades;

namespace TrabajosPracticosSIM.TP_6.Entidades
{
    public class ModeloTP6 : IModelo
    {
        //Actividades
        public Llegadas Llegadas { get; set; } = new Llegadas();
        public ServidorConCS S1 { get; set; } = new ServidorConCS();
        public ServidorConCS S2 { get; set; } = new ServidorConCS();
        public ServidorConCS S3 { get; set; } = new ServidorConCS();
        public ServidorConCS S4 { get; set; } = new ServidorConCS();
        public ServidorConCD S5 { get; set; } = new ServidorConCD();
        public ServidorConCD S6 { get; set; } = new ServidorConCD();

        public List<IServidor> ListaServidores { get; set; } = new List<IServidor>();

        public List<ICola> ListaColas { get; set; } = new List<ICola>();

        #region CREACION E INICIALIZACION DE VARIABLES
        #region Definiciones

        public double reloj { get; set; } = 0;
        public double reloj_anterior { get; set; } = 0;
        public string evento { get; set; } = Evento.Inicio;
        public int? nro_pedido { get; set; } = null;
        #endregion
        #region Estadisticas

        public int pedidos_realizados { get; set; } = 0;
        public int pedidos_realizados_anterior { get; set; } = 0;
        public int? nro_pedido_listo { get; set; } = null;
        public double? tiempo_ensamble { get; set; } = null;
        //q de queue
        public Queue<double> q_tiempos_llegada_pedido { get; set; } = new Queue<double>();
        public Queue<double> q_tiempos_act1 { get; set; } = new Queue<double>();
        public Queue<double> q_tiempos_act2 { get; set; } = new Queue<double>();
        public Queue<double> q_tiempos_act3 { get; set; } = new Queue<double>();
        public Queue<double> q_tiempos_act4 { get; set; } = new Queue<double>();
        public Queue<double> q_tiempos_act5 { get; set; } = new Queue<double>();
        public Queue<double> q_tiempos_act6 { get; set; } = new Queue<double>();
        //e de estadisticas para diferenciarlos de las definiciones
        public double? e_t_llegada_pedido { get; set; } = null;
        public double? e_t_a1 { get; set; } = null;
        public double? e_t_a2 { get; set; } = null;
        public double? e_t_a3 { get; set; } = null;
        public double? e_t_a4 { get; set; } = null;
        public double? e_t_a5 { get; set; } = null;
        public double? e_t_a6 { get; set; } = null;
        //Caminos
        public double? camino1 { get; set; } = null;
        public double? camino2 { get; set; } = null;
        public double? camino3 { get; set; } = null;

        #endregion
        #region Punto 2

        public double prom_tiempo_ensamble { get; set; } = 0;

        #endregion
        #region Punto 3

        public int p3_pedidos_solicitados { get; set; } = 0;
        public double p3_proporcion_PR_PS { get; set; } = 0;

        #endregion
        #region Punto 7

        public int p7_pedidos_en_sist { get; set; } = 0;
        public double p7_prom_pedidos_en_sist { get; set; } = 0;

        #endregion
        #region Punto 10

        public double p10_reloj { get; set; } = 0;
        public double p10_reloj_anterior { get; set; } = 0;
        public int p10_nro_hora { get; set; } = 0;



        public int p10_nro_hora_anterior { get; set; } = 0;
        public int p10_contador { get; set; } = 0;
        int p10_contador_anterior { get; set; } = 0;
        public double p10_prom_ensambles { get; set; } = 0;

        #endregion
        #region Punto 11

        public int? p11_contador_mayor_igual { get; set; } = null;
        public double p11_probabilidad { get; set; } = 0;

        #endregion
        #region Punto 13

        public string p13_camino_critico { get; set; } = "-";
        public double p13_a1 { get; set; } = 0;
        public double p13_a2 { get; set; } = 0;
        public double p13_a3 { get; set; } = 0;
        public double p13_a4 { get; set; } = 0;
        public double p13_a5 { get; set; } = 0;

        #endregion

        #endregion
        public ModeloTP6(EcDiferencial ed)
        {
            IniciarLlegadas();
            IniciarServidor1();
            IniciarServidor2();
            IniciarServidor3();
            IniciarServidor4();
            IniciarServidor5();
            IniciarServidor6(ed);
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
            ListaServidores.Add(S6);
        }
        private void IniciarListaColas()
        {
            ListaColas.Add(S1.Cola);
            ListaColas.Add(S2.Cola);
            ListaColas.Add(S3.Cola);
            ListaColas.Add(S4.Cola);
            ListaColas.Add(S5.Cola);
            ListaColas.Add(S6.Cola); ;
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
        private void IniciarServidor6(EcDiferencial ed)
        {
            S6.Distr = ed;
            S6.Cola.Cola1.EventoEncolador = Evento.Fin_Actividad_5;
            S6.Cola.Cola1.EventoDecolador = Evento.Fin_Actividad_6;
            S6.Cola.Cola2.EventoEncolador = Evento.Fin_Actividad_3;
            S6.Cola.Cola2.EventoDecolador = Evento.Fin_Actividad_6;
        }
        public void CalcularLlegada()
        {
            Llegadas.CalcularProxNroPedido(nro_pedido);
            Llegadas.CalcularRandom(evento);
            Llegadas.CalcularTiempo();
            Llegadas.CalcularProxTiempo(reloj);
        }
        public void GuardarLlegadaPedido()
        {
            q_tiempos_llegada_pedido.Enqueue((double)Llegadas.Tiempo_Prox);
        }
        public void CalcularReloj()
        {
            reloj_anterior = reloj;
            reloj = ProxTiempoMinimo();
        }
        private double ProxTiempoMinimo()
        {
            List<double> proximos_tiempos = new List<double>();
            double? t1 = Llegadas.Tiempo_Prox;
            double? t2 = S1.TiempoProx;
            double? t3 = S2.TiempoProx;
            double? t4 = S3.TiempoProx;
            double? t5 = S4.TiempoProx;
            double? t6 = S5.TiempoProx;
            double? t7 = S6.TiempoProx;

            if (t1.HasValue)
            {
                proximos_tiempos.Add((double)t1);
            }
            if (t2.HasValue)
            {
                proximos_tiempos.Add((double)t2);
            }
            if (t3.HasValue)
            {
                proximos_tiempos.Add((double)t3);
            }
            if (t4.HasValue)
            {
                proximos_tiempos.Add((double)t4);
            }
            if (t5.HasValue)
            {
                proximos_tiempos.Add((double)t5);
            }
            if (t6.HasValue)
            {
                proximos_tiempos.Add((double)t6);
            }
            if (t7.HasValue)
            {
                proximos_tiempos.Add((double)t7);
            }
            proximos_tiempos.Sort();

            return proximos_tiempos.First();
        }

        public void CalcularEvento()
        {
            evento = DeterminarEvento(reloj);
        }
        private string DeterminarEvento(double reloj)
        {
            if (reloj == Llegadas.Tiempo_Prox)
                return Evento.Llegada_Pedido;
            if (reloj == S1.TiempoProx)
                return Evento.Fin_Actividad_1;
            if (reloj == S2.TiempoProx)
                return Evento.Fin_Actividad_2;
            if (reloj == S3.TiempoProx)
                return Evento.Fin_Actividad_3;
            if (reloj == S4.TiempoProx)
                return Evento.Fin_Actividad_4;
            if (reloj == S5.TiempoProx)
                return Evento.Fin_Actividad_5;
            if (reloj == S6.TiempoProx)
                return Evento.Fin_Actividad_6;
            return "x";
        }
        public void CalcularNroPedido()
        {
            nro_pedido = DeterminarNumeroPedido(evento);
        }
        private int? DeterminarNumeroPedido(string evento)
        {
            switch (evento)
            {
                case Evento.Llegada_Pedido:
                    return Llegadas.Prox_Nro_Pedido;
                case Evento.Fin_Actividad_1:
                    return S1.Nro_Pedido;
                case Evento.Fin_Actividad_2:
                    return S2.Nro_Pedido;
                case Evento.Fin_Actividad_3:
                    return S3.Nro_Pedido;
                case Evento.Fin_Actividad_4:
                    return S4.Nro_Pedido;
                case Evento.Fin_Actividad_5:
                    return S5.Nro_Pedido;
                case Evento.Fin_Actividad_6:
                    return S6.Nro_Pedido;
                default:
                    return 0;
            }
        }
        public void CalcularServidoresYColas()
        {
            foreach (IServidor s in ListaServidores)
            {
                s.CalcularCola(evento);
                s.CalcularEstado(evento);
                s.CalcularNroPedidoEnAtencion(evento, nro_pedido);
                s.CalcularRandom();
                s.CalcularTiempo();
                s.CalcularTiempoProx(reloj);
            }
        }
        public void CalcularPedidosRealizados()
        {
            pedidos_realizados_anterior = pedidos_realizados;
            pedidos_realizados = CalcularAcumuladorEnsamblesRealizados(evento, pedidos_realizados);
        }
        private int CalcularAcumuladorEnsamblesRealizados(string evento, int pedidos_realizados)
        {
            if (evento == Evento.Fin_Actividad_6)
            {
                pedidos_realizados++;
            }
            return pedidos_realizados;
        }

        public void CalcularNroPedidoRealizado()
        {
            nro_pedido_listo = DeterminarNroPedidoRealizados(pedidos_realizados, pedidos_realizados_anterior, nro_pedido);
        }
        private int? DeterminarNroPedidoRealizados(int pedidos_realizados, int pedidos_realizados_anterior, int? nro_pedido)
        {
            if (pedidos_realizados != pedidos_realizados_anterior)
                return nro_pedido;
            return null;
        }
        public void CalcularTiemposDeCadaPedido()
        {
            e_t_llegada_pedido = CalcularTiemposLlegadaCliente(q_tiempos_llegada_pedido, pedidos_realizados_anterior, pedidos_realizados);
            e_t_a1 = CalcularTiemposAct1(q_tiempos_act1, pedidos_realizados_anterior, pedidos_realizados);
            e_t_a2 = CalcularTiemposAct2(q_tiempos_act2, pedidos_realizados_anterior, pedidos_realizados);
            e_t_a3 = CalcularTiemposAct3(q_tiempos_act3, pedidos_realizados_anterior, pedidos_realizados);
            e_t_a4 = CalcularTiemposAct4(q_tiempos_act4, pedidos_realizados_anterior, pedidos_realizados);
            e_t_a5 = CalcularTiemposAct5(q_tiempos_act5, pedidos_realizados_anterior, pedidos_realizados);
            e_t_a6 = CalcularTiemposAct6(q_tiempos_act6, pedidos_realizados_anterior, pedidos_realizados);
        }
        private double? CalcularTiemposAct6(Queue<double> q_tiempos_act6, int pedidos_realizados_anterior, int pedidos_realizados)
        {
            if (pedidos_realizados != pedidos_realizados_anterior)
            {
                if (S6.Tiempo.HasValue)
                {
                    q_tiempos_act6.Enqueue(S6.TiempoProx.Value);
                }
                return q_tiempos_act6.Dequeue();
            }
            else
            {
                if (S6.Tiempo.HasValue)
                {
                    q_tiempos_act6.Enqueue(S6.TiempoProx.Value);
                }
                if (q_tiempos_act6.Count == 0)
                {
                    return null;
                }
                return q_tiempos_act6.Peek();
            }
        }
        private double? CalcularTiemposAct5(Queue<double> q_tiempos_act5, int pedidos_realizados_anterior, int pedidos_realizados)
        {
            if (pedidos_realizados != pedidos_realizados_anterior)
            {
                if (S5.Tiempo.HasValue)
                {
                    q_tiempos_act5.Enqueue(S5.TiempoProx.Value);
                }
                return q_tiempos_act5.Dequeue();
            }
            else
            {
                if (S5.Tiempo.HasValue)
                {
                    q_tiempos_act5.Enqueue(S5.TiempoProx.Value);
                }
                if (q_tiempos_act5.Count == 0)
                {
                    return null;
                }
                return q_tiempos_act5.Peek();
            }
        }

        private double? CalcularTiemposAct4(Queue<double> q_tiempos_act4, int pedidos_realizados_anterior, int pedidos_realizados)
        {
            if (pedidos_realizados != pedidos_realizados_anterior)
            {
                return q_tiempos_act4.Dequeue();
            }
            else
            {
                if (S4.Tiempo.HasValue)
                {
                    q_tiempos_act4.Enqueue(S4.TiempoProx.Value);
                }
                if (q_tiempos_act4.Count == 0)
                {
                    return null;
                }
                return q_tiempos_act4.Peek();
            }
        }

        private double? CalcularTiemposAct3(Queue<double> q_tiempos_act3, int pedidos_realizados_anterior, int pedidos_realizados)
        {
            if (pedidos_realizados != pedidos_realizados_anterior)
            {
                if (S3.Tiempo.HasValue)
                {
                    q_tiempos_act3.Enqueue(S3.TiempoProx.Value);
                }
                return q_tiempos_act3.Dequeue();
            }
            else
            {
                if (S3.Tiempo.HasValue)
                {
                    q_tiempos_act3.Enqueue(S3.TiempoProx.Value);
                }
                if (q_tiempos_act3.Count == 0)
                {
                    return null;
                }
                return q_tiempos_act3.Peek();
            }
        }

        private double? CalcularTiemposAct2(Queue<double> q_tiempos_act2, int pedidos_realizados_anterior, int pedidos_realizados)
        {
            if (pedidos_realizados != pedidos_realizados_anterior)
            {
                return q_tiempos_act2.Dequeue();
            }
            else
            {
                if (S2.Tiempo.HasValue)
                {
                    q_tiempos_act2.Enqueue(S2.TiempoProx.Value);
                }
                if (q_tiempos_act2.Count == 0)
                {
                    return null;
                }
                return q_tiempos_act2.Peek();
            }
        }

        private double? CalcularTiemposAct1(Queue<double> q_tiempos_act1, int pedidos_realizados_anterior, int pedidos_realizados)
        {

            if (pedidos_realizados != pedidos_realizados_anterior)
            {
                return q_tiempos_act1.Dequeue();
            }
            else
            {
                if (S1.Tiempo.HasValue)
                {
                    q_tiempos_act1.Enqueue(S1.TiempoProx.Value);
                }
                if (q_tiempos_act1.Count == 0)
                {
                    return null;
                }
                return q_tiempos_act1.Peek();
            }

        }

        private double? CalcularTiemposLlegadaCliente(Queue<double> q_tiempos_llegada_pedido, int pedidos_realizados_anterior, int pedidos_realizados)
        {

            if (pedidos_realizados != pedidos_realizados_anterior)
            {
                return q_tiempos_llegada_pedido.Dequeue();
            }
            else
            {
                if (Llegadas.Tiempo.HasValue)
                {
                    q_tiempos_llegada_pedido.Enqueue(Llegadas.Tiempo_Prox.Value);
                }
                if (q_tiempos_llegada_pedido.Count == 0)
                {
                    return null;
                }
                return q_tiempos_llegada_pedido.Peek();
            }

        }
        public void CalcularCaminos()
        {
            camino1 = CalcularCamino1(e_t_llegada_pedido, e_t_a6, pedidos_realizados_anterior, pedidos_realizados);
            camino2 = camino1;
            camino3 = camino1;
        }

        private double? CalcularCamino1(double? e_t_llegada_pedido, double? e_t_a6, int pedidos_realizados_anterior, int pedidos_realizados)
        {
            if (pedidos_realizados != pedidos_realizados_anterior)
            {
                return (e_t_a6 - e_t_llegada_pedido);
            }
            else
            {
                return null;
            }
        }
        public void CalcularTiempoEnsamble()
        {
            tiempo_ensamble = CalcularTiempoNetoEnsamble(camino1, pedidos_realizados_anterior, pedidos_realizados);

        }
        private double? CalcularTiempoNetoEnsamble(double? camino1, int pedidos_realizados_anterior, int pedidos_realizados)
        {
            if (pedidos_realizados != pedidos_realizados_anterior)
            {
                return camino1;
            }
            else
            {
                return null;
            }
        }
        public void CalcularPunto2()
        {
            prom_tiempo_ensamble = CalcularPromTiempoEnsamble(prom_tiempo_ensamble, tiempo_ensamble, pedidos_realizados);
        }
        private double CalcularPromTiempoEnsamble(double prom_tiempo_ensamble, double? tiempo_ensamble, int pedidos_realizados)
        {
            if (tiempo_ensamble.HasValue)
                return (double)(((pedidos_realizados - 1) * prom_tiempo_ensamble + tiempo_ensamble) / pedidos_realizados);
            else
                return prom_tiempo_ensamble;
        }
        public void CalcularPunto3()
        {
            p3_pedidos_solicitados = (int)(Llegadas.Prox_Nro_Pedido - 1);
            p3_proporcion_PR_PS = (pedidos_realizados > 0 ? (pedidos_realizados / ((double)p3_pedidos_solicitados)) * 100 : 0);
        }
        public void CalcularPunto4()
        {
            foreach (ICola c in ListaColas)
            {
                c.CalcularMaxCantEnCola();
            }
        }
        public void CalcularPunto5()
        {
            foreach (ICola c in ListaColas)
            {
                c.CalcularTiempoPromedioEnCola(reloj_anterior, reloj, p3_pedidos_solicitados);
            }
        }
        public void CalcularPunto6()
        {
            foreach (ICola c in ListaColas)
            {
                c.CalcularCantPromedioEnCola(reloj);
            }
        }
        public void CalcularPunto7(int i)
        {
            p7_pedidos_en_sist = p3_pedidos_solicitados - pedidos_realizados;
            p7_prom_pedidos_en_sist = ((i - 1) * p7_prom_pedidos_en_sist + p7_pedidos_en_sist) / (double)i;
        }
        public void CalcularPunto8()
        {
            foreach (IServidor s in ListaServidores)
            {
                s.CalcularPorcentajeOcupacionServidor(reloj, reloj_anterior);
            }
        }
        public void CalcularPunto9()
        {
            //Punto 9a
            S5.CalcularProporcionBloqueadoOcupado(reloj, reloj_anterior);
            //Punto 9b
            S6.Cola.CalcularProporcionesDeEspera();
        }
        public void CalcularPunto10()
        {
            p10_reloj = reloj % 60;
            p10_reloj_anterior = reloj_anterior % 60;
            p10_nro_hora_anterior = (int)Math.Truncate(reloj_anterior / 60) + 1;
            p10_nro_hora = (int)Math.Truncate(reloj / 60) + 1;
            p10_contador_anterior = p10_contador;
            p10_contador = CalcularContadorEnsamblesPorHora(p10_reloj, p10_reloj_anterior, pedidos_realizados, pedidos_realizados_anterior, p10_contador);
            p10_prom_ensambles = CalcularPromEnsamblesPorHora(p10_nro_hora, p10_nro_hora_anterior, p10_contador_anterior, p10_prom_ensambles);

        }
        private double CalcularPromEnsamblesPorHora(int p10_nro_hora, int p10_nro_hora_anterior, int p10_contador_anterior, double p10_prom_ensambles)
        {
            if (p10_nro_hora != p10_nro_hora_anterior)
            {
                return (((p10_nro_hora_anterior - 1) * p10_prom_ensambles) + p10_contador_anterior) / p10_nro_hora_anterior;
            }
            else
            {
                return p10_prom_ensambles;
            }
        }
        private int CalcularContadorEnsamblesPorHora(double reloj, double reloj_anterior, int pedidos_realizados, int pedidos_realizados_anterior, int p10_contador)
        {
            if (pedidos_realizados != pedidos_realizados_anterior)
            {
                return p10_contador + 1;
            }
            else
            {
                if (reloj >= reloj_anterior)
                {
                    return p10_contador;
                }
                else
                {
                    return 0;
                }
            }
        }
        public void CalcularPunto11(int param_punto_11)
        {
            p11_contador_mayor_igual = CalcularContadorMayorIgualParametro(p10_nro_hora, p10_nro_hora_anterior, p10_contador_anterior, param_punto_11);
            p11_probabilidad = CalcularProbMayorIgualParametro(p10_nro_hora, p10_nro_hora_anterior, p11_contador_mayor_igual, p11_probabilidad);

        }
        private double CalcularProbMayorIgualParametro(int p10_nro_hora, int p10_nro_hora_anterior, int? p11_contador_mayor_igual, double p11_probabilidad)
        {
            if (p10_nro_hora != p10_nro_hora_anterior)
            {
                return (double)((((p10_nro_hora_anterior - 1) * p11_probabilidad) + p11_contador_mayor_igual) / (double)p10_nro_hora_anterior);
            }
            else
            {
                return p11_probabilidad;
            }
        }
        private int? CalcularContadorMayorIgualParametro(int p10_nro_hora, int p10_nro_hora_anterior, int p10_contador_anterior, int param_punto_11)
        {
            if (p10_nro_hora != p10_nro_hora_anterior)
            {
                if (p10_contador_anterior >= param_punto_11)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return null;
            }
        }
        public void CalcularPunto13()
        {
            p13_camino_critico = DeterminarCaminoCritico(pedidos_realizados, pedidos_realizados_anterior, tiempo_ensamble, camino1, e_t_a2, e_t_a4, e_t_a5, e_t_a3);
            p13_a1 = CalcularProporcionCaminoCritico(p13_camino_critico, "C1", pedidos_realizados, p13_a1);
            p13_a2 = CalcularProporcionCaminoCritico(p13_camino_critico, "C2", pedidos_realizados, p13_a2);
            p13_a3 = CalcularProporcionCaminoCritico(p13_camino_critico, "C3", pedidos_realizados, p13_a3);
            p13_a4 = CalcularProporcionCaminoCritico(p13_camino_critico, "C1", pedidos_realizados, p13_a4);
            p13_a5 = CalcularProporcionCaminoCriticoA5(p13_camino_critico, "C1", "C2", pedidos_realizados, p13_a5);
        }
        private string DeterminarCaminoCritico(int pedidos_realizados, int pedidos_realizados_anterior, double? tiempo_ensamble, double? camino1, double? e_t_a2, double? e_t_a4, double? e_t_a5, double? e_t_a3)
        {
            if (pedidos_realizados != pedidos_realizados_anterior)
            {
                if (e_t_a5 > e_t_a3)
                {
                    if (e_t_a2 > e_t_a4)
                    {
                        return "C2";
                    }
                    else
                    {
                        return "C1";
                    }
                }
                else
                {
                    return "C3";
                }
            }
            return "-";
        }
        private double CalcularProporcionCaminoCriticoA5(string p13_camino_critico, string caminoPredeterminado1, string caminoPredeterminado2, int pedidos_realizados, double p13_a5)
        {
            if (p13_camino_critico != "-")
            {
                if (p13_camino_critico == caminoPredeterminado1 || p13_camino_critico == caminoPredeterminado2)
                {
                    return ((pedidos_realizados - 1) * p13_a5 + 1) / (double)pedidos_realizados;
                }
                else
                {
                    return ((pedidos_realizados - 1) * p13_a5 + 0) / (double)pedidos_realizados;
                }
            }
            else
            {
                return p13_a5;
            }
        }

        private double CalcularProporcionCaminoCritico(string p13_camino_critico, string caminoPredeterminado, int pedidos_realizados, double p13_a1)
        {
            if (p13_camino_critico != "-")
            {
                if (p13_camino_critico == caminoPredeterminado)
                {
                    return ((pedidos_realizados - 1) * p13_a1 + 1) / (double)pedidos_realizados;
                }
                else
                {
                    return ((pedidos_realizados - 1) * p13_a1 + 0) / (double)pedidos_realizados;
                }
            }
            else
            {
                return p13_a1;
            }
        }
        public void AgregarFila(int i, ref DataTable dtGeneral)
        {
            string llegadasTiempo = Stringficar(Llegadas.Tiempo);
            string llegadasProxTiempo = Stringficar(Llegadas.Tiempo_Prox);

            string S1Tiempo = Stringficar(S1.Tiempo);
            string S2Tiempo = Stringficar(S2.Tiempo);
            string S3Tiempo = Stringficar(S3.Tiempo);
            string S4Tiempo = Stringficar(S4.Tiempo);
            string S5Tiempo = Stringficar(S5.Tiempo);
            string S6Tiempo = Stringficar(S6.Tiempo);/////

            string S1ProxTiempo = Stringficar(S1.TiempoProx);
            string S2ProxTiempo = Stringficar(S2.TiempoProx);
            string S3ProxTiempo = Stringficar(S3.TiempoProx);
            string S4ProxTiempo = Stringficar(S4.TiempoProx);
            string S5ProxTiempo = Stringficar(S5.TiempoProx);
            string S6ProxTiempo = Stringficar(S6.TiempoProx);//////

            string e_s_llegada = Stringficar(e_t_llegada_pedido);
            string e_s_a1 = Stringficar(e_t_a1);
            string e_s_a2 = Stringficar(e_t_a2);
            string e_s_a3 = Stringficar(e_t_a3);
            string e_s_a4 = Stringficar(e_t_a4);
            string e_s_a5 = Stringficar(e_t_a5);
            string e_s_a6 = Stringficar(e_t_a6);//////

            string s_camino_1 = Stringficar(camino1);
            string s_camino_2 = Stringficar(camino2);
            string s_camino_3 = Stringficar(camino3);

            string s_tiempo_ensamble = Stringficar(tiempo_ensamble);
            dtGeneral.Rows.Add(i, reloj.ToString("0.00"), evento, nro_pedido,
                                Llegadas.Prox_Nro_Pedido, llegadasTiempo, llegadasProxTiempo,
                                S1.Cola.Cantidad, (S1.Ocupado ? "Ocupado" : "Libre"),
                                S1.Nro_Pedido, S1Tiempo, S1ProxTiempo,
                                S2.Cola.Cantidad, (S2.Ocupado ? "Ocupado" : "Libre"),
                                S2.Nro_Pedido, S2Tiempo, S2ProxTiempo,
                                S3.Cola.Cantidad, (S3.Ocupado ? "Ocupado" : "Libre"),
                                S3.Nro_Pedido, S3Tiempo, S3ProxTiempo,
                                S4.Cola.Cantidad, (S4.Ocupado ? "Ocupado" : "Libre"),
                                S4.Nro_Pedido, S4Tiempo, S4ProxTiempo,
                                S5.Cola.Cola1.Cantidad, S5.Cola.Cola2.Cantidad, (S5.Ocupado ? "Ocupado" : "Libre"),
                                S5.Nro_Pedido, S5Tiempo, S5ProxTiempo,
                                S6.Cola.Cola1.Cantidad, S6.Cola.Cola2.Cantidad, (S6.Ocupado ? "Ocupado" : "Libre"),
                                S6.Nro_Pedido, S6Tiempo, S6ProxTiempo,
                                pedidos_realizados, nro_pedido_listo,
                                e_s_llegada, e_s_a1, e_s_a2, e_s_a3, e_s_a4, e_s_a5, e_s_a6,
                                s_tiempo_ensamble,
                                prom_tiempo_ensamble.ToString("0.00"),
                                p3_pedidos_solicitados, p3_proporcion_PR_PS.ToString("0.00"),
                                S1.Cola.P4_Cantidad_Maxima, S2.Cola.P4_Cantidad_Maxima,
                                S3.Cola.P4_Cantidad_Maxima, S4.Cola.P4_Cantidad_Maxima,
                                S5.Cola.P4_Cantidad_Maxima, S6.Cola.P4_Cantidad_Maxima,
                                 S1.Cola.P5_Tiempo_Promedio.ToString("0.00"),
                                 S2.Cola.P5_Tiempo_Promedio.ToString("0.00"),
                                 S3.Cola.P5_Tiempo_Promedio.ToString("0.00"),
                                 S4.Cola.P5_Tiempo_Promedio.ToString("0.00"),
                                 S5.Cola.P5_Tiempo_Promedio.ToString("0.00"),
                                 S6.Cola.P5_Tiempo_Promedio.ToString("0.00"),
                                S1.Cola.P6_Promedio_Pedidos_en_Cola.ToString("0.00"), S2.Cola.P6_Promedio_Pedidos_en_Cola.ToString("0.00"),
                                S3.Cola.P6_Promedio_Pedidos_en_Cola.ToString("0.00"), S4.Cola.P6_Promedio_Pedidos_en_Cola.ToString("0.00"),
                                S5.Cola.P6_Promedio_Pedidos_en_Cola.ToString("0.00"), S6.Cola.P6_Promedio_Pedidos_en_Cola.ToString("0.00"),
                                p7_pedidos_en_sist, p7_prom_pedidos_en_sist.ToString("0.00"),
                                 S1.P8_Porcentaje_Tiempo_Ocupado.ToString("0.00"),
                                 S2.P8_Porcentaje_Tiempo_Ocupado.ToString("0.00"),
                                 S3.P8_Porcentaje_Tiempo_Ocupado.ToString("0.00"),
                                 S4.P8_Porcentaje_Tiempo_Ocupado.ToString("0.00"),
                                 S5.P8_Porcentaje_Tiempo_Ocupado.ToString("0.00"),
                                 S6.P8_Porcentaje_Tiempo_Ocupado.ToString("0.00"),
                                S5.P9_Tiempo_Bloqueado_Acumulado.ToString("0.00"), S5.P9_Proporcion_Bloqueado_Ocupado.ToString("0.00"),
                                S6.Cola.P9_Proporcion_Espera_Cola_1.ToString("0.00"), S6.Cola.P9_Proporcion_Espera_Cola_2.ToString("0.00"),
                                p10_nro_hora, p10_contador, p10_prom_ensambles.ToString("0.00"),
                                p11_contador_mayor_igual, p11_probabilidad.ToString("0.00"), p13_camino_critico,
                                (p13_a1 * 100).ToString("0.00"), (p13_a2 * 100).ToString("0.00"), (p13_a3 * 100).ToString("0.00"),
                                (p13_a4 * 100).ToString("0.00"), (p13_a5 * 100).ToString("0.00"));
        }

        private string Stringficar(double? nroconmuchosdecimales)
        {
            if (nroconmuchosdecimales.HasValue)
                return nroconmuchosdecimales.Value.ToString("0.00");
            return "";
        }

        public void ResetearValores()
        {
            Llegadas.Resetear();
            foreach (IServidor s in ListaServidores)
            {
                s.ResetearServidor();
            }
            reloj = 0;
            reloj_anterior = 0;
            evento = Evento.Inicio;
            nro_pedido = null;
            pedidos_realizados = 0;
            pedidos_realizados_anterior = 0;
            nro_pedido_listo = null;
            tiempo_ensamble = null;
            q_tiempos_llegada_pedido = new Queue<double>();
            q_tiempos_act1 = new Queue<double>();
            q_tiempos_act2 = new Queue<double>();
            q_tiempos_act3 = new Queue<double>();
            q_tiempos_act4 = new Queue<double>();
            q_tiempos_act5 = new Queue<double>();
            q_tiempos_act6 = new Queue<double>();
            e_t_llegada_pedido = null;
            e_t_a1 = null;
            e_t_a2 = null;
            e_t_a3 = null;
            e_t_a4 = null;
            e_t_a5 = null;
            e_t_a6 = null;
            camino1 = null;
            camino2 = null;
            camino3 = null;
            prom_tiempo_ensamble = 0;
            p3_pedidos_solicitados = 0;
            p3_proporcion_PR_PS = 0;
            p7_pedidos_en_sist = 0;
            p7_prom_pedidos_en_sist = 0;
            p10_reloj = 0;
            p10_reloj_anterior = 0;
            p10_nro_hora = 0;
            p10_nro_hora_anterior = 0;
            p10_contador = 0;
            p10_contador_anterior = 0;
            p10_prom_ensambles = 0;
            p11_contador_mayor_igual = null;
            p11_probabilidad = 0;
            p13_camino_critico = "-";
            p13_a1 = 0;
            p13_a2 = 0;
            p13_a3 = 0;
            p13_a4 = 0;
            p13_a5 = 0;

        }
    }
}
