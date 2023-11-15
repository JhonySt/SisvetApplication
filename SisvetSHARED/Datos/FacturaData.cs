using SisvetSHARED.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisvetSHARED.Datos
{
    public class FacturaData
    {
        public object Id_Factura;
        public bool insertarFactura(string Documento, List<FacturaModelo> listaDetalle, decimal totaCompra)
        {
            try
            {
                var dt = new DataTable();
                dt.Columns.Add("Id_Detalle");
                dt.Columns.Add("Id_Producto");
                dt.Columns.Add("Codigo");
                dt.Columns.Add("Nombre");
                dt.Columns.Add("Presentacion");
                dt.Columns.Add("Precio_Unitario");
                dt.Columns.Add("Cantidad");
                dt.Columns.Add("Total");

                int i = 1;
                decimal x = 0;
                foreach (var item in listaDetalle)
                {
                    dt.Rows.Add(i, item.Id_Producto, item.Codigo, item.Nombre, item.presentacion,
                        Convert.ToDouble(item.PrecioUnitario), item.Cantidad, Convert.ToDouble(item.Total));
                    i++;
                }

                CONEXIONBD.abrirConexion();

                SqlCommand Comando = new SqlCommand("INSERTAR_FACTURA", CONEXIONBD.conexion);
                var parametroLista = new SqlParameter("@ListaDetalle", SqlDbType.Structured);
                parametroLista.TypeName = "dbo.DETALLE_FACTURA2";
                parametroLista.Value = dt;

                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add(parametroLista);
                Comando.Parameters.AddWithValue("@Documento", Documento);
                Comando.Parameters.AddWithValue("@Total_Compra", totaCompra);
                Id_Factura = Comando.ExecuteScalar();
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
