using SisvetSHARED.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisvetSHARED.Datos
{
    public class PreescripcionData
    {
        public object Id_Prescripcion;
        public bool insertarPrescripcion(int Id_Cliente, List<PrescripcionDetalleModelo> listaDetalle)
        {

			try
			{
				var dt = new DataTable();
				dt.Columns.Add("Id_PrescripcionD");
                dt.Columns.Add("Nombre");
                dt.Columns.Add("Cantidad");
                dt.Columns.Add("Presentacion");
                dt.Columns.Add("Indicaciones");

				int i = 1;
                foreach (var item in listaDetalle)
                {
					dt.Rows.Add(i, item.Nombre, item.Cantidad, item.Presentacion, item.Indicaciones);
					i++;
                }

                CONEXIONBD.abrirConexion();

				SqlCommand Comando = new SqlCommand("INSERTAR_PRESCRIPCION", CONEXIONBD.conexion);
				var parametroLista = new SqlParameter("@ListaDetalle", SqlDbType.Structured);
				parametroLista.TypeName = "DETALLE_PRESCRIPCION";
				parametroLista.Value = dt;

				Comando.CommandType = System.Data.CommandType.StoredProcedure;
				Comando.Parameters.Add(parametroLista);
				Comando.Parameters.AddWithValue("@Id_Cliente", Id_Cliente);
                Id_Prescripcion = Comando.ExecuteScalar();
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
