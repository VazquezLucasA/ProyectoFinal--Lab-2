namespace CapaPresentacion
{
    partial class frmPresentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPresentacion));
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnSucursal = new System.Windows.Forms.Button();
            this.cbxSucursal = new System.Windows.Forms.ComboBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Location = new System.Drawing.Point(300, 310);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(111, 100);
            this.btnEmpleados.TabIndex = 19;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSucursal
            // 
            this.btnSucursal.Location = new System.Drawing.Point(109, 310);
            this.btnSucursal.Name = "btnSucursal";
            this.btnSucursal.Size = new System.Drawing.Size(111, 100);
            this.btnSucursal.TabIndex = 18;
            this.btnSucursal.Text = "Sucursal";
            this.btnSucursal.UseVisualStyleBackColor = true;
            this.btnSucursal.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbxSucursal
            // 
            this.cbxSucursal.FormattingEnabled = true;
            this.cbxSucursal.Location = new System.Drawing.Point(535, 240);
            this.cbxSucursal.Name = "cbxSucursal";
            this.cbxSucursal.Size = new System.Drawing.Size(156, 23);
            this.cbxSucursal.TabIndex = 17;
            this.cbxSucursal.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(557, 310);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(111, 100);
            this.btnIngresar.TabIndex = 16;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(548, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "SELECCIONE SUCURSAL";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Location = new System.Drawing.Point(371, 178);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(74, 15);
            this.lblBienvenido.TabIndex = 14;
            this.lblBienvenido.Text = "BIENVENIDO";
            this.lblBienvenido.Click += new System.EventHandler(this.label1_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(109, 41);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(572, 114);
            this.picLogo.TabIndex = 13;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.btnSucursal);
            this.Controls.Add(this.cbxSucursal);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.picLogo);
            this.Name = "frmPresentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPresentacion";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEmpleados;
        private Button btnSucursal;
        private ComboBox cbxSucursal;
        private Button btnIngresar;
        private Label label2;
        private Label lblBienvenido;
        private PictureBox picLogo;
    }
}