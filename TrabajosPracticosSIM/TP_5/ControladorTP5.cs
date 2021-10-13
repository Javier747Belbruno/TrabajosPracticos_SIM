using System.Collections.Generic;
using System.Windows.Forms;
using TrabajosPracticosSIM.TP_5.InterfacesDeUsuario;

namespace TrabajosPracticosSIM.TP_5
{
    public class ControladorTP5 : ApplicationContext
    {
        //Instancia Unica - Patron Singleton
        private static readonly ControladorTP5 _instance = new ControladorTP5();


        //Lista de Vistas / Pantallas que controla el ControladorTP5
        private List<Form> Views = new List<Form>();

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
