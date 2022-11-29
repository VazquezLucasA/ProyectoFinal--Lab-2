namespace CapaPresentacion
{
    partial class frmVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.lblReporte = new System.Windows.Forms.Label();
            this.cboSucursal = new System.Windows.Forms.ComboBox();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.cboEmpleados = new System.Windows.Forms.ComboBox();
            this.chkSucursal = new System.Windows.Forms.CheckBox();
            this.chkEmpleados = new System.Windows.Forms.CheckBox();
            this.btnDetalles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(610, 181);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(169, 48);
            this.btnBuscar.TabIndex = 43;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(7, 39);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(572, 114);
            this.picLogo.TabIndex = 42;
            this.picLogo.TabStop = false;
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(12, 181);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.RowTemplate.Height = 25;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(567, 306);
            this.dgvVentas.TabIndex = 38;
            this.dgvVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellClick);
            // 
            // lblReporte
            // 
            this.lblReporte.AutoSize = true;
            this.lblReporte.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReporte.Location = new System.Drawing.Point(231, 9);
            this.lblReporte.Name = "lblReporte";
            this.lblReporte.Size = new System.Drawing.Size(333, 46);
            this.lblReporte.TabIndex = 53;
            this.lblReporte.Text = "REPORTE DE VENTAS";
            // 
            // cboSucursal
            // 
            this.cboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSucursal.FormattingEnabled = true;
            this.cboSucursal.Location = new System.Drawing.Point(608, 85);
            this.cboSucursal.Name = "cboSucursal";
            this.cboSucursal.Size = new System.Drawing.Size(121, 23);
            this.cboSucursal.TabIndex = 55;
            this.cboSucursal.SelectedIndexChanged += new System.EventHandler(this.cboSucursal_SelectedIndexChanged);
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Location = new System.Drawing.Point(608, 67);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(64, 15);
            this.lblSucursal.TabIndex = 56;
            this.lblSucursal.Text = "SUCURSAL";
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.Location = new System.Drawing.Point(608, 111);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(74, 15);
            this.lblEmpleados.TabIndex = 57;
            this.lblEmpleados.Text = "EMPLEADOS";
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Location = new System.Drawing.Point(610, 43);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(119, 15);
            this.lblSeleccion.TabIndex = 58;
            this.lblSeleccion.Text = "SELECCIONE FILTROS";
            // 
            // cboEmpleados
            // 
            this.cboEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpleados.FormattingEnabled = true;
            this.cboEmpleados.Location = new System.Drawing.Point(608, 129);
            this.cboEmpleados.Name = "cboEmpleados";
            this.cboEmpleados.Size = new System.Drawing.Size(121, 23);
            this.cboEmpleados.TabIndex = 59;
            // 
            // chkSucursal
            // 
            this.chkSucursal.AutoSize = true;
            this.chkSucursal.Location = new System.Drawing.Point(735, 87);
            this.chkSucursal.Name = "chkSucursal";
            this.chkSucursal.Size = new System.Drawing.Size(56, 19);
            this.chkSucursal.TabIndex = 62;
            this.chkSucursal.Text = "Todas";
            this.chkSucursal.UseVisualStyleBackColor = true;
            this.chkSucursal.CheckedChanged += new System.EventHandler(this.chkSucursal_CheckedChanged);
            // 
            // chkEmpleados
            // 
            this.chkEmpleados.AutoSize = true;
            this.chkEmpleados.Location = new System.Drawing.Point(735, 129);
            this.chkEmpleados.Name = "chkEmpleados";
            this.chkEmpleados.Size = new System.Drawing.Size(57, 19);
            this.chkEmpleados.TabIndex = 63;
            this.chkEmpleados.Text = "Todos";
            this.chkEmpleados.UseVisualStyleBackColor = true;
            this.chkEmpleados.CheckedChanged += new System.EventHandler(this.chkEmpleados_CheckedChanged);
            // 
            // btnDetalles
            // 
            this.btnDetalles.Location = new System.Drawing.Point(631, 439);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(133, 48);
            this.btnDetalles.TabIndex = 64;
            this.btnDetalles.Text = "Detalle";
            this.btnDetalles.UseVisualStyleBackColor = true;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 511);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.chkEmpleados);
            this.Controls.Add(this.chkSucursal);
            this.Controls.Add(this.cboEmpleados);
            this.Controls.Add(this.lblSeleccion);
            this.Controls.Add(this.lblEmpleados);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.cboSucursal);
            this.Controls.Add(this.lblReporte);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.dgvVentas);
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de ventas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnBuscar;
        private PictureBox picLogo;
        private DataGridView dgvVentas;
        private Label lblReporte;
        private ComboBox cboSucursal;
        private Label lblSucursal;
        private Label lblEmpleados;
        private Label lblSeleccion;
        private ComboBox cboEmpleados;
        private CheckBox chkSucursal;
        private CheckBox chkEmpleados;
        private Button btnDetalles;
    }
}