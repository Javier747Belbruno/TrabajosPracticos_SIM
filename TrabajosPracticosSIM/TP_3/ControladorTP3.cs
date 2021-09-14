using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using TrabajosPracticosSIM.TP_1;
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
        
        private int cant_intervalos;
        EstructuraFrecuencias_General EFG;

        //Para solo Poisson
        private ArrayList funcDeDistrib = new ArrayList();
        private ArrayList probAcumuladas = new ArrayList();

        //Para mostrar en pantalla PuntoB
        private string distrSeleccionada;
        private string parametros;
        private string cantidad_var_aleatorias;

        private double a;
        private double b;
        private double lambda;
        private double media;
        private double ds;

        
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
        public void ReplaceView(Form frm)
        {
            bool EstaCreada = false;
            foreach (var v in Views)
            {
                if (frm.GetType() == v.GetType())
                {
                    v.Close();
                    v.FormClosed += FormClosed;
                    Views.Add(frm);
                    frm.FormClosed += FormClosed;
                    frm.Show();
                    EstaCreada = true;
                    break;
                }
            }
            if (!EstaCreada)
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
            Frm_TP3_PuntoB pantalla = new Frm_TP3_PuntoB();
            CreateView(pantalla);
            pantalla.setLabels(distrSeleccionada,parametros,cantidad_var_aleatorias);
            pantalla.MostrarLista(listaVariablesAleatorias);
        }

        //Prueba de Frecuenta.
        public void BtnPrueba_de_Frecuencias(int cant_intervalos, Frm_TP3_PuntoB form)
        {
            this.cant_intervalos = cant_intervalos;
            EFG = new EstructuraFrecuencias_General(distrSeleccionada,listaVariablesAleatorias
                                                                            ,listaVariablesAleatorias.Count,cant_intervalos);
            EFG.construirEstructuraFrecuencias();
            //Calculo chi cuadrado
            EFG.CalcularChiCuadrado();
            // Obtener los intervalos.
            var Intervalos = EFG.getIntervalos();

            //Crear arrays para meter los datos.
            ArrayList mediaInterFO = new ArrayList();
            ArrayList FE = new ArrayList();
            ArrayList FO = new ArrayList();

            foreach (KeyValuePair<double, Subintervalo> kvp in Intervalos)
            {
                mediaInterFO.Add(Utiles.RedondearDecimales(kvp.Key, 2));
                FO.Add(Utiles.Redondear4Decimales(kvp.Value.getFrecuenciaObservada()));
                FE.Add(Utiles.Redondear4Decimales(kvp.Value.getFrecuenciaEsperada()));
            }

            double chi_cuadrado_calculado = 0.0;
            double chi_tabulado = 0.0;
            string mensaje = "";
            double significancia_alfa = 0.0;
            int cantIntervs = 0; 
            form.GenerarGraficosYTabla(FE, mediaInterFO, FO, Intervalos, listaVariablesAleatorias, chi_cuadrado_calculado
                                    , chi_tabulado, mensaje, significancia_alfa, cantIntervs);

        }

        

        public void OpcionGenerarUniforme(int cantidad, double a, double b, Frm_TP3_PuntoA form)
        {

            //Lleno info que se va a usar en pantalla B
            this.a = a;
            this.b = b;
            distrSeleccionada = "Uniforme";
            parametros = "a = " + a + ", b = " + b;
            cantidad_var_aleatorias = cantidad.ToString();

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

            //Lleno info que se va a usar en pantalla B
            this.lambda = lambda;
            distrSeleccionada = "Exponencial";
            parametros = "λ = " + lambda;
            cantidad_var_aleatorias = cantidad.ToString();

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
            //Lleno info que se va a usar en pantalla B
            this.lambda = lambda;
            distrSeleccionada = "Poisson";
            parametros = "λ = " + lambda;
            cantidad_var_aleatorias = cantidad.ToString();

            //Obtener randoms Lenguaje
            GeneradorLenguaje genLenguage = new GeneradorLenguaje(cantidad);
            SortedDictionary<int, double> listaRandoms = genLenguage.getLista();

            //Generar las var aleatorias Poisson
            GeneradorAleatoriasPoisson genAP = new GeneradorAleatoriasPoisson(lambda);
            listaVariablesAleatorias = genAP.getListaVariablesAleatorias(listaRandoms);

            //Traer Arraylist Probabilidades Acumuladas.
            funcDeDistrib = genAP.getFuncionDeProbabilidad();
            probAcumuladas = genAP.getProbabilidadesAcumladas();

            //Pasar a la Pantalla para que muestre
            form.MostrarLista(listaVariablesAleatorias);
        }
        public void OpcionGenerarNormal(int cantidad, double media, double ds, Frm_TP3_PuntoA form)
        {
            //Lleno info que se va a usar en pantalla B
            this.media = media;
            this.ds = ds;
            distrSeleccionada = "Normal";
            parametros = "µ = " + media + ", σ = " + ds;
            cantidad_var_aleatorias = cantidad.ToString();

            //Obtener randoms Lenguaje
            GeneradorLenguaje genLenguage = new GeneradorLenguaje(cantidad);
            int milisegundo = 20;
            System.Threading.Thread.Sleep(milisegundo);
            GeneradorLenguaje genLenguage2 = new GeneradorLenguaje(cantidad);
            SortedDictionary<int, double> listaRandoms = genLenguage.getLista();
            SortedDictionary<int, double> listaRandoms2 = genLenguage2.getLista();

            //Generar las var aleatorias Normal
            GeneradorAleatoriasNormal genAN = new GeneradorAleatoriasNormal(media, ds);
            listaVariablesAleatorias = genAN.getListaVariablesAleatorias(listaRandoms, listaRandoms2);

            //Pasar a la Pantalla para que muestre
            form.MostrarLista(listaVariablesAleatorias);
        }

        public void Btn_Chi_Cuadrado(double significancia_alfa, Frm_TP3_PuntoB frm_TP3_PuntoB)
        {
            Frm_TP3_PuntoB_ChiCuadrado pantalla = new Frm_TP3_PuntoB_ChiCuadrado();
            CreateView(pantalla);

            double chi_calculado = EFG.getChi_cuadrado();


            PruebaDeChi x2 = new PruebaDeChi(distrSeleccionada, chi_calculado, significancia_alfa, cant_intervalos);
            x2.calcularPrueba();

            pantalla.LlenarTextBoxes(chi_calculado, x2.getChi_tabulado(), x2.getGDL(),
                                        significancia_alfa, x2.getMensaje());
        }

        public void Btn_Probabilidades_Poisson()
        {
            Frm_TP3_PuntoB_ProbPoisson pantalla = new Frm_TP3_PuntoB_ProbPoisson();
            ReplaceView(pantalla);
            pantalla.LlenarTabla(funcDeDistrib, probAcumuladas);
        }
        public string getDistrSeleccionada()
        {
            return distrSeleccionada;
        }

        public double getA()
        {
            return a;
        }
        public double getB()
        {
            return b;
        }
        public double getLambda()
        {
            return lambda;
        }
        public double getMedia()
        {
            return media;
        }
        public double getDS()
        {
            return ds;
        }
        public ArrayList getFuncDeDistribPoisson()
        {
            return funcDeDistrib;
        }
        public ArrayList getFuncDeDistribPoissonAcum()
        {
            return probAcumuladas;
        }

    }
}