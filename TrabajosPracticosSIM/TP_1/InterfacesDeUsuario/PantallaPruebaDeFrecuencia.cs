using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajosPracticosSIM.TP_1.InterfacesDeUsuario
{
    public partial class Frm_PantallaPruebaDeFrecuencia : Form
    {
        public Frm_PantallaPruebaDeFrecuencia()
        {
            InitializeComponent();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void limpiarPantalla()
        {
            btn_Gen_Leng.BackColor = Color.LightGray;
            btn_genMixto.BackColor = Color.LightGray;
            //habitarC();
            tb_semilla.Clear();
            tb_a.Clear();
            tb_c.Clear();
        }
        private void btn_Gen_Leng_Click(object sender, EventArgs e)
        {
            CambiarColorBtnSeleccionado(sender);
        }
        private void CambiarColorBtnSeleccionado(object sender)
        {
            ((Button)sender).BackColor = Color.LightBlue;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }


    }
}
