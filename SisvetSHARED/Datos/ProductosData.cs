using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisvetSHARED.Datos
{
    public class ProductosData
    {
        public void mostrarProductos(DataTable tabla)
        {
            try
            {
                CONEXIONBD.abrirConexion();
                SqlDataAdapter Adaptador = new SqlDataAdapter("MOSTRAR_PRODUCTOS", CONEXIONBD.conexion);
                Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                Adaptador.Fill(tabla);

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                CONEXIONBD.cerrarConexion();
            }
        }

        public void buscarProducto(DataTable tabla, string Buscador)
        {
            try
            {
                CONEXIONBD.abrirConexion();
                SqlDataAdapter Adaptador = new SqlDataAdapter("BUSCAR_PRODUCTO", CONEXIONBD.conexion);
                Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                Adaptador.SelectCommand.Parameters.AddWithValue("@Buscador", Buscador);
                Adaptador.Fill(tabla);

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                CONEXIONBD.cerrarConexion();
            }
        }

        public bool insertarProducto(string Codigo, string Nombre, string Presentacion,
                                     decimal Precio)
        {
            try
            {
                CONEXIONBD.abrirConexion();
                SqlCommand Comando = new SqlCommand("INSERTAR_PRODUCTO", CONEXIONBD.conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@Codigo", Codigo);
                Comando.Parameters.AddWithValue("@Nombre", Nombre);
                Comando.Parameters.AddWithValue("@Presentacion", Presentacion);
                Comando.Parameters.AddWithValue("@Precio", Precio);
                Comando.ExecuteNonQuery();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                CONEXIONBD.cerrarConexion();
            }
        }

        public void buscarProductoId(DataTable tabla, int Id_Producto)
        {
            try
            {
                CONEXIONBD.abrirConexion();
                SqlDataAdapter Adaptador = new SqlDataAdapter("BUSCAR_PRODUCTO_ID", CONEXIONBD.conexion);
                Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                Adaptador.SelectCommand.Parameters.AddWithValue("@Id_Producto", Id_Producto);
                Adaptador.Fill(tabla);

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                CONEXIONBD.cerrarConexion();
            }
        }

        public bool actualizarProducto(int Id_Producto, string Codigo, string Nombre, string Presentacion,
                                     decimal Precio)
        {
            try
            {
                CONEXIONBD.abrirConexion();
                SqlCommand Comando = new SqlCommand("ACTUALIZAR_PRODUCTO", CONEXIONBD.conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@Id_Producto", Id_Producto);
                Comando.Parameters.AddWithValue("@Codigo", Codigo);
                Comando.Parameters.AddWithValue("@Nombre", Nombre);
                Comando.Parameters.AddWithValue("@Presentacion", Presentacion);
                Comando.Parameters.AddWithValue("@Precio", Precio);
                Comando.ExecuteNonQuery();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                CONEXIONBD.cerrarConexion();
            }
        }

        public bool borrarProducto(int Id_Producto)
        {
            try
            {
                CONEXIONBD.abrirConexion();
                SqlCommand Comando = new SqlCommand("ELIMINAR_PRODUCTO", CONEXIONBD.conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@Id_Producto", Id_Producto);
                Comando.ExecuteNonQuery();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                CONEXIONBD.cerrarConexion();
            }
        }
    }
}
