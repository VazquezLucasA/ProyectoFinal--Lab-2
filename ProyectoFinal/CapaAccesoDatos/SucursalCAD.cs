using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class SucursalCAD
    {
        //miembros atributos
        private ConexionCAD objConexionCAD;
        private SqlDataReader leerTabla;
        private DataTable miTabla;
        private SqlCommand comando;

        public SucursalCAD()
        {
            objConexionCAD = new ConexionCAD();
            miTabla = new DataTable();
            comando = new SqlCommand();
        }

        public DataTable consultarSucursales()
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "consultarSucursales";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            leerTabla = comando.ExecuteReader();
            miTabla.Load(leerTabla);
            objConexionCAD.cerrarConexion();
            return miTabla;
        }
        public void agregarSucursal(int idProducto, string descripcion, int stock, float precio)
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "agregarVenta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idProducto", idProducto);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }
        public void actualizarSucursal(int idProducto, string descripcion, int stock, float precio)
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

        public void eliminarSucursal(int idProducto)
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
