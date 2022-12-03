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
    public partial class frmUsuario : Form
    {
        private UsuarioCLN objUsuarioCLN;
        private frmMenu frmMenuInicio;
        public frmUsuario()
        {
            InitializeComponent();
            objUsuarioCLN= new UsuarioCLN();
            frmMenuInicio = new frmMenu();
            llenarCboUsuario();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            int idUsuario = Convert.ToInt32(cboUsuarios.SelectedValue);
            string usuario = txtUsuario.Text;
            string clave = txtContraseña.Text;
            bandera = objUsuarioCLN.validarLogin(usuario, clave);
            if (bandera)
            {
                MessageBox.Show("Contraseña correcta. Ingresando...");
                this.Hide();
                frmMenuInicio.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta. Contacte al administrador.");
                cboUsuarios.SelectedIndex = 0;
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.UseSystemPasswordChar = false;

            }

        }
        private void llenarCboUsuario()
        {
            //cboUsuarios
            DataTable miTabla = new DataTable();
            miTabla.Clear();
            miTabla = objUsuarioCLN.consultarUsuarios();
            cboUsuarios.DataSource = miTabla;
            cboUsuarios.ValueMember = "idUsuario";
            cboUsuarios.DisplayMember = "nombre";
            cboUsuarios.SelectedIndex = 0;
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if(txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Red;
                txtContraseña.UseSystemPasswordChar= true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Red;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

    }
}
