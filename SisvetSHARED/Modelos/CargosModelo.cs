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
    public class CargosModelo
    {
        public int Id_Cargo { get; set; }
        public int Descripcion { get;set; }
        //Id_Cargo int
        //Descripcion varchar(50)


        public void mostrarCargos(DataTable tabla)
        {
            CargosData cargos = new CargosData();
            cargos.mostrarCargos(tabla);
        }
    }
}
