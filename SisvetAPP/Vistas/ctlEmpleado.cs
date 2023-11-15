using SisvetSHARED.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
//using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;
using System.IO;

namespace SisvetAPP.Vistas
{
    public partial class ctlEmpleado : UserControl
    {
        int Id_Empleado;

        #region metodos iniciales
        public ctlEmpleado()
        {
            InitializeComponent();
        }

        private void ctlEmpleado_Load(object sender, EventArgs e)
        {
            mostrarEmpleados();
            mostrarCargos();
            this.txtBuscar.Focus();
        }
        #endregion

        #region eventos
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            mostrarRegistro();
            btnGuardar.Visible = true;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            limpiarRegistro();
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            buscarEmpleado();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtBuscar.Clear();
            mostrarEmpleados();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            insertarEmpleado();
            mostrarEmpleados();
            limpiarRegistro();
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            cargarFoto();
        }

        private void txtFoto_TextChanged(object sender, EventArgs e)
        {
            if (this.txtFoto.Text != string.Empty)
            {
                FileStream stream = new FileStream(@txtFoto.Text, FileMode.Open, FileAccess.Read);
                byte[] misDatos = new byte[stream.Length];
                stream.Read(misDatos, 0, Convert.ToInt32(stream.Length));
                MemoryStream ms = new MemoryStream(misDatos);
                pbFoto.Image = Image.FromStream(ms);
            }
        }
        private void GridEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                EmpleadosModelo empleado = new EmpleadosModelo();
                Id_Empleado = Convert.ToInt32(this.GridEmpleados.Rows[e.RowIndex].Cells[0].Value);
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
            actualizarEmpleado();
            mostrarEmpleados();
            limpiarRegistro();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Estas seguro de borrar este registro?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.OK)
            {
                borrarEmpleado();
                mostrarEmpleados();
            }

        }
        #endregion

        #region metodos propios
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
        private void mostrarEmpleados()
        {
            EmpleadosModelo Empleados = new EmpleadosModelo();
            DataTable tabla = new DataTable();
            Empleados.mostrarEmpleados(tabla);
            GridEmpleados.DataSource = tabla;
            GridEmpleados.Columns[7].Visible = false;
            GridEmpleados.Columns[8].Visible = false;
            if (GridEmpleados.Rows.Count > 0)
            {
                Id_Empleado = Convert.ToInt32(GridEmpleados.Rows[0].Cells[0].Value);
            }
        }

        private void limpiarRegistro()
        {
            txtDocumento.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtFoto.Clear();
            pbFoto.Image = null;
            cbCargo.SelectedValue = 0;
            btnActualizarVerificar.Visible = false;
            btnGuardar.Visible = false;
            pnlRegistro.Visible = false;
            pnlBotones.Visible = true;
            picBuscar.Visible = true;
            txtBuscar.Visible = true;
            btnLimpiar.Visible = true;
            GridEmpleados.Visible = true;
        }

        private void mostrarRegistro()
        {
            pnlRegistro.BringToFront();
            pnlRegistro.Dock = DockStyle.Fill;
            pnlBotones.Visible = false;
            GridEmpleados.Visible = false;
            pnlRegistro.Visible = true;
            txtDocumento.Focus();
            picBuscar.Visible = false;
            txtBuscar.Visible = false;
            btnLimpiar.Visible = false;
        }
        private void cargarRegistros()
        {
            EmpleadosModelo empleado = new EmpleadosModelo();
            DataTable tabla = new DataTable();
            empleado.Id_Empleado = Id_Empleado;
            empleado.buscarEmpleadoId(tabla, empleado.Id_Empleado);
            this.txtDocumento.Text = tabla.Rows[0]["Cedula"].ToString();
            this.txtNombre.Text = tabla.Rows[0]["NombreCompleto"].ToString();
            this.txtDireccion.Text = tabla.Rows[0]["Direccion"].ToString();
            this.txtTelefono.Text = tabla.Rows[0]["Telefono"].ToString();
            this.txtCorreo.Text = tabla.Rows[0]["Correo"].ToString();
            this.cbCargo.SelectedValue = tabla.Rows[0]["Id_Cargo"].ToString();
            if (tabla.Rows[0]["Foto"] != System.DBNull.Value)
            {
                byte[] misDatos = new byte[0];
                misDatos = (byte[])tabla.Rows[0]["Foto"];
                MemoryStream ms = new MemoryStream(misDatos);
                pbFoto.Image = Image.FromStream(ms);
            }

        }
        private void mostrarCargos()
        {
            DataTable tabla = new DataTable();
            CargosModelo cargos = new CargosModelo();
            cargos.mostrarCargos(tabla);
            DataRow row = tabla.NewRow();
            row[0] = 0;
            row[1] = "Seleccione una opcion";
            tabla.Rows.InsertAt(row, 0);
            cbCargo.DataSource = tabla;
            cbCargo.DisplayMember = "Descripcion";
            cbCargo.ValueMember = "Id_Cargo";

        }

        private void buscarEmpleado()
        {
            DataTable tabla = new DataTable();
            EmpleadosModelo empleado = new EmpleadosModelo();
            empleado.Buscador = this.txtBuscar.Text;
            empleado.buscarEmpleado(tabla, empleado.Buscador);
            GridEmpleados.DataSource = tabla;
        }
        private void cargarFoto()
        {

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txtFoto.Text = openFileDialog1.FileName;
            }

        }

        private void insertarEmpleado()
        {
            EmpleadosModelo empleado = new EmpleadosModelo();
            empleado.Cedula = this.txtDocumento.Text;
            empleado.NombreCompleto = this.txtNombre.Text;
            empleado.Direccion = this.txtDireccion.Text;
            empleado.Telefono = this.txtTelefono.Text;
            empleado.Correo = this.txtCorreo.Text;
            empleado.IdCargo = Convert.ToInt32(this.cbCargo.SelectedValue);
            if (this.txtFoto.Text != string.Empty)
            {
                FileStream stream = new FileStream(@txtFoto.Text, FileMode.Open, FileAccess.Read);
                empleado.Foto = new byte[stream.Length];
                stream.Read(empleado.Foto, 0, Convert.ToInt32(stream.Length));
            }

            if (empleado.insertarEmpleado())
            {
                MessageBox.Show("Empleado ingresado de manera exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"{empleado.Error}\nError, el empleado no pudo ser ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void actualizarEmpleado()
        {
            EmpleadosModelo empleado = new EmpleadosModelo();
            empleado.Id_Empleado = Id_Empleado;
            empleado.Cedula = this.txtDocumento.Text;
            empleado.NombreCompleto = this.txtNombre.Text;
            empleado.Direccion = this.txtDireccion.Text;
            empleado.Telefono = this.txtTelefono.Text;
            empleado.Correo = this.txtCorreo.Text;
            empleado.IdCargo = Convert.ToInt32(this.cbCargo.SelectedValue);

            if (empleado.actualizarEmpleado())
            {
                if (this.txtFoto.Text != string.Empty)
                {
                    FileStream stream = new FileStream(@txtFoto.Text, FileMode.Open, FileAccess.Read);
                    empleado.Foto = new byte[stream.Length];
                    stream.Read(empleado.Foto, 0, Convert.ToInt32(stream.Length));
                    empleado.actualizarEmpleadoFoto();
                }
                MessageBox.Show("Empleado actualizado de manera exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"{empleado.Error}\nError, el empleado no pudo ser actualizado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void borrarEmpleado()
        {
            EmpleadosModelo empleado = new EmpleadosModelo();
            empleado.Id_Empleado = Id_Empleado;

            if (empleado.borrarEmpleado())
            {
                MessageBox.Show("Empleado eliminado de manera exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error, el empleado no pudo ser eliminado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


    }
}
