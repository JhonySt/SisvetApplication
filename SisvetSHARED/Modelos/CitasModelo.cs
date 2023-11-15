using SisvetSHARED.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SisvetSHARED.Modelos
{
    public class CitasModelo
    {
        public int Id_Cita { get; set; }
        public DateTime fecha { get; set; }
        public string Hora { get; set; }
        public int Id_Cliente { get; set; }
        public int Id_Empleado { get; set; }
        public string Estado { get; set; }
        public string Error { get; set; }
        public string Buscador { get; set; }

        public CitasModelo()
        {
            Id_Cita = 0;
            Hora = string.Empty;
            Id_Empleado = 0;
            Id_Cliente = 1;
            Estado = string.Empty;
            Error = string.Empty;
            Buscador = string.Empty;
        }

        public bool insertarCita()
        {
            if (!validar())
            {
                return false;
            }
            CitasData citas = new CitasData();
            if (citas.insertarCita(fecha, Hora, Id_Cliente, Id_Empleado))
            {
                return true;
            }
            return false;
        }

        public void mostrarCitas(DataTable tabla)
        {
            CitasData citas = new CitasData();
            citas.mostrarCitas(tabla, fecha, Id_Empleado);
        }

        public void mostrarCitasAsignadas(DataTable tabla)
        {
            CitasData citas = new CitasData();
            citas.mostrarCitasAsignadas(tabla, fecha, Id_Empleado);
        }

        public bool agendarCita()
        {
            CitasData citas = new CitasData();
            if (citas.agendarCita(Id_Cita, Estado)) return true;
            return false;
        }

        public bool cancelarCita()
        {
            CitasData citas = new CitasData();
            if (citas.cancelarCita(Id_Cita)) return true;
            return false;
        }
        public void terminarCita(int Id_Cita)
        {
            CitasData citas = new CitasData();
            citas.terminarCita(Id_Cita);
            
        }

        public void buscarCita(DataTable tabla)
        {
            CitasData citas = new CitasData();
            citas.buscarCita(tabla, Buscador);
        }

        private bool validar()
        {
            if (Hora == string.Empty)
            {
                Error = "Seleccione una hora";
                return false;
            }
            if (Id_Empleado == 0)
            {
                Error = "Seleccione un medico";
                return false;
            }
            return true;
        }
    }

    
}
