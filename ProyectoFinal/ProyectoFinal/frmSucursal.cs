using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion;

namespace ProyectoFinal.PL
{
    public partial class frmSucursal : Form
    {
        public frmSucursal()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //instrucciones GUI (Obtener información de la presentación)
            CaptarDatos();

        }
        private void CaptarDatos()
        {
            //int id = 0; int.TryParse(txtIDSucursal.Text, out id);
        }
    }
}
