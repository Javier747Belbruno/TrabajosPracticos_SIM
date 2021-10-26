using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TrabajosPracticosSIM.TP_5.Entidades;
using TrabajosPracticosSIM.TP_5.InterfacesDeUsuario;

namespace TrabajosPracticosSIM.TP_5
{
    public class ControladorTP5 : ApplicationContext
    {
        //Instancia Unica - Patron Singleton
        private static readonly ControladorTP5 _instance = new ControladorTP5();
        //Lista de Vistas / Pantallas que controla el ControladorTP5
        private List<Form> Views = new List<Form>();


        //MODELO
        Modelo modelo = new Modelo();
        //TABLA GENERAL
        DataTable dtGeneral = new DataTable();

        //Constructor Privado.
        private ControladorTP5()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        }

        // Devolver instancia estática única.
        public static ControladorTP5 GetInstance() { return _instance; }

        public void Start()
        {
            IniciarFuncionalidad();
            Application.Run(this);
        }

        public void IniciarFuncionalidad()
        {
            HabilitarPantallaPrincipal();
            InicializarColumnasTablas();
        }

        public void HabilitarPantallaPrincipal()
        {
            CreateView(new Frm_TP5_Principal());
        }
        //Crear una ventana
        public void CreateView(Form frm)
        {
            //Pregunto si ya existe este Tipo de Pantalla, si no existe la creo.
            bool EstaRepetidaLaVista = false;
            foreach (var v in Views)
            {
                if (frm.GetType() == v.GetType())
                    EstaRepetidaLaVista = true;
            }
            if (!EstaRepetidaLaVista)
            {
                Views.Add(frm);
                frm.FormClosed += FormClosed;
                frm.Show();
            }
        }

