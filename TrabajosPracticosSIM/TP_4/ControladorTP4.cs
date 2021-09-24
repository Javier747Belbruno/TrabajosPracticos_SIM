using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TrabajosPracticosSIM.TP_4.Entidades;

namespace TrabajosPracticosSIM.TP_4
{
    public class ControladorTP4 : ApplicationContext
    {
        //Instancia Unica - Patron Singleton
        private static readonly ControladorTP4 _instance = new ControladorTP4();
        public Random r = new Random();
    

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

        public void OpcionIniciarSimulacion()
        {
    
            //The Mighty FOR
            for (int i = 0; i < 2; i++)
            {
                double r1, r2, r3, r4, r5;
                
                r1 = r.NextDouble();
                r2 = r.NextDouble();
                r3 = r.NextDouble();
                r4 = r.NextDouble();
                r5 = r.NextDouble();
                var lala = "";
            }
        }



    }
}
