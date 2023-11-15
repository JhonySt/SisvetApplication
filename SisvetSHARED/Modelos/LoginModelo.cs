using SisvetSHARED.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisvetSHARED.Modelos
{
    public class LoginModelo
    {
        public string User { get; set; }
        public string Password { get; set; }


        public bool comprobarLogin()
        {
            LoginData loginData = new LoginData();
            bool resultado = loginData.comprobarLogin(User, Password);
            return resultado;
        }



    }
}
