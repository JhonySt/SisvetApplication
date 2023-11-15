
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
    public partial class ctlAtenderCita : UserControl
    {
        public int Id_Empleado = 3;
        int Id_Cita = 0;
        int Id_Mascota = 0;
        int Id_Cliente = 0;
        public ctlAtenderCita()
        {
            InitializeComponent();
        }

        private void ctlAtenderCita_Load(object sender, EventArgs e)
        {
            mostrarCitas();
            //mostrarMascotaCliente();
        }

        private void mostrarCitas()
        {
            gridCitas.BringToFront();
            gridCitas.Dock = DockStyle.Fill;
            DataTable tabla = new DataTable();
            CitasModelo citas = new CitasModelo();
            citas.fecha = DateTime.Now.Date;
            citas.Id_Empleado = Id_Empleado;
            citas.mostrarCitasAsignadas(tabla);
            gridCitas.DataSource = tabla;
            gridCitas.Columns[1].Visible = false;
            gridCitas.Columns[4].Visible = false;
            gridCitas.Columns[5].Visible = false;
        }

        private void mostrarMascotaCliente()
        {
            DataTable tabla = new DataTable();
            MascotasModelo mascotas = new MascotasModelo();
            mascotas.Id_Cliente = Id_Cliente;
            mascotas.mostrarMascotaCliente(tabla);
            DataRow row = tabla.NewRow();
            row[0] = 0;
            row[1] = "Seleccione una mascota";
            tabla.Rows.InsertAt(row, 0);
            cbMascota.DataSource = tabla;
            cbMascota.DisplayMember = "Nombre";
            cbMascota.ValueMember = "Id_Mascota";
            cbMotivo.SelectedIndex = 0;
        }

        private void gridCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Id_Cita = Convert.ToInt32(this.gridCitas.Rows[e.RowIndex].Cells[1].Value);
                Id_Cliente = Convert.ToInt32(this.gridCitas.Rows[e.RowIndex].Cells[4].Value);
            }
            if (e.ColumnIndex == gridCitas.Columns["Atender"].Index)
            {

                DialogResult result = MessageBox.Show("¿Esta seguro de atender la cita?", "Atender Cita", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    mostrarMascotaCliente();
                    gridCitas.Visible = false;
                    pnlHistoria.BringToFront();
                    pnlHistoria.Dock = DockStyle.Fill;
                    pnlHistoria.Visible = true;

                }
            }
        }

        private void cbMascota_TextChanged(object sender, EventArgs e)
        {
            if (cbMascota.Text != string.Empty && cbMascota.Text != "Seleccione una mascota")
            {
                MascotasModelo mascotas = new MascotasModelo();
                DataTable tabla = new DataTable();
                Id_Mascota = Convert.ToInt32(cbMascota.SelectedValue);
                mascotas.buscarMascotaId(tabla, Id_Mascota);
                this.txtRaza.Text = tabla.Rows[0]["Raza"].ToString();
                this.txtSexo.Text = tabla.Rows[0]["Sexo"].ToString();
                this.txtFecha.Text = DateTime.Now.Date.ToString("d");
                this.txtEspecie.Text = tabla.Rows[0]["Descripcion"].ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            insertarHistoria();
        }

        private void insertarHistoria()
        {
            HistoriaModelo historia = new HistoriaModelo();
            historia.Id_Mascota = Convert.ToInt32(cbMascota.SelectedValue);
            historia.Motivo = this.cbMotivo.SelectedItem.ToString();
            historia.Descripcion = this.txtDescripcion.Text;
            historia.Observacion = this.txtObservaciones.Text;
            historia.Peso = this.txtPeso.Text;
            historia.Edad = this.txtEdad.Text;
            if (historia.insertarHistoria())
            {
                MessageBox.Show("Historia guardada con exito");
            }
            else
            {
                MessageBox.Show("No se pudo guardar el registro" + historia.Error);
            }
        }

        private void limpiar()
        {
            txtDescripcion.Clear();
            txtObservaciones.Clear();
            txtEdad.Clear();
            txtEspecie.Clear();
            txtRaza.Clear();
            txtPeso.Clear();
            txtSexo.Clear();
            cbMotivo.SelectedIndex = 0;
            cbMascota.SelectedIndex = 0;
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            CitasModelo citas = new CitasModelo();
            citas.terminarCita(Id_Cita);
            mostrarCitas();
            limpiar();
            gridCitas.Visible = true;
            pnlHistoria.Visible = false;

        }

        private void btnprescripcion_Click(object sender, EventArgs e)
        {
            PrescripcionMedica main = new PrescripcionMedica();
            main.IdCliente = Id_Cliente;
            main.Show();
        }

    }
}
