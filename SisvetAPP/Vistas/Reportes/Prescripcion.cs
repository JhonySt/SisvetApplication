using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisvetAPP.Vistas.Reportes
{
    public partial class Prescripcion : Form
    {
        public Prescripcion()
        {
            InitializeComponent();
        }

        private void Prescripcion_Load(object sender, EventArgs e)
        {
            this.mOSTRAR_PRESCRIPCION_ENCABEZADOTableAdapter.Fill(this.dataSetDetallePrescripcion.MOSTRAR_PRESCRIPCION_ENCABEZADO,Convert.ToInt32(txtId.Text));
            this.mOSTRAR_PRESCRIPCIONTableAdapter.Fill(this.dataSetDetallePrescripcion.MOSTRAR_PRESCRIPCION,Convert.ToInt32(txtId.Text));
            this.reportViewer1.RefreshReport();
        }
    }
}
