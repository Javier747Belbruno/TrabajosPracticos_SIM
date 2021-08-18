using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajosPracticosSIM.TP_1.Entidades;
using TrabajosPracticosSIM.TP_1.InterfacesDeUsuario;
using MathNet.Numerics.Distributions;
using TrabajosPracticosSIM.TP_1;

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
        public void opcionGeneracionDeNumerosAleatorios(Frm_PantallaGeneracionDeNumerosAleatorios frm, 
                                int a, int c, int semilla, int m)
        {
            if(frm.getMetodo() == 0)
            {
                GeneradorCongruenteMixto genCMixto = new GeneradorCongruenteMixto(x:semilla,a:a,c:c,m:m);
                var lista = genCMixto.getLista();
                frm.LlenarTablaInicial(lista);
            }
            if(frm.getMetodo() == 1)
            {
                GeneradorCongruenteMultiplicativo genCMult = new GeneradorCongruenteMultiplicativo(x: semilla, a: a, m: m);
                var lista = genCMult.getLista();
                frm.LlenarTablaInicial(lista);
            }
        }

        public void opcionNumerosAleatoriosLenguaje(Frm_PantallaPruebaDeFrecuencia frm, int cantNros, int cantIntervs)
        {
            GeneradorLenguaje genLenguaje = new GeneradorLenguaje(m: cantNros);
            var lista = genLenguaje.getLista();
            EstructuraFrecuencias(frm, lista, cantNros, cantIntervs);
        }

        public void opcionNumerosAleatoriosMixtos(Frm_PantallaPruebaDeFrecuencia frm, 
                                int cantNros, int cantIntervs, int a, int c, int semilla, int m)
        {
            GeneradorCongruenteMixto genCM = new GeneradorCongruenteMixto(a: a,x:semilla,c:c,m:m, cant:cantNros);
            var lista = genCM.getLista();
            EstructuraFrecuencias(frm, lista, cantNros, cantIntervs);

        }

        public void EstructuraFrecuencias(Frm_PantallaPruebaDeFrecuencia frm
                        , SortedDictionary<int, double> lista,int cantNros,int cantIntervs)
        {
            EstructuraFrecuencias estruc = new EstructuraFrecuencias(lista: lista, cant_Nros: cantNros, cant_intervalos: cantIntervs);
            
            //Construyo Estructura.
            estruc.construirEstructuraFrecuencias();
            //Calculo chi cuadrado
            estruc.CalcularChiCuadrado();
            // Obtener los intervalos.
            var Intervalos = estruc.getIntervalos();

            double chi_cuadrado_calculado = estruc.getChi_cuadrado();
            
            double significancia_alfa = 0.05;

            //Obtener Chi por tabla
            double chi_tabulado = getChiTabulado(chi_cuadrado_calculado, cantIntervs, significancia_alfa);
            //Get Resultado de hipotesis
            String mensaje = getRespuestaFinal(chi_cuadrado_calculado, chi_tabulado);

            //Crear arrays para meter los datos.
            ArrayList mediaInterFO = new ArrayList();
            ArrayList FE = new ArrayList();
            ArrayList FO = new ArrayList();
            
            foreach (KeyValuePair<double, Subintervalo> kvp in Intervalos)
            {
                mediaInterFO.Add(Utiles.Redondear4Decimales(kvp.Key));
                FO.Add(Utiles.Redondear4Decimales(kvp.Value.getFrecuenciaObservada()));
                FE.Add(Utiles.Redondear4Decimales(kvp.Value.getFrecuenciaEsperada()));
            }


            frm.GenerarGraficosYTabla(FE, mediaInterFO, FO, Intervalos, lista,chi_cuadrado_calculado
                                    ,chi_tabulado,mensaje,significancia_alfa, cantIntervs);
        }

        private string getRespuestaFinal(double chi_cuadrado_calculado, double chi_tabulado)
        {
            if(chi_cuadrado_calculado <= chi_tabulado)
            {
                return "Dado que el chi calculado es menor o igual al chi por tabla NO se puede rechazar la hipótesis"
                    + " de que la muestra proviene de una distribución uniforme de probabilidad";
            }
            
        return "Dado que el chi calculado es mayor al chi por tabla se puede rechazar la hipótesis"
            + " de que la muestra proviene de una distribución uniforme de probabilidad";
   
        }

        //Obtener Chi por tabla
        public double getChiTabulado(double chi_cuadrado_calculado, int cantIntervs, double significancia_alfa)
        {
            ChiSquared ch = new ChiSquared(cantIntervs - 1);
            double chiTabulado = ch.InverseCumulativeDistribution(1 - significancia_alfa);
            return chiTabulado;
        }

        public void opcionPantallaPruebaDeFrecuencia()
        {
            HabilitarPantallaPruebaDeFrecuencia();
        }

        public void HabilitarPantallaPruebaDeFrecuencia()
        {
            CreateView(new Frm_PantallaPruebaDeFrecuencia());
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
            if (!EstaRepetidaLaVista) { 
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
            if (Views.Count == 0 || sender.GetType() == typeof(Frm_PantallaPrincipal)) Exit();
        }

        //Finalizar Programa
        public void Exit()
        {
            this.ExitThread();
        }

    }
}
