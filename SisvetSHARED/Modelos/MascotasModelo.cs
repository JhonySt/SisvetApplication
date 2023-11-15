using SisvetSHARED.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisvetSHARED.Modelos
{
    public class MascotasModelo
    {
        public int Id_Mascota { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Edad { get; set; }
        public int Id_Cliente { get; set; }
        public int IdTipo { get; set; }
        public byte[] Foto { get; set; }
        public string Buscador { get; set; }
        public string Error { get; set; }
        public string Raza { get; set; }
        public string Sexo { get; set; }

        public MascotasModelo()
        {
            Id_Mascota = 0;
            Cedula = string.Empty;
            Nombre = string.Empty;
            Edad = string.Empty;
            Id_Cliente = 0;
            IdTipo = 0;
            Buscador = string.Empty;
            Error = string.Empty;

        }

        public void mostrarMascotas(DataTable tabla)
        {
            MascotasData mascotas = new MascotasData();
            mascotas.mostrarMascotas(tabla);
        }

        public void buscarMascota(DataTable tabla, string Buscador)
        {
            MascotasData mascotas = new MascotasData();
            mascotas.buscarMascota(tabla, Buscador);
        }

        public void buscarMascotaId(DataTable tabla, int Id_Mascota)
        {
            MascotasData mascotas = new MascotasData();
            mascotas.buscarMascotaId(tabla, Id_Mascota);
        }

        public void mostrarMascotaCliente(DataTable tabla)
        {
            MascotasData mascotas = new MascotasData();
            mascotas.mostrarMascotaCliente(tabla, Id_Cliente);
        }

        public bool insertarMascota()
        {
            if (!validar())
            {
                return false;
            }
            MascotasData mascotas = new MascotasData();
            if (mascotas.insertarMascota(Nombre, Edad, Id_Cliente, Foto, IdTipo, Raza, Sexo))
            {
                return true;
            }
            return false;

        }

        public bool actualizarMascota()
        {
            if (!validar())
            {
                return false;
            }
            MascotasData mascotas = new MascotasData();
            if (mascotas.actualizarMascota(Id_Mascota,Nombre, Edad, Id_Cliente, IdTipo))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool actualizarMascotaFoto()
        {
            MascotasData mascotas = new MascotasData();
            if (mascotas.actualizarMascotaFoto(Id_Mascota, Foto))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool borrarMascota()
        {
            MascotasData mascotas = new MascotasData();
            if (mascotas.borrarMascota(Id_Mascota))
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
            if (Nombre == string.Empty)
            {
                Error = "Ingrese un nombre de empleado";
                return false;
            }
            if (Edad == string.Empty)
            {
                Error = "Ingrese una edad valida";
                return false;
            }
            if (IdTipo == 0)
            {
                Error = "Seleccione un cargo";
                return false;
            }
            if (Raza == string.Empty)
            {
                Error = "Ingrese la raza de la mascota";
                return false;
            }
            if (Sexo == string.Empty)
            {
                Error = "Ingrese el sexo de la mascota";
                return false;
            }
            return true;
        }
    }
}
