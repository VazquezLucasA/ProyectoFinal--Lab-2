using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public class EmpleadosCLN
    {
        private DataTable miTabla;
        private EmpleadosCAD objEmpleadosCAD;

        public EmpleadosCLN()
        {
            miTabla = new DataTable();
            objEmpleadosCAD = new EmpleadosCAD();
        }

        public DataTable consultarEmpleados()
        {
            miTabla = objEmpleadosCAD.consultarEmpleados();
            return miTabla;
        }

        public void agregarEmpleado(int idEmpleado, string nombre, string apellido, string correo, int idSucursal)
        {
            objEmpleadosCAD.agregarEmpleado(idEmpleado, nombre, apellido, correo, idSucursal);
        }

        public void eliminarEmpleado(int idEmpleado)
        {
            objEmpleadosCAD.eliminarEmpleado(idEmpleado);
        }

        public void actualizarEmpleado(int idEmpleado, string nombre, string apellido, string correo, int idSucursal)
        {
            objEmpleadosCAD.actualizarEmpleado(idEmpleado, nombre, apellido, correo, idSucursal);
        }

        public int getIndiceUltFila(int cantFilas)
        {
            return cantFilas - 2;
        }

        public int getCodigoEmpleado(object a)
        {
            int numero = Convert.ToInt32(a);
            int codigo = numero + 1;
            return codigo;
        }
    }

}