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
            CambiarColorBtnSeleccionado(btn_met_mixto, Color.LightGray);
            CambiarColorBtnSeleccionado(sender, Color.LightBlue);
            //Tomar valores Parametros cantidades
            TomarParametrosIngresados();

            VisibilidadPanelParametrosMixto(false);
            VisibilidadPanelGrafico(true);

            //Mandar Datos al Gestor.
            ControladorTP1.GetInstance().opcionNumerosAleatoriosLenguaje(this, cantNros, cantIntervs);
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
            VisibilidadPanelGrafico(true);
            TomarParametrosIngresados();
            //Mandar Datos al Gestor.
            ControladorTP1.GetInstance().opcionNumerosAleatoriosMixtos(this, cantNros, cantIntervs
                                            , a,c,semilla,m);
        }

        public void TomarParametrosIngresados()
        {
            //Tomar valores Parametros cantidades
            cantNros = Convert.ToInt32(tb_cantNros.Text);
            cantIntervs = Convert.ToInt32(tb_cantInterv.Text);
            a = ( tb_a.Text.Length!=0 ? Convert.ToInt32(tb_a.Text) : 0  );
            c = (tb_c.Text.Length != 0 ? Convert.ToInt32(tb_c.Text) : 0);
            semilla = (tb_semilla.Text.Length != 0 ? Convert.ToInt32(tb_semilla.Text) : 0); 
            m = (tb_m.Text.Length != 0 ? Convert.ToInt32(tb_m.Text) : 0); 
        }


        public void GenerarGrafico(ArrayList mediaInterFE, ArrayList FE
                        ,ArrayList mediaInterFO , ArrayList FO, 
                         SortedDictionary<double, Subintervalo> estructuraFrecObservada)
        {
            this.estructuraFrecObservada = estructuraFrecObservada;

            chart1.Series[0].Points.DataBindXY(mediaInterFO,FO);
            chart1.Series[1].Points.DataBindXY(mediaInterFE,FE);
        }

        private void btn_exportar_Click(object sender, EventArgs e)
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
                nueva["Media_Int"] = kvp.Value.getMedia_intervalo();
                nueva["Frec_Obs"] = kvp.Value.getFrecuencia();
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
            //METER TRY CATCH AHORA .
            File.WriteAllText(selectedPath, sb.ToString());

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


    }
}
