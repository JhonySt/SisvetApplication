using SisvetSHARED.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisvetAPP.Vistas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            LoginModelo loginModelo = new LoginModelo();
            loginModelo.User = this.txtUsuario.Text;
            loginModelo.Password = this.txtPassword.Text;
            if (loginModelo.comprobarLogin() == true)
            {
                Principal frmprincipal = new Principal();
                frmprincipal.User = loginModelo.User;
                frmprincipal.Show();
                frmprincipal.FormClosed += Frmprincipal_FormClosed;
                frmprincipal.VisibleChanged += Frmprincipal_VisibleChanged;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
                limpiar();
            }

        }

        private void Frmprincipal_VisibleChanged(object sender, EventArgs e)
        {
            limpiar();
            this.Show();
        }

        private void Frmprincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void limpiar()
        {
            this.txtUsuario.Clear();
            this.txtPassword.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
