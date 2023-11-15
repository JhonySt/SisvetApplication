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
    public partial class ctlCancelarCita : UserControl
    {
        int Id_Cita = 0;
        public ctlCancelarCita()
        {
            InitializeComponent();
        }

        private void ctlCancelarCita_Load(object sender, EventArgs e)
        {
            buscarCita();
        }

        private void buscarCita()
        {
            DataTable tabla = new DataTable();
            CitasModelo citas = new CitasModelo();
            citas.Buscador = this.txtBuscar.Text;
            citas.buscarCita(tabla);
            gridCitas.DataSource = tabla;
            gridCitas.Columns[1].Visible = false;
            gridCitas.Columns[4].Visible = false;
            gridCitas.Columns[5].Visible = false;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            buscarCita();
        }

        private void gridCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Id_Cita = Convert.ToInt32(this.gridCitas.Rows[e.RowIndex].Cells[1].Value);
            }
            if (e.ColumnIndex == gridCitas.Columns["Cancelar"].Index)
            {

                DialogResult result = MessageBox.Show("¿Esta seguro de cancelar la cita?", "Cancelar Cita", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    cancelarCita();
                }
            }
        }

        private void cancelarCita()
        {

            CitasModelo citas = new CitasModelo();
            citas.Id_Cita = Id_Cita;
            if (citas.cancelarCita())
            {
                MessageBox.Show("Cita cancelada con exito");
                buscarCita();
            }
            else MessageBox.Show("Error, no se pudo cancelar la cita");

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
        }

    }
}
