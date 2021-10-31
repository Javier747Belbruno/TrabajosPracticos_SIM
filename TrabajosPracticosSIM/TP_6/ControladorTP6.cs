using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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



        //Constructor Privado.
        private ControladorTP6()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
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
        public void OpcionIniciarSimulacion(Frm_TP6_PantallaSimulacion form, int cant_sim, int desde, int hasta, int param_punto_11)
        {


            IModelo modelo;
            modelo = new ModeloTP6();
            String tipomodelo = "TP6";
            //TABLA GENERAL
            DataTable dtGeneral = new DataTable();
            InicializarColumnasTablas(tipomodelo,ref dtGeneral);

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

            form.LlenarPantallaSimulacion(dtGeneral);
        }
        private void InicializarColumnasTablas(string modelo,ref DataTable dtGeneral)
        {

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
            if(modelo == "TP6")
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
            if (modelo == "TP6")
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
            if (modelo == "TP6")
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

    }
}
