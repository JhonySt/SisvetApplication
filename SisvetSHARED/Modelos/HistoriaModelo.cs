using SisvetSHARED.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SisvetSHARED.Modelos
{
    public class HistoriaModelo
    {
        public int Id_Historia { get; set; }
        public int Id_Mascota { get; set; }
        public DateTime fecha { get; set; }
        public string Motivo { get; set; }
        public string Observacion { get; set; }
        public string Descripcion { get; set; }
        public string Peso { get; set; }
        public string Edad { get; set; }
        public string Error { get; set; }


        public bool insertarHistoria()
        {
            if (!validar())
            {
                return false;
            }
            HistoriaData historia = new HistoriaData();
            if (historia.insertarHistoria(Id_Mascota, Motivo, Observacion, Descripcion, Peso, Edad))
            {
                return true;
            }
            return false;

        }


        private bool validar()
        {
            if (Id_Mascota <= 0)
            {
                Error = "Seleccione una Mascota";
                return false;
            }
            if (Motivo == string.Empty || Motivo == "Seleccione una opcion")
            {
                Error = "Seleccione un motivo";
                return false;
            }
            if (Observacion == string.Empty)
            {
                Error = "Ingrese una observacion";
                return false;
            }
            if (Descripcion == string.Empty)
            {
                Error = "Ingrese una descripcion del motivo";
                return false;
            }
            if (Peso == string.Empty)
            {
                Error = "Ingrese un peso";
                return false;
            }
            if (Edad == string.Empty)
            {
                Error = "Ingrese una edad";
                return false;
            }

            return true;
        }

    }
}
