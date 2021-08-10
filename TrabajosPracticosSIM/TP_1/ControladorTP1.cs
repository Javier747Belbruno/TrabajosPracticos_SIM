using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajosPracticosSIM
{
    public class ControladorTP1 : ApplicationContext
    {

        //Instancia Unica - Patron Singleton
        private ControladorTP1 mInstance;
        //Lista de Vistas
        private List<Form> Views = new List<Form>();


        //Constructor
        public ControladorTP1()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mInstance = this;
        }
        public ControladorTP1 Instance { get { return mInstance; } }
        public void Start()
        {
            HabilitarPantallaPrincipal();
            Application.Run(this);
        }

        public void IniciarFuncionalidad()
        {
            HabilitarPantallaPrincipal();
        }

        public void HabilitarPantallaPrincipal()
        {
            CreateView(new PantallaPrincipal());
        }

        public void Exit()
        {
            this.ExitThread();
        }
        public void CreateView(Form frm)
        {
            Views.Add(frm);
            frm.FormClosed += FormClosed;
            frm.Show();
        }
        private void FormClosed(object sender, FormClosedEventArgs e)
        {
            Views.Remove(sender as Form);
            // NOTE: Terminar programa si no quedan mas Vistas/Forms
            if (Views.Count == 0) Exit();
        }

    }
}
