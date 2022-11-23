using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            cantFilas = cantFilas - 1;
            return cantFilas;
        }
    }
}
