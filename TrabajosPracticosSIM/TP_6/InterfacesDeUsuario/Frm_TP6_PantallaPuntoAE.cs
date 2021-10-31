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
            ControladorTP6.GetInstance().CalcularEuler(this);
        }
    }
}
