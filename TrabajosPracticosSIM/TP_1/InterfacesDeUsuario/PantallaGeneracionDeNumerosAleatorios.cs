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
    public partial class Frm_PantallaGeneracionDeNumerosAleatorios : Form
    {
        public Frm_PantallaGeneracionDeNumerosAleatorios()
        {
            InitializeComponent();
            Iniciar();
        }

        private void Iniciar()
        {
            pnl_IngresoDatos.Visible = false;
            pnl_tabla.Visible = false;
        }

        private void Frm_PantallaGeneracionDeNumerosAleatorios_Load(object sender, EventArgs e)
        {

        }

     

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_Generar_Click(object sender, EventArgs e)
        {
            //Chequear que todo se encuentre bien.
            habitarPanelTabla();
        }
        private void btn_sel_Congr_Mixto_Click(object sender, EventArgs e)
        {
            limpiarPantalla();
            CambiarColorBtnSeleccionado(sender);
            habitarPanelIngresoDeDatos();
        }

        private void btn_sel_Congr_Mult_Click(object sender, EventArgs e)
        {
            limpiarPantalla();
            CambiarColorBtnSeleccionado(sender);
            habitarPanelIngresoDeDatos();
            deshabitarC();
        }

        private void habitarPanelIngresoDeDatos()
        {
            pnl_IngresoDatos.Visible = true;
        }

        private void habitarPanelTabla()
        {
            pnl_tabla.Visible = true;
        }

        private void CambiarColorBtnSeleccionado(object sender)
        {
            ((Button)sender).BackColor = Color.LightBlue;
        }

        private void limpiarPantalla()
        {
            btn_sel_Congr_Mult.BackColor = Color.LightGray;
            btn_sel_Congr_Mixto.BackColor = Color.LightGray;
            habitarC();
            tb_semilla.Clear();
            tb_a.Clear();
            tb_c.Clear();
        }
        private void deshabitarC()
        {
            lbl_c.Enabled = false;
            tb_c.Enabled = false;
        }

        private void habitarC()
        {
            lbl_c.Enabled = true;
            tb_c.Enabled = true;
        }
    }
}
