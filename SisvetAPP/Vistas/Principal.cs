using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using SisvetSHARED.Datos;
using SisvetSHARED.Modelos;

namespace SisvetAPP.Vistas
{
    public partial class Principal : Form
    {
        public int Id_Empleado = 3;
        public string User = string.Empty;

        private IconButton currentBtn;
        private Panel leftBorderBtn;

        public Principal()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 55);
            pnlMenu.Controls.Add(leftBorderBtn);
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            this.pnlLogo.Focus();
            mostrarUsuario();
            if (User != string.Empty)
            {
                cargarPermisos();
            }
            
        }

        private void ActivatedButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(30, 54, 124);
                currentBtn.ForeColor = Color.FromArgb(216, 126, 3);
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.FromArgb(216, 126, 3);
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = Color.FromArgb(216, 126, 3);
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                this.pnlSubCitas.Visible = false;
                currentBtn.BackColor = Color.FromArgb(3, 6, 57);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void pnlLogo_Click(object sender, EventArgs e)
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            this.pnlContenido.Controls.Clear();
        }

        private void ibtnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ibtnEmpleados_Click(object sender, EventArgs e)
        {
            ActivatedButton(sender);
            this.pnlContenido.Controls.Clear();
            ctlEmpleado control = new ctlEmpleado();
            control.Dock = DockStyle.Fill;
            this.pnlContenido.Controls.Add(control);
        }

        private void ibtnClientes_Click(object sender, EventArgs e)
        {
            ActivatedButton(sender);
            this.pnlContenido.Controls.Clear();
            ctlClientes control = new ctlClientes();
            control.Dock = DockStyle.Fill;
            this.pnlContenido.Controls.Add(control);
        }

        private void ibtnMascotas_Click(object sender, EventArgs e)
        {
            ActivatedButton(sender);
            this.pnlContenido.Controls.Clear();
            ctlMascotas control = new ctlMascotas();
            control.Dock = DockStyle.Fill;
            this.pnlContenido.Controls.Add(control);
        }

        private void ibtnCitas_Click(object sender, EventArgs e)
        {
            ActivatedButton(sender);
            if (this.pnlSubCitas.Visible == false)
            {
                this.pnlSubCitas.Visible = true;
            }
            else this.pnlSubCitas.Visible = false;

        }

        private void ibtnProductos_Click(object sender, EventArgs e)
        {
            ActivatedButton(sender);
            this.pnlContenido.Controls.Clear();
            ctlProductos control = new ctlProductos();
            control.Dock = DockStyle.Fill;
            this.pnlContenido.Controls.Add(control);
        }

        private void ibtnFacturar_Click(object sender, EventArgs e)
        {
            ActivatedButton(sender);
            this.pnlContenido.Controls.Clear();
            ctlFacturar control = new ctlFacturar();
            control.Dock = DockStyle.Fill;
            this.pnlContenido.Controls.Add(control);

        }

        private void ibtnUsuarios_Click(object sender, EventArgs e)
        {
            ActivatedButton(sender);
            this.pnlContenido.Controls.Clear();
            ctlUsuarios control = new ctlUsuarios();
            control.Dock = DockStyle.Fill;
            this.pnlContenido.Controls.Add(control);
        }


        private void btnAgendar_Click(object sender, EventArgs e)
        {
            this.pnlContenido.Controls.Clear();
            ctlAgendarCita control = new ctlAgendarCita();
            control.Dock = DockStyle.Fill;
            this.pnlContenido.Controls.Add(control);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.pnlContenido.Controls.Clear();
            ctlCancelarCita control = new ctlCancelarCita();
            control.Dock = DockStyle.Fill;
            this.pnlContenido.Controls.Add(control);
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            this.pnlContenido.Controls.Clear();
            ctlAtenderCita control = new ctlAtenderCita();
            control.Id_Empleado = Id_Empleado;
            control.Dock = DockStyle.Fill;
            this.pnlContenido.Controls.Add(control);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            this.pnlContenido.Controls.Clear();
            ctlCrearAgenda control = new ctlCrearAgenda();
            control.Dock = DockStyle.Fill;
            this.pnlContenido.Controls.Add(control);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMinMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized) this.WindowState = FormWindowState.Normal;
            else this.WindowState = FormWindowState.Maximized;
        }

        private void mostrarUsuario()
        {
            if (User != string.Empty)
            {
                EmpleadosModelo data = new EmpleadosModelo();
                DataTable tabla = new DataTable();
                data.cargarHeader(tabla, User);
                lblNombre.Text = tabla.Rows[0]["NombreCompleto"].ToString();
                Id_Empleado = Convert.ToInt32(tabla.Rows[0]["Id_Empleado"]);
                
            }

        }

        private void cargarPermisos()
        {
            UsuariosData usuarios = new UsuariosData();
            DataTable tabla = new DataTable();
            usuarios.mostrarUsuario(tabla, User);
            ibtnEmpleados.Visible = Convert.ToBoolean(tabla.Rows[0]["Empleados"]);
            ibtnClientes.Visible = Convert.ToBoolean(tabla.Rows[0]["Clientes"]);
            ibtnMascotas.Visible = Convert.ToBoolean(tabla.Rows[0]["Mascotas"]);
            ibtnCitas.Visible = Convert.ToBoolean(tabla.Rows[0]["Citas"]);
            ibtnProductos.Visible = Convert.ToBoolean(tabla.Rows[0]["Productos"]);
            ibtnFacturar.Visible = Convert.ToBoolean(tabla.Rows[0]["Ventas"]);
            ibtnUsuarios.Visible = Convert.ToBoolean(tabla.Rows[0]["Usuarios"]);
        }

    }
}
