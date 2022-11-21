using ProyectoFinal;
using ProyectoFinal.PL;
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
    
    public partial class frmPresentacion : Form
    {
       
        public frmPresentacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPacoGarcia frmProductos = new frmPacoGarcia();
            frmProductos.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //frmPresentacion.ActiveForm.Close();
            //frmPresentacion.ActiveForm.Visible = false;

            frmSucursal frmSuc = new frmSucursal();
            //frmPresentacion.ActiveForm.Visible = false;
            frmSuc.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmEmpleados frmEmp = new frmEmpleados();
            frmEmp.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void llenarCmb()
        {
            //comboBox1.DataSource = tabla.find();
            //comboBox1.ValueMember = "idSucursal";
            cbxSucursal.DisplayMember = "sucursal";
            cbxSucursal.SelectedIndex = 0;
        }
    }
}
