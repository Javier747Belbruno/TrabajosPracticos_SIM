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
        }

        private void btn_simular_Click(object sender, EventArgs e)
        {
            ControladorTP4.GetInstance().OpcionIniciarSimulacion(this);
        }

        public void LlenarGridView(DataTable dt)
        {
            BindingSource SBind = new BindingSource();
            SBind.DataSource = dt;
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = SBind;

        }

        private void btn_config_Click(object sender, EventArgs e)
        {

        }
    }
}
