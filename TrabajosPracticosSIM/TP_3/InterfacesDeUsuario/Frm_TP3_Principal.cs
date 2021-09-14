using System;
using System.Windows.Forms;
using TrabajosPracticosSIM.TP_3;

namespace TrabajosPracticosSIM
{
    public partial class Frm_TP3_Principal : Form
    {
        public Frm_TP3_Principal()
        {
            InitializeComponent();
        }

        //Inicio Caso de Uso Punto A 
        private void Btn_Iniciar_Click(object sender, EventArgs e)
        {
            ControladorTP3.GetInstance().OpcionPantallaPuntoA();
        }

    }
}
