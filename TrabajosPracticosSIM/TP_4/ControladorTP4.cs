using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using TrabajosPracticosSIM.TP_1;
using TrabajosPracticosSIM.TP_4.Entidades;
using TrabajosPracticosSIM.TP_4.InterfacesDeUsuario;

namespace TrabajosPracticosSIM.TP_4
{
    public class ControladorTP4 : ApplicationContext
    {
        //Instancia Unica - Patron Singleton
        private static readonly ControladorTP4 _instance = new ControladorTP4();
        public Random r = new Random();
        private Grafo grafo = new Grafo();
        DataTable dtActividadesPantalla = new DataTable();
        DataTable dtGeneral = new DataTable();

        //Lista de Vistas / Pantallas que controla el ControladorTP4
        private List<Form> Views = new List<Form>();

        //Constructor Privado.
        private ControladorTP4()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        }

        // Devolver instancia estática única.
        public static ControladorTP4 GetInstance() { return _instance; }

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
            CreateView(new Frm_TP4_Principal());
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
        //Evento Cerrar un Form
        private void FormClosed(object sender, FormClosedEventArgs e)
        {
            //Remover Pantalla de la lista de Pantallas.
            Views.Remove(sender as Form);
            // NOTE: Terminar programa si no quedan mas Vistas/Forms o si se está cerrando la ventana principal.
            if (Views.Count == 0 || sender.GetType() == typeof(Frm_TP4_Principal)) Exit();
        }

        //Finalizar Programa
        public void Exit()
        {
            this.ExitThread();
        }

        /// <summary>
        /// /Crea Pantalla Frm_TP4_Montecarlo
        /// </summary>
        public void OpcionPantallaMontecarlo()
        {
            CreateView(new Frm_TP4_Montecarlo());
        }
        public void OpcionPantallaConfiguracion()
        {
            CreateView(new Frm_TP4_Configuracion());
        }
        /// <summary>
        /// Metodo que ejecuta la Simulación
        /// </summary>
        /// <param name="form">Por Parametro se pasa pantalla que lo llamó</param>
        public void OpcionIniciarSimulacion(Frm_TP4_Montecarlo form, int cant_sim, int desde, int hasta)
        {
            //Dejar Lista Tablas de Datos
            LimpiarTableDatas();

            //Condiciones Iniciales
            double r1, r2, r3, r4, r5;
            double t1, t2, t3, t4, t5;
            double n1, n2, n3, n4;
            double tiempoEnsamble = 0,promedioTiempoEnsamble = 0;
            double tiempoMin = 9999, tiempoMax = 0;
            int contadorMenorIgual45 = 0;
            double probMenorIgual45 = 0;
            
            //Empieza la simulacion
            for (int i = 1; i <= cant_sim; i++)
            {
                
                //Randoms
                r1 = Utiles.RedondearDecimales(r.NextDouble(), 4);
                r2 = Utiles.RedondearDecimales(r.NextDouble(), 4);
                r3 = Utiles.RedondearDecimales(r.NextDouble(), 4);
                r4 = Utiles.RedondearDecimales(r.NextDouble(), 4);
                r5 = Utiles.RedondearDecimales(r.NextDouble(), 4);

                //Tiempos de Actividades
                Queue<double> q = new Queue<double>();
                q.Enqueue(r1);
                t1 = grafo.actividad1.CalcularTiempo(q);
                q.Enqueue(r2);
                t2 = grafo.actividad2.CalcularTiempo(q);
                q.Enqueue(r3);
                t3 = grafo.actividad3.CalcularTiempo(q);
                q.Enqueue(r4);
                t4 = grafo.actividad4.CalcularTiempo(q);
                q.Enqueue(r5);
                t5 = grafo.actividad5.CalcularTiempo(q);

                //Calcular Tiempos en Nodos
                n1 = grafo.nodo1.CalcularTiempoFinalizacion();
                n2 = grafo.nodo2.CalcularTiempoFinalizacion();
                n3 = grafo.nodo3.CalcularTiempoFinalizacion();
                n4 = grafo.nodo4.CalcularTiempoFinalizacion();

                //Tiempo Ensamble
                tiempoEnsamble = n4;

                //Calcular Promedio
                promedioTiempoEnsamble = Utiles.RedondearDecimales((promedioTiempoEnsamble * (i - 1) + tiempoEnsamble) / i, 4);

                //Tiempo Minimo
                if(tiempoEnsamble< tiempoMin)
                {
                    tiempoMin = tiempoEnsamble;
                }
                //Tiempo Maximo
                if (tiempoEnsamble > tiempoMax)
                {
                    tiempoMax = tiempoEnsamble;
                }
                //Probabilidad Menor Igual 45
                if (tiempoEnsamble <= 45)
                {
                    contadorMenorIgual45++;
                }
                probMenorIgual45 = Utiles.RedondearDecimales(contadorMenorIgual45 / (double)i, 4);

                //Recordar solo las que pide
                if((i >= 1 && i <= 20) || i%1000 == 0 || (i >= desde && i <= hasta) )
                {
                    dtGeneral.Rows.Add(i,r1, r2, r3, r4, r5, t1, t2, t3, t4, t5, n1, n2, n3, n4,
                               tiempoEnsamble, promedioTiempoEnsamble,
                tiempoMin, tiempoMax, contadorMenorIgual45, probMenorIgual45);
                }

                

            }
            form.LlenarGridView(dtGeneral);
        }

