using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajosPracticosSIM.TP_4.InterfacesDeUsuario
{
    public partial class Frm_TP4_PuntoGHI : Form
    {
        public Frm_TP4_PuntoGHI(DataTable dt)
        {
            InitializeComponent();
            LlenarDataGridView(dt);
        }

        private void LlenarDataGridView(DataTable dt)
        {
            BindingSource SBind = new BindingSource();
            SBind.DataSource = dt;
            dgv_tabla.Columns.Clear();
            dgv_tabla.DataSource = SBind;

            dgv_tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dt.Columns.Count == 4)
            {
                dgv_tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }

            
            dgv_tabla.AllowUserToAddRows = false;

            for (int i = 0; i < dgv_tabla.ColumnCount; i++)
            {
                if (i % 2 == 0)
                {
                    dgv_tabla.Columns[i].DefaultCellStyle.BackColor = Color.LightGray;
                }
                else
                {
                    dgv_tabla.Columns[i].HeaderCell.Style.BackColor = Color.LightSkyBlue;
                }
            }
            dgv_tabla.EnableHeadersVisualStyles = false;
        }

        private void dgv_tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
