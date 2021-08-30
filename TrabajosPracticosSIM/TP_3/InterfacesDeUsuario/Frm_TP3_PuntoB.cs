using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajosPracticosSIM.TP_1;
using TrabajosPracticosSIM.TP_1.Entidades;
using TrabajosPracticosSIM.TP_3.Entidades;

namespace TrabajosPracticosSIM.TP_3.InterfacesDeUsuario
{
    public partial class Frm_TP3_PuntoB : Form
    {
        private int cantNros;
        private int cantIntervs;
        private int a;
        private int c;
        private int semilla;
        private int m;
        private SortedDictionary<double, Subintervalo> estructuraFrecObservada;
        private SortedDictionary<int, Random_VarAleatoria> lista;

        public Frm_TP3_PuntoB()
        {
            InitializeComponent();
            Iniciar();
        }

        private void Iniciar()
        {
            VisibilidadPanelChiCuadrado(false);
            VisibilidadPanelGrafico(false);
            chart1.Titles.Add("Histograma de Frecuencias");
            chart1.ChartAreas[0].AxisX.Title = "Marcas de Clase";
            chart1.ChartAreas[0].AxisY.Title = "Frecuencia";
            chart1.Series[0].LegendText = "FE";
            chart1.Series[1].LegendText = "FO";
            Btn_Probabilidades.Visible = false;
        }

        private void VisibilidadPanelChiCuadrado(bool valor)
        {
            pnl_x2.Visible = valor;
        }
        private void VisibilidadPanelGrafico(bool valor)
        {
            pnl_Grafico.Visible = valor;
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void btn_Gen_Leng_Click(object sender, EventArgs e)
        {
            try
            {
               // CambiarColorBtnSeleccionado(btn_met_mixto, Color.LightGray);
                CambiarColorBtnSeleccionado(sender, Color.LightBlue);
                //Tomar valores Parametros cantidades
                //cantNros = Convert.ToInt32(tb_cantNros.Text);
                cantIntervs = Convert.ToInt32(tb_cantInterv.Text);


                VisibilidadPanelChiCuadrado(false);
                VisibilidadPanelGrafico(true);

                //Mandar Datos al Gestor.
                //ControladorTP1.GetInstance().opcionNumerosAleatoriosLenguaje(this, cantNros, cantIntervs);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mensaje Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CambiarColorBtnSeleccionado(object sender,Color color)
        {
            ((Button)sender).BackColor = color;
        }
        

        private void btn_met_mixto_Click(object sender, EventArgs e)
        {
            //CambiarColorBtnSeleccionado(btn_Gen_Leng, Color.LightGray);
            CambiarColorBtnSeleccionado(sender, Color.LightBlue);
            VisibilidadPanelChiCuadrado(true);
     
        }
        //Boton de Confirmacion> Mixto.
        private void btn_genMixto_Click(object sender, EventArgs e)
        {
            try
            {


            VisibilidadPanelGrafico(true);

            TomarParametrosIngresados();

            //Mandar Datos al Gestor.
            //ControladorTP1.GetInstance().opcionNumerosAleatoriosMixtos(this, cantNros, cantIntervs                      , a,c,semilla,m);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mensaje Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void TomarParametrosIngresados()
        {
            //Tomar valores Parametros cantidades

           
            cantIntervs = Convert.ToInt32(tb_cantInterv.Text);


        }

        //Llenar labels Distr Seleccionada y Parametros
        public void setLabels(String distrSeleccionada,String parametros, String cantVarAleatorias)
        {
            lbl_distr_seleccionada.Text = distrSeleccionada;
            lbl_parametros.Text = parametros;
            lbl_cant_var_aleatorias.Text = cantVarAleatorias;
            Btn_Probabilidades.Visible = (distrSeleccionada == "Poisson" ? true : false);
        }

        public void MostrarLista(SortedDictionary<int, Random_VarAleatoria> listaVariablesAleatorias)
        {
            dgv_distribucion.Rows.Clear();

            foreach (KeyValuePair<int, Random_VarAleatoria> kvp in listaVariablesAleatorias)
            {
                if (kvp.Value.getTieneRandom2())
                {
                    dgv_distribucion.Rows.Add(kvp.Key, kvp.Value.getRandom().ToString() + " , " + kvp.Value.getRandom2().ToString(), kvp.Value.getVarAleatoria());
                }
                else
                {
                    dgv_distribucion.Rows.Add(kvp.Key, kvp.Value.getRandom(), kvp.Value.getVarAleatoria());
                }
            }
        }


        public void GenerarGraficosYTabla(ArrayList FE
                        , ArrayList mediaInterFO, ArrayList FO,
                         SortedDictionary<double, Subintervalo> Intervalos,
                         SortedDictionary<int, Random_VarAleatoria> lista, double chi_cuadrado_calculado,
                         double chi_tabulado, string mensaje, double significancia_alfa, int cantIntervs)
        {
            this.estructuraFrecObservada = Intervalos;
            this.lista = lista;


            var ca = chart1.ChartAreas.FirstOrDefault();
            ca.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            //Parte del intervalo.
            //Si es un numero mayor a 15 intervalos, que el grafico automatice que mostrar.
            //Si no que lo parta en los intervalos que le corresponden
            ca.AxisX.IsStartedFromZero = true;
            ca.AxisX.LabelAutoFitStyle = System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30;
            //Si es impar que lo haga par.
            double escala_intervalo = mediaInterFO.Count;
            chart1.ChartAreas.FirstOrDefault().AxisX.Interval 
                    = (mediaInterFO.Count <= 15 ? Utiles.RedondearDecimales((1/ (double)escala_intervalo),2) : 0);

            chart1.Series[0].Points.DataBindXY(mediaInterFO, FE);
            chart1.Series[1].Points.DataBindXY(mediaInterFO, FO);


            limpiarDatos();
            foreach (KeyValuePair<double, Subintervalo> kvp in Intervalos)
            {
                dgv_frecuencias.Rows.Add(kvp.Value.getLimite_inferior().ToString("0.0000"), kvp.Value.getLimite_superior().ToString("0.0000"),
                                        Utiles.Redondear4Decimales(kvp.Value.getFrecuenciaEsperada())
                                        , Utiles.Redondear4Decimales(kvp.Value.getFrecuenciaObservada()),
                                        kvp.Value.getIntervalo_chi_cuadrado().ToString("0.0000"));
            }
            /*tb_resultado_final.Text = mensaje;
            tb_significancia_alfa.Text = significancia_alfa.ToString();
            tb_valor_tabulado.Text = chi_tabulado.ToString("0.00");
            tb_xo_cuadrado.Text = chi_cuadrado_calculado.ToString("0.00");
            tb_gdl.Text = (cantIntervs - 1).ToString();*/




        }

        private void limpiarDatos()
        {
            dgv_frecuencias.Rows.Clear();
            tb_significancia_alfa.Clear();
        }


        private void Btn_Prueba_De_Frecuencia_Click(object sender, EventArgs e)
        {
            try
            {
                int cant_intervalos = Convert.ToInt32(tb_cantInterv.Text);
                ControladorTP3.GetInstance().BtnPrueba_de_Frecuencias(cant_intervalos,this);
                pnl_Grafico.Visible = true;
                pnl_x2.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Frm_TP3_PuntoB_UEN_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Probabilidades_Click(object sender, EventArgs e)
        {
            ControladorTP3.GetInstance().Btn_Probabilidades_Poisson();
        }

    }
}
