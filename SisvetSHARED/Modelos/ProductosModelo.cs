using SisvetSHARED.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisvetSHARED.Modelos
{
    public class ProductosModelo
    {
        public int Id_Producto { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Presentacion { get; set; }
        public decimal Precio { get; set; }
        public string Buscador { get; set; }
        public string Error { get; set; }

        public ProductosModelo()
        {
            Id_Producto = 0;
            Codigo = string.Empty;
            Presentacion = string.Empty;
            Nombre = string.Empty;
            Precio = 0;
            Buscador = string.Empty;
            Error = string.Empty;

        }

        public void mostrarProductos(DataTable tabla)
        {
            ProductosData productos = new ProductosData();
            productos.mostrarProductos(tabla);
        }

        public void buscarProducto(DataTable tabla, string Buscador)
        {
            ProductosData productos = new ProductosData();
            productos.buscarProducto(tabla, Buscador);
        }

        public bool insertarProducto()
        {
            if (!validar())
            {
                return false;
            }
            ProductosData productos = new ProductosData();
            if (productos.insertarProducto(Codigo, Nombre, Presentacion, Precio))
            {
                return true;
            }
            return false;

        }

        public void buscarProductoId(DataTable tabla, int Id_Producto)
        {
            ProductosData productos = new ProductosData();
            productos.buscarProductoId(tabla, Id_Producto);
        }

        public bool actualizarProducto()
        {
            if (!validar())
            {
                return false;
            }
            ProductosData productos = new ProductosData();
            if (productos.actualizarProducto(Id_Producto, Codigo, Nombre, Presentacion, Precio))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool borrarProducto()
        {
            ProductosData productos = new ProductosData();
            if (productos.borrarProducto(Id_Producto))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private bool validar()
        {
            if (Codigo == string.Empty)
            {
                Error = "Ingrese un codigo";
                return false;
            }
            if (Nombre == string.Empty)
            {
                Error = "Ingrese un nombre de producto";
                return false;
            }
            if (Presentacion == string.Empty)
            {
                Error = "Ingrese una presentacion";
                return false;
            }
            if (Precio == 0)
            {
                Error = "Ingrese un precio";
                return false;
            }

            return true;
        }
    }
}
