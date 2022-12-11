using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class VentasCAD
    {
        //miembros atributos
        private ConexionCAD objConexionCAD;
        private SqlDataReader leerTabla;
        private DataTable miTabla;
        private SqlCommand comando;

        public VentasCAD()
        {
            objConexionCAD = new ConexionCAD();
            miTabla = new DataTable();
            comando = new SqlCommand();
        }

        public DataTable consultarVentas()
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "consultarVentas";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            leerTabla = comando.ExecuteReader();
            miTabla.Load(leerTabla);
            objConexionCAD.cerrarConexion();
            return miTabla;
        }
        public DataTable consultarVentasUnEmpleado(int idEmpleado)
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "consultarVentasUnEmpleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idEmpleado", idEmpleado);
            leerTabla = comando.ExecuteReader();
            miTabla.Load(leerTabla);
            objConexionCAD.cerrarConexion();
            return miTabla;
        }
        public DataTable consultarVentasUnaSucursal(int idSucursal)
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "consultarVentasUnaSucursal";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idSucursal", idSucursal);
            leerTabla = comando.ExecuteReader();
            miTabla.Load(leerTabla);
            objConexionCAD.cerrarConexion();
            return miTabla;
        }
        public DataTable consultaVentasTodas()
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "consultaVentasTodas";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            leerTabla = comando.ExecuteReader();
            miTabla.Load(leerTabla);
            objConexionCAD.cerrarConexion();
            return miTabla;
        }
        public void agregarVenta(int idVenta,float total, DateTime fecha, int idEmpleado)
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "agregarVenta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idVenta", idVenta);
            comando.Parameters.AddWithValue("@total", total);
            comando.Parameters.AddWithValue("@fechaVenta", fecha); 
            comando.Parameters.AddWithValue("@idEmpleado", idEmpleado);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }
        public void actualizarVenta(int idVenta, float total, DateTime fecha, int idEmpleado)
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "actualizarVenta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idVenta", idVenta);
            comando.Parameters.AddWithValue("@total", total);
            comando.Parameters.AddWithValue("@fechaVenta", fecha);
            comando.Parameters.AddWithValue("@idEmpleado", idEmpleado);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }

        public void eliminarVenta(int idVenta)
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "eliminarVenta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idVenta", idVenta);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }
        
        //BORRAR ELIMINAR Y ACTUALIZAR VENTA
        public int getIdVenta()
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "select top 1 idVenta from Venta order by idVenta desc";
            comando.CommandType = CommandType.Text;
            //comando.CommandText = "getIdVenta";
            //comando.CommandType = CommandType.Text;
            comando.Parameters.Clear();
            object objIdVenta = comando.ExecuteScalar();
            objConexionCAD.cerrarConexion();
            int idVenta = Convert.ToInt32(objIdVenta);
            return idVenta;
        }

    }
}



