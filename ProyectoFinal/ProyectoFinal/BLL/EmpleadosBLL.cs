using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.BLL
{
    internal class EmpleadosBLL
    {
        public int ID { get; set; }
        public string nombreEmpleado { get; set; }
        public string apellido { get; set; }
        public string correo { get; set; }
        public int sucursal { get; set; }
        public byte[] fotoEmpleado { get; set; }
    }
}
