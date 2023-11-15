using SisvetSHARED.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisvetSHARED.Modelos
{
    public class TiposModelo
    {
        public int Id_Tipo { get; set; }
        public int Descripcion { get; set; }
        //Id_Cargo int
        //Descripcion varchar(50)


        public void mostrarTipos(DataTable tabla)
        {
            TiposData tipos = new TiposData();
            tipos.mostrarTipos(tabla);
        }
    }
}
