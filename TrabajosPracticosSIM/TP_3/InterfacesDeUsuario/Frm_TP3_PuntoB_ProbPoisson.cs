using System;
using System.Collections;
using System.Windows.Forms;

namespace TrabajosPracticosSIM.TP_3.InterfacesDeUsuario
{
    public partial class Frm_TP3_PuntoB_ProbPoisson : Form
    {
        public Frm_TP3_PuntoB_ProbPoisson()
        {
            InitializeComponent();
        }

        public void LlenarTabla(ArrayList prob, ArrayList probAcum)
        {
            dgv_probabilidades.Rows.Clear();

            for (int i = 0; i < probAcum.Count; i++)
            {
                dgv_probabilidades.Rows.Add(i, prob[i], probAcum[i]);
            }
        }

        private void Frm_TP3_PuntoB_ProbPoisson_Load(object sender, EventArgs e)
        {

        }
    }
}
