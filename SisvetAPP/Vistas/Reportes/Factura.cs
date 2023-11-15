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
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            this.mOSTRAR_FACTURA_ENCABEZADOTableAdapter.Fill(this.dataSetDetalleFactura.MOSTRAR_FACTURA_ENCABEZADO,Convert.ToInt32(txtId.Text));
            this.mOSTRAR_FACTURATableAdapter.Fill(this.dataSetDetalleFactura.MOSTRAR_FACTURA, Convert.ToInt32(txtId.Text));
            this.reportViewer1.RefreshReport();
        }
    }
}
