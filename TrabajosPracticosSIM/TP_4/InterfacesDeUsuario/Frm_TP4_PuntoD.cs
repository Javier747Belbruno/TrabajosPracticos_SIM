using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajosPracticosSIM.TP_4.InterfacesDeUsuario
{
    public partial class Frm_TP4_PuntoD : Form
    {
        public Frm_TP4_PuntoD()
        {
            InitializeComponent();
            PedirDatosGrafico();

        }

        private void PedirDatosGrafico()
        {
            ControladorTP4.GetInstance().OpcionPedirDatosGrafico(this);
        }
    }
}