        public void OpcionIniciarSimulacion(Frm_TP5_PantallaSimulacion form, int cant_sim, int desde, int hasta)
        {
            //Dejar Lista Tablas de Datos
            LimpiarTableDatas();
            LimpiarModelo();
            //
            #region CREACION E INICIALIZACION DE VARIABLES
            #region Definiciones

            double reloj = 0;
            string evento = Evento.Inicio;
            int? nro_pedido = null;
            #endregion

            
            #region Estadisticas

            int pedidos_realizados = 0;
            int pedidos_realizados_anterior = 0;
            int? nro_pedido_listo = null;
            double? tiempo_ensamble = null;
            //q de queue
            Queue<double> q_tiempos_llegada_pedido = new Queue<double>();
            Queue<double> q_tiempos_act1 = new Queue<double>();
            Queue<double> q_tiempos_act2 = new Queue<double>();
            Queue<double> q_tiempos_act3 = new Queue<double>();
            Queue<double> q_tiempos_act4 = new Queue<double>();
            Queue<double> q_tiempos_act5 = new Queue<double>();
            //e de estadisticas para diferenciarlos de las definiciones
            double? e_t_llegada_pedido = null;
            double? e_t_a1 = null;
            double? e_t_a2 = null;
            double? e_t_a3 = null;
            double? e_t_a4 = null;
            double? e_t_a5 = null;

            //Caminos
            double? camino1 = null;
            double? camino2 = null;
            double? camino3 = null;

            double? camino_critico = null; //a.k.a tiempo de ensamble neto

            #endregion
            #region Punto 2

            double prom_tiempo_ensamble = 0;

            #endregion
            #region Punto 3

            int p3_pedidos_solicitados = 0;
            double p3_proporcion_PR_PS = 0;

            #endregion
            #region Punto 4

            int p4_cola_1 = 0;
            int p4_cola_2 = 0;
            int p4_cola_3 = 0;
            int p4_cola_4 = 0;
            int p4_cola_5 = 0;
            int p4_cola_6 = 0;

            #endregion
            #region Punto 5

            double p5_cola_1_t_acum = 0;
            double p5_cola_1_t_prom = 0;
            double p5_cola_2_t_acum = 0;
            double p5_cola_2_t_prom = 0;
            double p5_cola_3_t_acum = 0;
            double p5_cola_3_t_prom = 0;
            double p5_cola_4_t_acum = 0;
            double p5_cola_4_t_prom = 0;
            double p5_cola_5_t_acum = 0;
            double p5_cola_5_t_prom = 0;
            double p5_cola_6_t_acum = 0;
            double p5_cola_6_t_prom = 0;

            #endregion
            #region Punto 6

            double p6_cola_1 = 0;
            double p6_cola_2 = 0;
            double p6_cola_3 = 0;
            double p6_cola_4 = 0;
            double p6_cola_5 = 0;
            double p6_cola_6 = 0;

            #endregion
            #region Punto 7

            int p7_pedidos_en_sist = 0;
            double p7_prom_pedidos_en_sist = 0;

            #endregion
            #region Punto 8

            double p8_s1_tiempo_ocupado_acum = 0;
            double p8_s1_porcentaje_ocupado = 0;
            double p8_s2_tiempo_ocupado_acum = 0;
            double p8_s2_porcentaje_ocupado = 0;
            double p8_s3_tiempo_ocupado_acum = 0;
            double p8_s3_porcentaje_ocupado = 0;
            double p8_s4_tiempo_ocupado_acum = 0;
            double p8_s4_porcentaje_ocupado = 0;
            double p8_s5_tiempo_ocupado_acum = 0;
            double p8_s5_porcentaje_ocupado = 0;

            #endregion
            #region Punto 9

            //Parte 1
            double p9_bloqueado = 0;
            double p9_proporcion_bloq_ocup= 0;

            //Parte 2
            double p9_tiempo_en_cola_acum_a5 = 0;
            double p9_tiempo_en_cola_acum_a3 = 0;
            double p9_proporcion_a5 = 0;
            double p9_proporcion_a3 = 0;

            #endregion
            #region Punto 10

            double p10_reloj = 0;
            int p10_nro_hora = 1;
            int p10_contador = 0;
            double p10_prom_ensambles = 0;

            #endregion
            #region Punto 11

            int? p11_contador_mayor_igual = null;
            double p11_probabilidad = 0;

            #endregion
            #region Punto 13

            string p13_camino_critico = "-";
            double p13_a1 = 0;
            double p13_a2 = 0;
            double p13_a3 = 0;
            double p13_a4 = 0;
            double p13_a5 = 0;

            #endregion

            #endregion
            #region SIMULACION
            for (int i = 1; i <= cant_sim; i++)
            {
                //Primera vuelta
                if (i == 1)
                {
                    modelo.Llegadas.CalcularProxNroPedido(nro_pedido);
                    modelo.Llegadas.CalcularRandom(evento);
                    modelo.Llegadas.CalcularTiempo();
                    modelo.Llegadas.CalcularProxTiempo(reloj);
                    q_tiempos_llegada_pedido.Enqueue((double)modelo.Llegadas.Tiempo_Prox);
                    //Grabar Fila
                    string llegadasTiempo = "";
                    if (modelo.Llegadas.Tiempo.HasValue)
                        llegadasTiempo = modelo.Llegadas.Tiempo.Value.ToString("0.00");

                    dtGeneral.Rows.Add(i,reloj.ToString("0.00"), evento, nro_pedido,
                                modelo.Llegadas.Prox_Nro_Pedido, llegadasTiempo, modelo.Llegadas.Tiempo_Prox,
                                modelo.S1.Cola.Cantidad, (modelo.S1.Ocupado ? "Ocupado" : "Libre"),
                                modelo.S1.Nro_Pedido, modelo.S1.Tiempo, modelo.S1.TiempoProx,
                                modelo.S2.Cola.Cantidad, (modelo.S2.Ocupado ? "Ocupado" : "Libre"),
                                modelo.S2.Nro_Pedido, modelo.S2.Tiempo, modelo.S2.TiempoProx,
                                modelo.S3.Cola.Cantidad, (modelo.S3.Ocupado ? "Ocupado" : "Libre"),
                                modelo.S3.Nro_Pedido, modelo.S3.Tiempo, modelo.S3.TiempoProx,
                                modelo.S4.Cola.Cantidad, (modelo.S4.Ocupado ? "Ocupado" : "Libre"),
                                modelo.S4.Nro_Pedido, modelo.S4.Tiempo, modelo.S4.TiempoProx,
                                modelo.S5.Cola.Cola1.Cantidad, modelo.S5.Cola.Cola2.Cantidad, (modelo.S5.Ocupado ? "Ocupado" : "Libre"),
                                modelo.S5.Nro_Pedido, modelo.S5.Tiempo, modelo.S5.TiempoProx,
                                modelo.C6.Cola1.Cantidad, modelo.C6.Cola2.Cantidad,
                                pedidos_realizados);
                    //Continuar con la segunda vuelta
                    continue;
                }

                reloj = ProxTiempoMinimo();

                evento = DeterminarEvento(reloj);

                nro_pedido = DeterminarNumeroPedido(evento);


                modelo.Llegadas.CalcularProxNroPedido(nro_pedido);
                modelo.Llegadas.CalcularRandom(evento);
                modelo.Llegadas.CalcularTiempo();
                modelo.Llegadas.CalcularProxTiempo(reloj);

                foreach (IServidor s in modelo.ListaServidores)
                {
                    s.CalcularCola(evento);
                    s.CalcularEstado(evento);
                    s.CalcularNroPedidoEnAtencion(evento, nro_pedido);
                    s.CalcularRandom();
                    s.CalcularTiempo();
                    s.CalcularTiempoProx(reloj);
                }

                modelo.C6.EncastreFinal(evento);
                
                pedidos_realizados_anterior = pedidos_realizados;
                pedidos_realizados = CalcularAcumuladorEnsamblesRealizados(evento, pedidos_realizados);

                nro_pedido_listo = DeterminarNroPedidoRealizados(pedidos_realizados, pedidos_realizados_anterior, nro_pedido);


                e_t_llegada_pedido = CalcularTiemposLlegadaCliente(q_tiempos_llegada_pedido, pedidos_realizados_anterior,pedidos_realizados); 
                e_t_a1 = CalcularTiemposAct1(q_tiempos_act1, pedidos_realizados_anterior, pedidos_realizados); 
                e_t_a2 = CalcularTiemposAct2(q_tiempos_act2, pedidos_realizados_anterior, pedidos_realizados);
                e_t_a3 = CalcularTiemposAct3(q_tiempos_act3, pedidos_realizados_anterior, pedidos_realizados);
                e_t_a4 = CalcularTiemposAct4(q_tiempos_act4, pedidos_realizados_anterior, pedidos_realizados);
                e_t_a5 = CalcularTiemposAct5(q_tiempos_act5, pedidos_realizados_anterior, pedidos_realizados);

                camino1 = CalcularCamino1(e_t_llegada_pedido, e_t_a1, e_t_a2, e_t_a4, e_t_a5, pedidos_realizados_anterior, pedidos_realizados); 
                


                //Recordar solo las que pide
                if ((i >= 1 && i <= 20) || i % 10000 == 0 || (i >= desde && i <= hasta) || i == cant_sim)
                {
                    string llegadasTiempo = "";
                    if (modelo.Llegadas.Tiempo.HasValue)
                        llegadasTiempo = modelo.Llegadas.Tiempo.Value.ToString("0.00");

                    dtGeneral.Rows.Add(i,reloj.ToString("0.00"), evento, nro_pedido,
                                modelo.Llegadas.Prox_Nro_Pedido, llegadasTiempo, modelo.Llegadas.Tiempo_Prox,
                                modelo.S1.Cola.Cantidad,(modelo.S1.Ocupado ? "Ocupado" : "Libre"), 
                                modelo.S1.Nro_Pedido,modelo.S1.Tiempo,modelo.S1.TiempoProx,
                                modelo.S2.Cola.Cantidad, (modelo.S2.Ocupado ? "Ocupado" : "Libre"),
                                modelo.S2.Nro_Pedido, modelo.S2.Tiempo, modelo.S2.TiempoProx,
                                modelo.S3.Cola.Cantidad, (modelo.S3.Ocupado ? "Ocupado" : "Libre"),
                                modelo.S3.Nro_Pedido, modelo.S3.Tiempo, modelo.S3.TiempoProx,
                                modelo.S4.Cola.Cantidad, (modelo.S4.Ocupado ? "Ocupado" : "Libre"),
                                modelo.S4.Nro_Pedido, modelo.S4.Tiempo, modelo.S4.TiempoProx,
                                modelo.S5.Cola.Cola1.Cantidad, modelo.S5.Cola.Cola2.Cantidad, (modelo.S5.Ocupado ? "Ocupado" : "Libre"),
                                modelo.S5.Nro_Pedido, modelo.S5.Tiempo, modelo.S5.TiempoProx,
                                modelo.C6.Cola1.Cantidad, modelo.C6.Cola2.Cantidad,
                                pedidos_realizados, nro_pedido_listo , 
                                e_t_llegada_pedido,  e_t_a1, e_t_a2, e_t_a3, e_t_a4, e_t_a5,
                                camino1, camino2, camino3, camino_critico) ;

                    
                }
            }
            #endregion
            form.LlenarPantallaSimulacion(dtGeneral);
        }

