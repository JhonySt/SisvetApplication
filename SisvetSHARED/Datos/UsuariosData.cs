using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisvetSHARED.Datos
{
    public class UsuariosData
    {
        public void insertarUsuario(bool Empleados, bool Clientes, bool Mascotas,
            bool Citas, bool Productos, bool Ventas, bool Usuarios, string Username,
            string Password, string Cedula)
        {
            try
            {
                CONEXIONBD.abrirConexion();
                SqlCommand Comando = new SqlCommand("INSERTAR_USUARIO", CONEXIONBD.conexion);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@Username", Username);
                Comando.Parameters.AddWithValue("@Password", Password);
                Comando.Parameters.AddWithValue("@Cedula", Cedula);
                Comando.Parameters.AddWithValue("@Empleados", Empleados);
                Comando.Parameters.AddWithValue("@Clientes", Clientes);
                Comando.Parameters.AddWithValue("@Mascotas", Mascotas);
                Comando.Parameters.AddWithValue("@Citas", Citas);
                Comando.Parameters.AddWithValue("@Productos", Productos);
                Comando.Parameters.AddWithValue("@Ventas", Ventas);
                Comando.Parameters.AddWithValue("@Usuarios", Usuarios);
                Comando.ExecuteNonQuery();

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

        public void mostrarUsuario(DataTable tabla, string Username)
        {
            try
            {
                CONEXIONBD.abrirConexion();
                SqlDataAdapter Adaptador = new SqlDataAdapter("MOSTRAR_USUARIOS", CONEXIONBD.conexion);
                Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                Adaptador.SelectCommand.Parameters.AddWithValue("@Username", Username);
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
    }
}
