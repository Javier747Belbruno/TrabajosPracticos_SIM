using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajosPracticosSIM.TP_5.InterfacesDeUsuario
{
    public partial class Frm_TP5_PantallaSimulacion : Form
    {
        public Frm_TP5_PantallaSimulacion()
        {
            InitializeComponent();
        }

        private void btn_simular_Click(object sender, EventArgs e)
        {
            //try
            //{
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
                ControladorTP5.GetInstance().OpcionIniciarSimulacion(this, cant_sim, desde, hasta);
            //}
            //catch (Exception ex)
            //{

                //MessageBox.Show("Error: " + ex.Message, "Error - Formato de los datos ingresados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
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
                if (i >= 1 && i <= 3 || i >= 7 && i <= 11 || i >= 17 && i <= 21 || i >= 27 && i <= 31 || i >= 37 && i <= 42)
                    dgvSimulacion.Columns[i].DefaultCellStyle.BackColor = Color.LightYellow;
                else
                    dgvSimulacion.Columns[i].HeaderCell.Style.BackColor = Color.LightSkyBlue;

                dgvSimulacion.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            }
            dgvSimulacion.EnableHeadersVisualStyles = false;
            dgvSimulacion.AllowUserToAddRows = false;

        }
    }
}
