using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TrabajosPracticosSIM.TP_1;
using TrabajosPracticosSIM.TP_1.Entidades;
using TrabajosPracticosSIM.TP_3.Entidades;
using System.Windows.Forms.DataVisualization.Charting;

namespace TrabajosPracticosSIM.TP_3.InterfacesDeUsuario
{
    public partial class Frm_TP3_PuntoB : Form
    {
        private int cantNros;
        private int cantIntervs;
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



            var CA = chart1.ChartAreas.FirstOrDefault();
            


            CA.AxisX.MajorTickMark.Enabled = false;
            CA.AxisY.MajorTickMark.Enabled = false;
            CA.AxisX.MinorTickMark.Enabled = false;
            CA.AxisY.MinorTickMark.Enabled = false;

            CA.AxisX.CustomLabels.Clear();
            CA.AxisX.IsLabelAutoFit = false;

            if (mediaInterFO.Count < 50)
            {
                foreach (double MarcadeClase in mediaInterFO)
                {
                    var label = new CustomLabel(MarcadeClase - 100, MarcadeClase + 100, MarcadeClase.ToString(), 0, LabelMarkStyle.LineSideMark);
                    CA.AxisX.CustomLabels.Add(label);
                }
            }
          

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

        private void Btn_Chi_Cuadrado_Click(object sender, EventArgs e)
        {
            try
            {
                double significancia_alfa = Convert.ToDouble(tb_significancia_alfa.Text);
                ControladorTP3.GetInstance().Btn_Chi_Cuadrado(significancia_alfa, this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
