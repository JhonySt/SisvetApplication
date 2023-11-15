using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisvetSHARED.Datos
{
    public class MascotasData
    {
        public void mostrarMascotas(DataTable tabla)
        {
            try
            {
                CONEXIONBD.abrirConexion();
                SqlDataAdapter Adaptador = new SqlDataAdapter("MOSTRAR_MASCOTAS", CONEXIONBD.conexion);
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

        public void buscarMascota(DataTable tabla, string Buscador)
        {
            try
            {
                CONEXIONBD.abrirConexion();
                SqlDataAdapter Adaptador = new SqlDataAdapter("BUSCAR_MASCOTA", CONEXIONBD.conexion);
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

        public void buscarMascotaId(DataTable tabla, int Id_Mascota)
        {
            try
            {
                CONEXIONBD.abrirConexion();
                SqlDataAdapter Adaptador = new SqlDataAdapter("BUSCAR_MASCOTA_ID", CONEXIONBD.conexion);
                Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                Adaptador.SelectCommand.Parameters.AddWithValue("@Id_Mascota", Id_Mascota);
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

        public void mostrarMascotaCliente(DataTable tabla, int Id_Cliente)
        {
            try
            {
                CONEXIONBD.abrirConexion();
                SqlDataAdapter Adaptador = new SqlDataAdapter("MOSTRAR_MASCOTAS_CLIENTE", CONEXIONBD.conexion);
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

        public bool insertarMascota(string Nombre, string Edad, int Id_Cliente, byte[] Foto,
                                     int IdTipo, string Raza, string Sexo)
        {
            try
            {
                CONEXIONBD.abrirConexion();
                SqlCommand Comando = new SqlCommand("INSERTAR_MASCOTA", CONEXIONBD.conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@Nombre", Nombre);
                Comando.Parameters.AddWithValue("@Edad", Edad);
                Comando.Parameters.AddWithValue("@Id_Cliente", Id_Cliente);
                Comando.Parameters.AddWithValue("@Foto", Foto);
                Comando.Parameters.AddWithValue("@Id_Tipo", IdTipo);
                Comando.Parameters.AddWithValue("@Raza", Raza);
                Comando.Parameters.AddWithValue("@sexo", Sexo);
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

        public bool actualizarMascota(int Id_Mascota, string Nombre, string Edad, int Id_Cliente,
                                     int Id_Tipo)
        {
            try
            {
                CONEXIONBD.abrirConexion();
                SqlCommand Comando = new SqlCommand("ACTUALIZAR_MASCOTA", CONEXIONBD.conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@Id_Mascota", Id_Mascota);
                Comando.Parameters.AddWithValue("@Nombre", Nombre);
                Comando.Parameters.AddWithValue("@Edad", Edad);
                Comando.Parameters.AddWithValue("@Id_Cliente", Id_Cliente);
                Comando.Parameters.AddWithValue("@Id_Tipo", Id_Tipo);
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

        public bool actualizarMascotaFoto(int Id_mascota, byte[] Foto)
        {
            try
            {
                CONEXIONBD.abrirConexion();
                SqlCommand Comando = new SqlCommand("ACTUALIZAR_MASCOTA_FOTO", CONEXIONBD.conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@Id_Mascota", Id_mascota);
                Comando.Parameters.AddWithValue("@Foto", Foto);
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

        public bool borrarMascota(int Id_Mascota)
        {
            try
            {
                CONEXIONBD.abrirConexion();
                SqlCommand Comando = new SqlCommand("ELIMINAR_MASCOTA", CONEXIONBD.conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@Id_Mascota", Id_Mascota);
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
