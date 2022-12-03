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
        private VentasCAD objVentasCAD;
        private DetalleCAD objDetalleCAD;

        //miembros metodos
        public ProductoCLN()
        {
            miTabla = new DataTable();
            objProductoCAD = new ProductoCAD();
            objVentasCAD = new VentasCAD();
            objDetalleCAD = new DetalleCAD();
        }
        public DataTable consultarProductos()
        {
            miTabla = objProductoCAD.consultarProductos();
            return miTabla;
        }
        public void agregarProducto(int idProducto, string descripcion, float precio, int stock)
        {
            idProducto++;
            objProductoCAD.agregarProducto(idProducto, descripcion, precio, stock);
        }
        public void actualizarProducto(int idProducto, string descripcion, float precio, int stock)
        {
            objProductoCAD.actualizarProducto(idProducto, descripcion, precio, stock);
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
        public float venderProductos(int[] idProducto, int idEmpleado)
        {
            /*se necesita:
             venta: ultimo idVenta +1, total, fecha, idEmpleado
             detalle: ultimo idDetalle +1 por cada producto, id de cada producto, cantidad siempre 1, mismo idVenta
             producto: where idProducto, stock -1
             */
            //DataTable idVenta, idDetalle, precio= new DataTable();

            int idVentaUlt = objVentasCAD.getIdVenta() +1;
            float total = 0;
            DateTime fechaVenta = DateTime.Now;

            int idDetalle = objDetalleCAD.getIdDetalle();
            int cantidad = 1;
            
            for (int i=0; i< idProducto.Length; i++)
            {
                if (idProducto[i] != 0)
                {
                    int precio = objProductoCAD.getPrecio(idProducto[i]);
                    total = total + precio;
                    objProductoCAD.venderProducto(idProducto[i]);
                }
            }
            objVentasCAD.agregarVenta(idVentaUlt, total, fechaVenta, idEmpleado);
            for (int i = 0; i < idProducto.Length; i++)
            {
                idDetalle = idDetalle + 1;
                if (idProducto[i] != 0) 
                {
                    objDetalleCAD.agregarDetalles(idDetalle, idProducto[i], cantidad, idVentaUlt);
                }                
            }
            
            return total;
        }
        public bool productoFueVendido(int idProducto)
        {
            bool valor = objProductoCAD.productoFueVendido(idProducto);
            return valor;
        }
    }
}
