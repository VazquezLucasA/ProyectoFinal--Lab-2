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
    public partial class frmEmpleados : Form
    {
        private EmpleadosCLN objEmpleadosCLN;
        private SucursalCLN objSucursalCLN;
        private DataTable miTabla;
        private int indice;
        public frmEmpleados()
        {
            InitializeComponent();
            objEmpleadosCLN = new EmpleadosCLN();
            miTabla = new DataTable();
            indice = 0;
            objSucursalCLN = new SucursalCLN();
    }
        //BOTON CANCELAR
        private void btnCancel_Click(object sender, EventArgs e)
        {
            LimpiarTextBoxs();
            btnAdd.Enabled = true;

            btnModify.Enabled = false;
            btnEliminate.Visible = false;
            btnEliminate.Enabled = false;

            btnPreEliminar.Visible = true;
            btnPreEliminar.Enabled = false;


        }
        //BOTON AGREGAR
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int indiceUltFila = objEmpleadosCLN.getIndiceUltFila(dgvEmpleados.Rows.Count);
            int idEmpleado = objEmpleadosCLN.getCodigoEmpleado(dgvEmpleados.Rows[indiceUltFila].Cells[0].Value);

            lblEmail.Text = idEmpleado.ToString();

            DialogResult opcion = MessageBox.Show("¿Está seguro que quiere agregar un nuevo empleado?", "Nuevo empleado", MessageBoxButtons.YesNo);
            if (opcion == DialogResult.Yes)
            {
                try
                {
                    if(txtEmail.Text == string.Empty || txtName.Text == string.Empty || txtSurname.Text == string.Empty)
                    {
                        MessageBox.Show("Por favor complete todos los campos", "Carga cancelada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        objEmpleadosCLN.agregarEmpleado(idEmpleado, txtName.Text, txtSurname.Text, txtEmail.Text, Convert.ToInt32(cbxSucursal.SelectedValue));
                    }
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error: ", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Carga de empleado cancelada");
            }
            LimpiarTextBoxs();
            cargarDgv();
        }
        //BOTON MODIFICAR
        private void btnModify_Click(object sender, EventArgs e)
        {
            objEmpleadosCLN.actualizarEmpleado(Convert.ToInt32(dgvEmpleados.Rows[indice].Cells[0].Value), txtName.Text, txtSurname.Text, txtEmail.Text, Convert.ToInt32(cbxSucursal.SelectedValue));

            MessageBox.Show("Los datos fueron actualizados");
            LimpiarTextBoxs();
            btnAdd.Enabled = true;
            btnPreEliminar.Enabled = false;
            btnModify.Enabled = false;

            cargarDgv();
        }
        //BOTON ELIMINAR
        private void btnEliminate_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Desea eliminar el empleado?", "Eliminar empleado", MessageBoxButtons.YesNo);

            if (opcion == DialogResult.Yes)
            {
                int idEmpleado = Convert.ToInt32(dgvEmpleados.Rows[indice].Cells[0].Value);
                bool banderaVerificacion = objEmpleadosCLN.empleadoTieneVentas(idEmpleado);
                if (banderaVerificacion)
                {
                    MessageBox.Show("No se puede eliminar un empleado que ya posee ventas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    objEmpleadosCLN.eliminarEmpleado(idEmpleado);
                    MessageBox.Show("Se eliminó el empleado correctamente", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    LimpiarTextBoxs();
                }
                btnEliminate.Visible = false;
                btnPreEliminar.Visible = true;
                btnPreEliminar.Enabled = true;
                btnModify.Enabled = true;
                cargarDgv();
            }
            else
            { MessageBox.Show("Operación cancelada", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

            cargarDgv();
        }

        private void btnExaminate_Click(object sender, EventArgs e)
        {

        }
        //CLICK EN CELDAS
        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            if (indice == -1)
            { MessageBox.Show("Seleccione un fila válida"); }
            else
            {
                if (dgvEmpleados.Rows[indice].Cells[0].Value == null)
                {
                    MessageBox.Show("Error, haga bien el click");
                }
                else
                {
                    btnEliminate.Visible = false;
                    btnAdd.Enabled = false;
                    btnPreEliminar.Enabled = true;
                    btnPreEliminar.Visible = true;
                    btnModify.Enabled = true;
                    txtName.Text = (dgvEmpleados.Rows[indice].Cells[1].Value).ToString();
                    txtSurname.Text = (dgvEmpleados.Rows[indice].Cells[2].Value).ToString();
                    txtEmail.Text = (dgvEmpleados.Rows[indice].Cells[3].Value).ToString();

                }
            }
        }

        //SE CARGA EL DGV
        private void cargarDgv()
        {
            miTabla.Clear();
            miTabla = objEmpleadosCLN.consultarEmpleados();
            dgvEmpleados.DataSource = miTabla;
        }
        //LIMPIAR TXT
        private void LimpiarTextBoxs()
        {
            txtEmail.Clear();
            txtName.Clear();
            txtSurname.Clear();

        }

        //BOTON HABILITAR ELIMINAR
        private void btnPreEliminar_Click(object sender, EventArgs e)
        {
            btnEliminate.Visible = true;
            btnEliminate.Enabled = true;
            btnPreEliminar.Visible = false;
            btnModify.Enabled = false;
        }

        //EVENTO LOAD
        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            cargarDgv();
            btnEliminate.Visible = false;
            btnModify.Enabled = false;
            btnEliminate.Enabled = false;
            btnPreEliminar.Enabled = false;
            llenarCbxSucursal();
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        //LLENAR COMBOBOX SUCUS
        private void llenarCbxSucursal()
        {
            DataTable miTabla = new DataTable();
            miTabla = objSucursalCLN.consultarSucursales();
            cbxSucursal.DataSource = miTabla;
            cbxSucursal.ValueMember = "idSucursal";
            cbxSucursal.DisplayMember = "sucursal";
            cbxSucursal.SelectedIndex = 0;
        }
    }
}
