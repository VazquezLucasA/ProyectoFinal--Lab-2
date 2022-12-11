using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class DetalleCAD
    {
        //miembros atributos
        private ConexionCAD objConexionCAD;
        private SqlDataReader leerTabla;
        private DataTable miTabla;
        private SqlCommand comando;


        //metodos para el CRUD y constructor
        public DetalleCAD()
        {
            objConexionCAD = new ConexionCAD();
            miTabla = new DataTable();
            comando = new SqlCommand();
        }

        public DataTable consultarDetalles(int idVenta)
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "consultarDetalles";
            comando.CommandType = CommandType.StoredProcedure;
            //comando.CommandText = $"Select descripcion, cantidad, precio from DetalleVenta inner join Producto on DetalleVenta.idProducto = Producto.idProducto where idVenta = {idVenta}";
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idVenta", idVenta);
            leerTabla = comando.ExecuteReader();
            miTabla.Load(leerTabla);

            objConexionCAD.cerrarConexion();
            return miTabla;
        }
        public void agregarDetalles(int idDetalle, int idProducto, int cantidad, int idVenta)
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "agregarDetalle";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idDetalle", idDetalle);
            comando.Parameters.AddWithValue("@idProducto", idProducto);
            comando.Parameters.AddWithValue("@cantidad", cantidad);
            comando.Parameters.AddWithValue("@idVenta", idVenta);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }
        public int getIdDetalle()
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "select top 1 idDetalle from DetalleVenta order by idDetalle desc";
            comando.CommandType = CommandType.Text;
            //comando.CommandText = "getIdDetalle";
            //comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            object objIdDetalle = comando.ExecuteScalar();
            objConexionCAD.cerrarConexion();
            int idDetalle = Convert.ToInt32(objIdDetalle);
            return idDetalle;
        }

}
}
