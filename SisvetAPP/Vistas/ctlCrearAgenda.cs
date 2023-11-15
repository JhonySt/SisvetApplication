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
    public partial class ctlCrearAgenda : UserControl
    {
        public ctlCrearAgenda()
        {
            InitializeComponent();
        }

        private void ctlCrearAgenda_Load(object sender, EventArgs e)
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
            row[1] = "Seleccione un medico:";
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            insertarCita();
        }

        private List<string> crearListaHora()
        {
            List<string> lista = new List<string>();
            for (int i = 0; i < listaHoras.CheckedItems.Count; i++)
            {
                lista.Add(listaHoras.CheckedItems[i].ToString());
            }
            return lista;
        }

        private void insertarCita()
        {
            int exito = 0;
            CitasModelo citas = new CitasModelo();
            citas.Id_Empleado = Convert.ToInt32(cbMedicos.SelectedValue);
            citas.fecha = Convert.ToDateTime(txtFecha.Text);
            // MessageBox.Show(citas.fecha.Date.ToString());
            List<string> lista = new List<string>();
            lista = crearListaHora();
            if (lista.Count == 0) MessageBox.Show("Seleccione una hora");
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista.Count > 0) citas.Hora = lista[i].ToString();
                if (citas.insertarCita()) exito = exito + 1;
                else MessageBox.Show(citas.Error);
            }
            MessageBox.Show("Citas a crear: " + lista.Count + "\nCitas creadas con exito: " + exito);



        }

        private void btnMarcar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listaHoras.Items.Count; i++)
            {
                listaHoras.SetItemChecked(i, true);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            for (int i = 0; i < listaHoras.Items.Count; i++)
            {
                listaHoras.SetItemChecked(i, false);
            }
            cbMedicos.SelectedValue = 0;
        }

    }
}
