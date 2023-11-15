namespace SisvetAPP.Vistas.Reportes
{
    partial class Factura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dataSetDetalleFactura = new SisvetAPP.Vistas.Reportes.DataSetDetalleFactura();
            this.mOSTRARFACTURAENCABEZADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mOSTRAR_FACTURA_ENCABEZADOTableAdapter = new SisvetAPP.Vistas.Reportes.DataSetDetalleFacturaTableAdapters.MOSTRAR_FACTURA_ENCABEZADOTableAdapter();
            this.mOSTRARFACTURABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mOSTRAR_FACTURATableAdapter = new SisvetAPP.Vistas.Reportes.DataSetDetalleFacturaTableAdapters.MOSTRAR_FACTURATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDetalleFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOSTRARFACTURAENCABEZADOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOSTRARFACTURABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetEncabezado";
            reportDataSource1.Value = this.mOSTRARFACTURAENCABEZADOBindingSource;
            reportDataSource2.Name = "DataSetDetalle";
            reportDataSource2.Value = this.mOSTRARFACTURABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SisvetAPP.Vistas.Reportes.RptFactura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(82, 52);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(114, 20);
            this.txtId.TabIndex = 1;
            this.txtId.Visible = false;
            // 
            // dataSetDetalleFactura
            // 
            this.dataSetDetalleFactura.DataSetName = "DataSetDetalleFactura";
            this.dataSetDetalleFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mOSTRARFACTURAENCABEZADOBindingSource
            // 
            this.mOSTRARFACTURAENCABEZADOBindingSource.DataMember = "MOSTRAR_FACTURA_ENCABEZADO";
            this.mOSTRARFACTURAENCABEZADOBindingSource.DataSource = this.dataSetDetalleFactura;
            // 
            // mOSTRAR_FACTURA_ENCABEZADOTableAdapter
            // 
            this.mOSTRAR_FACTURA_ENCABEZADOTableAdapter.ClearBeforeFill = true;
            // 
            // mOSTRARFACTURABindingSource
            // 
            this.mOSTRARFACTURABindingSource.DataMember = "MOSTRAR_FACTURA";
            this.mOSTRARFACTURABindingSource.DataSource = this.dataSetDetalleFactura;
            // 
            // mOSTRAR_FACTURATableAdapter
            // 
            this.mOSTRAR_FACTURATableAdapter.ClearBeforeFill = true;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Factura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDetalleFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOSTRARFACTURAENCABEZADOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOSTRARFACTURABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        internal System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.BindingSource mOSTRARFACTURAENCABEZADOBindingSource;
        private DataSetDetalleFactura dataSetDetalleFactura;
        private System.Windows.Forms.BindingSource mOSTRARFACTURABindingSource;
        private DataSetDetalleFacturaTableAdapters.MOSTRAR_FACTURA_ENCABEZADOTableAdapter mOSTRAR_FACTURA_ENCABEZADOTableAdapter;
        private DataSetDetalleFacturaTableAdapters.MOSTRAR_FACTURATableAdapter mOSTRAR_FACTURATableAdapter;
    }
}