using SisvetSHARED.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisvetSHARED.Modelos
{
    public class EmpleadosModelo
    {
        public int Id_Empleado { get; set; }
        public string Cedula { get; set; }
        public string NombreCompleto { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public int IdCargo { get; set; }
        public byte[] Foto { get; set; }
        public string Buscador { get; set; }
        public string Error { get; set; }

        public EmpleadosModelo()
        {
            Id_Empleado = 0;
            Cedula = string.Empty;
            NombreCompleto = string.Empty;
            Direccion = string.Empty;
            Telefono = string.Empty;
            Correo = string.Empty;
            IdCargo = 0;
            Buscador = string.Empty;
            Error = string.Empty;

        }

        public void mostrarEmpleados(DataTable tabla)
        {
            EmpleadosData Empleados = new EmpleadosData();
            Empleados.mostrarEmpleados(tabla);
        }
        public void mostrarMedicos(DataTable tabla)
        {
            EmpleadosData Empleados = new EmpleadosData();
            Empleados.mostrarMedicos(tabla);
        }

        public void cargarHeader(DataTable tabla, string user)
        {
            try
            {
                CONEXIONBD.abrirConexion();
                string sentencia = "SELECT E.Id_Empleado, E.NombreCompleto from Empleados E INNER JOIN Usuarios U ON E.Id_Empleado = U.Id_Empleado WHERE U.Username = @User";
                SqlDataAdapter Adaptador = new SqlDataAdapter(sentencia, CONEXIONBD.conexion);
                Adaptador.SelectCommand.Parameters.AddWithValue("@User", user);
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
            EmpleadosData Empleados = new EmpleadosData();
            Empleados.buscarEmpleado(tabla, Buscador);
        }

        public void buscarEmpleadoId(DataTable tabla, int Id_Empleado)
        {
            EmpleadosData Empleados = new EmpleadosData();
            Empleados.buscarEmpleadoId(tabla, Id_Empleado);
        }

        public bool insertarEmpleado()
        {
            if (!validar())
            {
                return false;
            }
            EmpleadosData empleado = new EmpleadosData();
            if (empleado.insertarEmpleado(Cedula, NombreCompleto, Direccion, Telefono, Correo, IdCargo, Foto))
            {
                return true;
            }
            return false;
            
        }

        public bool actualizarEmpleado()
        {
            if (!validar())
            {
                return false;
            }
            EmpleadosData empleado = new EmpleadosData();
            if (empleado.actualizarEmpleado(Id_Empleado,Cedula, NombreCompleto, Direccion, Telefono, Correo, IdCargo))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool actualizarEmpleadoFoto()
        {
            EmpleadosData empleado = new EmpleadosData();
            if (empleado.actualizarEmpleadoFoto(Id_Empleado, Cedula, Foto))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool borrarEmpleado()
        {
            EmpleadosData empleado = new EmpleadosData();
            if (empleado.borrarEmpleado(Id_Empleado))
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
            if (Cedula == string.Empty)
            {
                Error = "Ingrese un numero de documento";
                return false;
            }
            if (NombreCompleto == string.Empty)
            {
                Error = "Ingrese un nombre de empleado";
                return false;
            }
            if (Direccion == string.Empty)
            {
                Error = "Ingrese una direccion";
                return false;
            }
            if (Telefono == string.Empty)
            {
                Error = "Ingrese un numero de telefono";
                return false;
            }
            if (Correo == string.Empty)
            {
                Error = "Ingrese un correo electronico";
                return false;
            }
            if (IdCargo == 0)
            {
                Error = "Seleccione un cargo";
                return false;
            }
            return true;
        }
    }
}
