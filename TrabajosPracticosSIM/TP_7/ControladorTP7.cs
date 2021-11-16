using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajosPracticosSIM.TP_7.Entidades;
using TrabajosPracticosSIM.TP_7.InterfacesDeUsuario;

namespace TrabajosPracticosSIM.TP_7
{
    public class ControladorTP7 : ApplicationContext
    {
        private static readonly ControladorTP7 _instance = new ControladorTP7();

        //Lista de Vistas / Pantallas que controla el ControladorTP5
        private List<Form> Views = new List<Form>();



        //Objeto Ecuacion Diferencial
        //private EcDiferencial ed = new EcDiferencial();
   
        //MODELO
        ModeloTP7 m = new ModeloTP7();

        //TABLA ACTIVIDADES
        //DataTable dtActividadesPantalla = new DataTable();

        //Constructor Privado.
        private ControladorTP7()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        }
        // Devolver instancia estática única.
        public static ControladorTP7 GetInstance() { return _instance; }

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
            CreateView(new Frm_TP7_Principal());
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
        ///Evento Cerrar un Form
        private void FormClosed(object sender, FormClosedEventArgs e)
        {
            //Remover Pantalla de la lista de Pantallas.
            Views.Remove(sender as Form);
            // NOTE: Terminar programa si no quedan mas Vistas/Forms o si se está cerrando la ventana principal.
            if (Views.Count == 0 || sender.GetType() == typeof(Frm_TP7_Principal)) Exit();
        }

        //Finalizar Programa
        public void Exit()
        {
            this.ExitThread();
        }
        /// <summary>
        /// Pantallas
        /// </summary>
        public void OpcionPantallaEnunciado()
        {
            CreateView(new Frm_TP7_Enunciado());
        }
        public void OpcionPantallaSimulacion()
        {
            CreateView(new Frm_TP7_PantallaSimulacion());
        }

        public void OpcionIniciarSimulacion(Frm_TP7_PantallaSimulacion form, int cant_sim, int desde, int hasta)
        {

            //TABLA GENERAL
            DataTable dtGeneral = new DataTable();
            InicializarColumnasTablas(ref dtGeneral);
            
            m.ResetearValores();

            #region SIMULACION
            for (int i = 1; i <= cant_sim; i++)
            {
                //Primera vuelta
                if (i == 1)
                {
                    m.CalcularLlegada();

                    m.AgregarFila(i, ref dtGeneral);
                    //Continuar con la segunda vuelta
                    continue;
                }

                m.CalcularReloj();

                m.CalcularEvento();

                m.CalcularNroCamion();

                m.CalcularSiloDesignado();

                m.CalcularTnCamionActual();

                m.CalcularLlegada();

                m.CalcularTuboAspirador();

                m.DeterminarPrimeroColaCamion();

                m.DeterminarPrimeroColaTn();

                m.CalcularColaCamion();

                m.CalcularColaTn();

                m.CalcularCantidadCola();

                m.CalcularTiempoCambio();

                m.CalcularSiloParaSuministrar();
                
                m.CalcularSilos();

                /*modelo.CalcularPedidosRealizados();

                modelo.CalcularNroPedidoRealizado();

                modelo.CalcularTiemposDeCadaPedido();

                modelo.CalcularCaminos();

                modelo.CalcularTiempoEnsamble();

                modelo.CalcularPunto2();//PromedioEnsamble

                modelo.CalcularPunto3();//Proporcion_PR_PS

                modelo.CalcularPunto4();//Calcular Max Cant En cada Cola

                modelo.CalcularPunto5();//Tiempo Promedio En Cola

                modelo.CalcularPunto6();//Cant Promedio En Cola

                modelo.CalcularPunto7(i);//Prom pedidos en sist

                modelo.CalcularPunto8();//Porcentaje Ocupacion Servidor

                modelo.CalcularPunto9();//ProporcionBloqueadoOcupado
                                        //ProporcionesDeEspera

                modelo.CalcularPunto10();//ContadorEnsamblesPorHora
                                         //CalcularPromEnsamblesPorHora

                modelo.CalcularPunto11(param_punto_11);//Prob Mayor Igual Parametro

                modelo.CalcularPunto13();//Proporcion Actividades de Caminos Criticos
                */
                //Recordar solo las que pide
                if ((i >= 1 && i <= 50) || i % 10000 == 0 || (i >= desde && i <= hasta) || i == cant_sim)
                {
                    m.AgregarFila(i, ref dtGeneral);
                }
            }
            #endregion

            form.LlenarPantallaSimulacion(dtGeneral);
        }

