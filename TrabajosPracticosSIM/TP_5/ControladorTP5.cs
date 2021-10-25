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

            //
            #region CREACION E INICIALIZACION DE VARIABLES
            #region Definiciones

            double reloj = 0;
            string evento = Evento.Inicio;
            int? nro_pedido = null;
            #endregion

            #region SupuestamenteInnecesarios
            // Pedidos
            double prox_pedido = 1;
            double? rnd_pedido = 0;
            double? t_llegada = 0;
            double t_prox_llegada = 0;

            // Cola 1
            int cola_1 = 0;

            //MAQUINA ACTIVIDAD 1 (SERVIDOR 1)
            string s1_estado = "Libre";
            int? s1_nro_pedido_en_at = null;
            double? s1_rnd = null;
            double? s1_t_atencion = null;
            double? s1_prox_t_atencion = null;

            //Cola 2
            int cola_2 = 0;

            //MAQUINA ACTIVIDAD 2 (SERVIDOR 2)
            string s2_estado = "Libre";
            int? s2_nro_pedido_en_at = null;
            double? s2_rnd = null;
            double? s2_t_atencion = null;
            double? s2_prox_t_atencion = null;

            //Cola 3
            int cola_3 = 0;

            //MAQUINA ACTIVIDAD 3 (SERVIDOR 3)
            string s3_estado = "Libre";
            int? s3_nro_pedido_en_at = null;
            double? s3_rnd = null;
            double? s3_t_atencion = null;
            double? s3_prox_t_atencion = null;

            //Cola 4
            int cola_4 = 0;

            //MAQUINA ACTIVIDAD 4 (SERVIDOR 4)
            string s4_estado = "Libre";
            int? s4_nro_pedido_en_at = null;
            double? s4_rnd = null;
            double? s4_t_atencion = null;
            double? s4_prox_t_atencion = null;

            //Colas 5
            int cola_5a = 0; //(A4)
            int cola_5b = 0; //(A2)

            //MAQUINA ACTIVIDAD 5 (SERVIDOR 5)
            string s5_estado = "Libre";
            int? s5_nro_pedido_en_at = null;
            double? s5_rnd = null;
            double? s5_t_atencion = null;
            double? s5_prox_t_atencion = null;

            //Colas 6 - Encastre final
            int cola_6a = 0; //(A5)
            int cola_6b = 0; //(A3)

            #endregion
            #region Estadisticas

            int pedidos_realizados = 0;
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
            double? c1 = null;
            double? c2 = null;
            double? c3 = null;

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

                    dtGeneral.Rows.Add(reloj, evento, nro_pedido,
                                modelo.Llegadas.Prox_Nro_Pedido, modelo.Llegadas.Tiempo, modelo.Llegadas.Prox_Nro_Pedido,
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
                                modelo.C6.Cola1.Cantidad, modelo.C6.Cola2.Cantidad);
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

                //Recordar solo las que pide
                if ((i >= 1 && i <= 20) || i % 10000 == 0 || (i >= desde && i <= hasta) || i == cant_sim)
                {


                    dtGeneral.Rows.Add(reloj, evento, nro_pedido,
                                modelo.Llegadas.Prox_Nro_Pedido, modelo.Llegadas.Tiempo, modelo.Llegadas.Prox_Nro_Pedido,
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
                                modelo.C6.Cola1.Cantidad, modelo.C6.Cola2.Cantidad) ;

                    
                }
            }
            #endregion
            form.LlenarPantallaSimulacion(dtGeneral);
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
