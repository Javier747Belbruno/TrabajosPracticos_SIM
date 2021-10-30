using System;
using System.Windows.Forms;

namespace TrabajosPracticosSIM.TP_6.InterfacesDeUsuario
{
    public partial class Frm_TP6_Principal : Form
    {
        public Frm_TP6_Principal()
        {
            InitializeComponent();
        }

        //Inicio Caso de Uso Punto A 
        private void btn_punto_a_e_Click(object sender, EventArgs e)
        {
            ControladorTP6.GetInstance().OpcionPuntoAE();
        }

        private void btn_Enunciado_Click(object sender, EventArgs e)
        {
            ControladorTP6.GetInstance().OpcionPantallaEnunciado();
        }

        private void btn_punto_f_Click(object sender, EventArgs e)
        {
            ControladorTP6.GetInstance().OpcionPuntoF();
        }
    }
}
