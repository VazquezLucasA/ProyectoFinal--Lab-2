﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using CapaLogicaNegocio;

namespace CapaPresentacion
{
   
    public partial class frmSucursal : Form
    {

        private SucursalCLN objSucursalCLN;
        private DataTable miTabla;
        private int indice;
        private string sucursal;
        private string direccion;

        public frmSucursal()
        {

            InitializeComponent();
            indice = 0;
            objSucursalCLN = new SucursalCLN();
            miTabla = new DataTable();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Desea eliminar la sucursal?", "Eliminar sucursal", MessageBoxButtons.YesNo);

            if (opcion == DialogResult.Yes)
            {
                objSucursalCLN.eliminarSucursal(Convert.ToInt32(dgvSucursal.Rows[indice].Cells[0].Value));
                MessageBox.Show("Se eliminó la sucursal correctamente", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LimpiarTextBoxs();
                btnEliminar.Visible = false;
                btnPreEliminar.Visible = true;
                btnPreEliminar.Enabled = true;
                btnModificar.Enabled = true;
                cargarDgv();
            }
            else
            { MessageBox.Show("Operación cancelada", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

            cargarDgv();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            sucursal= txtSucursal.Text;
            direccion = txtDireccion.Text;

            objSucursalCLN.actualizarSucursal(Convert.ToInt32(dgvSucursal.Rows[indice].Cells[0].Value), sucursal, direccion);

            MessageBox.Show("Los datos fueron actualizados");
            LimpiarTextBoxs();
            btnAgregar.Enabled = true;
            btnPreEliminar.Enabled = false;
            btnModificar.Enabled = false;

            cargarDgv();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int indiceUltFila = objSucursalCLN.getIndiceUltFila(dgvSucursal.Rows.Count);
            int codigoSucursal = objSucursalCLN.getCodigoSucursal(dgvSucursal.Rows[indiceUltFila].Cells[0].Value);

            DialogResult opcion = MessageBox.Show("¿Está seguro que quiere agregar un nuevo producto?", "Nuevo producto", MessageBoxButtons.YesNo);
            if (opcion == DialogResult.Yes)
            {
                indice = dgvSucursal.Rows.Add();
                sucursal = txtSucursal.Text;
                direccion = txtDireccion.Text;

                try
                {
                    objSucursalCLN.agregarSucursal(codigoSucursal, sucursal, direccion);
                    LimpiarTextBoxs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarTextBoxs();
                }
            }
            else
            {
                MessageBox.Show("Carga de producto cancelada");
                LimpiarTextBoxs();
            }
            cargarDgv();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarTextBoxs();
            btnAgregar.Enabled = true;

            btnModificar.Enabled = false;
            btnEliminar.Visible = false;
            btnEliminar.Enabled = false;

            btnPreEliminar.Visible = true;
            btnPreEliminar.Enabled = false;
        }

        private void frmSucursal_Load(object sender, EventArgs e)
        {
            cargarDgv();
            btnEliminar.Visible = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnPreEliminar.Enabled = false;
        }

        private void dgvSucursal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            if (indice == -1)
            { MessageBox.Show("Seleccione un fila válida"); }
            else
            {
                if (dgvSucursal.Rows[indice].Cells[0].Value == null)
                {
                    MessageBox.Show("Error, haga bien el click");
                }
                else
                {
                    btnEliminar.Visible = false;
                    btnAgregar.Enabled = false;
                    btnPreEliminar.Enabled = true;
                    btnPreEliminar.Visible = true;
                    btnModificar.Enabled = true;
                    txtSucursal.Text = (dgvSucursal.Rows[indice].Cells[1].Value).ToString();
                    txtDireccion.Text = (dgvSucursal.Rows[indice].Cells[2].Value).ToString();
                    
                }
            }
        }

        //SE CARGA EL DGV
        private void cargarDgv()
        {
            miTabla = objSucursalCLN.consultarSucursales();
            dgvSucursal.DataSource = miTabla;
        }

        //LIMPIAR TXT
        private void LimpiarTextBoxs()
        {
            txtSucursal.Clear();
            txtDireccion.Clear();
            
        }
    }
}
