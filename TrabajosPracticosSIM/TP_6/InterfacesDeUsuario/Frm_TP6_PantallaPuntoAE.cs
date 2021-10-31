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
            pnl_euler.Visible = true;
            pnl_graficos.Visible = true;
      
            ControladorTP6.GetInstance().CalcularEuler(this);
        }

        public void LlenarDatosEuler(DataTable dt)
        {
            //En la tabla en la ultima fila vienen los valores de los picos,
            //Extraerlos y eliminar esa fila.
            string picot;
            string picox1;
            string valor_a;
            picot = dt.Rows[dt.Rows.Count - 1][0].ToString();
            picox1 = dt.Rows[dt.Rows.Count - 1][1].ToString();
            valor_a = dt.Rows[dt.Rows.Count - 1][2].ToString();

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
            tb_2pico_e_t.Text = picot;
            tb_2pico_e_x1.Text = picox1;
        }

        public void LlenarDatosRK(DataTable dt)
        {
            //En la tabla en la ultima fila vienen los valores de los picos,
            //Extraerlos y eliminar esa fila.
            string picot;
            string picox1;
            string valor_a;
            picot = dt.Rows[dt.Rows.Count - 1][0].ToString();
            picox1 = dt.Rows[dt.Rows.Count - 1][1].ToString();
            valor_a = dt.Rows[dt.Rows.Count - 1][2].ToString();

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
            tb_2pico_rk_t.Text = picot;
            tb_2pico_rk_x1.Text = picox1;
        }

        private void btn_rk_Click(object sender, EventArgs e)
        {
            pnl_rk.Visible = true;
            pnl_graficos.Visible = true;

            ControladorTP6.GetInstance().CalcularRK(this);
        }

        private void btn_punto_b_x_t_Click(object sender, EventArgs e)
        {
            ControladorTP6.GetInstance().OpcionGraficoPuntoBXdeT();
        }

        private void btn_punto_b_dx_t_Click(object sender, EventArgs e)
        {
            ControladorTP6.GetInstance().OpcionGraficoPuntoBDXdeT();
        }

        private void btn_punto_b_ddx_t_Click(object sender, EventArgs e)
        {
            ControladorTP6.GetInstance().OpcionGraficoPuntoBDDXdeT();
        }

        private void btn_punto_c_Click(object sender, EventArgs e)
        {
            ControladorTP6.GetInstance().OpcionGraficoPuntoC();
        }

        private void btn_punto_d_Click(object sender, EventArgs e)
        {
            ControladorTP6.GetInstance().OpcionGraficoPuntoD();
        }

        private void btn_punto_e_Click(object sender, EventArgs e)
        {
            ControladorTP6.GetInstance().OpcionGraficoPuntoE();
        }

        private void btn_config_Click(object sender, EventArgs e)
        {
            ControladorTP6.GetInstance().OpcionConfigED();
        }
    }
}
