using System;
using System.Data.SqlClient;
using System.Windows;
//listo
namespace CapaAccesoDatos
{
    public class ConexionCAD
    {
        //private string cadena;
        private string caden;
        private SqlConnection conectarDB;
        
        public ConexionCAD()
        {
            caden = "Data Source=DESKTOP-SHOETUK\\SQLEXPRESS;Initial Catalog=ProyectoFinalDB;Integrated Security=True";
            //cadena = "Data Source=DESKTOP-30DTIQQ\\MSSQLEXPRESS;Initial Catalog = Cuspide SA; User ID = sa; Password = 654321";
            conectarDB = new SqlConnection();
            conectarDB.ConnectionString = caden;
        }

        public SqlConnection abrirConeccion()
        {
            conectarDB.Open();
            return conectarDB;
        }
        public void cerrarConexion()
        {
            conectarDB.Close();
        }
    }
}