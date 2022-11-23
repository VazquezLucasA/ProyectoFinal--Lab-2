namespace ProyectoFinal
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
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnVender = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnPreEliminar = new System.Windows.Forms.Button();
            this.btnAgregarCarrito = new System.Windows.Forms.Button();
            this.lblLista = new System.Windows.Forms.Label();
            this.lblCantFilas = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStock
            // 
            this.dgvStock.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(12, 152);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowTemplate.Height = 25;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(567, 286);
            this.dgvStock.TabIndex = 0;
            this.dgvStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 123);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(116, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar producto";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(174, 123);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(312, 123);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(1, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(572, 114);
            this.picLogo.TabIndex = 5;
            this.picLogo.TabStop = false;
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(608, 390);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(169, 48);
            this.btnVender.TabIndex = 6;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(646, 20);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 23);
            this.txtDescripcion.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(646, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(646, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Stock";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(646, 64);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 23);
            this.txtStock.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(646, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(646, 108);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 23);
            this.txtPrecio.TabIndex = 11;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(646, 137);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 38);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnPreEliminar
            // 
            this.btnPreEliminar.Location = new System.Drawing.Point(293, 123);
            this.btnPreEliminar.Name = "btnPreEliminar";
            this.btnPreEliminar.Size = new System.Drawing.Size(118, 23);
            this.btnPreEliminar.TabIndex = 15;
            this.btnPreEliminar.Text = "Habilitar Eliminar";
            this.btnPreEliminar.UseVisualStyleBackColor = true;
            this.btnPreEliminar.Click += new System.EventHandler(this.btnPreEliminar_Click);
            // 
            // btnAgregarCarrito
            // 
            this.btnAgregarCarrito.Location = new System.Drawing.Point(608, 194);
            this.btnAgregarCarrito.Name = "btnAgregarCarrito";
            this.btnAgregarCarrito.Size = new System.Drawing.Size(138, 48);
            this.btnAgregarCarrito.TabIndex = 16;
            this.btnAgregarCarrito.Text = "Agregar al carrito";
            this.btnAgregarCarrito.UseVisualStyleBackColor = true;
            this.btnAgregarCarrito.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Location = new System.Drawing.Point(662, 252);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(38, 15);
            this.lblLista.TabIndex = 17;
            this.lblLista.Text = "label4";
            // 
            // lblCantFilas
            // 
            this.lblCantFilas.AutoSize = true;
            this.lblCantFilas.Location = new System.Drawing.Point(662, 304);
            this.lblCantFilas.Name = "lblCantFilas";
            this.lblCantFilas.Size = new System.Drawing.Size(38, 15);
            this.lblCantFilas.TabIndex = 18;
            this.lblCantFilas.Text = "label4";
            this.lblCantFilas.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(662, 343);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(38, 15);
            this.lblCodigo.TabIndex = 19;
            this.lblCodigo.Text = "label4";
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblCantFilas);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.btnAgregarCarrito);
            this.Controls.Add(this.btnPreEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvStock);
            this.Name = "frmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paco Garcia";
            this.Load += new System.EventHandler(this.frmPacoGarcia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvStock;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private PictureBox picLogo;
        private Button btnVender;
        private TextBox txtDescripcion;
        private Label label1;
        private Label label2;
        private TextBox txtStock;
        private Label label3;
        private TextBox txtPrecio;
        private Button btnLimpiar;
        private Button btnPreEliminar;
        private Button btnAgregarCarrito;
        private Label lblLista;
        private Label lblCantFilas;
        private Label lblCodigo;
    }
}