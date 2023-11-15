using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisvetSHARED.Datos
{
    public class CitasData
    {
        public bool insertarCita(DateTime fecha,string Hora,int Id_Cliente,int Id_Empleado)
        {
            try
            {
                CONEXIONBD.abrirConexion();
                SqlCommand Comando = new SqlCommand("INSERTAR_CITA", CONEXIONBD.conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@Fecha", fecha.Date);
                Comando.Parameters.AddWithValue("@Hora", Hora);
                Comando.Parameters.AddWithValue("@Id_Cliente", Id_Cliente);
                Comando.Parameters.AddWithValue("@Id_Empleado", Id_Empleado);
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

        public void mostrarCitas(DataTable tabla, DateTime fecha, int Id_Empleado)
        {
            try
            {
                CONEXIONBD.abrirConexion();
                SqlDataAdapter Adaptador = new SqlDataAdapter("MOSTRAR_CITAS", CONEXIONBD.conexion);
                Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                Adaptador.SelectCommand.Parameters.AddWithValue("@fecha", fecha);
                Adaptador.SelectCommand.Parameters.AddWithValue("@Id_Empleado", Id_Empleado);
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

        public void mostrarCitasAsignadas(DataTable tabla, DateTime fecha, int Id_Empleado)
        {
            try
            {
                CONEXIONBD.abrirConexion();
                SqlDataAdapter Adaptador = new SqlDataAdapter("MOSTRAR_CITAS_AGENDADAS", CONEXIONBD.conexion);
                Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                Adaptador.SelectCommand.Parameters.AddWithValue("@fecha", fecha);
                Adaptador.SelectCommand.Parameters.AddWithValue("@Id_Empleado", Id_Empleado);
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

        public bool agendarCita(int Id_Cita, string Documento)
        {
            try
            {
                CONEXIONBD.abrirConexion();
                SqlCommand Comando = new SqlCommand("AGENDAR_CITA", CONEXIONBD.conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@Id_Cita",Id_Cita);
                Comando.Parameters.AddWithValue("@Documento", Documento);
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

        public bool cancelarCita(int Id_Cita)
        {
            try
            {
                CONEXIONBD.abrirConexion();
                SqlCommand Comando = new SqlCommand("CANCELAR_CITA", CONEXIONBD.conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@Id_Cita", Id_Cita);
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

        public void terminarCita(int Id_Cita)
        {
            try
            {
                CONEXIONBD.abrirConexion();
                string sentecia = "UPDATE Citas SET Citas.Estado = @Estado WHERE Citas.Id_Cita = @Id_Cita";
                SqlCommand Comando = new SqlCommand(sentecia, CONEXIONBD.conexion);
                //Comando.CommandType = CommandType.Text;
                Comando.Parameters.AddWithValue("@Id_Cita", Id_Cita);
                Comando.Parameters.AddWithValue("@Estado", "TERMINADA");
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

        public void buscarCita(DataTable tabla, string Buscador)
        {
            try
            {
                CONEXIONBD.abrirConexion();
                SqlDataAdapter Adaptador = new SqlDataAdapter("BUSCAR_CITA", CONEXIONBD.conexion);
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
    }


    
}
