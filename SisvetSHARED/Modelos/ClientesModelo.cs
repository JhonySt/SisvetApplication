using SisvetSHARED.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisvetSHARED.Modelos
{
    public class ClientesModelo
    {
        public int Id_Cliente { get; set; }
        public string Cedula { get; set; }
        public string NombreCompleto { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Buscador { get; set; }
        public string Error { get; set; }

        public ClientesModelo()
        {
            Id_Cliente = 0;
            Cedula = string.Empty;
            NombreCompleto = string.Empty;
            Direccion = string.Empty;
            Telefono = string.Empty;
            Correo = string.Empty;
            Buscador = string.Empty;
            Error = string.Empty;

        }


        public void mostrarClientes(DataTable tabla)
        {
            ClientesData Clientes = new ClientesData();
            Clientes.mostrarClientes(tabla);
        }

        public void buscarCliente(DataTable tabla, string Buscador)
        {
            ClientesData clientes = new ClientesData();
            clientes.buscarCliente(tabla, Buscador);
        }

        public bool insertarCliente()
        {
            if (!validar())
            {
                return false;
            }
            ClientesData clientes = new ClientesData();
            if (clientes.insertarCliente(Cedula, NombreCompleto, Direccion, Telefono, Correo))
            {
                return true;
            }
            return false;

        }

        public void buscarClienteId(DataTable tabla, int Id_Cliente)
        {
            ClientesData clientes = new ClientesData();
            clientes.buscarClienteId(tabla, Id_Cliente);
        }

        public void buscarClienteCedula(DataTable tabla, string Cedula)
        {
            ClientesData clientes = new ClientesData();
            clientes.buscarClienteCedula(tabla, Cedula);
        }

        public bool actualizarCliente()
        {
            if (!validar())
            {
                return false;
            }
            ClientesData clientes = new ClientesData();
            if (clientes.actualizarCliente(Id_Cliente, Cedula, NombreCompleto, Direccion, Telefono, Correo))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool borrarCliente()
        {
            ClientesData clientes = new ClientesData();
            if (clientes.borrarCliente(Id_Cliente))
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
            
            return true;
        }
    }
}
