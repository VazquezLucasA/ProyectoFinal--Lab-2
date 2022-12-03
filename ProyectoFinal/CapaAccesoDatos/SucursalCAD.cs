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
            miTabla.Clear();
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "consultarSucursales";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            leerTabla = comando.ExecuteReader();
            miTabla.Load(leerTabla);
            objConexionCAD.cerrarConexion();
            return miTabla;
        }
        public void agregarSucursal(int idSucursal, string sucursal, string direccion)
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "agregarSucursal";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idSucursal", idSucursal);
            comando.Parameters.AddWithValue("@sucursal", sucursal);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }
        public void actualizarSucursal(int idSucursal, string sucursal, string direccion)
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "actualizarSucursal";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idSucursal", idSucursal);
            comando.Parameters.AddWithValue("@sucursal", sucursal);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }

        public void eliminarSucursal(int idSucursal)
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "eliminarSucursal";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idSucursal", idSucursal);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }
        public bool sucursalTieneEmpleado(int idSucursal)
        {
            bool valor;
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = $"select * from Empleado where idSucursal = {idSucursal} ";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idSucursal", idSucursal);
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