        private double? CalcularCamino1(double? e_t_llegada_pedido, double? e_t_a1, double? e_t_a4, double? e_t_a5, double? e_t_a2, int pedidos_realizados_anterior, int pedidos_realizados)
        {
            double? maximoA2oA4;
            if (e_t_a2.HasValue)
            {
                if (e_t_a4.HasValue)
                {
                    if(e_t_a2> e_t_a4) { 
                        maximoA2oA4 = e_t_a2;
                    }
                    else
                    {
                        maximoA2oA4 = e_t_a4;
                    }
                }
                else
                {
                    maximoA2oA4 = e_t_a2;
                }
            }
            else
            {
                if (e_t_a4.HasValue)
                {
                    maximoA2oA4 = e_t_a4;
                }
                else
                {
                    maximoA2oA4 = null;
                }
            }
            if (pedidos_realizados != pedidos_realizados_anterior)
            {
                return (e_t_a5 - maximoA2oA4.Value + e_t_a4 - e_t_llegada_pedido);
            }
            else
            {
                return null;
            }
        }

        private void LimpiarModelo()
        {
            modelo.C6.ResetearCola();
            modelo.S5.ResetearServidor();
            modelo.S4.ResetearServidor();
            modelo.S3.ResetearServidor();
            modelo.S2.ResetearServidor();
            modelo.S1.ResetearServidor();
        }

