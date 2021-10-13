using System;
using System.Windows.Forms;
using TrabajosPracticosSIM.TP_5;

namespace TrabajosPracticosSIM.TP_5.InterfacesDeUsuario
{
    public partial class Frm_TP5_Principal : Form
    {
        public Frm_TP5_Principal()
        {
            InitializeComponent();
        }

        //Inicio Caso de Uso Punto A 
        private void Btn_Iniciar_Click(object sender, EventArgs e)
        {
            ControladorTP5.GetInstance().OpcionPantallaSimulacion();
        }

        private void btn_Enunciado_Click(object sender, EventArgs e)
        {
            ControladorTP5.GetInstance().OpcionPantallaEnunciado();
        }
    }
}
