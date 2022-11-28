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
        private DetalleCLN objDetalleCAD;

        public DetalleCLN()
        {
            miTabla = new DataTable();
            objDetalleCAD = new DetalleCLN();
        }

        public DataTable consultarEmpleados()
        {
            miTabla.Clear();
            miTabla = objDetalleCAD.consultar();
            return miTabla;
        }
    }
}
