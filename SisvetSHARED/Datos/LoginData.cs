using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisvetSHARED.Datos
{
    public class LoginData
    {
        public bool comprobarLogin(string User, string Password)
        {
            try
            {
                CONEXIONBD.abrirConexion();
                SqlCommand Comando = new SqlCommand("COMPROBAR_USUARIO", CONEXIONBD.conexion);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@Username", User);
                Comando.Parameters.AddWithValue("@Password", Password);
                SqlDataReader Lector;
                Lector = Comando.ExecuteReader();
                if (Lector.HasRows == true)
                {
                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return false;

            }
            finally
            {
                CONEXIONBD.cerrarConexion();
            }
        }
    }
}
