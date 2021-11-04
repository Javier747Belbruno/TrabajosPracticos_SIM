using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajosPracticosSIM.TP_6.InterfacesDeUsuario
{
    public partial class Frm_TP6_PantallaPuntoAE : Form
    {
        public Frm_TP6_PantallaPuntoAE()
        {
            InitializeComponent();
            IniciarPantalla();
        }
        public void IniciarPantalla()
        {
            pnl_euler.Visible = false;
            pnl_rk.Visible = false;
            pnl_graficos.Visible = false;
        }

        private void btn_euler_Click(object sender, EventArgs e)
        {
            try
            {
                pnl_euler.Visible = true;
                pnl_graficos.Visible = true;
                ControladorTP6.GetInstance().CalcularEuler(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void LlenarDatosEuler(DataTable dt)
        {
            //En la tabla en las ultimas dos filas vienen los valores de los picos, y parametros
            //Extraerlos y eliminar esas filas.
            string picot;
            string picox1;
            string valor_a,valor_b,valor_c,valor_h,valor_x0,valor_Dx0;
            
            picot = dt.Rows[dt.Rows.Count - 1][0].ToString();
            picox1 = dt.Rows[dt.Rows.Count - 1][1].ToString();
            valor_a = dt.Rows[dt.Rows.Count - 1][2].ToString();
            valor_b = dt.Rows[dt.Rows.Count - 1][3].ToString();

            dt.Rows[dt.Rows.Count - 1].Delete();

            valor_c = dt.Rows[dt.Rows.Count - 1][0].ToString();
            valor_h = dt.Rows[dt.Rows.Count - 1][1].ToString();
            valor_x0 = dt.Rows[dt.Rows.Count - 1][2].ToString();
            valor_Dx0 = dt.Rows[dt.Rows.Count - 1][3].ToString();

            dt.Rows[dt.Rows.Count - 1].Delete();
            //Llenar Tabla
            BindingSource SBind = new BindingSource();
            SBind.DataSource = dt;
            dgvEuler.Columns.Clear();
            dgvEuler.DataSource = SBind;

            dgvEuler.EnableHeadersVisualStyles = false;
            dgvEuler.AllowUserToAddRows = false;
            //Llenar Campos
            lb_a_e.Text = "Valor a: " + valor_a;
            lb_b_e.Text = "Valor b: " + valor_b;
            lb_c_e.Text = "Valor c: " + valor_c;
            lb_h_e.Text = "Valor h: " + valor_h;
            lb_x0_e.Text = "Valor x0: " + valor_x0;
            lb_Dx0_e.Text = "Valor Dx0: " + valor_Dx0;
            tb_2pico_e_t.Text = picot;
            tb_2pico_e_x1.Text = picox1;
        }

        public void LlenarDatosRK(DataTable dt)
        {
            //En la tabla en la ultima fila vienen los valores de los picos,
            //Extraerlos y eliminar esa fila.
            string picot;
            string picox1;
            string valor_a, valor_b, valor_c, valor_h, valor_x0, valor_Dx0;
            picot = dt.Rows[dt.Rows.Count - 1][0].ToString();
            picox1 = dt.Rows[dt.Rows.Count - 1][1].ToString();
            
            valor_a = dt.Rows[dt.Rows.Count - 1][2].ToString();
            valor_b = dt.Rows[dt.Rows.Count - 1][3].ToString();
            valor_c = dt.Rows[dt.Rows.Count - 1][4].ToString();
            valor_h = dt.Rows[dt.Rows.Count - 1][5].ToString();
            valor_x0 = dt.Rows[dt.Rows.Count - 1][6].ToString();
            valor_Dx0 = dt.Rows[dt.Rows.Count - 1][7].ToString();

            dt.Rows[dt.Rows.Count - 1].Delete();
            //Llenar Tabla
            BindingSource SBind = new BindingSource();
            SBind.DataSource = dt;
            dgvRK.Columns.Clear();
            dgvRK.DataSource = SBind;

            dgvRK.EnableHeadersVisualStyles = false;
            dgvRK.AllowUserToAddRows = false;
            //Llenar Campos
            lb_a_rk.Text = "Valor a: " + valor_a;
            lb_b_rk.Text = "Valor b: " + valor_b;
            lb_c_rk.Text = "Valor c: " + valor_c;
            lb_h_rk.Text = "Valor h: " + valor_h;
            lb_x0_rk.Text = "Valor x0: " + valor_x0;
            lb_Dx0_rk.Text = "Valor Dx0: " + valor_Dx0;
            
            tb_2pico_rk_t.Text = picot;
            tb_2pico_rk_x1.Text = picox1;
        }

        private void btn_rk_Click(object sender, EventArgs e)
        {
            try
            {
                pnl_rk.Visible = true;
                pnl_graficos.Visible = true;
                ControladorTP6.GetInstance().CalcularRK(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_punto_b_x_t_Click(object sender, EventArgs e)
        {
            try
            {
                ControladorTP6.GetInstance().OpcionGraficoPuntoBXdeT();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_punto_b_dx_t_Click(object sender, EventArgs e)
        {
            try
            {
                ControladorTP6.GetInstance().OpcionGraficoPuntoBDXdeT();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_punto_b_ddx_t_Click(object sender, EventArgs e)
        {
            try
            {
                ControladorTP6.GetInstance().OpcionGraficoPuntoBDDXdeT();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_punto_c_Click(object sender, EventArgs e)
        {
            try
            {
                ControladorTP6.GetInstance().OpcionGraficoPuntoC();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_punto_d_Click(object sender, EventArgs e)
        {
            try
            {
                ControladorTP6.GetInstance().OpcionGraficoPuntoD();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_punto_e_Click(object sender, EventArgs e)
        {
            try
            {
                ControladorTP6.GetInstance().OpcionGraficoPuntoE();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_config_Click(object sender, EventArgs e)
        {
            ControladorTP6.GetInstance().OpcionConfigED();
        }

        private void btn_DDx_Dx_x_f_t_Click(object sender, EventArgs e)
        {
            try
            {
                ControladorTP6.GetInstance().OpcionGraficoPuntoBEuler();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_DDx_Dx_x_f_t_rk_Click(object sender, EventArgs e)
        {
            try
            {
                ControladorTP6.GetInstance().OpcionGraficoPuntoBRK();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pnl_euler_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
