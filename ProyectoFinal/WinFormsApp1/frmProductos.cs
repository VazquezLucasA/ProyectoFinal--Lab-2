using CapaLogicaNegocio;
using CapaPresentacion;
using System.Data;

namespace WinFormsApp1
{
    public partial class frmProductos : Form
    {
        /*
           Proyecto Final - Laboratorio de computación 2.
           Universidad Tecnologica Nacional. 2022.
           Grupo:
               -González, Mateo   
               -Vázquez, Lucas Alejo
               -Yalux, Sergio
       */


        //MIEMBROS ATRIBUTOS
        private int indice;
        private ProductoCLN objProductoCLN;
        private DataTable miTabla;
        private int stock;
        private float precio;
        private int indiceCarrito;
        private string nombreBienvenida;
        private int asd;
        private string nombreProducto;
        private int[] idProductos;
        //CONSTRUCTOR
        public frmProductos(string nombreBienvenido)
        {
            InitializeComponent();
            indice = 0;
            objProductoCLN = new ProductoCLN();
            miTabla = new DataTable();
            precio = 0;
            stock = 0;
            indiceCarrito = 0;
            nombreBienvenida = nombreBienvenido;
            nombreProducto = "";
            asd= 0;
            idProductos = new int[5];
        }
        //MIEMBROS METODOS

        //LOAD
        private void Form1_Load(object sender, EventArgs e)
        {
            cargarDgv();
            btnEliminar.Visible = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnPreEliminar.Enabled = false;
            lblBienvenida.Text += nombreBienvenida;
        }

        //CLICK EN LAS CELDAS
        private void dgvStock_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            nombreProducto = dgvStock.Rows[indice].Cells[1].Value.ToString();
            lblCantFilas.Text = indice.ToString();
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

        //CARGAR DATA GRID
        private void cargarDgv()
        {
            miTabla.Clear();
            miTabla = objProductoCLN.consultarProductos();
            dgvStock.DataSource = miTabla;
        }
        //BOTON AGREGAR 
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int indiceUltFila = objProductoCLN.getIndiceUltFila(dgvStock.Rows.Count);
            int codigoProducto = objProductoCLN.getCodigoProducto(dgvStock.Rows[indiceUltFila].Cells[0].Value);

            DialogResult opcion = MessageBox.Show("¿Está seguro que quiere agregar un nuevo producto?", "Nuevo producto", MessageBoxButtons.YesNo);
            if (opcion == DialogResult.Yes)
            {
                //indice = dgvStock.Rows.Add();
                stock = Convert.ToInt32(txtStock.Text);
                precio = Convert.ToInt32(txtPrecio.Text);

                try
                {
                    objProductoCLN.agregarProducto(codigoProducto, txtDescripcion.Text, stock, precio);
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
        //BOTON MODIFICAR
        private void btnModificar_Click(object sender, EventArgs e)
        {
            stock = Convert.ToInt32(txtStock.Text);
            precio = float.Parse(txtPrecio.Text);

            objProductoCLN.actualizarProducto(Convert.ToInt32(dgvStock.Rows[indice].Cells[0].Value), txtDescripcion.Text, stock, precio);

            MessageBox.Show("Los datos fueron actualizados");
            LimpiarTextBoxs();
            btnAgregar.Enabled = true;
            btnPreEliminar.Enabled = false;
            btnModificar.Enabled = false;

            cargarDgv();
        }


        //LIMPIAR TXT
        private void LimpiarTextBoxs()
        {
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }

        //BOTON ELIMINAR
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Desea eliminar el producto?", "Eliminar producto", MessageBoxButtons.YesNo);

            if (opcion == DialogResult.Yes)
            {
                objProductoCLN.eliminarProducto(Convert.ToInt32(dgvStock.Rows[indice].Cells[0].Value));
                MessageBox.Show("Se eliminó el producto correctamente", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        //BOTON VENDER
        private void btnVender_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Desea confirmar la venta del producto?", "Venta de producto", MessageBoxButtons.YesNo);
            if (opcion == DialogResult.Yes)
            {

                try
                {
                    dgvStock.Rows[indice].Cells[2].Value = Convert.ToInt32(dgvStock.Rows[indice].Cells[2].Value) - 1;
                    MessageBox.Show("Se vendió el producto correctamente", "Venta de producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    LimpiarTextBoxs();
                }
                catch
                {
                    MessageBox.Show("Hubo un error, intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Operación cancelada", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            cargarDgv();
        }

        //BOTON PARA LIMPIAR
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTextBoxs();
            btnAgregar.Enabled = true;

            btnModificar.Enabled = false;
            btnEliminar.Visible = false;
            btnEliminar.Enabled = false;

            btnPreEliminar.Visible = true;
            btnPreEliminar.Enabled = false;
        }
        //BOTON HABILITAR ELIMINAR
        private void btnPreEliminar_Click(object sender, EventArgs e)
        {
            btnEliminar.Visible = true;
            btnEliminar.Enabled = true;
            btnPreEliminar.Visible = false;
            btnModificar.Enabled = false;
        }

        private void dgvStock_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //int indiceCarrito = 0;
            //lblLista.Text += dgvStock.Rows[indice].Cells[1].Value.ToString() + "\n";
            string[] listado = new string[5];
            int[] idProductos = new int[5];

        }

        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            lblLista.Text +=  nombreProducto + " \n";


            if (indiceCarrito < 5)
            {
                idProductos[indiceCarrito] = Convert.ToInt32(dgvStock.Rows[indice].Cells[0].Value);
            }
            else
            {
                MessageBox.Show("Alcanzó la cantidad máxima del carrito");
            }
            indiceCarrito++;
        }
    }
}