        private void InicializarColumnasTablas()
        {
            dtActividadesPantalla.Columns.Add("ID");
            dtActividadesPantalla.Columns.Add("DISTR");
            dtActividadesPantalla.Columns.Add("PARAMS");


            dtGeneral.Columns.Add("i");
            dtGeneral.Columns.Add("r1");
            dtGeneral.Columns.Add("r2");
            dtGeneral.Columns.Add("r3");
            dtGeneral.Columns.Add("r4");
            dtGeneral.Columns.Add("r5");
            dtGeneral.Columns.Add("t1");
            dtGeneral.Columns.Add("t2");
            dtGeneral.Columns.Add("t3");
            dtGeneral.Columns.Add("t4");
            dtGeneral.Columns.Add("t5");
            dtGeneral.Columns.Add("n1");
            dtGeneral.Columns.Add("n2");
            dtGeneral.Columns.Add("n3");
            dtGeneral.Columns.Add("n4");
            dtGeneral.Columns.Add("tiempoEnsamble");
            dtGeneral.Columns.Add("promedioTiempoEnsamble");
            dtGeneral.Columns.Add("tiempoMin");
            dtGeneral.Columns.Add("tiempoMax");
            dtGeneral.Columns.Add("contadorMenorIgual45");
            dtGeneral.Columns.Add("probMenorIgual45");
        }
        private void LimpiarTableDatas()
        {
            dtGeneral.Clear();
        }
        public void OpcionCargarPanelActividades(Frm_TP4_Montecarlo form)
        {
            dtActividadesPantalla.Clear();
            dtActividadesPantalla.Rows.Add(grafo.actividad1.Id, grafo.actividad1.Distr.GetType().Name, grafo.actividad1.Distr.DevolverParams());
            dtActividadesPantalla.Rows.Add(grafo.actividad2.Id, grafo.actividad2.Distr.GetType().Name, grafo.actividad2.Distr.DevolverParams());
            dtActividadesPantalla.Rows.Add(grafo.actividad3.Id, grafo.actividad3.Distr.GetType().Name, grafo.actividad3.Distr.DevolverParams());
            dtActividadesPantalla.Rows.Add(grafo.actividad4.Id, grafo.actividad4.Distr.GetType().Name, grafo.actividad4.Distr.DevolverParams());
            dtActividadesPantalla.Rows.Add(grafo.actividad5.Id, grafo.actividad5.Distr.GetType().Name, grafo.actividad5.Distr.DevolverParams());

            form.LlenarGridViewActividades(dtActividadesPantalla);
        }
    }

}
