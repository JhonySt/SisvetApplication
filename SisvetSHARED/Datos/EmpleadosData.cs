using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisvetSHARED.Datos
{
    public class EmpleadosData
    {
        public void mostrarEmpleados(DataTable tabla)
        {
			try
			{
				CONEXIONBD.abrirConexion();
				SqlDataAdapter Adaptador = new SqlDataAdapter("MOSTRAR_EMPLEADOS", CONEXIONBD.conexion);
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

        public void mostrarMedicos(DataTable tabla)
        {
            try
            {
                CONEXIONBD.abrirConexion();
                SqlDataAdapter Adaptador = new SqlDataAdapter("MOSTRAR_MEDICOS", CONEXIONBD.conexion);
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

        public void buscarEmpleado(DataTable tabla, string Buscador)
		{
            try
            {
                CONEXIONBD.abrirConexion();
                SqlDataAdapter Adaptador = new SqlDataAdapter("BUSCAR_EMPLEADO", CONEXIONBD.conexion);
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

        public void buscarEmpleadoId(DataTable tabla, int Id_Empleado)
        {
            try
            {
                CONEXIONBD.abrirConexion();
                SqlDataAdapter Adaptador = new SqlDataAdapter("BUSCAR_EMPLEADO_ID", CONEXIONBD.conexion);
                Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
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

        public bool insertarEmpleado(string Cedula, string NombreCompleto, string Direccion,
                                     string Telefono, string Correo, int IdCargo, byte[] Foto)
        {
            try
            {
                CONEXIONBD.abrirConexion();
                SqlCommand Comando = new SqlCommand("INSERTAR_EMPLEADO", CONEXIONBD.conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@Cedula", Cedula);
                Comando.Parameters.AddWithValue("@NombreCompleto", NombreCompleto);
                Comando.Parameters.AddWithValue("@Direccion", Direccion);
                Comando.Parameters.AddWithValue("@Telefono", Telefono);
                Comando.Parameters.AddWithValue("@Correo", Correo);
                Comando.Parameters.AddWithValue("@IdCargo", IdCargo);
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
        public bool actualizarEmpleado(int Id_Empleado, string Cedula, string NombreCompleto, string Direccion,
                                     string Telefono, string Correo, int IdCargo)
        {
            try
            {
                CONEXIONBD.abrirConexion();
                SqlCommand Comando = new SqlCommand("ACTUALIZAR_EMPLEADO", CONEXIONBD.conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@Cedula", Cedula);
                Comando.Parameters.AddWithValue("@NombreCompleto", NombreCompleto);
                Comando.Parameters.AddWithValue("@Direccion", Direccion);
                Comando.Parameters.AddWithValue("@Telefono", Telefono);
                Comando.Parameters.AddWithValue("@Correo", Correo);
                Comando.Parameters.AddWithValue("@IdCargo", IdCargo);
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
        public bool actualizarEmpleadoFoto(int Id_Empleado, string Cedula, byte[] Foto)
        {
            try
            {
                CONEXIONBD.abrirConexion();
                SqlCommand Comando = new SqlCommand("ACTUALIZAR_EMPLEADO_FOTO", CONEXIONBD.conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@Cedula", Cedula);
                Comando.Parameters.AddWithValue("@Id_Empleado", Id_Empleado);
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

        public bool borrarEmpleado(int Id_Empleado)
        {
            try
            {
                CONEXIONBD.abrirConexion();
                SqlCommand Comando = new SqlCommand("ELIMINAR_EMPLEADO", CONEXIONBD.conexion);
                Comando.CommandType = CommandType.StoredProcedure;
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

        
    }
}
