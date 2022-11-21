using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    internal class ProductoCAD
    {
        //miembros atributos
        private ConexionDB objConexionCAD;
        private SqlDataReader leerTabla;
        private DataTable miTabla;
        private SqlCommand comando;

        //metodos para el CRUD y constructor

        public ProductoCAD()
        {
            objConexionCAD = new ConexionDB();
            miTabla = new DataTable();
            comando = new SqlCommand();
        }

        public DataTable consultarProductos()
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "consultarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            leerTabla = comando.ExecuteReader();
            miTabla.Load(leerTabla);
            objConexionCAD.cerrarConexion();
            return miTabla;
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

        public void eliminarGenero(int idProducto)
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
