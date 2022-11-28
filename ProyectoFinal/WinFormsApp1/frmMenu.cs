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
using WinFormsApp1;

namespace CapaPresentacion
{
    public partial class frmMenu : Form
    {
        private frmSucursal frmSuc;
        private frmEmpleados frmEmp;
        private frmProductos frmProduct;
        private frmVentas objFrmVentas;
        private SucursalCLN objSucursalCLN;
        private EmpleadosCLN objEmpleadosCLN;
        public frmMenu()
        {
            InitializeComponent();
            frmSuc = new frmSucursal();
            frmEmp = new frmEmpleados(); 
            
            objFrmVentas = new frmVentas();
            objSucursalCLN= new SucursalCLN();
            objEmpleadosCLN = new EmpleadosCLN();
        }
        private void frmMenu_Load(object sender, EventArgs e)
        {
            llenarCbxSucursal();
            llenarCbxEmpleado();
        }

        //BOTON INGRESAR SUCURSAL
        private void btnSucursal_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSuc.ShowDialog();
            this.Close();
        }

        //BOTON INGRESAR EMPLEADOS
        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmp.ShowDialog();
            this.Close();
        }
        
        //BOTON INGRESAR PRODUCTOS
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProduct = new frmProductos(cbxEmpleados.Text);
            frmProduct.ShowDialog();
            this.Close();
        }
        //BOTON REPORTE DE VENTAS

        private void llenarCbxSucursal()
        {
            DataTable miTabla = new DataTable();
            miTabla = objSucursalCLN.consultarSucursales();
            cbxSucursal.DisplayMember = "nombre";
            cbxSucursal.ValueMember = "idSucursal";
            cbxSucursal.DataSource = miTabla;
            cbxSucursal.SelectedIndex = 0;
        }
        private void llenarCbxEmpleado()
        {
            DataTable miTabla = new DataTable();
            int valor = Convert.ToInt32(cbxSucursal.SelectedValue);
            miTabla = objEmpleadosCLN.consultarEmpleadosUnaSucursal(valor);
            cbxEmpleados.DataSource = miTabla;
            cbxEmpleados.ValueMember = "idEmpleado";
            cbxEmpleados.DisplayMember = "apellido";
        }

            private void btnVentas_Click(object sender, EventArgs e)
        {
            this.Hide();
            objFrmVentas.ShowDialog();
            this.Close();
        }

        private void cbxSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarCbxEmpleado();
        }
    }
}