        private void InicializarColumnasTablas(ref DataTable dtGeneral)
        {
            /*if (dtActividadesPantalla.Columns.Count == 0)
            {
                dtActividadesPantalla.Columns.Add("SERV");
                dtActividadesPantalla.Columns.Add("DISTR");
                dtActividadesPantalla.Columns.Add("PARAMS");
            }*/

            dtGeneral.Columns.Add("i");
            dtGeneral.Columns.Add("Reloj");
            dtGeneral.Columns.Add("Evento");
            dtGeneral.Columns.Add("Nro Camion");
            dtGeneral.Columns.Add("Silo Designado");
            dtGeneral.Columns.Add("Tn Camion Actuales");
            dtGeneral.Columns.Add("Prox Camion");
            dtGeneral.Columns.Add("Tiempo Lleg");
            dtGeneral.Columns.Add("Tiempo Prox Lleg");
            dtGeneral.Columns.Add("Capacidad Camion");
            dtGeneral.Columns.Add("tubo aspirador");
            dtGeneral.Columns.Add("nro primer camion en salir");
            dtGeneral.Columns.Add("tn primer camion en salir");
            dtGeneral.Columns.Add("cola camiones");
            dtGeneral.Columns.Add("TiempoCambio");
            dtGeneral.Columns.Add("silo para suministro");

            dtGeneral.Columns.Add("S1 Capacidad actual");
            dtGeneral.Columns.Add("S1 Estado");
            dtGeneral.Columns.Add("S1 Nro Camion");
            dtGeneral.Columns.Add("S1 Capacidad Camion Inicial");
            dtGeneral.Columns.Add("S1 Tasa de Descarga");
            dtGeneral.Columns.Add("S1 Tiempo Fin Llenado Silo");
            dtGeneral.Columns.Add("S1 Prox Fin Llenado Silo");
            dtGeneral.Columns.Add("S1 Tiempo Fin Descarga");
            dtGeneral.Columns.Add("S1 Prox Fin Descarga");
            dtGeneral.Columns.Add("S1 Capacidad Camion Final");
            dtGeneral.Columns.Add("S1 Prox Fin Suministro");

            dtGeneral.Columns.Add("S2 Capacidad actual");
            dtGeneral.Columns.Add("S2 Estado");
            dtGeneral.Columns.Add("S2 Nro Camion");
            dtGeneral.Columns.Add("S2 Capacidad Camion Inicial");
            dtGeneral.Columns.Add("S2 Tasa de Descarga");
            dtGeneral.Columns.Add("S2 Tiempo Fin Llenado Silo");
            dtGeneral.Columns.Add("S2 Prox Fin Llenado Silo");
            dtGeneral.Columns.Add("S2 Tiempo Fin Descarga");
            dtGeneral.Columns.Add("S2 Prox Fin Descarga");
            dtGeneral.Columns.Add("S2 Capacidad Camion Final");
            dtGeneral.Columns.Add("S2 Prox Fin Suministro");

            dtGeneral.Columns.Add("S3 Capacidad actual");
            dtGeneral.Columns.Add("S3 Estado");
            dtGeneral.Columns.Add("S3 Nro Camion");
            dtGeneral.Columns.Add("S3 Capacidad Camion Inicial");
            dtGeneral.Columns.Add("S3 Tasa de Descarga");
            dtGeneral.Columns.Add("S3 Tiempo Fin Llenado Silo");
            dtGeneral.Columns.Add("S3 Prox Fin Llenado Silo");
            dtGeneral.Columns.Add("S3 Tiempo Fin Descarga");
            dtGeneral.Columns.Add("S3 Prox Fin Descarga");
            dtGeneral.Columns.Add("S3 Capacidad Camion Final");
            dtGeneral.Columns.Add("S3 Prox Fin Suministro");

            dtGeneral.Columns.Add("S4 Capacidad actual");
            dtGeneral.Columns.Add("S4 Estado");
            dtGeneral.Columns.Add("S4 Nro Camion");
            dtGeneral.Columns.Add("S4 Capacidad Camion Inicial");
            dtGeneral.Columns.Add("S4 Tasa de Descarga");
            dtGeneral.Columns.Add("S4 Tiempo Fin Llenado Silo");
            dtGeneral.Columns.Add("S4 Prox Fin Llenado Silo");
            dtGeneral.Columns.Add("S4 Tiempo Fin Descarga");
            dtGeneral.Columns.Add("S4 Prox Fin Descarga");
            dtGeneral.Columns.Add("S4 Capacidad Camion Final");
            dtGeneral.Columns.Add("S4 Prox Fin Suministro");

        }

    }
}
