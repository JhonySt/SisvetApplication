using SisvetSHARED.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisvetAPP.Vistas
{
    public partial class ctlMascotas : UserControl
    {
        int Id_Mascota;

        #region Metodos Iniciales
        public ctlMascotas()
        {
            InitializeComponent();
        }
        private void ctlMascotas_Load(object sender, EventArgs e)
        {
            mostrarMascotas();
            mostrarTipos();
            this.txtBuscar.Focus();
        }
        #endregion


        #region Eventos
        private void GridMascotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                MascotasModelo mascotas = new MascotasModelo();
                Id_Mascota = Convert.ToInt32(this.GridMascotas.Rows[e.RowIndex].Cells[0].Value);
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtBuscar.Clear();
            mostrarMascotas();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            limpiarRegistro();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            mostrarRegistro();
            btnGuardar.Visible = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            mostrarRegistro();
            cargarRegistros();
            btnActualizarVerificar.Visible = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Estas seguro de borrar este registro?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.OK)
            {
                borrarMascota();
                mostrarMascotas();
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            cargarFoto();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            insertarMascota();
            mostrarMascotas();
            limpiarRegistro();
        }

        private void btnActualizarVerificar_Click(object sender, EventArgs e)
        {
            actualizarMascota();
            mostrarMascotas();
            limpiarRegistro();
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
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            buscarMascota();
        }
        #endregion


        #region Metodos Propios
        private void mostrarMascotas()
        {
            MascotasModelo mascotas = new MascotasModelo();
            DataTable tabla = new DataTable();
            mascotas.mostrarMascotas(tabla);
            GridMascotas.DataSource = tabla;
            GridMascotas.Columns[4].Visible = false;
            //GridMascotas.Columns[8].Visible = false;
            if (GridMascotas.Rows.Count > 0)
            {
                Id_Mascota = Convert.ToInt32(GridMascotas.Rows[0].Cells[0].Value);
            }
        }

        private void mostrarTipos()
        {
            DataTable tabla = new DataTable();
            TiposModelo tipos = new TiposModelo();
            tipos.mostrarTipos(tabla);
            DataRow row = tabla.NewRow();
            row[0] = 0;
            row[1] = "Seleccione una opcion";
            tabla.Rows.InsertAt(row, 0);
            cbTipo.DataSource = tabla;
            cbTipo.DisplayMember = "Descripcion";
            cbTipo.ValueMember = "Id_Tipo";

        }

        private void buscarMascota()
        {
            DataTable tabla = new DataTable();
            MascotasModelo mascotas = new MascotasModelo();
            mascotas.Buscador = this.txtBuscar.Text;
            mascotas.buscarMascota(tabla, mascotas.Buscador);
            GridMascotas.DataSource = tabla;
        }

        private void mostrarRegistro()
        {
            pnlRegistro.BringToFront();
            pnlRegistro.Dock = DockStyle.Fill;
            pnlBotones.Visible = false;
            GridMascotas.Visible = false;
            pnlRegistro.Visible = true;
            txtDocumento.Focus();
            picBuscar.Visible = false;
            txtBuscar.Visible = false;
            btnLimpiar.Visible = false;
        }

        private void limpiarRegistro()
        {
            txtDocumento.Clear();
            txtNombre.Clear();
            txtEdad.Clear();
            txtFoto.Clear();
            pbFoto.Image = null;
            cbTipo.SelectedValue = 0;
            btnActualizarVerificar.Visible = false;
            btnGuardar.Visible = false;
            pnlRegistro.Visible = false;
            pnlBotones.Visible = true;
            picBuscar.Visible = true;
            txtBuscar.Visible = true;
            btnLimpiar.Visible = true;
            GridMascotas.Visible = true;
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

        private void insertarMascota()
        {
            MascotasModelo mascotas = new MascotasModelo();
            mascotas.Cedula = this.txtDocumento.Text;
            mascotas.Nombre = this.txtNombre.Text;
            mascotas.Raza = this.txtRaza.Text;
            mascotas.Sexo = this.txtSexo.Text;
            mascotas.Edad = this.txtEdad.Text;
            mascotas.IdTipo = Convert.ToInt32(this.cbTipo.SelectedValue);
            if (this.txtFoto.Text != string.Empty)
            {
                FileStream stream = new FileStream(@txtFoto.Text, FileMode.Open, FileAccess.Read);
                mascotas.Foto = new byte[stream.Length];
                stream.Read(mascotas.Foto, 0, Convert.ToInt32(stream.Length));
            }

            ClientesModelo clientes = new ClientesModelo();
            DataTable tabla = new DataTable();
            clientes.buscarClienteCedula(tabla, mascotas.Cedula);
            if (tabla.Rows.Count != 0)
            {
                mascotas.Id_Cliente = Convert.ToInt32(tabla.Rows[0]["Id_Cliente"]);
                if (mascotas.insertarMascota())
                {
                    MessageBox.Show("Mascota ingresada de manera exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{mascotas.Error}\nError, la mascota no pudo ser ingresada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Documento no existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarRegistros()
        {
            MascotasModelo mascotas = new MascotasModelo();
            DataTable tabla = new DataTable();
            mascotas.Id_Mascota = Id_Mascota;
            mascotas.buscarMascotaId(tabla, mascotas.Id_Mascota);
            this.txtDocumento.Text = tabla.Rows[0]["Cedula"].ToString();
            this.txtNombre.Text = tabla.Rows[0]["Nombre"].ToString();
            this.txtEdad.Text = tabla.Rows[0]["Edad"].ToString();
            this.cbTipo.SelectedValue = tabla.Rows[0]["Id_Tipo"].ToString();
            if (tabla.Rows[0]["Foto"] != System.DBNull.Value)
            {
                byte[] misDatos = new byte[0];
                misDatos = (byte[])tabla.Rows[0]["Foto"];
                MemoryStream ms = new MemoryStream(misDatos);
                pbFoto.Image = Image.FromStream(ms);
            }

        }

        private void actualizarMascota()
        {
            MascotasModelo mascotas = new MascotasModelo();
            mascotas.Id_Mascota = Id_Mascota;
            mascotas.Cedula = this.txtDocumento.Text;
            mascotas.Nombre = this.txtNombre.Text;
            mascotas.Edad = this.txtEdad.Text;
            mascotas.IdTipo = Convert.ToInt32(this.cbTipo.SelectedValue);

            ClientesModelo clientes = new ClientesModelo();
            DataTable tabla = new DataTable();
            clientes.buscarClienteCedula(tabla, mascotas.Cedula);
            if (tabla.Rows.Count != 0)
            {
                mascotas.Id_Cliente = Convert.ToInt32(tabla.Rows[0]["Id_Cliente"]);
                if (mascotas.actualizarMascota())
                {
                    if (this.txtFoto.Text != string.Empty)
                    {
                        FileStream stream = new FileStream(@txtFoto.Text, FileMode.Open, FileAccess.Read);
                        mascotas.Foto = new byte[stream.Length];
                        stream.Read(mascotas.Foto, 0, Convert.ToInt32(stream.Length));
                        mascotas.actualizarMascotaFoto();
                    }
                    MessageBox.Show("Mascota actualizada de manera exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{mascotas.Error}\nError, la mascota no pudo ser actualizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Documento no existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void borrarMascota()
        {
            MascotasModelo mascotas = new MascotasModelo();
            mascotas.Id_Mascota = Id_Mascota;

            if (mascotas.borrarMascota())
            {
                MessageBox.Show("Mascota eliminada de manera exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error, la mascota no pudo ser eliminada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

    }
}
