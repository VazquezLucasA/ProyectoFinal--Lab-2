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
        private int idVenta;


        //metodos para el CRUD y constructor
        public DetalleCAD(int idVenta)
        {
            objConexionCAD = new ConexionCAD();
            miTabla = new DataTable();
            comando = new SqlCommand();
            this.idVenta = idVenta; 
        }

        public DataTable consultarDetalles(int idVenta)
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            //comando.CommandText = "consultarDetalles";
            //comando.CommandType = CommandType.StoredProcedure;}
            comando.CommandText = $"Select producto, cantidad from DetalleVenta inner join Producto on DetalleVenta.idProducto = Producto.idProducto where idVenta = {idVenta}";
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idVenta", idVenta);
            leerTabla = comando.ExecuteReader();
            miTabla.Load(leerTabla);

            objConexionCAD.cerrarConexion();
            return miTabla;
        }
    }
}
