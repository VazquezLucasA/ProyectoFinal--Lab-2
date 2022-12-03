using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaAccesoDatos;
using System.Data.SqlClient;

namespace CapaLogicaNegocio
{

    public class UsuarioCLN
    {
        private DataTable miTabla;
        private UsuarioCAD objUsuarioCAD;

        public UsuarioCLN()
        {
            miTabla = new DataTable();
            objUsuarioCAD = new UsuarioCAD();
        }
        public bool validarLogin(string usuario, string clave)
        {
            return objUsuarioCAD.validarLogin(usuario, clave);
        }
        public DataTable consultarUsuarios()
        {
            miTabla = objUsuarioCAD.consultarUsuarios();
            return miTabla;
        }



        //TESTEO
        public bool test()
        {
            SqlDataReader versianda = objUsuarioCAD.usuarioClave();
            if(versianda.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
