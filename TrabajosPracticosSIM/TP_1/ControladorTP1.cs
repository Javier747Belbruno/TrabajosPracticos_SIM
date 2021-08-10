using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajosPracticosSIM.TP_1.InterfacesDeUsuario;

namespace TrabajosPracticosSIM
{
    public class ControladorTP1 : ApplicationContext
    {

        //Instancia Unica - Patron Singleton
        private static readonly ControladorTP1 _instance = new ControladorTP1();
        
        //Lista de Vistas / Pantallas que controla el ControladorTP1
        private List<Form> Views = new List<Form>();


        //Constructor Privado.
        private ControladorTP1()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        }
        
        // Devolver instancia estática única.
        public static ControladorTP1 GetInstance() { return _instance; }


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
            CreateView(new Frm_PantallaPrincipal());
        }

        public void opcionPantallaGeneracionDeNumerosAleatorios()
        {
            HabilitarPantallaGeneracionDeNumerosAleatorios();
        }

        public void HabilitarPantallaGeneracionDeNumerosAleatorios()
        {
            CreateView(new Frm_PantallaGeneracionDeNumerosAleatorios());
        }

        //Viene de Pantalla GenDeNumerosAleat.
        public void opcionGeneracionDeNumerosAleatorios(Frm_PantallaGeneracionDeNumerosAleatorios frm_PantallaGeneracionDeNumerosAleatorios)
        {
            var mapa = GeneracionDeNumerosAleatorios();
            frm_PantallaGeneracionDeNumerosAleatorios.LlenarTablaInicial(mapa);
        }

        public SortedDictionary<int, double> GeneracionDeNumerosAleatorios()
        {
            //Prueba Con 5 Valores de llenado de Tabla.
            SortedDictionary<int, double> numeros = new SortedDictionary<int, double>();

            for (int i = 1; i < 51; i++)
            {
                numeros.Add(i, ((double)i/50));
            }
            

            return numeros;
        }


        public void Exit()
        {
            this.ExitThread();
        }
        public void CreateView(Form frm)
        {
            //Pregunto si ya existe este Tipo de Pantalla, si no existe la creo.
            bool EstaRepetidaLaVista = false;
            foreach (var v in Views)
            {
                if (frm.GetType() == v.GetType())
                    EstaRepetidaLaVista = true;
            }
            if (!EstaRepetidaLaVista) { 
                Views.Add(frm);
                frm.FormClosed += FormClosed;
                frm.Show();
            }
        }
        private void FormClosed(object sender, FormClosedEventArgs e)
        {
            //Remover Pantalla de la lista de Pantallas.
            Views.Remove(sender as Form);
            // NOTE: Terminar programa si no quedan mas Vistas/Forms o si se está cerrando la ventana principal.
            if (Views.Count == 0 || sender.GetType() == typeof(Frm_PantallaPrincipal)) Exit();
        }

    }
}
