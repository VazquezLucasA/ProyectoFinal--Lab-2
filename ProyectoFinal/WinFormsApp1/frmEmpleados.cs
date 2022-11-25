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
        private DataTable miTabla;
        private int indice;
        public frmEmpleados()
        {
            InitializeComponent();
            objEmpleadosCLN = new EmpleadosCLN();
            miTabla = new DataTable();
            indice = 0;
    }

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

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            objEmpleadosCLN.actualizarEmpleado(Convert.ToInt32(dgvEmpleados.Rows[indice].Cells[0].Value), txtName.Text, txtSurname.Text, txtEmail.Text, cbxSucursal.SelectedIndex);

            MessageBox.Show("Los datos fueron actualizados");
            LimpiarTextBoxs();
            btnAdd.Enabled = true;
            btnPreEliminar.Enabled = false;
            btnModify.Enabled = false;

            cargarDgv();
        }

        private void btnEliminate_Click(object sender, EventArgs e)
        {

        }

        private void btnExaminate_Click(object sender, EventArgs e)
        {

        }

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
        private void LimpiarTextBoxs()
        {
            txtEmail.Clear();
            txtName.Clear();
            txtSurname.Clear();

        }


        private void btnPreEliminar_Click(object sender, EventArgs e)
        {

        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            cargarDgv();
            btnEliminate.Visible = false;
            btnModify.Enabled = false;
            btnEliminate.Enabled = false;
            btnPreEliminar.Enabled = false;
        }
    }
}
