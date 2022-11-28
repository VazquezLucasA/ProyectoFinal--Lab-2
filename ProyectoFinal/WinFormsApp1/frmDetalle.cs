using CapaLogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmDetalle : Form
    {
        private DataTable miTabla;
        private VentasCLN objVentasCLN;
        private int idVenta;
        public frmDetalle(int indice)
        {
            InitializeComponent();
            miTabla = new DataTable();
            objVentasCLN = new VentasCLN();
            idVenta = indice;
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {
            cargarDgv();
        }
        private void cargarDgv()
        {
            miTabla.Clear();
            //miTabla = objVentasCLN.consultarVentas(idVenta);
            dgvDetalles.DataSource = miTabla;
        }
    }
}
