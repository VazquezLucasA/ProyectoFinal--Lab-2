namespace ProyectoFinal
{
    public partial class frmPacoGarcia : Form
    {
        /*
            Proyecto Final - Laboratorio de computación 2.
            Universidad Tecnologica Nacional. 2022.
            Grupo:
                -González, Mateo   
                -Vázquez, Lucas Alejo
                -Yalux, Sergio
            LucidChart: https://lucid.app/lucidchart/f235846b-6863-4969-8921-81f04b5a200c/edit?invitationId=inv_adcb7877-67fc-46b4-ba9c-2caea1d77f7c&page=0_0#
        */
        private int indice;
        public frmPacoGarcia()
        {
            InitializeComponent();
            indice = 0;
        }

        private void frmPacoGarcia_Load(object sender, EventArgs e)
        {
            /*  
                columnas 
            codigo descripcion stock precio
             */
            indice = dgvStock.Rows.Add();
            dgvStock.Rows[indice].Cells[0].Value = 1;
            dgvStock.Rows[indice].Cells[1].Value = "Camiseta River Plate";
            dgvStock.Rows[indice].Cells[2].Value = 50;
            dgvStock.Rows[indice].Cells[3].Value = 3499.99f;

            indice = dgvStock.Rows.Add();
            dgvStock.Rows[indice].Cells[0].Value = 2;
            dgvStock.Rows[indice].Cells[1].Value = "Botines F5";
            dgvStock.Rows[indice].Cells[2].Value = 100;
            dgvStock.Rows[indice].Cells[3].Value = 12000.00f;

            indice = dgvStock.Rows.Add();
            dgvStock.Rows[indice].Cells[0].Value = 3;
            dgvStock.Rows[indice].Cells[1].Value = "Shorts";
            dgvStock.Rows[indice].Cells[2].Value = 350;
            dgvStock.Rows[indice].Cells[3].Value = 5000.00f;


            btnEliminar.Visible = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnPreEliminar.Enabled = false;

        }
        private void LimpiarTextBoxs()
        {
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }



        //BOTON AGREGAR 
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int cantFilas = dgvStock.Rows.Count - 1;
            int codigo = Convert.ToInt32(dgvStock.Rows[cantFilas].Cells[0].Value) + 1;
            DialogResult opcion = MessageBox.Show("¿Está seguro que quiere agregar un nuevo producto?", "Nuevo producto", MessageBoxButtons.YesNo);
            if (opcion == DialogResult.Yes)
            {
                indice = dgvStock.Rows.Add();
                dgvStock.Rows[indice].Cells[0].Value = codigo;
                dgvStock.Rows[indice].Cells[1].Value = txtDescripcion.Text;
                dgvStock.Rows[indice].Cells[2].Value = txtStock.Text;
                dgvStock.Rows[indice].Cells[3].Value = txtPrecio.Text;
                LimpiarTextBoxs();
            }
            else
            {
                MessageBox.Show("Carga de producto cancelada");
                LimpiarTextBoxs();
            }
        }

        //CLICK EN LAS CELDAS
        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            if (indice == -1)
            { MessageBox.Show("Seleccione un fila válida"); }
            else
            {
                if (dgvStock.Rows[indice].Cells[0].Value == null)
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
                    txtDescripcion.Text = (dgvStock.Rows[indice].Cells[1].Value).ToString();
                    txtStock.Text = (dgvStock.Rows[indice].Cells[2].Value).ToString();
                    txtPrecio.Text = (dgvStock.Rows[indice].Cells[3].Value).ToString();
                    
                }
            }
            
        }


        //BOTON MODIFICAR
        private void btnModificar_Click(object sender, EventArgs e)
        {
            dgvStock.Rows[indice].Cells[1].Value = txtDescripcion.Text;
            dgvStock.Rows[indice].Cells[2].Value = txtStock.Text;
            dgvStock.Rows[indice].Cells[3].Value = txtPrecio.Text;
            MessageBox.Show("Los datos fueron actualizados");
            limpiarTextBoxs();
            btnAgregar.Enabled = true;
            btnPreEliminar.Enabled = false;
            btnModificar.Enabled = false;

        }

        //BOTON ELIMINAR
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Desea eliminar el producto?", "Eliminar producto", MessageBoxButtons.YesNo);

            if (opcion == DialogResult.Yes)
            {
                dgvStock.Rows.RemoveAt(indice);
                MessageBox.Show("Se eliminó el producto correctamente","Eliminado" , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                limpiarTextBoxs();
                btnEliminar.Visible = false;
                btnPreEliminar.Visible = true;
                btnPreEliminar.Enabled = true;
                btnModificar.Enabled = true;

            }
            else
                MessageBox.Show("Operación cancelada", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        //BOTON VENDER
        private void btnVender_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Desea confirmar la venta del producto?", "Venta de producto", MessageBoxButtons.YesNo);
            if (opcion == DialogResult.Yes)
            {
                dgvStock.Rows[indice].Cells[2].Value = Convert.ToInt32(dgvStock.Rows[indice].Cells[2].Value) - 1;
                MessageBox.Show("Se vendió el producto correctamente", "Venta de producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                limpiarTextBoxs();
            }
            else
                MessageBox.Show("Operación cancelada", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        //LIMPIAR TEXT BOXS
        private void limpiarTextBoxs()
        {
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
        }

        //BOTON PARA LIMPIAR
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarTextBoxs();
            btnAgregar.Enabled = true;
           
            btnModificar.Enabled = false;
            btnEliminar.Visible = false;
            btnEliminar.Enabled = false;

            btnPreEliminar.Visible = true;
            btnPreEliminar.Enabled = false;
        }

        private void btnPreEliminar_Click(object sender, EventArgs e)
        {
            btnEliminar.Visible = true;
            btnEliminar.Enabled = true;
            btnPreEliminar.Visible = false;
            btnModificar.Enabled = false;
            
        }
    }
}