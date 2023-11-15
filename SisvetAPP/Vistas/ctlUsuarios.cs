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
    public partial class ctlUsuarios : UserControl
    {
        
        public ctlUsuarios()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            insertarUsuario();
            MessageBox.Show("Usuario creado");
            limpiar();
        }

        private bool[] asignarPermisos()
        {
            bool[] Roles = new bool[listaPermisos.Items.Count];
            for (int i = 0; i < listaPermisos.Items.Count; i++)
            {
                Roles[i] = listaPermisos.GetItemChecked(i);
            }
            return Roles;
        }

        private void insertarUsuario()
        {
            bool[] Roles = asignarPermisos();
            UsuariosModelo usuarios = new UsuariosModelo();
            usuarios.Empleados = Roles[0];
            usuarios.Clientes = Roles[1];
            usuarios.Mascotas = Roles[2];
            usuarios.Citas = Roles[3];
            usuarios.Productos = Roles[4];
            usuarios.Ventas = Roles[5];
            usuarios.Usuarios = Roles[6];
            usuarios.Username = txtUser.Text;
            usuarios.Password = txtPass.Text;
            usuarios.Cedula = txtDocumento.Text;
            usuarios.insertarUsuario();
        }
        private void limpiar()
        {
            txtDocumento.Clear();
            txtUser.Clear();
            txtPass.Clear();
            for (int i = 0; i < listaPermisos.Items.Count; i++)
            {
                listaPermisos.SetItemChecked(i, false);
            }
        }
    }
}
