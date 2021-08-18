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
using TrabajosPracticosSIM.TP_1.Entidades;

namespace TrabajosPracticosSIM.TP_1.InterfacesDeUsuario
{
    public partial class Frm_PantallaPruebaDeFrecuencia : Form
    {
        private int cantNros;
        private int cantIntervs;
        private int a;
        private int c;
        private int semilla;
        private int m;
        private SortedDictionary<double, Subintervalo> estructuraFrecObservada;
        private SortedDictionary<int, double> lista;

        public Frm_PantallaPruebaDeFrecuencia()
        {
            InitializeComponent();
            Iniciar();
        }

        private void Iniciar()
        {
            VisibilidadPanelParametrosMixto(false);
            VisibilidadPanelGrafico(false);
            chart1.Titles.Add("Histograma de Frecuencias");
            chart1.ChartAreas[0].AxisX.Title = "Media Intervalos";
            chart1.ChartAreas[0].AxisY.Title = "Frecuencia";
            chart1.Series[0].LegendText = "FO";
            chart1.Series[1].LegendText = "FE";

            tb_gdl.Enabled = false;
            tb_resultado_final.Enabled = false;
            tb_significancia_alfa.Enabled = false;
            tb_xo_cuadrado.Enabled = false;
            tb_valor_tabulado.Enabled = false;
        }

