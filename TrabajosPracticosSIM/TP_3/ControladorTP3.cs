using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TrabajosPracticosSIM.TP_1.Entidades;
using TrabajosPracticosSIM.TP_3.Entidades;
using TrabajosPracticosSIM.TP_3.InterfacesDeUsuario;

namespace TrabajosPracticosSIM.TP_3
{
    public class ControladorTP3 : ApplicationContext
    {
        //Instancia Unica - Patron Singleton
        private static readonly ControladorTP3 _instance = new ControladorTP3();
        //Lista de Vistas / Pantallas que controla el ControladorTP3
        private List<Form> Views = new List<Form>();

        //Aca se guarda las varAleatorias
        SortedDictionary<int, Random_VarAleatoria> listaVariablesAleatorias 
                = new SortedDictionary<int, Random_VarAleatoria>();

        //

        //Constructor Privado.
        private ControladorTP3()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        }
        // Devolver instancia estática única.
        public static ControladorTP3 GetInstance() { return _instance; }

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
            CreateView(new Frm_TP3_Principal());
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
            if (Views.Count == 0 || sender.GetType() == typeof(Frm_TP3_Principal)) Exit();
        }

        //Finalizar Programa
        public void Exit()
        {
            this.ExitThread();
        }


        //Crear Pantalla Punto A
        public void OpcionPantallaPuntoA()
        {
            CreateView(new Frm_TP3_PuntoA());
        }
        //Crear Pantalla Punto B
        public void OpcionPantallaPuntoB()
        {
            CreateView(new Frm_TP3_PuntoB_UEN());
        }

        //Prueba de Frecuenta.
        public void Prueba_de_Frecuencias(int cant_intervalos, int significancia_alfa)
        {
            EstructuraFrecuencias_General EFG = new EstructuraFrecuencias_General(listaVariablesAleatorias,listaVariablesAleatorias.Count,cant_intervalos);
            EFG.construirEstructuraFrecuencias();
            
        }

        

        public void OpcionGenerarUniforme(int cantidad, double a, double b, Frm_TP3_PuntoA form)
        {
            //Obtener randoms Lenguaje
            GeneradorLenguaje genLenguage = new GeneradorLenguaje(cantidad);
            SortedDictionary<int, double> listaRandoms = genLenguage.getLista();
        
            //Generar las var aleatorias uniformes
            GeneradorAleatoriasUniforme genAU = new GeneradorAleatoriasUniforme(a, b);
            listaVariablesAleatorias = genAU.getListaVarUniformes(listaRandoms);

            //Pasar a la Pantalla para que muestre
            form.MostrarLista(listaVariablesAleatorias);
        }
        public void OpcionGenerarExponencial(int cantidad, double lambda, Frm_TP3_PuntoA form)
        {
            //Obtener randoms Lenguaje
            GeneradorLenguaje genLenguage = new GeneradorLenguaje(cantidad);
            SortedDictionary<int, double> listaRandoms = genLenguage.getLista();

            //Generar las var aleatorias Exponenciales
            GeneradorAleatoriasExponencial genAE = new GeneradorAleatoriasExponencial(lambda);
            listaVariablesAleatorias = genAE.getListaVariablesAleatorias(listaRandoms);

            //Pasar a la Pantalla para que muestre
            form.MostrarLista(listaVariablesAleatorias);
        }
        public void OpcionGenerarPoisson(int cantidad, double lambda, Frm_TP3_PuntoA form)
        {
            //Obtener randoms Lenguaje
            GeneradorLenguaje genLenguage = new GeneradorLenguaje(cantidad);
            SortedDictionary<int, double> listaRandoms = genLenguage.getLista();

            //Generar las var aleatorias Poisson
            GeneradorAleatoriasPoisson genAP = new GeneradorAleatoriasPoisson(lambda);
            listaVariablesAleatorias = genAP.getListaVariablesAleatorias(listaRandoms);

            //Pasar a la Pantalla para que muestre
            form.MostrarLista(listaVariablesAleatorias);
        }
        public void OpcionGenerarNormal(int cantidad, double normal, double ds, Frm_TP3_PuntoA form)
        {
            //Obtener randoms Lenguaje
            GeneradorLenguaje genLenguage = new GeneradorLenguaje(cantidad);
            int milisegundo = 20;
            System.Threading.Thread.Sleep(milisegundo);
            GeneradorLenguaje genLenguage2 = new GeneradorLenguaje(cantidad);
            SortedDictionary<int, double> listaRandoms = genLenguage.getLista();
            SortedDictionary<int, double> listaRandoms2 = genLenguage2.getLista();

            //Generar las var aleatorias Normal
            GeneradorAleatoriasNormal genAN = new GeneradorAleatoriasNormal(normal, ds);
            listaVariablesAleatorias = genAN.getListaVariablesAleatorias(listaRandoms, listaRandoms2);

            //Pasar a la Pantalla para que muestre
            form.MostrarLista(listaVariablesAleatorias);
        }
    }
}