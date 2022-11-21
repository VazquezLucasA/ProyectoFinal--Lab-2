using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaAccesoDatos
{
    public class ConexionDB
    {
        private string cadena;
        private string caden;
        private SqlConnection conectarDB;

        public ConexionDB()
        {
            caden = "Data Source=DESKTOP-SHOETUK\\SQLEXPRESS;Initial Catalog=ProyectoFinalDB;Integrated Security=True";
            cadena = "Data Source=DESKTOP-30DTIQQ\\MSSQLEXPRESS;Initial Catalog = Cuspide SA; User ID = sa; Password = 654321";
            conectarDB = new SqlConnection();
            conectarDB.ConnectionString = caden;
        }

        public SqlConnection abrirConeccion()
        {
            try
            {
                conectarDB.Open();
                MessageBox.Show("La conexión está abierta");
                return conectarDB;
            }
            catch (Exception ex)
            {
                MessageBox.Show("La conexión no se pudo abrir" + ex.Message);
                return conectarDB;
            }
        }
        public void cerrarConexion()
        {
            conectarDB.Close();
        }
    }
}
