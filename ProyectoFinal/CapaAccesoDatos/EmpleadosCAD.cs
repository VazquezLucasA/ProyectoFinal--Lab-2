using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//LISTO

namespace CapaAccesoDatos
{
    public class EmpleadosCAD
    {
        //miembros atributos
        private ConexionCAD objConexionCAD;
        private SqlDataReader leerTabla;
        private DataTable miTabla;
        private SqlCommand comando;


        //metodos para el CRUD y constructor
        public EmpleadosCAD()
        {
            objConexionCAD = new ConexionCAD();
            miTabla = new DataTable();
            comando = new SqlCommand();
        }

        public DataTable consultarEmpleados()
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "consultarEmpleados";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            leerTabla = comando.ExecuteReader();
            miTabla.Load(leerTabla);

            objConexionCAD.cerrarConexion();
            return miTabla;
        }
        public void agregarEmpleado(int idEmpleado, string nombre, string apellido, string correo, int idSucursal)
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "agregarEmpleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idEmpleado", idEmpleado);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Parameters.AddWithValue("@idSucursal", idSucursal);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }
        public void actualizarEmpleado(int idEmpleado, string nombre, string apellido, string correo, int idSucursal)
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "actualizarEmpleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idEmpleado", idEmpleado);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Parameters.AddWithValue("@idSucursal", idSucursal);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }
        public void eliminarEmpleado(int idEmpleado)
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "eliminarEmpleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idEmpleado", idEmpleado);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }
        public DataTable consultarEmpleadosUnaSucursal(int idSucursal)
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "consultarEmpleadosUnaSucursal";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idSucursal", idSucursal);
            leerTabla = comando.ExecuteReader();
            miTabla.Load(leerTabla);

            objConexionCAD.cerrarConexion();
            return miTabla;
        }
    }
}
