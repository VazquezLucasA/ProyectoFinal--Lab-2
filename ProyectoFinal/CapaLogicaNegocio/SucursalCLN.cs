using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public class SucursalCLN
    {
        private DataTable miTabla;
        private SucursalCAD objSucursalCAD;

        public SucursalCLN()
        {
            miTabla = new DataTable();
            objSucursalCAD = new SucursalCAD();
        }

        public DataTable consultarSucursales()
        {
            miTabla.Clear();
            miTabla = objSucursalCAD.consultarSucursales();
            return miTabla;
        }

        public void agregarSucursal(int idSucursal, string sucursal, string direccion)
        {
            idSucursal++;
            objSucursalCAD.agregarSucursal(idSucursal, sucursal, direccion);
        }

        public void eliminarSucursal(int idSucursal)
        {
            objSucursalCAD.eliminarSucursal(idSucursal);
        }

        public void actualizarSucursal(int idSucursal, string nombre, string direccion)
        {
            objSucursalCAD.actualizarSucursal(idSucursal, nombre, direccion);
        }

        public int getIndiceUltFila(int cantFilas)
        {
            return cantFilas - 2;
        }

        public int getCodigoSucursal(object a)
        {
            int numero = Convert.ToInt32(a);
            int codigo = numero + 1;
            return codigo;
        }
        public bool sucursalTieneEmpleado(int idSucursal)
        {
            bool valor = objSucursalCAD.sucursalTieneEmpleado(idSucursal);
            return valor;
        }
    }
}
