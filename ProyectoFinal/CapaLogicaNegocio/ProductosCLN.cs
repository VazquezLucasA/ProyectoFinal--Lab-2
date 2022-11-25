using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public class ProductoCLN
    {
        //miembros atributos
        private DataTable miTabla;
        private ProductoCAD objProductoCAD;
        
        //miembros metodos
        public ProductoCLN()
        {
            miTabla = new DataTable();
            objProductoCAD = new ProductoCAD();
        }
        public DataTable consultarProductos()
        {
            miTabla = objProductoCAD.consultarProductos();
            return miTabla;
        }
        public void agregarProducto(int idProducto, string descripcion, int stock, float precio)
        {
            idProducto++;
            objProductoCAD.agregarProducto(idProducto, descripcion, stock, precio);
        }
        public void actualizarProducto(int idProducto, string descripcion, int stock, float precio)
        {
            objProductoCAD.actualizarProducto(idProducto, descripcion, stock, precio);
        }
        public void eliminarProducto(int idProducto)
        {
            objProductoCAD.eliminarProducto(idProducto);
        }
        public int getIndiceUltFila(int cantFilas)
        {
            return cantFilas - 2;
        }
        public int getCodigoProducto(object a)
        {
            int numero = Convert.ToInt32(a);
            int codigo = numero + 1;
            return codigo;

        }
        public int convertirINT()
        {
            return 0;
        }
        public float convertirFloat(string numero)
        {
            float jesus = float.Parse(numero);
            jesus = (float)Math.Truncate((double)jesus * 100.0 / 100.0);
            return jesus;
        }
    }
}
