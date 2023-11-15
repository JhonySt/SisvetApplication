using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisvetSHARED.Datos
{
    public class ClientesData
    {
        public void mostrarClientes(DataTable tabla)
        {
            try
            {
                CONEXIONBD.abrirConexion();
                SqlDataAdapter Adaptador = new SqlDataAdapter("MOSTRAR_CLIENTES", CONEXIONBD.conexion);
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

        public void buscarCliente(DataTable tabla, string Buscador)
        {
            try
            {
                CONEXIONBD.abrirConexion();
                SqlDataAdapter Adaptador = new SqlDataAdapter("BUSCAR_CLIENTE", CONEXIONBD.conexion);
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

        public bool insertarCliente(string Cedula, string NombreCompleto, string Direccion,
                                     string Telefono, string Correo)
        {
            try
            {
                CONEXIONBD.abrirConexion();
                SqlCommand Comando = new SqlCommand("INSERTAR_CLIENTE", CONEXIONBD.conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@Cedula", Cedula);
                Comando.Parameters.AddWithValue("@NombreCompleto", NombreCompleto);
                Comando.Parameters.AddWithValue("@Direccion", Direccion);
                Comando.Parameters.AddWithValue("@Telefono", Telefono);
                Comando.Parameters.AddWithValue("@Correo", Correo);
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
        public void buscarClienteId(DataTable tabla, int Id_Cliente)
        {
            try
            {
                CONEXIONBD.abrirConexion();
                SqlDataAdapter Adaptador = new SqlDataAdapter("BUSCAR_CLIENTE_ID", CONEXIONBD.conexion);
                Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                Adaptador.SelectCommand.Parameters.AddWithValue("@Id_Cliente", Id_Cliente);
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

        public void buscarClienteCedula(DataTable tabla, string cedula)
        {
            try
            {
                CONEXIONBD.abrirConexion();
                SqlDataAdapter Adaptador = new SqlDataAdapter("BUSCAR_CLIENTE_CEDULA", CONEXIONBD.conexion);
                Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                Adaptador.SelectCommand.Parameters.AddWithValue("@Cedula", cedula);
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

        public bool actualizarCliente(int Id_Cliente, string Cedula, string NombreCompleto, string Direccion,
                                     string Telefono, string Correo)
        {
            try
            {
                CONEXIONBD.abrirConexion();
                SqlCommand Comando = new SqlCommand("ACTUALIZAR_CLIENTE", CONEXIONBD.conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@Cedula", Cedula);
                Comando.Parameters.AddWithValue("@NombreCompleto", NombreCompleto);
                Comando.Parameters.AddWithValue("@Direccion", Direccion);
                Comando.Parameters.AddWithValue("@Telefono", Telefono);
                Comando.Parameters.AddWithValue("@Correo", Correo);
                Comando.Parameters.AddWithValue("@Id_Cliente", Id_Cliente);
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

        public bool borrarCliente(int Id_Cliente)
        {
            try
            {
                CONEXIONBD.abrirConexion();
                SqlCommand Comando = new SqlCommand("ELIMINAR_CLIENTE", CONEXIONBD.conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@Id_Cliente", Id_Cliente);
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
