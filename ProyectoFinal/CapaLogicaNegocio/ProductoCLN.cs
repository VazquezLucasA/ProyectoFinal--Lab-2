using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;


namespace CapaLogicaNegocio
{
    internal class ProductoCLN
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
        public DataTable consultarGeneros()
        {
            miTabla = objProductoCAD.consultarGeneros();
            return miTabla;
        }
        public void insertarGenero(int idGenero, string nombre, string calificacion)
        {
            idGenero++;
            objProductoCAD.insertarGenero(idGenero, nombre, calificacion);
        }
        public void actualizarGenero(int idGenero, string nombre, string calificacion)
        {
            objProductoCAD.actualizarGenero(idGenero, nombre, calificacion);
        }
        public void eliminarGenero(int idGenero)
        {
            objProductoCAD.eliminarGenero(idGenero);
        }
        public int getIndiceUltFila(int cantFilas)
        {
            cantFilas = cantFilas - 1;
            return cantFilas;
        }
    }
}
