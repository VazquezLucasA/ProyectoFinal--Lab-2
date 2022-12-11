using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//listo
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
            comando.CommandText = "consultarProductos";
            comando.CommandType = CommandType.StoredProcedure;
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
        public void agregarProducto(int idProducto, string descripcion, float precio, int stock)
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "agregarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idProducto", idProducto);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }
        public void actualizarProducto(int idProducto, string descripcion, float precio, int stock)
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "actualizarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idProducto", idProducto);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@stock", stock);
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

        public void venderProducto(int idProducto) 
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "venderUnProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idProducto", idProducto);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }

        public int getPrecio(int idProducto)
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = $"select precio from Producto where idProducto = {idProducto}";
            comando.CommandType = CommandType.Text;
            //comando.CommandText = "getPrecio";
            //comando.CommandType = CommandType.StoredProcedure;
            //comando.Parameters.AddWithValue("@idProducto", idProducto);
            comando.Parameters.Clear();
            object objPrecio = comando.ExecuteScalar();
            objConexionCAD.cerrarConexion();
            int precio = Convert.ToInt32(objPrecio);
            return precio;
        }
        public bool productoFueVendido(int idProducto)
        {
            bool valor;
            comando.Connection = objConexionCAD.abrirConeccion();
            //comando.CommandText = $"select * from DetalleVenta where idProducto = {idProducto} ";
            //comando.CommandType = CommandType.Text;
            comando.CommandText = "productoFueVendido";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idProducto", idProducto);
            leerTabla = comando.ExecuteReader();
            if (leerTabla.HasRows)
            {
                valor = true;
            }
            else
            {
                valor = false;
            }
            objConexionCAD.cerrarConexion();
            return valor;
        }
    }
}
