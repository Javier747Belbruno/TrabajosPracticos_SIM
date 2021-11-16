using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajosPracticosSIM.TP_7.InterfacesDeUsuario
{
    public partial class Frm_TP7_Config_Actividades : Form
    {
        public Frm_TP7_Config_Actividades()
        {
            InitializeComponent();
            LlenarConDatosIniciales();
            
        }

        private void LlenarConDatosIniciales()
        {
            ControladorTP7.GetInstance().OpcionCargarActividadesConfiguracion(this);
        }


        public void LlenarCamposActividades(List<string> distrTodas, DataTable dtActividadesPantalla)
        {

            //Setear combos con todas las distr
            foreach (Panel p in this.Controls.OfType<Panel>().OrderBy(c => c.Name))
            {
                foreach (ComboBox cb in p.Controls.OfType<ComboBox>().OrderBy(c => c.Name))
                {
                    foreach (string distr in distrTodas)
                    {
                        cb.Items.Add(distr);
                    }
                    cb.DropDownStyle = ComboBoxStyle.DropDownList;
                }
            }

            //Meter los actuales en una lista
            Queue<string> distrsActuales = new Queue<string>();
            for (int i = 0; i < dtActividadesPantalla.Rows.Count; i++)
            {
                distrsActuales.Enqueue(dtActividadesPantalla.Rows[i][1].ToString());
            }

            //Dejar Seleccionados de todos solo los actuales
            //+
            //Dependiendo de la seleccion de combo Ocultar o desocultar parametros.

            foreach (Panel p in this.Controls.OfType<Panel>().OrderBy(c => c.Name))
            {
                if(distrsActuales.Count != 0)
                {
                    foreach (ComboBox cb in p.Controls.OfType<ComboBox>())
                    {
                        cb.Text = distrsActuales.Dequeue();
                        ActualizarLabelsTextBoxesParams(cb);
                    }
                }
            }

            //Llenar los campos con los parametros
            int j = 0;
            foreach (Panel p in this.Controls.OfType<Panel>().OrderBy(c => c.Name))
            {
                foreach (TextBox tb in p.Controls.OfType<TextBox>())
                {
                    if(j== dtActividadesPantalla.Rows.Count)
                    {
                        //panel1.Visible = true;
                        //panel2.Visible = true;
                        //panel3.Visible = true;
                        break;
                    }
                    if (tb.Name.StartsWith("tb_param1"))
                    {
                        tb.Text = dtActividadesPantalla.Rows[j][2].ToString();
                    }
                    else
                    {
                       tb.Text = dtActividadesPantalla.Rows[j][3].ToString();
                    }
                }
                j++;
            }
        }

        private void ComboBox_SelectionChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            ActualizarLabelsTextBoxesParams(cb);
        }

        /// <summary>
        /// Distribucion a cambiar 
        /// </summary>
        /// <param name="distr"></param>
        private void ActualizarLabelsTextBoxesParams(ComboBox cb)
        {
            
            var parent = cb.Parent;
            switch (cb.Text)
            {
                case "Uniforme":
                    foreach (Label lb in parent.Controls.OfType<Label>())
                    {
                        lb.Visible = true;
                        if (lb.Name.StartsWith("lb_param1"))
                        {
                            lb.Text = "a:";
                        }
                        else
                        {
                            lb.Text = "b:";
                        }
                    }
                    foreach (TextBox tb in parent.Controls.OfType<TextBox>())
                    {
                        tb.Visible = true;
                    }
                        break;
                case "Normal":
                    foreach (Label lb in parent.Controls.OfType<Label>())
                    {
                        lb.Visible = true;
                        if (lb.Name.StartsWith("lb_param1"))
                        {
                            lb.Text = "µ:";
                        }
                        else
                        {
                            lb.Text = "σ:";
                        }
                    }
                    foreach (TextBox tb in parent.Controls.OfType<TextBox>())
                    {
                        tb.Visible = true;
                    }
                    break;
                case "Exponencial":
                    foreach (Label lb in parent.Controls.OfType<Label>())
                    {
                        if (lb.Name.StartsWith("lb_param1"))
                        {
                            lb.Text = "media";
                        }
                        else
                        {
                            lb.Visible = false;
                        }
                    }
                    foreach (TextBox tb in parent.Controls.OfType<TextBox>())
                    {
                        if (tb.Name.StartsWith("tb_param2"))
                        {
                            tb.Visible = false;
                        }
                    }
                    break;
                case "Constante":
                    foreach (Label lb in parent.Controls.OfType<Label>())
                    {
                        if (lb.Name.StartsWith("lb_param1"))
                        {
                            lb.Text = "valor";
                        }
                        else
                        {
                            lb.Visible = false;
                        }
                    }
                    foreach (TextBox tb in parent.Controls.OfType<TextBox>())
                    {
                        if (tb.Name.StartsWith("tb_param2"))
                        {
                            tb.Visible = false;
                        }
                    }
                    break;
                case "EcDiferencial":
                    foreach (Label lb in parent.Controls.OfType<Label>())
                    {
                            lb.Visible = false;
                    }
                    foreach (TextBox tb in parent.Controls.OfType<TextBox>())
                    {
                            tb.Visible = false;
                    }
                    break;
                case "ED":
                    foreach (Label lb in parent.Controls.OfType<Label>())
                    {
                        lb.Visible = false;
                    }
                    foreach (TextBox tb in parent.Controls.OfType<TextBox>())
                    {
                        tb.Visible = false;
                    }
                    break;
                default:
                    break;
            }
        }

        //Guardar La nueva configuración.
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtActividadesActualizadas = new DataTable();
                dtActividadesActualizadas.Columns.Add("ID");
                dtActividadesActualizadas.Columns.Add("DISTR");
                dtActividadesActualizadas.Columns.Add("PARAM1");
                dtActividadesActualizadas.Columns.Add("PARAM2");
                int i = 0;
                foreach (Panel p in this.Controls.OfType<Panel>().OrderBy(c => c.Name))
                {
                    dtActividadesActualizadas.Rows.Add(i, "DISTR", "PARAMS");

                    foreach (ComboBox cb in p.Controls.OfType<ComboBox>())
                    {
                        dtActividadesActualizadas.Rows[i][1] = cb.SelectedItem;
                    }
                    foreach (TextBox tb in p.Controls.OfType<TextBox>().OrderBy(c => c.Name))
                    {
                        if (tb.Name.StartsWith("tb_param1"))
                        {
                            dtActividadesActualizadas.Rows[i][2] = tb.Text;
                        }
                        else
                        {
                            if (tb.Visible)
                            {
                                dtActividadesActualizadas.Rows[i][3] = tb.Text;
                            }
                        }
                    }
                    i++;
                }

                ControladorTP7.GetInstance().ActualizarActividades(dtActividadesActualizadas);

                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Error - Formato de los datos ingresados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btn_config_Click(object sender, EventArgs e)
        {
            //ControladorTP7.GetInstance().OpcionConfigED();
        }
    }
}
