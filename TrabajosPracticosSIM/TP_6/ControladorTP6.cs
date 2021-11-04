using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TrabajosPracticosSIM.TP_4.Entidades;
using TrabajosPracticosSIM.TP_5.Entidades;
using TrabajosPracticosSIM.TP_6.Entidades;
using TrabajosPracticosSIM.TP_6.InterfacesDeUsuario;

namespace TrabajosPracticosSIM.TP_6
{
    public class ControladorTP6 : ApplicationContext
    {
        //Instancia Unica - Patron Singleton
        private static readonly ControladorTP6 _instance = new ControladorTP6();

        //Lista de Vistas / Pantallas que controla el ControladorTP5
        private List<Form> Views = new List<Form>();



        //Objeto Ecuacion Diferencial
        private EcDiferencial ed = new EcDiferencial();
        //Objeto Modelo
        private IModelo modelo;

        //TABLA ACTIVIDADES
        DataTable dtActividadesPantalla = new DataTable();

        //Constructor Privado.
        private ControladorTP6()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        }

        public void CalcularEuler(Frm_TP6_PantallaPuntoAE form)
        {
            ed.CalcularEuler();
            form.LlenarDatosEuler(ed.EulerDT); 
        }

        public void CalcularRK(Frm_TP6_PantallaPuntoAE form)
        {
            ed.CalcularRK();
            form.LlenarDatosRK(ed.RKDT);
        }

