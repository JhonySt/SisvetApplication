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
    public partial class ctlAgendarCita : UserControl
    {
        int Id_Cita = 0;
        public ctlAgendarCita()
        {
            InitializeComponent();
        }

        private void ctlAgendarCita_Load(object sender, EventArgs e)
        {
            mostrarMedicos();
            mostrarFecha();
        }

        private void mostrarMedicos()
        {
            DataTable tabla = new DataTable();
            EmpleadosModelo medicos = new EmpleadosModelo();
            medicos.mostrarMedicos(tabla);
            DataRow row = tabla.NewRow();
            row[0] = 0;
            row[1] = "Seleccione una opcion";
            tabla.Rows.InsertAt(row, 0);
            cbMedicos.DataSource = tabla;
            cbMedicos.DisplayMember = "NombreCompleto";
            cbMedicos.ValueMember = "Id_Empleado";

        }

        private void mostrarFecha()
        {
            txtFecha.Text = monthCalendar1.SelectionStart.ToShortDateString();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            mostrarFecha();
        }

        private void mostrarCitas()
        {
            DataTable tabla = new DataTable();
            CitasModelo citas = new CitasModelo();
            citas.fecha = Convert.ToDateTime(txtFecha.Text).Date;
            citas.Id_Empleado = Convert.ToInt32(cbMedicos.SelectedValue);
            citas.mostrarCitas(tabla);
            gridCitas.DataSource = tabla;
            gridCitas.Columns[1].Visible = false;
            gridCitas.Columns[4].Visible = false;
            gridCitas.Columns[5].Visible = false;


        }

        private void cbMedicos_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.txtFecha.Text != string.Empty)
            {
                mostrarCitas();
            }

        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {
            if (this.txtFecha.Text != string.Empty)
            {
                mostrarCitas();
            }
        }

        private void gridCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Id_Cita = Convert.ToInt32(this.gridCitas.Rows[e.RowIndex].Cells[1].Value);
            }
            if (e.ColumnIndex == gridCitas.Columns["Agendar"].Index)
            {

                DialogResult result = MessageBox.Show("¿Esta seguro de asignar la cita?", "Agendar Cita", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    agendarCita();
                }
            }
        }

        private void agendarCita()
        {
            if (txtDocumento.Text != string.Empty)
            {
                CitasModelo citas = new CitasModelo();
                citas.Id_Cita = Id_Cita;
                citas.Estado = this.txtDocumento.Text;
                if (citas.agendarCita())
                {
                    MessageBox.Show("Cita agendada con exito");
                    mostrarCitas();
                }
                else MessageBox.Show("Error, no se pudo agendar la cita");
            }
            else
            {
                MessageBox.Show("No ha ingresado un numero de documento", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
