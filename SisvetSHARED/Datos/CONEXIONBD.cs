using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisvetSHARED.Datos
{
    public class CONEXIONBD
    {
        public static string cadenaCnx = "Data Source = DESKTOP-IQ323VM; Initial Catalog = Sisvet; user id = dba; password = Abcd1234*;";
        public static SqlConnection conexion = new SqlConnection(cadenaCnx);

        public static void abrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
        }
        public static void cerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
}
