namespace WinFormsApp1
{
    partial class frmProductos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            this.lblProductoCero = new System.Windows.Forms.Label();
            this.lblProductoTres = new System.Windows.Forms.Label();
            this.lblLista = new System.Windows.Forms.Label();
            this.btnAgregarCarrito = new System.Windows.Forms.Button();
            this.btnPreEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtStocki = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDescrip = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnVender = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblProductoUno = new System.Windows.Forms.Label();
            this.lblProductoCuatro = new System.Windows.Forms.Label();
            this.lblProductoDos = new System.Windows.Forms.Label();
            this.btnVaciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductoCero
            // 
            this.lblProductoCero.AutoSize = true;
            this.lblProductoCero.Location = new System.Drawing.Point(633, 9);
            this.lblProductoCero.Name = "lblProductoCero";
            this.lblProductoCero.Size = new System.Drawing.Size(32, 15);
            this.lblProductoCero.TabIndex = 37;
            this.lblProductoCero.Text = "label";
            // 
            // lblProductoTres
            // 
            this.lblProductoTres.AutoSize = true;
            this.lblProductoTres.Location = new System.Drawing.Point(633, 35);
            this.lblProductoTres.Name = "lblProductoTres";
            this.lblProductoTres.Size = new System.Drawing.Size(38, 15);
            this.lblProductoTres.TabIndex = 36;
            this.lblProductoTres.Text = "label4";
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Location = new System.Drawing.Point(687, 316);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(13, 15);
            this.lblLista.TabIndex = 35;
            this.lblLista.Text = "1";
            // 
            // btnAgregarCarrito
            // 
            this.btnAgregarCarrito.Location = new System.Drawing.Point(633, 245);
            this.btnAgregarCarrito.Name = "btnAgregarCarrito";
            this.btnAgregarCarrito.Size = new System.Drawing.Size(96, 48);
            this.btnAgregarCarrito.TabIndex = 34;
            this.btnAgregarCarrito.Text = "Agregar al carrito";
            this.btnAgregarCarrito.UseVisualStyleBackColor = true;
            this.btnAgregarCarrito.Click += new System.EventHandler(this.btnAgregarCarrito_Click);
            // 
            // btnPreEliminar
            // 
            this.btnPreEliminar.Location = new System.Drawing.Point(313, 175);
            this.btnPreEliminar.Name = "btnPreEliminar";
            this.btnPreEliminar.Size = new System.Drawing.Size(118, 23);
            this.btnPreEliminar.TabIndex = 5;
            this.btnPreEliminar.Text = "Habilitar Eliminar";
            this.btnPreEliminar.UseVisualStyleBackColor = true;
            this.btnPreEliminar.Click += new System.EventHandler(this.btnPreEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(671, 201);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 38);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(671, 154);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 15);
            this.lblPrecio.TabIndex = 31;
            this.lblPrecio.Text = "Precio";
            // 
            // txtStocki
            // 
            this.txtStocki.Location = new System.Drawing.Point(671, 128);
            this.txtStocki.Name = "txtStocki";
            this.txtStocki.Size = new System.Drawing.Size(100, 23);
            this.txtStocki.TabIndex = 2;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(671, 110);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(36, 15);
            this.lblStock.TabIndex = 29;
            this.lblStock.Text = "Stock";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(671, 172);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 23);
            this.txtPrice.TabIndex = 1;
            // 
            // txtDescrip
            // 
            this.txtDescrip.AutoSize = true;
            this.txtDescrip.Location = new System.Drawing.Point(671, 66);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(69, 15);
            this.txtDescrip.TabIndex = 27;
            this.txtDescrip.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(671, 84);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 23);
            this.txtDescripcion.TabIndex = 0;
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(633, 442);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(169, 48);
            this.btnVender.TabIndex = 7;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(26, 52);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(572, 114);
            this.picLogo.TabIndex = 24;
            this.picLogo.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(337, 175);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(199, 175);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(37, 175);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(116, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar producto";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStock.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(37, 204);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowTemplate.Height = 25;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(567, 286);
            this.dgvStock.TabIndex = 20;
            this.dgvStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellClick_1);
            this.dgvStock.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellContentDoubleClick);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBienvenida.Location = new System.Drawing.Point(160, 9);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(114, 28);
            this.lblBienvenida.TabIndex = 54;
            this.lblBienvenida.Text = "Bienvenido ";
            // 
            // lblProductoUno
            // 
            this.lblProductoUno.AutoSize = true;
            this.lblProductoUno.Location = new System.Drawing.Point(679, 9);
            this.lblProductoUno.Name = "lblProductoUno";
            this.lblProductoUno.Size = new System.Drawing.Size(32, 15);
            this.lblProductoUno.TabIndex = 55;
            this.lblProductoUno.Text = "label";
            // 
            // lblProductoCuatro
            // 
            this.lblProductoCuatro.AutoSize = true;
            this.lblProductoCuatro.Location = new System.Drawing.Point(679, 35);
            this.lblProductoCuatro.Name = "lblProductoCuatro";
            this.lblProductoCuatro.Size = new System.Drawing.Size(32, 15);
            this.lblProductoCuatro.TabIndex = 56;
            this.lblProductoCuatro.Text = "label";
            // 
            // lblProductoDos
            // 
            this.lblProductoDos.AutoSize = true;
            this.lblProductoDos.Location = new System.Drawing.Point(717, 9);
            this.lblProductoDos.Name = "lblProductoDos";
            this.lblProductoDos.Size = new System.Drawing.Size(32, 15);
            this.lblProductoDos.TabIndex = 57;
            this.lblProductoDos.Text = "label";
            // 
            // btnVaciar
            // 
            this.btnVaciar.Location = new System.Drawing.Point(735, 245);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(81, 48);
            this.btnVaciar.TabIndex = 58;
            this.btnVaciar.Text = "Vaciar carrito";
            this.btnVaciar.UseVisualStyleBackColor = true;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 543);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.lblProductoDos);
            this.Controls.Add(this.lblProductoCuatro);
            this.Controls.Add(this.lblProductoUno);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.lblProductoCero);
            this.Controls.Add(this.lblProductoTres);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.btnAgregarCarrito);
            this.Controls.Add(this.btnPreEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtStocki);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvStock);
            this.Name = "frmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblProductoCero;
        private Label lblProductoTres;
        private Label lblLista;
        private Button btnAgregarCarrito;
        private Button btnPreEliminar;
        private Button btnLimpiar;
        private Label lblPrecio;
        private TextBox txtStocki;
        private Label lblStock;
        private TextBox txtPrice;
        private Label txtDescrip;
        private TextBox txtDescripcion;
        private Button btnVender;
        private PictureBox picLogo;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private DataGridView dgvStock;
        private Label lblBienvenida;
        private Label lblProductoUno;
        private Label lblProductoCuatro;
        private Label lblProductoDos;
        private Button btnVaciar;
    }
}