        private double? CalcularTiemposAct5(Queue<double> q_tiempos_act5, int pedidos_realizados_anterior, int pedidos_realizados)
        {
            if (pedidos_realizados != pedidos_realizados_anterior)
            {
                if (modelo.S5.Tiempo.HasValue)
                {
                    q_tiempos_act5.Enqueue(modelo.S5.TiempoProx.Value);
                }
                return q_tiempos_act5.Dequeue();
            }
            else
            {
                if (modelo.S5.Tiempo.HasValue)
                {
                    q_tiempos_act5.Enqueue(modelo.S5.TiempoProx.Value);
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
                if (modelo.S4.Tiempo.HasValue)
                {
                    q_tiempos_act4.Enqueue(modelo.S4.TiempoProx.Value);
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
                if (modelo.S3.Tiempo.HasValue)
                {
                    q_tiempos_act3.Enqueue(modelo.S3.TiempoProx.Value);
                }
                return q_tiempos_act3.Dequeue();
            }
            else
            {
                if (modelo.S3.Tiempo.HasValue)
                {
                    q_tiempos_act3.Enqueue(modelo.S3.TiempoProx.Value);
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
                if (modelo.S2.Tiempo.HasValue)
                {
                    q_tiempos_act2.Enqueue(modelo.S2.TiempoProx.Value);
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
                if (modelo.S1.Tiempo.HasValue)
                {
                    q_tiempos_act1.Enqueue(modelo.S1.TiempoProx.Value);
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
                if (modelo.Llegadas.Tiempo.HasValue)
                {
                    q_tiempos_llegada_pedido.Enqueue(modelo.Llegadas.Tiempo_Prox.Value);
                }
                if (q_tiempos_llegada_pedido.Count == 0)
                {
                    return null;
                }
                return q_tiempos_llegada_pedido.Peek();
            }

        }

        private int? DeterminarNroPedidoRealizados(int pedidos_realizados, int pedidos_realizados_anterior, int? nro_pedido)
        {
            if (pedidos_realizados != pedidos_realizados_anterior)
                return nro_pedido;
            return null;
        }

        private int CalcularAcumuladorEnsamblesRealizados(string evento, int pedidos_realizados)
        {
            if(evento == Evento.Fin_Actividad_5 && modelo.C6.Cola2.Cantidad_Anterior > 0)
            {
                pedidos_realizados++;
            }
            if (evento == Evento.Fin_Actividad_3 && modelo.C6.Cola1.Cantidad_Anterior > 0)
            {
                pedidos_realizados++;
            }
            return pedidos_realizados;
        }

        private int? DeterminarNumeroPedido(string evento)
        {
            switch (evento)
            {
                case Evento.Llegada_Pedido:
                    return modelo.Llegadas.Prox_Nro_Pedido;
                case Evento.Fin_Actividad_1:
                    return modelo.S1.Nro_Pedido;
                case Evento.Fin_Actividad_2:
                    return modelo.S2.Nro_Pedido;
                case Evento.Fin_Actividad_3:
                    return modelo.S3.Nro_Pedido;
                case Evento.Fin_Actividad_4:
                    return modelo.S4.Nro_Pedido;
                case Evento.Fin_Actividad_5:
                    return modelo.S5.Nro_Pedido;
                default:
                    return 0;
            }
        }

        private string DeterminarEvento(double reloj)
        {
            if(reloj == modelo.Llegadas.Tiempo_Prox)
                return Evento.Llegada_Pedido;
            if (reloj == modelo.S1.TiempoProx)
                return Evento.Fin_Actividad_1;
            if (reloj == modelo.S2.TiempoProx)
                return Evento.Fin_Actividad_2;
            if (reloj == modelo.S3.TiempoProx)
                return Evento.Fin_Actividad_3;
            if (reloj == modelo.S4.TiempoProx)
                return Evento.Fin_Actividad_4;
            if (reloj == modelo.S5.TiempoProx)
                return Evento.Fin_Actividad_5;
            return "x";
        }

        private double ProxTiempoMinimo()
        {
            List<double> proximos_tiempos = new List<double>();
            double? t1 = modelo.Llegadas.Tiempo_Prox;
            double? t2 = modelo.S1.TiempoProx;
            double? t3 = modelo.S2.TiempoProx;
            double? t4 = modelo.S3.TiempoProx;
            double? t5 = modelo.S4.TiempoProx;
            double? t6 = modelo.S5.TiempoProx;

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
            proximos_tiempos.Sort();

            return proximos_tiempos.First();
        }


        private void InicializarColumnasTablas()
        {
            dtGeneral.Columns.Add("i");
            dtGeneral.Columns.Add("reloj");
            dtGeneral.Columns.Add("evento");
            dtGeneral.Columns.Add("nro_pedido");
            dtGeneral.Columns.Add("Prox_Pedido");
            dtGeneral.Columns.Add("Tiempo_lleg");
            dtGeneral.Columns.Add("Tiempo_Prox_lleg");
            dtGeneral.Columns.Add("Cola 1");
            dtGeneral.Columns.Add("Estado Servidor 1");
            dtGeneral.Columns.Add("Nro Pedido en At 1");
            dtGeneral.Columns.Add("Tiempo A1");
            dtGeneral.Columns.Add("Prox Tiempo A1");
            dtGeneral.Columns.Add("Cola 2");
            dtGeneral.Columns.Add("Estado Servidor 2");
            dtGeneral.Columns.Add("Nro Pedido en At 2");
            dtGeneral.Columns.Add("Tiempo A2");
            dtGeneral.Columns.Add("Prox Tiempo A2");
            dtGeneral.Columns.Add("Cola 3");
            dtGeneral.Columns.Add("Estado Servidor 3");
            dtGeneral.Columns.Add("Nro Pedido en At 3");
            dtGeneral.Columns.Add("Tiempo A3");
            dtGeneral.Columns.Add("Prox Tiempo A3");
            dtGeneral.Columns.Add("Cola 4");
            dtGeneral.Columns.Add("Estado Servidor 4");
            dtGeneral.Columns.Add("Nro Pedido en At 4");
            dtGeneral.Columns.Add("Tiempo A4");
            dtGeneral.Columns.Add("Prox Tiempo A4");
            dtGeneral.Columns.Add("Cola 5a (A4)");
            dtGeneral.Columns.Add("Cola 5b (A2)");
            dtGeneral.Columns.Add("Estado Servidor 5");
            dtGeneral.Columns.Add("Nro Pedido en At 5");
            dtGeneral.Columns.Add("Tiempo A5");
            dtGeneral.Columns.Add("Prox Tiempo A5");
            dtGeneral.Columns.Add("Cola 6a (A5)");
            dtGeneral.Columns.Add("Cola 6b (A3)");
            dtGeneral.Columns.Add("EnsamblesRealizados");
            dtGeneral.Columns.Add("NroPedidoListo");
            dtGeneral.Columns.Add("LlegadaCliente");
            dtGeneral.Columns.Add("A1");
            dtGeneral.Columns.Add("A2");
            dtGeneral.Columns.Add("A3");
            dtGeneral.Columns.Add("A4");
            dtGeneral.Columns.Add("A5");
            dtGeneral.Columns.Add("Camino 1");
            dtGeneral.Columns.Add("Camino 2");
            dtGeneral.Columns.Add("Camino 3");
            dtGeneral.Columns.Add("Tiempo Ensamble/C MAX");
        }
        private void LimpiarTableDatas()
        {
            dtGeneral.Clear();
        }

        ///Evento Cerrar un Form
        private void FormClosed(object sender, FormClosedEventArgs e)
        {
            //Remover Pantalla de la lista de Pantallas.
            Views.Remove(sender as Form);
            // NOTE: Terminar programa si no quedan mas Vistas/Forms o si se está cerrando la ventana principal.
            if (Views.Count == 0 || sender.GetType() == typeof(Frm_TP5_Principal)) Exit();
        }

        //Finalizar Programa
        public void Exit()
        {
            this.ExitThread();
        }
        /// <summary>
        /// /Crea Pantalla Simulacion
        /// </summary>
        public void OpcionPantallaSimulacion()
        {
            CreateView(new Frm_TP5_PantallaSimulacion());
        }

        /// <summary>
        /// /Crea Pantalla Enunciado
        /// </summary>
        public void OpcionPantallaEnunciado()
        {
            CreateView(new Frm_TP5_Enunciado());
        }
    }
}
