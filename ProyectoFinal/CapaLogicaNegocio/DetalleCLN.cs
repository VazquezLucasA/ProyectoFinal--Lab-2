using CapaAccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class DetalleCLN
    {
        private DataTable miTabla;
        private DetalleCAD objDetalleCAD;

        public DetalleCLN()
        {
            miTabla = new DataTable();
            objDetalleCAD = new DetalleCAD();
        }

        public DataTable consultarDetalles(int idVenta)
        {
            miTabla.Clear();
            miTabla = objDetalleCAD.consultarDetalles(idVenta);
            return miTabla;
        }
    }
}
