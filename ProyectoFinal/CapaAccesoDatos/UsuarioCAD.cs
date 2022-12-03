using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class UsuarioCAD
    {
        private ConexionCAD objConexionCAD;
        private SqlDataReader leerTabla;
        private DataTable miTabla;
        private SqlCommand comando;

        public UsuarioCAD()
        {
            objConexionCAD = new ConexionCAD();
            miTabla = new DataTable();
            comando = new SqlCommand();
        }

        public DataTable consultarUsuarios()
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "consultarUsuarios";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            leerTabla = comando.ExecuteReader();
            miTabla.Load(leerTabla);
            objConexionCAD.cerrarConexion();
            return miTabla;
        }
       public bool consultarUnaClave(int idUsuario, string clave)
        {
            bool bandera = false;
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "recuperarClave";
            //comando.CommandText = "verificarLogin";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idUsuario", idUsuario);
            comando.Parameters.AddWithValue("@contraseña", clave);
            leerTabla = comando.ExecuteReader();
            if (leerTabla.HasRows)
            {
                bandera = true;
            }
            else
            {
                bandera = false;
            }
            objConexionCAD.cerrarConexion();
            return bandera;
        }
        public bool validarLogin(string usuario, string contraseña)
        {
            bool bandera = false;
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "validarLogin";
            comando.CommandType = CommandType.StoredProcedure;
            //comando.CommandText = $"select * from usuario where nombre = '{usuario}' and contraseña = '{contraseña}'";
            //comando.CommandType = CommandType.Text;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@nombre", usuario);
            comando.Parameters.AddWithValue("@contraseña", contraseña);
            leerTabla = comando.ExecuteReader();
            if (leerTabla.HasRows)
            {
                bandera = true;
            }
            else
            {
                bandera = false;
            }
            objConexionCAD.cerrarConexion();
            return bandera;
        }


        //TEST SI ANDA
        public SqlDataReader usuarioClave()
        {

            return leerTabla;
        }
    }
}
