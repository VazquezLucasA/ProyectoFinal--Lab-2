using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.BLL;

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
            int id = Convert.ToInt32(txtIDSucursal.Text);
            SucursalBLL sucursalUno = new SucursalBLL();
            sucursalUno.id = id;
            sucursalUno.sucursal = txtSucursal.Text;
            MessageBox.Show(sucursalUno.id.ToString() + " " + sucursalUno.sucursal);
            
        }
    }
}
