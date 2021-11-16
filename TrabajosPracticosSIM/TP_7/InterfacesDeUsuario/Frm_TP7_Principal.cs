using System;
using System.Windows.Forms;

namespace TrabajosPracticosSIM.TP_7.InterfacesDeUsuario
{
    public partial class Frm_TP7_Principal : Form
    {
        public Frm_TP7_Principal()
        {
            InitializeComponent();
        }

        private void btn_Simulacion_Click(object sender, EventArgs e)
        {
            ControladorTP7.GetInstance().OpcionPantallaSimulacion();
        }

        private void btn_Enunciado_Click(object sender, EventArgs e)
        {
            ControladorTP7.GetInstance().OpcionPantallaEnunciado();
        }
    }
}