        // Devolver instancia estática única.
        public static ControladorTP6 GetInstance() { return _instance; }

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
            CreateView(new Frm_TP6_Principal());
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
            if (Views.Count == 0 || sender.GetType() == typeof(Frm_TP6_Principal)) Exit();
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
            CreateView(new Frm_TP6_Enunciado());
        }
        public void OpcionPuntoAE()
        {
            CreateView(new Frm_TP6_PantallaPuntoAE());
        }
        public void OpcionPuntoF()
        {
            CreateView(new Frm_TP6_PantallaSimulacion());
        }
        public void OpcionGraficoPuntoBXdeT()
        {
            CreateView(new Frm_TP6_GraficoTipoT(1));
        }
        public void OpcionGraficoPuntoBDXdeT()
        {
            CreateView(new Frm_TP6_GraficoTipoT(2));
        }
        public void OpcionGraficoPuntoBDDXdeT()
        {
            CreateView(new Frm_TP6_GraficoTipoT(3));
        }
        public void OpcionGraficoPuntoBRK()
        {
            CreateView(new Frm_TP6_GraficoTipo3Series(1));
        }
        public void OpcionGraficoPuntoBEuler()
        {
            CreateView(new Frm_TP6_GraficoTipo3Series(2));
        }
        public void OpcionGraficoPuntoC()
        {
            CreateView(new Frm_TP6_GraficoTipoT(4));
        }
        public void OpcionGraficoPuntoD()
        {
            CreateView(new Frm_TP6_GraficoTipoT(5));
        }
        public void OpcionGraficoPuntoE()
        {
            CreateView(new Frm_TP6_GraficoTipoT(6));
        }
        public void OpcionConfigED()
        {
            CreateView(new Frm_TP6_Config_ED());
        }
        public void OpcionPantallaConfiguracion()
        {
            CreateView(new Frm_TP6_Config_Actividades());
        }
        public void OpcionPedirDatosGraficoTipoT(Frm_TP6_GraficoTipoT form, int valorgrafico)
        {
            ArrayList EjeXEuler = null;
            ArrayList EjeYEuler = null;
            ArrayList EjeXRK = null;
            ArrayList EjeYRK = null;
            int columnaXEuler = 0;
            int columnaYEuler = 0;
            int columnaXRK = 0;
            int columnaYRK = 0;
            if (valorgrafico == 1)//x en funcion de t
            {
                columnaXEuler = 0;
                columnaYEuler = 1;
                columnaXRK = 0;
                columnaYRK = 1;
            }
            if (valorgrafico == 2)//x' en funcion de t
            {
                columnaXEuler = 0;
                columnaYEuler = 2;
                columnaXRK = 0;
                columnaYRK = 6;
            }
            if (valorgrafico == 3)//x'' en funcion de t
            {
                columnaXEuler = 0;
                columnaYEuler = 3;
                columnaXRK = 0;
                columnaYRK = 11;
            }
            if (valorgrafico == 4)//x'' en funcion de x
            {
                columnaXEuler = 1;
                columnaYEuler = 3;
                columnaXRK = 1;
                columnaYRK = 11;
            }
            if (valorgrafico == 5)//x' en funcion de x
            {
                columnaXEuler = 1;
                columnaYEuler = 2;
                columnaXRK = 1;
                columnaYRK = 6;
            }
            if (valorgrafico == 6)//x'' en funcion de x'
            {
                columnaXEuler = 2;
                columnaYEuler = 3;
                columnaXRK = 6;
                columnaYRK = 11;
            }

            if (ed.EulerDT.Rows.Count > 0)
            {
  
                EjeXEuler = new ArrayList();
                EjeYEuler = new ArrayList();
                foreach (DataRow dr in ed.EulerDT.Rows)
                {
                    if (dr == ed.EulerDT.Rows[ed.EulerDT.Rows.Count - 1]) {
                        break;
                    }
                    EjeXEuler.Add(Convert.ToDouble(dr[columnaXEuler]));
                    EjeYEuler.Add(Convert.ToDouble(dr[columnaYEuler]));
                }
            }
            if (ed.RKDT.Rows.Count > 0)
            {
                EjeXRK = new ArrayList();
                EjeYRK = new ArrayList();
                foreach (DataRow dr in ed.RKDT.Rows)
                {
                    if (dr == ed.RKDT.Rows[ed.RKDT.Rows.Count - 1])
                    {
                        break;
                    }
                    EjeXRK.Add(Convert.ToDouble(dr[columnaXRK]));
                    EjeYRK.Add(Convert.ToDouble(dr[columnaYRK]));
                }
            }
            form.LlenarGrafico(valorgrafico,EjeXEuler, EjeYEuler, EjeXRK, EjeYRK);
            

        }
        public void OpcionPedirDatosGraficoTipo3Series(Frm_TP6_GraficoTipo3Series form, int valorgrafico)
        {
            ArrayList EjeX = null;
            ArrayList EjeY1 = null;
            ArrayList EjeY2 = null;
            ArrayList EjeY3 = null;
            int columnaX = 0;
            int columnaY1 = 0;
            int columnaY2 = 0;
            int columnaY3 = 0;
            if (valorgrafico == 1)//RK
            {
                columnaX = 0;
                columnaY1 = 11;
                columnaY2 = 6;
                columnaY3 = 1;
                if (ed.RKDT.Rows.Count > 0)
                {
                    EjeX = new ArrayList();
                    EjeY1 = new ArrayList();
                    EjeY2 = new ArrayList();
                    EjeY3 = new ArrayList();
                    foreach (DataRow dr in ed.RKDT.Rows)
                    {
                        if (dr == ed.RKDT.Rows[ed.RKDT.Rows.Count - 1])
                        {
                            break;
                        }
                        EjeX.Add(Convert.ToDouble(dr[columnaX]));
                        EjeY1.Add(Convert.ToDouble(dr[columnaY1]));
                        EjeY2.Add(Convert.ToDouble(dr[columnaY2]));
                        EjeY3.Add(Convert.ToDouble(dr[columnaY3]));
                    }
                    form.LlenarGrafico(valorgrafico, EjeX, EjeY1, EjeY2, EjeY3);
                }
                else
                {
                    throw new Exception("No hay data de RK para graficar");
                }
            }
            if (valorgrafico == 2)//Euler
            {
                columnaX = 0;
                columnaY1 = 3;
                columnaY2 = 2;
                columnaY3 = 1;
                if (ed.EulerDT.Rows.Count > 0)
                {
                    EjeX = new ArrayList();
                    EjeY1 = new ArrayList();
                    EjeY2 = new ArrayList();
                    EjeY3 = new ArrayList();
                    foreach (DataRow dr in ed.EulerDT.Rows)
                    {
                        if (dr == ed.EulerDT.Rows[ed.EulerDT.Rows.Count - 1])
                        {
                            break;
                        }
                        EjeX.Add(Convert.ToDouble(dr[columnaX]));
                        EjeY1.Add(Convert.ToDouble(dr[columnaY1]));
                        EjeY2.Add(Convert.ToDouble(dr[columnaY2]));
                        EjeY3.Add(Convert.ToDouble(dr[columnaY3]));
                    }
                    form.LlenarGrafico(valorgrafico, EjeX, EjeY1, EjeY2, EjeY3);
                }
                else
                {
                    throw new Exception("No hay data de Euler para graficar");
                }
            }

            
        }


        public void OpcionIniciarSimulacion(Frm_TP6_PantallaSimulacion form, int tipo_modelo, int cant_sim, int desde, int hasta, int param_punto_11)
        {

            if(tipo_modelo == 0 && modelo == null || tipo_modelo == 0 && modelo is ModeloTP6)
            {
                modelo = new ModeloTP5();
            }
            if (tipo_modelo == 1 && modelo == null || tipo_modelo == 1 && modelo is ModeloTP5)
            {
                //Pasarle la ecuacion diferencial al modelo
                modelo = new ModeloTP6(ed);
            }
            
            //TABLA GENERAL
            DataTable dtGeneral = new DataTable();
            InicializarColumnasTablas(tipo_modelo, ref dtGeneral);
            modelo.ResetearValores();

            #region SIMULACION
            for (int i = 1; i <= cant_sim; i++)
            {
                //Primera vuelta
                if (i == 1)
                {
                    modelo.CalcularLlegada();
                    modelo.GuardarLlegadaPedido();

                    modelo.AgregarFila(i,ref dtGeneral);
                    //Continuar con la segunda vuelta
                    continue;
                }

                modelo.CalcularReloj();

                modelo.CalcularEvento();

                modelo.CalcularNroPedido();

                modelo.CalcularLlegada();

                modelo.CalcularServidoresYColas();

                modelo.CalcularPedidosRealizados();

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
                
                //Recordar solo las que pide
                if ((i >= 1 && i <= 50) || i % 10000 == 0 || (i >= desde && i <= hasta) || i == cant_sim)
                {
                    modelo.AgregarFila(i,ref dtGeneral);
                }
            }
            #endregion

            form.LlenarPantallaSimulacion(dtGeneral, tipo_modelo);
        }

        public void ActualizarActividades(DataTable dtActividadesActualizadas)
        {
           //Manejar la tabla por parametro y actualizar el grafo.
            foreach (DataRow dr in dtActividadesActualizadas.Rows)
            {
                if (dr[0].ToString() == "0")
                {
                    modelo.Llegadas.Distr = getDistribucion(dr[1].ToString(),
                                                                dr[2].ToString(),
                                                                dr[3].ToString());
                }
                if (dr[0].ToString() == "1")
                {
                    modelo.S1.Distr = getDistribucion(dr[1].ToString(),
                                                                dr[2].ToString(),
                                                                dr[3].ToString());
                }
                if (dr[0].ToString() == "2")
                {
                    modelo.S2.Distr = getDistribucion(dr[1].ToString(),
                                                                dr[2].ToString(),
                                                                dr[3].ToString());
                }
                if (dr[0].ToString() == "3")
                {
                    modelo.S3.Distr = getDistribucion(dr[1].ToString(),
                                                                dr[2].ToString(),
                                                                dr[3].ToString());
                }
                if (dr[0].ToString() == "4")
                {
                    modelo.S4.Distr = getDistribucion(dr[1].ToString(),
                                                                dr[2].ToString(),
                                                                dr[3].ToString());
                }
                if (dr[0].ToString() == "5")
                {
                    modelo.S5.Distr = getDistribucion(dr[1].ToString(),
                                                                dr[2].ToString(),
                                                                dr[3].ToString());
                }

            }


            foreach (var v in Views)
            {
                if (v.GetType().Name == "Frm_TP6_PantallaSimulacion")
                {
                    var vista = (Frm_TP6_PantallaSimulacion)v;
                    OpcionCargarPanelActividades(vista);
                }
            }
         }

        public void OpcionCargarPanelActividades(Frm_TP6_PantallaSimulacion form)
        {
            dtActividadesPantalla.Clear();

            dtActividadesPantalla.Rows.Add("Lleg", modelo.Llegadas.Distr.GetType().Name, modelo.Llegadas.Distr.DevolverParams());
            var i = 1;
            foreach (IServidor s in modelo.ListaServidores)
            {
                dtActividadesPantalla.Rows.Add("S" + i, s.Distr.GetType().Name, s.Distr.DevolverParams()); i++;
            }
            form.LlenarGridViewActividades(dtActividadesPantalla);
        }

        private void InicializarColumnasTablas(int modelo,ref DataTable dtGeneral)
        {
            if(dtActividadesPantalla.Columns.Count == 0)
            {
                dtActividadesPantalla.Columns.Add("SERV");
                dtActividadesPantalla.Columns.Add("DISTR");
                dtActividadesPantalla.Columns.Add("PARAMS");
            }

            dtGeneral.Columns.Add("i");
            dtGeneral.Columns.Add("Reloj");
            dtGeneral.Columns.Add("Evento");
            dtGeneral.Columns.Add("Nro Pedido");
            dtGeneral.Columns.Add("Prox Pedido");
            dtGeneral.Columns.Add("Tiempo Lleg");
            dtGeneral.Columns.Add("Tiempo Prox Lleg");
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
            if(modelo == 1)
            {
                dtGeneral.Columns.Add("Estado Servidor 6");
                dtGeneral.Columns.Add("Nro Pedido en At 6");
                dtGeneral.Columns.Add("Tiempo A6");
                dtGeneral.Columns.Add("Prox Tiempo A6");
            }
            dtGeneral.Columns.Add("EnsamblesRealizados");
            dtGeneral.Columns.Add("NroPedido Listo");
            dtGeneral.Columns.Add("Llegada Cliente");
            dtGeneral.Columns.Add("A1");
            dtGeneral.Columns.Add("A2");
            dtGeneral.Columns.Add("A3");
            dtGeneral.Columns.Add("A4");
            dtGeneral.Columns.Add("A5");
            if (modelo == 1)
            {
                dtGeneral.Columns.Add("A6");
            }
            dtGeneral.Columns.Add("Tiempo Ensamble");
            dtGeneral.Columns.Add("Prom Tiempo Ensamble");
            dtGeneral.Columns.Add("Pedidos Solicitados");
            dtGeneral.Columns.Add("Proporcion PR - PS");
            dtGeneral.Columns.Add("Cantidad_Maxima C1");
            dtGeneral.Columns.Add("Cantidad_Maxima C2");
            dtGeneral.Columns.Add("Cantidad_Maxima C3");
            dtGeneral.Columns.Add("Cantidad_Maxima C4");
            dtGeneral.Columns.Add("Cantidad_Maxima C5");
            dtGeneral.Columns.Add("Cantidad_Maxima C6");
            dtGeneral.Columns.Add("Tiempo_Promedio C1");
            dtGeneral.Columns.Add("Tiempo_Promedio C2");
            dtGeneral.Columns.Add("Tiempo_Promedio C3");
            dtGeneral.Columns.Add("Tiempo_Promedio C4");
            dtGeneral.Columns.Add("Tiempo_Promedio C5");
            dtGeneral.Columns.Add("Tiempo_Promedio C6");
            dtGeneral.Columns.Add("Cant Prom en Cola C1");
            dtGeneral.Columns.Add("Cant Prom en Cola C2");
            dtGeneral.Columns.Add("Cant Prom en Cola C3");
            dtGeneral.Columns.Add("Cant Prom en Cola C4");
            dtGeneral.Columns.Add("Cant Prom en Cola C5");
            dtGeneral.Columns.Add("Cant Prom en Cola C6");
            dtGeneral.Columns.Add("Pedidos en Sistema");
            dtGeneral.Columns.Add("Prom Pedidos en Sistema");
            dtGeneral.Columns.Add("Porcentaje Ocupado S1");
            dtGeneral.Columns.Add("Porcentaje Ocupado S2");
            dtGeneral.Columns.Add("Porcentaje Ocupado S3");
            dtGeneral.Columns.Add("Porcentaje Ocupado S4");
            dtGeneral.Columns.Add("Porcentaje Ocupado S5");
            if (modelo == 1)
            {
                dtGeneral.Columns.Add("Porcentaje Ocupado S6");
            }
            dtGeneral.Columns.Add("Tiempo Bloqueado S5");
            dtGeneral.Columns.Add("Proporcion Bloqueado - Ocupado S5");
            dtGeneral.Columns.Add("Proporcion Espera En Cola C6 (A5)");
            dtGeneral.Columns.Add("Proporcion Espera En Cola C6 (A3)");
            dtGeneral.Columns.Add("Nro_hora");
            dtGeneral.Columns.Add("contador");
            dtGeneral.Columns.Add("prom_ensambles");
            dtGeneral.Columns.Add("p11_contador_mayor_igual");
            dtGeneral.Columns.Add("p11_probabilidad");
            dtGeneral.Columns.Add("camino_critico");
            dtGeneral.Columns.Add("p13_A1");
            dtGeneral.Columns.Add("p13_A2");
            dtGeneral.Columns.Add("p13_A3");
            dtGeneral.Columns.Add("p13_A4");
            dtGeneral.Columns.Add("p13_A5");
        }


        public void OpcionCargarEDConfiguracion(Frm_TP6_Config_ED form)
        {
            List<string> distribuciones = new List<string>();
            var type = typeof(IDistribucion);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && p.IsClass && !(p.Name == "EcDiferencial"));

            foreach (var item in types)
            {
                distribuciones.Add(item.Name);
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("PARAM");
            dt.Columns.Add("DISTR");
            dt.Columns.Add("PARAM1");
            dt.Columns.Add("PARAM2");

            dt.Rows.Add("a", ed.a.GetType().Name, ed.a.DevolverParam1(), ed.a.DevolverParam2());
            dt.Rows.Add("b", ed.b.GetType().Name, ed.b.DevolverParam1(), ed.b.DevolverParam2());
            dt.Rows.Add("c", ed.c.GetType().Name, ed.c.DevolverParam1(), ed.c.DevolverParam2());
            dt.Rows.Add("h", ed.c.GetType().Name, ed.h.DevolverParam1(), ed.h.DevolverParam2());
            dt.Rows.Add("x0", ed.c.GetType().Name, ed.x0.DevolverParam1(), ed.x0.DevolverParam2());
            dt.Rows.Add("Dx0", ed.c.GetType().Name, ed.Dx0.DevolverParam1(), ed.Dx0.DevolverParam2());

            form.LlenarCamposActividades(distribuciones, dt);
        }
        public void ActualizarED(DataTable dt)
        {
            //Manejar la tabla por parametro y actualizar el grafo.
            foreach (DataRow dr in dt.Rows)
            {
                if (dr[0].ToString() == "0")
                {
                    ed.a = getDistribucion(dr[1].ToString(),
                                                                dr[2].ToString(),
                                                                dr[3].ToString());
                }
                if (dr[0].ToString() == "1")
                {
                    ed.b = getDistribucion(dr[1].ToString(),
                                                                dr[2].ToString(),
                                                                dr[3].ToString());
                }
                if (dr[0].ToString() == "2")
                {
                    ed.c = getDistribucion(dr[1].ToString(),
                                                                dr[2].ToString(),
                                                                dr[3].ToString());
                }
                if (dr[0].ToString() == "3")
                {
                    ed.h = getDistribucion(dr[1].ToString(),
                                                                dr[2].ToString(),
                                                                dr[3].ToString());
                }
                if (dr[0].ToString() == "4")
                {
                    ed.x0 = getDistribucion(dr[1].ToString(),
                                                                dr[2].ToString(),
                                                                dr[3].ToString());
                }
                if (dr[0].ToString() == "5")
                {
                    ed.Dx0 = getDistribucion(dr[1].ToString(),
                                                                dr[2].ToString(),
                                                                dr[3].ToString());
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
                default:
                    break;
            }
            return null;
        }
        public void OpcionCargarActividadesConfiguracion(Frm_TP6_Config_Actividades form)
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

            dtActividades.Rows.Add("Lleg", modelo.Llegadas.Distr.GetType().Name, modelo.Llegadas.Distr.DevolverParam1(), modelo.Llegadas.Distr.DevolverParam2());
            var i = 1;
            foreach (IServidor s in modelo.ListaServidores)
            {
                dtActividades.Rows.Add("S" + i, s.Distr.GetType().Name, s.Distr.DevolverParam1(), s.Distr.DevolverParam2()); i++;
            }

            form.LlenarCamposActividades(distribuciones, dtActividades);
        }

    }
}
