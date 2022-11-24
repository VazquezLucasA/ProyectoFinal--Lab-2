using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class ProductoCAD
    {
        //miembros atributos
        private ConexionCAD objConexionCAD;
        private SqlDataReader leerTabla;
        private DataTable miTabla;
        private SqlCommand comando;

        public ProductoCAD()
        {
            objConexionCAD = new ConexionCAD();
            miTabla = new DataTable();
            comando = new SqlCommand();
        }

        public DataTable consultarProductos()
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            //comando.CommandText = "consultarProductos";
            //comando.CommandType = CommandType.StoredProcedure;

            comando.CommandText = "SELECT * FROM Producto";
            comando.CommandType = CommandType.Text;

            comando.Parameters.Clear();
            leerTabla = comando.ExecuteReader();
            miTabla.Load(leerTabla);
            objConexionCAD.cerrarConexion();
            return miTabla;
        }
        public string consultarUnProducto(int idProducto)
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "consultarUnProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idProducto", idProducto);
            leerTabla = comando.ExecuteReader();
            miTabla.Load(leerTabla);
            string resultado = miTabla.ToString();
            objConexionCAD.cerrarConexion();
            return resultado;
        }
        public void agregarProducto(int idProducto, string descripcion, int stock, float precio)
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "agregarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idProducto", idProducto);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }
        public void actualizarProducto(int idProducto, string descripcion, int stock, float precio)
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "actualizarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idProducto", idProducto);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }

        public void eliminarProducto(int idProducto)
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "eliminarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idProducto", idProducto);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }
    }
}
