using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajosPracticosSIM.TP_3.InterfacesDeUsuario
{
    public partial class Frm_TP3_PuntoB_ChiCuadrado : Form
    {
        public Frm_TP3_PuntoB_ChiCuadrado()
        {
            InitializeComponent();
            Iniciar();
        }

        private void Iniciar()
        {
            tb_gdl.Enabled = false;
            tb_resultado_final.Enabled = false;
            tb_significancia_alfa.Enabled = false;
            tb_xo_cuadrado.Enabled = false;
            tb_valor_tabulado.Enabled = false;
        }

        private void limpiarDatos()
        {
            tb_resultado_final.Clear();
            tb_significancia_alfa.Clear();
            tb_valor_tabulado.Clear();
            tb_xo_cuadrado.Clear();
            tb_gdl.Clear();
        }

        public void LlenarTextBoxes(double chi_calculado, double chi_tabulado, 
                                               int gdl, double significancia_alfa, string mensaje)
        {
            limpiarDatos();
            tb_gdl.Text = gdl.ToString();
            tb_resultado_final.Text = mensaje;
            tb_significancia_alfa.Text = significancia_alfa.ToString();
            tb_xo_cuadrado.Text = chi_calculado.ToString();
            tb_valor_tabulado.Text = chi_tabulado.ToString();
        }
    }
}
