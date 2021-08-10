using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajosPracticosSIM
{
    public partial class Frm_PantallaPrincipal : Form
    {
        public Frm_PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ControladorTP1.GetInstance().opcionGeneracionDeNumerosAleatorios();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_PantallaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
