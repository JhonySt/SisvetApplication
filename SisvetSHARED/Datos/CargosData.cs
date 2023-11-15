using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisvetSHARED.Datos
{
    public class CargosData
    {
        public void mostrarCargos(DataTable tabla)
        {
			try
			{
				CONEXIONBD.abrirConexion();
				SqlDataAdapter Adaptador = new SqlDataAdapter("MOSTRAR_CARGOS", CONEXIONBD.conexion);
				Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
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
    }
}
