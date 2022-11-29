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
    public partial class frmVentas : Form
    {
        private VentasCLN objVentasCLN;
        private bool banderaSucursal, banderaEmpleados;
        private DataTable miTabla;
        private DataTable tablaSuc;
        private DataTable tablaEmpleados;
        private SucursalCLN objSucursalCLN;
        private EmpleadosCLN objEmpleadosCLN;
        private int indice;
        public frmVentas()
        {
            InitializeComponent();
            objVentasCLN = new VentasCLN();
            miTabla = new DataTable();
            banderaSucursal= false;
            banderaEmpleados= false;
            objSucursalCLN = new SucursalCLN();
            objEmpleadosCLN = new EmpleadosCLN();
            tablaSuc = new DataTable();
            tablaEmpleados = new DataTable();
            indice = 0;
            
        }
        private void cargarDgv()
        {
            miTabla.Clear();
            miTabla = objVentasCLN.consultaVentasTodas(); 
            //miTabla = objVentasCLN.consultarVentas();
            dgvVentas.DataSource = miTabla;
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            cargarDgv();
            llenarCboSucursales();
            llenarCboEmpleados();
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            chkEmpleados.Visible=false;
            chkSucursal.Visible=false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int idSucursal, idEmpleado;

            idSucursal = Convert.ToInt32(cboSucursal.SelectedValue);
            

            if (chkSucursal.Checked && chkEmpleados.Checked==false)
            {
                miTabla.Clear();
                miTabla = objVentasCLN.consultaVentasTodas();
                dgvVentas.DataSource = miTabla;
            }
            if (chkEmpleados.Checked)
            {
                lblEmpleados.Text= cboEmpleados.Text;
                
                idSucursal = Convert.ToInt32(cboSucursal.SelectedValue);
                lblReporte.Text = idSucursal.ToString();
                miTabla.Clear();
                miTabla = objVentasCLN.consultarVentasUnaSucursal(idSucursal);
                dgvVentas.DataSource = miTabla;
            }

            if(!(chkEmpleados.Checked && chkSucursal.Checked)) 
            {
                idEmpleado = Convert.ToInt32(cboEmpleados.SelectedValue);
                miTabla.Clear();
                miTabla = objVentasCLN.consultarVentasUnEmpleado(idEmpleado);
                dgvVentas.DataSource = miTabla;
            }

        }

        private void chkSucursal_CheckedChanged(object sender, EventArgs e)
        {
            
            if(chkSucursal.Checked )
            {
                cboSucursal.Enabled= false;
                cboEmpleados.Enabled= false;
                chkEmpleados.Enabled = false;
            }
            else
            {
                cboSucursal.Enabled = true;
                cboEmpleados.Enabled = true;
                chkEmpleados.Enabled = true;
            }

        }

        private void chkEmpleados_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEmpleados.Checked)
            {
                banderaEmpleados = true;
                cboEmpleados.Enabled = false;
            }
            else
            {
                banderaEmpleados = false;
                cboEmpleados.Enabled = true;

            }
        }
        private void llenarCboSucursales()
        {
            tablaSuc.Clear();
            tablaSuc = objSucursalCLN.consultarSucursales();
            cboSucursal.ValueMember = "idSucursal";
            cboSucursal.DisplayMember = "sucursal";
            cboSucursal.DataSource = tablaSuc;
            cboSucursal.SelectedIndex = 0;
        }
        private void llenarCboEmpleados()
        {
            tablaEmpleados.Clear();
            tablaEmpleados = objEmpleadosCLN.consultarEmpleadosUnaSucursal(Convert.ToInt32(cboSucursal.SelectedValue));
            cboEmpleados.DataSource = tablaEmpleados;
            cboEmpleados.ValueMember = "idEmpleado";
            cboEmpleados.DisplayMember = "apellido";
        }

        private void cboSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarCboEmpleados();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            frmDetalle objFrmDetalle = new frmDetalle(indice);
            objFrmDetalle.Show();
        }

        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceDgv;
            indiceDgv = e.RowIndex;
            indice = Convert.ToInt32(dgvVentas.Rows[indiceDgv].Cells[0].Value);
        }

        private void rdoSucursal_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
