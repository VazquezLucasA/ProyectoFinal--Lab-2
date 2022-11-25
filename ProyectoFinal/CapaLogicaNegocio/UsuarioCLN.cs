using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaAccesoDatos;

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
        

       
    }
}
