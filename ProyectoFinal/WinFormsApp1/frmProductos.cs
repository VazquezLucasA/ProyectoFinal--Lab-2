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
        private string nombreProducto;
        private int[] idProductos;
        private float precioVenta;
        private int idEmpleado;
        //CONSTRUCTOR
        public frmProductos(string nombreBienvenido, int idEmpleado)
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
            idProductos = new int[5];
            this.idEmpleado= idEmpleado;
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
            lblBienvenida.Text += nombreBienvenida + "!";
        }

        //CLICK EN LAS CELDAS
        private void dgvStock_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            nombreProducto = dgvStock.Rows[indice].Cells[1].Value.ToString();
            //precioVenta = Convert.ToInt32(dgvStock.Rows[indice].Cells[2].Value);
            lblProductoTres.Text = indice.ToString();
            if (indice == -1)
            { 
                MessageBox.Show("Seleccione un fila válida"); 
            }
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
                    txtPrice.Text = (dgvStock.Rows[indice].Cells[2].Value).ToString();
                    txtStocki.Text = (dgvStock.Rows[indice].Cells[3].Value).ToString();
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
                if (txtDescripcion.Text == string.Empty || txtPrice.Text == string.Empty || txtStocki.Text == string.Empty)
                { 
                    MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        precio = float.Parse(txtPrice.Text);
                        stock = Convert.ToInt32(txtStocki.Text);
                        objProductoCLN.agregarProducto(codigoProducto, txtDescripcion.Text, precio, stock);
                    }
                    catch 
                    {
                        MessageBox.Show("Debe ingresar los tipos de datos correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Carga de producto cancelada");
            }
            LimpiarTextBoxs();
            cargarDgv();
        }
        //BOTON MODIFICAR
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == string.Empty || txtPrice.Text == string.Empty || txtStocki.Text == string.Empty)
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    stock = Convert.ToInt32(txtStocki.Text);
                    precio = float.Parse(txtPrice.Text);
                    objProductoCLN.actualizarProducto(Convert.ToInt32(dgvStock.Rows[indice].Cells[0].Value), txtDescripcion.Text, precio, stock);
                    MessageBox.Show("Los datos fueron actualizados");
                }
                catch
                {
                    MessageBox.Show("Debe ingresar los tipos de datos correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }   
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
            txtStocki.Clear();
            txtPrice.Clear();
        }

        //BOTON ELIMINAR
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Desea eliminar el producto?", "Eliminar producto", MessageBoxButtons.YesNo);

            if (opcion == DialogResult.Yes)
            {
                int idProducto = Convert.ToInt32(dgvStock.Rows[indice].Cells[0].Value);
                bool fueVendido = objProductoCLN.productoFueVendido(idProducto);
                if (fueVendido)
                {
                    MessageBox.Show("No se puede eliminar un producto que ya fue vendido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    objProductoCLN.eliminarProducto(idProducto);
                    MessageBox.Show("Se eliminó el producto correctamente", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                LimpiarTextBoxs();
                btnEliminar.Visible = false;
                btnPreEliminar.Visible = true;
                btnPreEliminar.Enabled = true;
                btnModificar.Enabled = true;
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
                    //vender carrito
                    float venta = objProductoCLN.venderProductos(idProductos, idEmpleado);
                    MessageBox.Show($"El total a pagar es {venta}", "Venta de producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch
                {
                    MessageBox.Show("Hubo un error, intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Operación cancelada", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            indiceCarrito = 0;
            for( int i=0; i<idProductos.Length; i++)
            {
                idProductos[i] = 0;
            }
            lblLista.Text = "";
            LimpiarTextBoxs();
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
        //BOTON AGREGAR CARRITO
        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            if (indiceCarrito < 5)
            {
                idProductos[indiceCarrito] = Convert.ToInt32(dgvStock.Rows[indice].Cells[0].Value);
                lblLista.Text += nombreProducto + " \n";
            }
            else
            {
                MessageBox.Show("Alcanzó la cantidad máxima del carrito");
            }
            indiceCarrito++;

            lblProductoCero.Text = idProductos[0].ToString();
            lblProductoUno.Text = idProductos[1].ToString();
            lblProductoDos.Text = idProductos[2].ToString();
            lblProductoTres.Text = idProductos[3].ToString();
            lblProductoCuatro.Text = idProductos[4].ToString();
        }

        //BOTON VACIAR CARRITO
        private void btnVaciar_Click(object sender, EventArgs e)
        {
            indiceCarrito = 0;
            for (int i = 0; i < idProductos.Length; i++)
            {
                idProductos[i] = 0;
            }
            lblLista.Text = "";
            cargarDgv();
        }

        //INTENTO DE AGREGAR AL CARRITO CON DOBLE CLICK FALLIDO...
        private void dgvStock_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //int indiceCarrito = 0;
            //lblLista.Text += dgvStock.Rows[indice].Cells[1].Value.ToString() + "\n";
            string[] listado = new string[5];
            int[] idProductos = new int[5];
        }
    }
}