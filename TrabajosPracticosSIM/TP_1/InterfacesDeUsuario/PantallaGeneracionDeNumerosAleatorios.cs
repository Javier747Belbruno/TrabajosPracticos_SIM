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
        private SortedDictionary<int, double> mapa;
        public Frm_PantallaGeneracionDeNumerosAleatorios()
        {
            InitializeComponent();
            Iniciar();
        }

        private void Iniciar()
        {
           
            pnl_IngresoDatos.Visible = false;
            pnl_tabla.Visible = false;
            LimpiarTabla();
        }

        private void LimpiarTabla()
        {
            dgv_numeros.Rows.Clear();
            dgv_numeros.Refresh();
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
            
            //Habilitamos Panel.
            habitarPanelTabla();

            //Mandar Datos al Gestor.
            ControladorTP1.GetInstance().opcionGeneracionDeNumerosAleatorios(this);
        }

        public void LlenarTablaInicial(SortedDictionary<int, double> mapa)
        {
            //Guardo en atributo interno de la pantalla los datos.
            this.mapa = mapa;
            foreach (KeyValuePair<int, double> kvp in mapa)
            {
                if(kvp.Key <= 20)
                    dgv_numeros.Rows.Add(kvp.Key,kvp.Value);
            }
            
        }

        private void btn_sel_Congr_Mixto_Click(object sender, EventArgs e)
        {
            Iniciar(); 
            limpiarPantalla();
            CambiarColorBtnSeleccionado(sender);
            habitarPanelIngresoDeDatos();
        }

        private void btn_sel_Congr_Mult_Click(object sender, EventArgs e)
        {
            Iniciar();
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

        private void btn_Prox_20_Click(object sender, EventArgs e)
        {
            var ultimaPosicion = getUltimaPosicionActual();
            foreach (KeyValuePair<int, double> kvp in mapa)
            {
                if (kvp.Key > ultimaPosicion && kvp.Key <= (ultimaPosicion + 20))
                    dgv_numeros.Rows.Add(kvp.Key, kvp.Value);
            }

        }

     


        private int getUltimaPosicionActual()
        {
            int ultimo = Convert.ToInt32(dgv_numeros.Rows[dgv_numeros.Rows.Count-2].Cells[0].Value);
            return ultimo;
        }

        private void btn_Prox_Click_1(object sender, EventArgs e)
        {
            var ultimaPosicion = getUltimaPosicionActual();
            foreach (KeyValuePair<int, double> kvp in mapa)
            {
                if (kvp.Key > ultimaPosicion && kvp.Key <= (ultimaPosicion + 1))
                    dgv_numeros.Rows.Add(kvp.Key, kvp.Value);
            }
        }

        private void btn_listar_todo_Click(object sender, EventArgs e)
        {
            LimpiarTabla();
            ListarTodo();
        }

        private void ListarTodo()
        {
            foreach (KeyValuePair<int, double> kvp in mapa)
            {
                    dgv_numeros.Rows.Add(kvp.Key, kvp.Value);
            }
        }

        private void btn_desde_hasta_Click(object sender, EventArgs e)
        {
            LimpiarTabla();
            ListarRango();
        }
        private void ListarRango()
        {
            //Hacer validaciones de RANGO
            //Hacer que lo que entre sea solo tipo Numerico.

            var desde = Convert.ToInt32(tb_desde.Text);
            var hasta = Convert.ToInt32(tb_hasta.Text);
            foreach (KeyValuePair<int, double> kvp in mapa)
            {
                if (kvp.Key >= desde && kvp.Key <= hasta)
                    dgv_numeros.Rows.Add(kvp.Key, kvp.Value);
            }
        }
    }
}
