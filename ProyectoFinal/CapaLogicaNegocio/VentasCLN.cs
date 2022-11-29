using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{

    public class VentasCLN
    {
        private DataTable miTabla;
        private VentasCAD objVentasCAD;

        public VentasCLN()
        {
            miTabla = new DataTable();
            objVentasCAD = new VentasCAD();
        }

        public DataTable consultarVentas()
        {
            miTabla = objVentasCAD.consultarVentas();
            return miTabla;
        }

        public void agregarVenta(int idVenta, float total, DateTime fechaVenta, int idEmpleado)
        {
            objVentasCAD.agregarVenta(idVenta, total, fechaVenta, idEmpleado);
        }

        public void eliminarVenta(int idVenta)
        {
            objVentasCAD.eliminarVenta(idVenta);
        }

        public void actualizarVenta(int idVenta, float total, DateTime fechaVenta, int idEmpleado)
        {
            objVentasCAD.actualizarVenta(idVenta, total, fechaVenta, idEmpleado);
        }

        public int getIndiceUltFila(int cantFilas)
        {
            return cantFilas - 2;
        }

        public int getCodigoVenta(object a)
        {
            int numero = Convert.ToInt32(a);
            int codigo = numero + 1;
            return codigo;
        }
        public DataTable consultarVentasUnEmpleado(int idEmpleado)
        {
            miTabla = objVentasCAD.consultarVentasUnEmpleado(idEmpleado);
            return miTabla;
        }
        public DataTable consultarVentasUnaSucursal(int idSucursal)
        {
            miTabla = objVentasCAD.consultarVentasUnaSucursal(idSucursal);
            return miTabla;
        }
        public DataTable consultaVentasTodas()
        {
            miTabla = objVentasCAD.consultaVentasTodas();
            return miTabla;
        }

    }
}
