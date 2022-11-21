using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    internal class EmpleadoCAD
    {
        //miembros atributos
        private ConexionDB objConexionCAD;
        private SqlDataReader leerTabla;
        private DataTable miTabla;
        private SqlCommand comando;


        //metodos para el CRUD y constructor
        public EmpleadoCAD()
        {
            objConexionCAD = new ConexionDB();
            miTabla = new DataTable();
            comando = new SqlCommand();
        }

        public DataTable constularEmpleados()
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
        public DataTable agregarEmpleado()
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "agregarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            leerTabla = comando.ExecuteReader();
            miTabla.Load(leerTabla);

            objConexionCAD.cerrarConexion();
            return miTabla;
        }
        public DataTable modificarEmpleado()
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
        public DataTable eliminarEmpleado()
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
    }
}
