using System;
using System.Windows.Forms;
using TrabajosPracticosSIM.TP_4;

namespace TrabajosPracticosSIM
{
    public partial class Frm_TP4_Principal : Form
    {
        public Frm_TP4_Principal()
        {
            InitializeComponent();
        }

        //Inicio Caso de Uso Punto A 
        private void Btn_Iniciar_Click(object sender, EventArgs e)
        {
            ControladorTP4.GetInstance().OpcionPantallaMontecarlo();
        }

        private void btn_Enunciado_Click(object sender, EventArgs e)
        {
            ControladorTP4.GetInstance().OpcionPantallaEnunciado();
        }
    }
}