        private void VisibilidadPanelParametrosMixto(bool valor)
        {
            pnl_Cong_mixto.Visible = valor;
        }
        private void VisibilidadPanelGrafico(bool valor)
        {
            pnl_Grafico.Visible = valor;
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void limpiarPantalla()
        {
            btn_Gen_Leng.BackColor = Color.LightGray;
            btn_genMixto.BackColor = Color.LightGray;
            //habitarC();
            tb_semilla.Clear();
            tb_a.Clear();
            tb_c.Clear();
        }
        private void btn_Gen_Leng_Click(object sender, EventArgs e)
        {
            try
            {
                CambiarColorBtnSeleccionado(btn_met_mixto, Color.LightGray);
                CambiarColorBtnSeleccionado(sender, Color.LightBlue);
                //Tomar valores Parametros cantidades
                cantNros = Convert.ToInt32(tb_cantNros.Text);
                cantIntervs = Convert.ToInt32(tb_cantInterv.Text);


                VisibilidadPanelParametrosMixto(false);
                VisibilidadPanelGrafico(true);

                //Mandar Datos al Gestor.
                ControladorTP1.GetInstance().opcionNumerosAleatoriosLenguaje(this, cantNros, cantIntervs);
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
            CambiarColorBtnSeleccionado(btn_Gen_Leng, Color.LightGray);
            CambiarColorBtnSeleccionado(sender, Color.LightBlue);
            VisibilidadPanelParametrosMixto(true);
     
        }
        //Boton de Confirmacion> Mixto.
        private void btn_genMixto_Click(object sender, EventArgs e)
        {
            try
            {


            VisibilidadPanelGrafico(true);

            TomarParametrosIngresados();

            //Mandar Datos al Gestor.
            ControladorTP1.GetInstance().opcionNumerosAleatoriosMixtos(this, cantNros, cantIntervs
                                        , a,c,semilla,m);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mensaje Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void TomarParametrosIngresados()
        {
            //Tomar valores Parametros cantidades

            cantNros = Convert.ToInt32(tb_cantNros.Text);
            cantIntervs = Convert.ToInt32(tb_cantInterv.Text);
            a = Convert.ToInt32(tb_a.Text);
            c = Convert.ToInt32(tb_c.Text);
            semilla = Convert.ToInt32(tb_semilla.Text);
            m = Convert.ToInt32(tb_m.Text);

        }


        public void GenerarGraficosYTabla( ArrayList FE
                        ,ArrayList mediaInterFO , ArrayList FO, 
                         SortedDictionary<double, Subintervalo> Intervalos,
                         SortedDictionary<int, double>  lista, double chi_cuadrado_calculado,
                         double chi_tabulado, string mensaje, double significancia_alfa, int cantIntervs)
        {
            this.estructuraFrecObservada = Intervalos;
            this.lista = lista;

            chart1.Series[0].Points.DataBindXY(mediaInterFO,FO);
            chart1.Series[1].Points.DataBindXY(mediaInterFO,FE);
            //chart1.ChartAreas[0].AxisX.Interval = 0.06;
            chart1.ChartAreas[0].AxisX.Maximum = 1;
            chart1.ChartAreas[0].AxisX.Minimum = 0;

            limpiarDatos();
            foreach (KeyValuePair<double, Subintervalo> kvp in Intervalos)
            {
                dgv_frecuencias.Rows.Add(kvp.Value.getLimite_inferior().ToString("0.0000"), kvp.Value.getLimite_superior().ToString("0.0000"),
                                        kvp.Value.getFrecuenciaEsperada(), kvp.Value.getFrecuenciaObservada(),
                                        kvp.Value.getIntervalo_chi_cuadrado().ToString("0.0000"));
            }
            tb_resultado_final.Text = mensaje;
            tb_significancia_alfa.Text = significancia_alfa.ToString();
            tb_valor_tabulado.Text = chi_tabulado.ToString("0.00");
            tb_xo_cuadrado.Text = chi_cuadrado_calculado.ToString("0.00");
            tb_gdl.Text = (cantIntervs - 1).ToString();




        }

        private void limpiarDatos()
        {
            dgv_frecuencias.Rows.Clear();
            tb_resultado_final.Clear();
            tb_significancia_alfa.Clear();
            tb_valor_tabulado.Clear();
            tb_xo_cuadrado.Clear();
            tb_gdl.Clear();
        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
            dt.Columns.Add("Int_Inf");
            dt.Columns.Add("Int_Sup");
            dt.Columns.Add("Media_Int");
            dt.Columns.Add("Frec_Obs");

            foreach (KeyValuePair<double, Subintervalo> kvp in estructuraFrecObservada)
            {
                DataRow nueva = dt.NewRow();
                nueva["Int_Inf"] = kvp.Value.getLimite_inferior();
                nueva["Int_Sup"] = kvp.Value.getLimite_superior();
                ///nueva["Media_Int"] = kvp.Value.getMedia_intervalo();
                //nueva["Frec_Obs"] = kvp.Value.getFrecuencia();
                dt.Rows.Add(nueva);
            }

            for (int i = 0; i < 4; i++)
            {
                DataRow nueva = dt.NewRow();
                nueva["Int_Inf"] = "";
                nueva["Int_Sup"] = "";
                dt.Rows.Add(nueva);
            }
            DataRow nueva1 = dt.NewRow();
            nueva1["Int_Inf"] = "Posicion";
            nueva1["Int_Sup"] = "NroRandom";
            dt.Rows.Add(nueva1);

            foreach (KeyValuePair<int, double> kvp in lista)
            {
                DataRow nueva = dt.NewRow();
                nueva["Int_Inf"] = kvp.Key;
                nueva["Int_Sup"] = kvp.Value;
                dt.Rows.Add(nueva);
            }


            StringBuilder sb = new StringBuilder();

            IEnumerable<string> columnNames = dt.Columns.Cast<DataColumn>().
                                              Select(column => column.ColumnName);
            sb.AppendLine(string.Join(",", columnNames));

            foreach (DataRow row in dt.Rows)
            {
                IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
                sb.AppendLine(string.Join(",", fields));
            }
            
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "csv files (*.csv)|*.csv";
            DialogResult result = dialog.ShowDialog();


            string selectedPath = "";
            if (result == DialogResult.OK)
            {
                selectedPath = dialog.FileName;
            }
     
            File.WriteAllText(selectedPath, sb.ToString());
            
            MessageBox.Show("El archivo se exportó con éxito", "Exportar archivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
            MessageBox.Show("Error: "+ ex.Message, "Error Archivo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
