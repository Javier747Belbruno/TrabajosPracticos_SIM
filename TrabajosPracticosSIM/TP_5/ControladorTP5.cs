using System;
using System.Collections;
using System.Collections.Generic;
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

        //INICIALIZAR MODELO
        Modelo modelo = new Modelo();

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

        public void OpcionIniciarSimulacion(Frm_TP5_PantallaSimulacion frm_TP5_PantallaSimulacion, int cant_sim, int desde, int hasta)
        {
            //Dejar Lista Tablas de Datos
            //LimpiarTableDatas();

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
                if(i==1)
                {
                    modelo.llegadas.CalcularProxNroPedido(nro_pedido);
                    modelo.llegadas.CalcularRandom(evento);
                    modelo.llegadas.CalcularTiempo();
                    modelo.llegadas.CalcularProxTiempo(reloj);

                    q_tiempos_llegada_pedido.Enqueue((double)modelo.llegadas.Tiempo_Prox);
                    //Continuar con la segunda vuelta
                    continue;
                }

                reloj = ProxTiempoMinimo(modelo.llegadas.Tiempo_Prox, s1_prox_t_atencion, s2_prox_t_atencion, s3_prox_t_atencion, s4_prox_t_atencion, s5_prox_t_atencion);

                evento = DeterminarEvento(reloj);

                nro_pedido = DeterminarNumeroPedido(evento);


                modelo.llegadas.CalcularProxNroPedido(nro_pedido);
                modelo.llegadas.CalcularRandom(evento);
                modelo.llegadas.CalcularTiempo();
                modelo.llegadas.CalcularProxTiempo(reloj);


            }
            #endregion
        }

        private int? DeterminarNumeroPedido(string evento)
        {
            switch (evento)
            {
                case Evento.Llegada_Pedido:
                    return modelo.llegadas.Prox_Nro_Pedido;
            }
            return 1;
        }

        private string DeterminarEvento(double reloj)
        {
            switch (reloj)
            {
                case double v when v == modelo.llegadas.Tiempo_Prox:
                    return Evento.Llegada_Pedido;
            }
            return Evento.Fin_Actividad_1;
        }

        private double ProxTiempoMinimo(double? t_prox_llegada, double? s1_prox_t_atencion, double? s2_prox_t_atencion, double? s3_prox_t_atencion, double? s4_prox_t_atencion, double? s5_prox_t_atencion)
        {
            List<double> proximos_tiempos = new List<double>();
           
            if (t_prox_llegada.HasValue)
            {
                proximos_tiempos.Add((double)t_prox_llegada);
            }
            if (s1_prox_t_atencion.HasValue) {
                proximos_tiempos.Add((double)s1_prox_t_atencion);
            }
            if (s2_prox_t_atencion.HasValue)
            {
                proximos_tiempos.Add((double)s2_prox_t_atencion);
            }
            if (s3_prox_t_atencion.HasValue)
            {
                proximos_tiempos.Add((double)s3_prox_t_atencion);
            }
            if (s4_prox_t_atencion.HasValue)
            {
                proximos_tiempos.Add((double)s4_prox_t_atencion);
            }
            if (s5_prox_t_atencion.HasValue)
            {
                proximos_tiempos.Add((double)s5_prox_t_atencion);
            }
            proximos_tiempos.Sort();

            return proximos_tiempos.First();
        }

        //Evento Cerrar un Form
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
