using SisvetAPP.Vistas.Reportes;
using SisvetSHARED.Datos;
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
    public partial class PrescripcionMedica : Form
    {
        public int IdCliente = 0;
        public PrescripcionMedica()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombre.Text;
            string Cantidad = txtCantidad.Text;
            string Presentacion = txtPresentacion.Text;
            string Indicaciones = txtIndicaciones.Text;
            gridPrescripcion.Rows.Add(new object[]
            {
                Nombre, Cantidad, Presentacion, Indicaciones, "Eliminar"
            });
            txtNombre.Clear();
            txtCantidad.Clear();
            txtPresentacion.Clear();
            txtIndicaciones.Clear();
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                List<PrescripcionDetalleModelo> listaDetalle = new List<PrescripcionDetalleModelo>();

                foreach (DataGridViewRow row in gridPrescripcion.Rows)
                {
                    PrescripcionDetalleModelo oDetalle = new PrescripcionDetalleModelo();
                    oDetalle.Nombre = row.Cells[0].Value.ToString();
                    oDetalle.Cantidad = row.Cells[1].Value.ToString();
                    oDetalle.Presentacion = row.Cells[2].Value.ToString();
                    oDetalle.Indicaciones = row.Cells[3].Value.ToString();
                    listaDetalle.Add(oDetalle);
                }

                PreescripcionData detalle = new PreescripcionData();
                if (detalle.insertarPrescripcion(IdCliente, listaDetalle))
                {
                    MessageBox.Show("Prescripcion medica guardada con exito");
                    txtId.Text = detalle.Id_Prescripcion.ToString();
                }
                else MessageBox.Show("Error al guardar prescripcion");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void gridPrescripcion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gridPrescripcion.Columns["Op"].Index)
            {
                gridPrescripcion.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Prescripcion prescripcion = new Prescripcion();
            prescripcion.txtId.Text = txtId.Text;
            prescripcion.ShowDialog();
        }

      
    }
}
