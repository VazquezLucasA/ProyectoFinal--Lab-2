namespace ProyectoFinal
{
    public partial class frmPacoGarcia : Form
    {
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


        }
        private void LimpiarTextBoxs()
        {
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgvStock.Rows[indice].Cells[1].Value = txtDescripcion;
            dgvStock.Rows[indice].Cells[2].Value = txtStock;
            dgvStock.Rows[indice].Cells[3].Value = txtPrecio;
            LimpiarTextBoxs();

            DialogResult opcion = MessageBox.Show("¿Está seguro que quiere agregar un nuevo producto?", "Nuevo producto", MessageBoxButtons.YesNo);
            if (opcion == DialogResult.Yes)
            {
                dgvStock.Rows[indice].Cells[1].Value = txtDescripcion;
                dgvStock.Rows[indice].Cells[2].Value = txtStock;
                dgvStock.Rows[indice].Cells[3].Value = txtPrecio;
                LimpiarTextBoxs();
            }
            else
            {
                MessageBox.Show("Carga de producto cancelada");
                LimpiarTextBoxs();
            }
        }

        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            if (indice == -1)
            { MessageBox.Show("Seleccione un fila válida"); }
            else
            {
                txtDescripcion.Text = (dgvStock.Rows[indice].Cells[1].Value).ToString();
                txtStock.Text = (dgvStock.Rows[indice].Cells[3].Value).ToString();
                txtPrecio.Text = (dgvStock.Rows[indice].Cells[2].Value).ToString();
            }
        }
    }
}