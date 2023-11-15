using SisvetSHARED.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisvetSHARED.Modelos
{
    public class UsuariosModelo
    {
        public int Id_Usuario { get; set; }
        public bool Empleados { get; set; }
        public bool Clientes { get; set; }
        public bool Mascotas { get; set; }
        public bool Citas { get; set; }
        public bool Productos { get; set; }
        public bool Ventas { get; set; }
        public bool Usuarios { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Id_Empleado { get; set; }
        public string Cedula { get; set; }


        public UsuariosModelo()
        {
            Id_Usuario = 0;
            Empleados = false;
            Clientes =false;
            Mascotas=false;
            Citas = false;
            Productos = false;
            Ventas = false;
            Usuarios = false;
            Username = string.Empty;
            Password = string.Empty;
            Id_Empleado = 0;
            Cedula = string.Empty;
        }

        public void insertarUsuario()
        {
            UsuariosData usuarios = new UsuariosData();
            usuarios.insertarUsuario(Empleados,Clientes, Mascotas, Citas,
                Productos, Ventas, Usuarios, Username, Password, Cedula);
        }
    }
}
