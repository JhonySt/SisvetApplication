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
    public partial class ctlClientes : UserControl
    {
        int Id_Cliente;

        #region Metodos iniciales
        public ctlClientes()
        {
            InitializeComponent();
        }
        private void ctlClientes_Load(object sender, EventArgs e)
        {
            mostrarClientes();
            this.txtBuscar.Focus();
        }
        #endregion


        #region Eventos
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            buscarCliente();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtBuscar.Clear();
            mostrarClientes();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            mostrarRegistro();
            btnGuardar.Visible = true;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            limpiarRegistro();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            insertarCliente();
            mostrarClientes();
            limpiarRegistro();
        }
        private void GridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //EmpleadosModelo empleado = new EmpleadosModelo();
                Id_Cliente = Convert.ToInt32(this.GridClientes.Rows[e.RowIndex].Cells[0].Value);
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            mostrarRegistro();
            cargarRegistros();
            btnActualizarVerificar.Visible = true;
        }
        private void btnActualizarVerificar_Click(object sender, EventArgs e)
        {
            actualizarCliente();
            mostrarClientes();
            limpiarRegistro();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Estas seguro de borrar este registro?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.OK)
            {
                borrarCliente();
                mostrarClientes();
            }
        }
        #endregion


        #region Metodos propios
        private void mostrarClientes()
        {
            ClientesModelo Clientes = new ClientesModelo();
            DataTable tabla = new DataTable();
            Clientes.mostrarClientes(tabla);
            GridClientes.DataSource = tabla;
            GridClientes.Columns[6].Visible = false;
            //GridClientes.Columns[8].Visible = false;
            if (GridClientes.Rows.Count > 0)
            {
                Id_Cliente = Convert.ToInt32(GridClientes.Rows[0].Cells[0].Value);
            }
        }

        private void limpiarRegistro()
        {
            txtDocumento.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            btnActualizarVerificar.Visible = false;
            btnGuardar.Visible = false;
            pnlRegistro.Visible = false;
            pnlBotones.Visible = true;
            picBuscar.Visible = true;
            txtBuscar.Visible = true;
            btnLimpiar.Visible = true;
            GridClientes.Visible = true;
        }

        private void buscarCliente()
        {
            DataTable tabla = new DataTable();
            ClientesModelo cliente = new ClientesModelo();
            cliente.Buscador = this.txtBuscar.Text;
            cliente.buscarCliente(tabla, cliente.Buscador);
            GridClientes.DataSource = tabla;
        }

        private void mostrarRegistro()
        {
            pnlRegistro.BringToFront();
            pnlRegistro.Dock = DockStyle.Fill;
            pnlBotones.Visible = false;
            GridClientes.Visible = false;
            pnlRegistro.Visible = true;
            txtDocumento.Focus();
            picBuscar.Visible = false;
            txtBuscar.Visible = false;
            btnLimpiar.Visible = false;
        }

        private void insertarCliente()
        {
            ClientesModelo clientes = new ClientesModelo();
            clientes.Cedula = this.txtDocumento.Text;
            clientes.NombreCompleto = this.txtNombre.Text;
            clientes.Direccion = this.txtDireccion.Text;
            clientes.Telefono = this.txtTelefono.Text;
            clientes.Correo = this.txtCorreo.Text;

            if (clientes.insertarCliente())
            {
                MessageBox.Show("Cliente ingresado de manera exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"{clientes.Error}\nError, el cliente no pudo ser ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarRegistros()
        {
            ClientesModelo clientes = new ClientesModelo();
            DataTable tabla = new DataTable();
            clientes.Id_Cliente = Id_Cliente;
            clientes.buscarClienteId(tabla, clientes.Id_Cliente);
            this.txtDocumento.Text = tabla.Rows[0]["Cedula"].ToString();
            this.txtNombre.Text = tabla.Rows[0]["NombreCompleto"].ToString();
            this.txtDireccion.Text = tabla.Rows[0]["Direccion"].ToString();
            this.txtTelefono.Text = tabla.Rows[0]["Telefono"].ToString();
            this.txtCorreo.Text = tabla.Rows[0]["Correo"].ToString();

        }
        private void actualizarCliente()
        {
            ClientesModelo clientes = new ClientesModelo();
            clientes.Id_Cliente = Id_Cliente;
            clientes.Cedula = this.txtDocumento.Text;
            clientes.NombreCompleto = this.txtNombre.Text;
            clientes.Direccion = this.txtDireccion.Text;
            clientes.Telefono = this.txtTelefono.Text;
            clientes.Correo = this.txtCorreo.Text;

            if (clientes.actualizarCliente())
            {
                MessageBox.Show("Cliente actualizado de manera exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"{clientes.Error}\nError, el cliente no pudo ser actualizado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void borrarCliente()
        {
            ClientesModelo clientes = new ClientesModelo();
            clientes.Id_Cliente = Id_Cliente;

            if (clientes.borrarCliente())
            {
                MessageBox.Show("Cliente eliminado de manera exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error, el cliente no pudo ser eliminado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }








        #endregion


    }
}
