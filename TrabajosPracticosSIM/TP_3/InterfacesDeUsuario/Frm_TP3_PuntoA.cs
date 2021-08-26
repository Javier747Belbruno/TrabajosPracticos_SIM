using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajosPracticosSIM.TP_3.Entidades;

namespace TrabajosPracticosSIM.TP_3.InterfacesDeUsuario
{
    public partial class Frm_TP3_PuntoA : Form
    {
        private String distribucionSeleccionada = "";

        public Frm_TP3_PuntoA()
        {
            InitializeComponent();
            pnl_parametros.Visible = false;
            pnl_tabla.Visible = false;
        }

        private void Btn_uniforme_Click(object sender, EventArgs e)
        {
            CambiarColorBotones(sender);
            VisibilizarPanelParametros();
            HabilitarParametros(sender);
        }

        private void Btn_exponencial_Click(object sender, EventArgs e)
        {
            CambiarColorBotones(sender);
            VisibilizarPanelParametros();
            HabilitarParametros(sender);
        }

        private void Btn_poisson_Click(object sender, EventArgs e)
        {
            CambiarColorBotones(sender);
            VisibilizarPanelParametros();
            HabilitarParametros(sender);
        }

        private void Btn_normal_Click(object sender, EventArgs e)
        {
            CambiarColorBotones(sender);
            VisibilizarPanelParametros();
            HabilitarParametros(sender);
        }

        private void HabilitarParametros(object sender)
        {
            distribucionSeleccionada = ((Button)sender).Text;
            switch (distribucionSeleccionada)
            {
                case "Uniforme":
                    tb_a.Enabled = true;
                    tb_b.Enabled = true;
                    break;
                case "Exponencial":
                    tb_lambda.Enabled = true;
                    break;
                case "Poisson":
                    tb_lambda.Enabled = true;
                    break;
                case "Normal":
                    tb_media.Enabled = true;
                    tb_desviacion_estandar.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void VisibilizarPanelParametros()
        {
            pnl_parametros.Visible = true;
            LimpiarParametros();
            InhabilitarParametros();
        }

        private void InhabilitarParametros()
        {
            tb_a.Enabled = false;
            tb_b.Enabled = false;
            tb_lambda.Enabled = false;
            tb_media.Enabled = false;
            tb_desviacion_estandar.Enabled = false;
        }
        private void LimpiarParametros()
        {
            tb_a.Clear();
            tb_b.Clear();
            tb_lambda.Clear();
            tb_media.Clear();
            tb_desviacion_estandar.Clear();
            tb_cantidad.Clear();
        }

        private void CambiarColorBotones(object sender)
        {
            LimpiarColorBotones();
            ((Button)sender).BackColor = Color.LightBlue;
        }

        private void LimpiarColorBotones()
        {
            Btn_uniforme.BackColor = Color.LightGray;
            Btn_exponencial.BackColor = Color.LightGray;
            Btn_poisson.BackColor = Color.LightGray;
            Btn_normal.BackColor = Color.LightGray;
        }

        private void Btn_Continuar_Click(object sender, EventArgs e)
        {
            ControladorTP3.GetInstance().OpcionPantallaPuntoB();
        }

        private void Btn_Generar_Click(object sender, EventArgs e)
        {
            
            //TRAI-CATCHA Para los inputs
            try
            {
                int cantidad = Convert.ToInt32(tb_cantidad.Text);
            
                switch (distribucionSeleccionada)
                {
                    case "Uniforme":
                        double a = Convert.ToDouble(tb_a.Text);
                        double b = Convert.ToDouble(tb_b.Text);
                        ControladorTP3.GetInstance().OpcionGenerarUniforme(cantidad,a,b,this);
                        break;
                    case "Exponencial":
                        double lambda = Convert.ToDouble(tb_lambda.Text);
                        ControladorTP3.GetInstance().OpcionGenerarExponencial(cantidad, lambda, this);
                        break;
                    case "Poisson":
                        double lambdaPoisson = Convert.ToDouble(tb_lambda.Text);
                        ControladorTP3.GetInstance().OpcionGenerarPoisson(cantidad, lambdaPoisson, this);
                        break;
                    case "Normal":
                        double media = Convert.ToDouble(tb_media.Text);
                        double ds = Convert.ToDouble(tb_desviacion_estandar.Text);
                        ControladorTP3.GetInstance().OpcionGenerarNormal(cantidad, media, ds, this);
                        break;
                    default:
                        break;
                }
                pnl_tabla.Visible = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Error - Formato de los datos ingresados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void MostrarLista(SortedDictionary<int,Random_VarAleatoria> listaVariablesAleatorias)
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
    }
}
