using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisvetSHARED.Datos
{
    public class HistoriaData
    {
        public bool insertarHistoria(int Id_Mascota, string Motivo, string Observacion, string Descripcion, string Peso, string Edad)
        {
            try
            {
                CONEXIONBD.abrirConexion();
                SqlCommand Comando = new SqlCommand("INSERTAR_HISTORIA", CONEXIONBD.conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@Id_Mascota", Id_Mascota);
                Comando.Parameters.AddWithValue("@Motivo", Motivo);
                Comando.Parameters.AddWithValue("@Observacion", Observacion);
                Comando.Parameters.AddWithValue("@Descripcion", Descripcion);
                Comando.Parameters.AddWithValue("@Peso", Peso);
                Comando.Parameters.AddWithValue("@Edad", Edad);
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
