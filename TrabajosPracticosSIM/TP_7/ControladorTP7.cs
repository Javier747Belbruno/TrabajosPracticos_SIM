using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajosPracticosSIM.TP_4.Entidades;
using TrabajosPracticosSIM.TP_6.Entidades;
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
        DataTable dtActividadesPantalla = new DataTable();

        //Constructor Privado.
        private ControladorTP7()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            InicializarColumnasTablaActividades();
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

        public void OpcionIniciarSimulacion(Frm_TP7_PantallaSimulacion form, int cant_sim, int desde, int hasta, bool @checked)
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

                //Recordar solo las que pide
                if ((i >= 1 && i <= 500) || (i >= desde && i <= hasta) || i == cant_sim)
                {
                    if (@checked) {
                        if(m.evento != EventosFabrica.Hora)
                            {
                              m.AgregarFila(i, ref dtGeneral);
                            }
                    }
                    else
                    {
                        m.AgregarFila(i, ref dtGeneral);
                    }
                    
                }
            }
            #endregion

            form.LlenarPantallaSimulacion(dtGeneral);
        }

        public void OpcionPantallaConfiguracion()
        {
            CreateView(new Frm_TP7_Config_Actividades());
        }
        public void OpcionCargarActividadesConfiguracion(Frm_TP7_Config_Actividades form)
        {
            List<string> distribuciones = new List<string>();
            var type = typeof(IDistribucion);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && p.IsClass);

            foreach (var item in types)
            {
                distribuciones.Add(item.Name);
            }


            DataTable dtActividades = new DataTable();
            dtActividades.Columns.Add("SERV");
            dtActividades.Columns.Add("DISTR");
            dtActividades.Columns.Add("PARAM1");
            dtActividades.Columns.Add("PARAM2");

            dtActividades.Rows.Add("Lleg", m.Llegadas.Distr.GetType().Name, m.Llegadas.Distr.DevolverParam1(), m.Llegadas.Distr.DevolverParam2());
            var i = 1;
            foreach (Silo s in m.ListaSilos)
            {
                dtActividades.Rows.Add("S" + i, s.Distr.GetType().Name, s.Distr.DevolverParam1(), s.Distr.DevolverParam2()); i++;
            }

            form.LlenarCamposActividades(distribuciones, dtActividades);
        }

        private void InicializarColumnasTablaActividades()
        {
            if (dtActividadesPantalla.Columns.Count == 0)
            {
                dtActividadesPantalla.Columns.Add("SERV");
                dtActividadesPantalla.Columns.Add("DISTR");
                dtActividadesPantalla.Columns.Add("PARAMS");
            }

        }

        public void ActualizarActividades(DataTable dtActividadesActualizadas)
        {
            //Manejar la tabla por parametro y actualizar el grafo.
            foreach (DataRow dr in dtActividadesActualizadas.Rows)
            {
                if (dr[0].ToString() == "0")
                {
                    m.Llegadas.Distr = getDistribucion(dr[1].ToString(),
                                                                dr[2].ToString(),
                                                                dr[3].ToString());
                }
                if (dr[0].ToString() == "1")
                {
                    m.S1.Distr = getDistribucion(dr[1].ToString(),
                                                                dr[2].ToString(),
                                                                dr[3].ToString());
                }
                if (dr[0].ToString() == "2")
                {
                    m.S2.Distr = getDistribucion(dr[1].ToString(),
                                                                dr[2].ToString(),
                                                                dr[3].ToString());
                }
                if (dr[0].ToString() == "3")
                {
                    m.S3.Distr = getDistribucion(dr[1].ToString(),
                                                                dr[2].ToString(),
                                                                dr[3].ToString());
                }
                if (dr[0].ToString() == "4")
                {
                    m.S4.Distr = getDistribucion(dr[1].ToString(),
                                                                dr[2].ToString(),
                                                                dr[3].ToString());
                }

            }


            foreach (var v in Views)
            {
                if (v.GetType().Name == "Frm_TP7_PantallaSimulacion")
                {
                    var vista = (Frm_TP7_PantallaSimulacion)v;
                    OpcionCargarPanelActividades(vista);
                }
            }
        }
        private IDistribucion getDistribucion(string dist, string pparam1, string pparam2)
        {
            switch (dist)
            {
                case "Uniforme":
                    double param1U = Convert.ToDouble(pparam1);
                    double param2U = Convert.ToDouble(pparam2);
                    Uniforme u = new Uniforme(param1U, param2U);
                    return u;
                case "Exponencial":
                    double param1E = Convert.ToDouble(pparam1);
                    Exponencial e = new Exponencial(param1E);
                    return e;
                case "Normal":
                    double param1N = Convert.ToDouble(pparam1);
                    double param2N = Convert.ToDouble(pparam2);
                    Normal n = new Normal(param1N, param2N);
                    return n;
                case "Constante":
                    double param1C = Convert.ToDouble(pparam1);
                    Constante c = new Constante(param1C);
                    return c;
                case "ED":
                    ED ed = new ED();
                    return ed;
                default:
                    break;
            }
            return null;
        }
        private void InicializarColumnasTablas(ref DataTable dtGeneral)
        {

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

        public void OpcionCargarPanelActividades(Frm_TP7_PantallaSimulacion form)
        {
            dtActividadesPantalla.Clear();

            dtActividadesPantalla.Rows.Add("Lleg", m.Llegadas.Distr.GetType().Name, m.Llegadas.Distr.DevolverParams());
            var i = 1;
            foreach (Silo s in m.ListaSilos)
            {
                dtActividadesPantalla.Rows.Add("S" + i, s.Distr.GetType().Name, s.Distr.DevolverParams()); i++;
            }
            form.LlenarGridViewActividades(dtActividadesPantalla);
        }

    }
}
