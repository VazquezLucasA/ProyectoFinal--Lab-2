using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoFinal.DAL
{   
    internal class ConexionDAL
    {
        
        public bool Conectar()
        {
            try {
                SqlConnection conexion = new SqlConnection("");
                conexion.Open();
            } 
            catch{ 
            }
            return true;
        }
    }
}
