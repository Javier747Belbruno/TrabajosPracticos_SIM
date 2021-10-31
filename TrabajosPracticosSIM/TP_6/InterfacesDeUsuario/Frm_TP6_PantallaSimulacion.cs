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
    public partial class Frm_TP6_PantallaSimulacion : Form
    {
        public Frm_TP6_PantallaSimulacion()
        {
            InitializeComponent();
            CargarTextBoxes();
            CargarPanelActividades();
        }
        private void CargarTextBoxes()
        {
            tb_cant_sim.Text = "50";
            tb_desde.Text = "";
            tb_hasta.Text = "";
            tb_param_p11.Text = "3";
        }

        private void CargarPanelActividades()
        {
            //ControladorTP5.GetInstance().OpcionCargarPanelActividades(this);
        }

        private void btn_simular_Click(object sender, EventArgs e)
        {
            try
            {
                int cant_sim = Convert.ToInt32(tb_cant_sim.Text);
                if (cant_sim <= 0)
                {
                    throw (new Exception("La cantidad de simulaciones debe ser mayor que 0"));
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
                if (tb_param_p11.Text.Length == 0)
                {
                    tb_param_p11.Text = "3";
                }
                int param_punto_11 = Convert.ToInt32(tb_param_p11.Text);
                if (param_punto_11 < 0)
                {
                    throw (new Exception("El parametro punto 11 no puede ser negativo"));
                }
                ControladorTP6.GetInstance().OpcionIniciarSimulacion(this, cant_sim, desde, hasta, param_punto_11);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error - Formato de los datos ingresados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void LlenarGridViewActividades(DataTable dtActividadesPantalla)
        {
            BindingSource SBind = new BindingSource();
            SBind.DataSource = dtActividadesPantalla;
            dgvActividades.Columns.Clear();
            dgvActividades.DataSource = SBind;

            dgvActividades.Columns["SERV"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvActividades.Columns["DISTR"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvActividades.Columns["PARAMS"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dgvActividades.AllowUserToAddRows = false;
        }

        public void LlenarPantallaSimulacion(DataTable dt)
        {
            BindingSource SBind = new BindingSource();
            SBind.DataSource = dt;
            dgvSimulacion.Columns.Clear();
            dgvSimulacion.DataSource = SBind;

            dgvSimulacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            for (int i = 0; i < dgvSimulacion.ColumnCount; i++)
            {
                if (i >= 1 && i <= 3 || i >= 7 && i <= 11 || i >= 17 && i <= 21 || i >= 27 && i <= 32 ||  i == 35 || i >= 37 && i <= 42
                    || i >= 37 && i <= 42 || i == 46 || i >= 48 && i <= 49 || i >= 56 && i <= 67 || i >= 74 && i <= 75 || i >= 86 && i <= 89
                    || i >= 94 && i <= 95)
                    dgvSimulacion.Columns[i].DefaultCellStyle.BackColor = Color.LightYellow;
                else
                    dgvSimulacion.Columns[i].HeaderCell.Style.BackColor = Color.LightSkyBlue;

                dgvSimulacion.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            }
            dgvSimulacion.EnableHeadersVisualStyles = false;
            dgvSimulacion.AllowUserToAddRows = false;

        }

        private void btn_config_Click(object sender, EventArgs e)
        {
            //ControladorTP5.GetInstance().OpcionPantallaConfiguracion();
        }
    }
}
