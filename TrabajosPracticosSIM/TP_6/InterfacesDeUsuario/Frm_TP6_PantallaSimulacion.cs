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
            OcultarPanelActividades();
        }
        private void CargarTextBoxes()
        {
            cmb_tipo_modelo.Items.Add("Modelo sin Ec.Diferencial (TP5)");
            cmb_tipo_modelo.Items.Add("Modelo con Ec.Diferencial (TP6)");
            cmb_tipo_modelo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_tipo_modelo.SelectedIndex = 0; // 0 : TP5 , 1 : TP6
            tb_cant_sim.Text = "50";
            tb_desde.Text = "";
            tb_hasta.Text = "";
            tb_param_p11.Text = "3";
        }

        private void OcultarPanelActividades()
        {
            pnl_Actividades.Visible = false;
            pnl_Config.Visible = false;
        }

        private void btn_simular_Click(object sender, EventArgs e)
        {
            try
            {
            int tipo_modelo = cmb_tipo_modelo.SelectedIndex; // 0 : TP5 , 1 : TP6
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
                ControladorTP6.GetInstance().OpcionIniciarSimulacion(this, tipo_modelo, cant_sim, desde, hasta, param_punto_11);

                pnl_Actividades.Visible = true;
                pnl_Config.Visible = true;
                ControladorTP6.GetInstance().OpcionCargarPanelActividades(this);
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

        public void LlenarPantallaSimulacion(DataTable dt, int tipo_modelo)
        {
            BindingSource SBind = new BindingSource();
            SBind.DataSource = dt;
            dgvSimulacion.Columns.Clear();
            dgvSimulacion.DataSource = SBind;

            dgvSimulacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            if (tipo_modelo == 0) //Colorear para Columnas TP5
            { 
                for (int i = 0; i < dgvSimulacion.ColumnCount; i++)
                {
                    if (i >= 1 && i <= 3 || i >= 7 && i <= 11 || i >= 17 && i <= 21 || i >= 27 && i <= 32 ||  i == 35 || i >= 37 && i <= 42
                        || i == 44 || i >= 47 && i <= 52 || i >= 59 && i <= 64 || i >= 67 && i <= 71 || i >= 74 && i <= 75 || i >= 79 && i <= 80)
                        dgvSimulacion.Columns[i].DefaultCellStyle.BackColor = Color.LightYellow;
                    else
                        dgvSimulacion.Columns[i].HeaderCell.Style.BackColor = Color.LightSkyBlue;

                    dgvSimulacion.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                }
            }
            if (tipo_modelo == 1) //Colorear para Columnas TP6
            {
                for (int i = 0; i < dgvSimulacion.ColumnCount; i++)
                {
                    if (i >= 1 && i <= 3 || i >= 7 && i <= 11 || i >= 17 && i <= 21 || i >= 27 && i <= 32 || i == 39
                       || i >= 41 && i <= 47 || i == 49 || i >= 52 && i <= 57 || i >= 64 && i <= 69 || i >= 72 && i <= 77 || i >= 80 && i <= 81
                       || i >= 85 && i <= 86)
                        dgvSimulacion.Columns[i].DefaultCellStyle.BackColor = Color.LightYellow;
                    else
                        dgvSimulacion.Columns[i].HeaderCell.Style.BackColor = Color.LightSkyBlue;

                    dgvSimulacion.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }

            dgvSimulacion.EnableHeadersVisualStyles = false;
            dgvSimulacion.AllowUserToAddRows = false;

        }

        private void btn_config_Click(object sender, EventArgs e)
        {
            ControladorTP6.GetInstance().OpcionPantallaConfiguracion();
        }
    }
}
