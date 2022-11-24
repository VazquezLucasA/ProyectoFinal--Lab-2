using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public DataTable constularEmpleados()
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
        public DataTable agregarEmpleado()
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "agregarEmpleado";
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
            comando.CommandText = "modificarEmpleado";
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
            comando.CommandText = "eliminarEmpleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            leerTabla = comando.ExecuteReader();
            miTabla.Load(leerTabla);
            objConexionCAD.cerrarConexion();
            return miTabla;
        }
    }
}
