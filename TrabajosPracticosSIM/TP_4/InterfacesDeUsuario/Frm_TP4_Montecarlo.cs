using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajosPracticosSIM.TP_4.Entidades
{
    public partial class Frm_TP4_Montecarlo : Form
    {
        public Frm_TP4_Montecarlo()
        {
            InitializeComponent();
            CargarTextBoxes();
            CargarPanelActividades();
        }
        private void CargarTextBoxes()
        {
            tb_cant_sim.Text = "20";
            tb_desde.Text = "";
            tb_hasta.Text = "";
        }

        private void CargarPanelActividades()
        {
            ControladorTP4.GetInstance().OpcionCargarPanelActividades(this);
        }
        private void btn_simular_Click(object sender, EventArgs e)
        {
            try
            {
                int cant_sim = Convert.ToInt32(tb_cant_sim.Text);
                if(cant_sim <= 0)
                {
                    throw (new Exception("La cantidad de simulaciones debe ser mayor que 0") );
                }
                if (tb_desde.Text.Length == 0)
                {
                    tb_desde.Text = "0";
                }
                int desde = Convert.ToInt32(tb_desde.Text);
                if (desde < 0)
                {
                    throw (new Exception("El parametro desde no puede ser negativo"));
                }
                if (tb_hasta.Text.Length == 0)
                {
                    tb_hasta.Text = "0";
                }
                int hasta = Convert.ToInt32(tb_hasta.Text);
                if (hasta > cant_sim)
                {
                    throw (new Exception("El parametro hasta no puede superar la cant de sim"));
                }
                ControladorTP4.GetInstance().OpcionIniciarSimulacion(this,cant_sim,desde,hasta);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Error - Formato de los datos ingresados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public void LlenarPantallaMontecarlo(DataTable dt, double promEnsamble)
        {
            BindingSource SBind = new BindingSource();
            SBind.DataSource = dt;
            dgvSimulacion.Columns.Clear();
            dgvSimulacion.DataSource = SBind;

            tb_prom_ensamble.Text = promEnsamble.ToString("0.00");
        }

        private void btn_config_Click(object sender, EventArgs e)
        {
            ControladorTP4.GetInstance().OpcionPantallaConfiguracion();
        }

        public void LlenarGridViewActividades(DataTable dtActividadesPantalla)
        {
            BindingSource SBind = new BindingSource();
            SBind.DataSource = dtActividadesPantalla;
            dgvActividades.Columns.Clear();
            dgvActividades.DataSource = SBind;

            dgvActividades.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvActividades.Columns["DISTR"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvActividades.Columns["PARAMS"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dgvActividades.AllowUserToAddRows = false;

        }

        private void btn_Grafico_Click(object sender, EventArgs e)
        {
            ControladorTP4.GetInstance().OpcionPantallaPuntoD();
        }
    }
}
