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
        private DetalleCLN objDetalleCLN;
        private int idVenta;
        public frmDetalle(int indice)
        {
            InitializeComponent();
            miTabla = new DataTable();
            objDetalleCLN = new DetalleCLN();
            idVenta = indice;
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {
            cargarDgv();
            dgvDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void cargarDgv()
        {
            miTabla.Clear();
            miTabla = objDetalleCLN.consultarDetalles(idVenta);
            dgvDetalles.DataSource = miTabla;
        }
    }
}
