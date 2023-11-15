namespace SisvetAPP.Vistas.Reportes
{
    partial class Prescripcion
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetDetallePrescripcion = new SisvetAPP.Vistas.Reportes.DataSetDetallePrescripcion();
            this.mOSTRARPRESCRIPCIONENCABEZADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mOSTRAR_PRESCRIPCION_ENCABEZADOTableAdapter = new SisvetAPP.Vistas.Reportes.DataSetDetallePrescripcionTableAdapters.MOSTRAR_PRESCRIPCION_ENCABEZADOTableAdapter();
            this.mOSTRARPRESCRIPCIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mOSTRAR_PRESCRIPCIONTableAdapter = new SisvetAPP.Vistas.Reportes.DataSetDetallePrescripcionTableAdapters.MOSTRAR_PRESCRIPCIONTableAdapter();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDetallePrescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOSTRARPRESCRIPCIONENCABEZADOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOSTRARPRESCRIPCIONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSetEncabezado";
            reportDataSource3.Value = this.mOSTRARPRESCRIPCIONENCABEZADOBindingSource;
            reportDataSource4.Name = "DataSetDetalle";
            reportDataSource4.Value = this.mOSTRARPRESCRIPCIONBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SisvetAPP.Vistas.Reportes.RptPrescripcion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetDetallePrescripcion
            // 
            this.dataSetDetallePrescripcion.DataSetName = "DataSetDetallePrescripcion";
            this.dataSetDetallePrescripcion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mOSTRARPRESCRIPCIONENCABEZADOBindingSource
            // 
            this.mOSTRARPRESCRIPCIONENCABEZADOBindingSource.DataMember = "MOSTRAR_PRESCRIPCION_ENCABEZADO";
            this.mOSTRARPRESCRIPCIONENCABEZADOBindingSource.DataSource = this.dataSetDetallePrescripcion;
            // 
            // mOSTRAR_PRESCRIPCION_ENCABEZADOTableAdapter
            // 
            this.mOSTRAR_PRESCRIPCION_ENCABEZADOTableAdapter.ClearBeforeFill = true;
            // 
            // mOSTRARPRESCRIPCIONBindingSource
            // 
            this.mOSTRARPRESCRIPCIONBindingSource.DataMember = "MOSTRAR_PRESCRIPCION";
            this.mOSTRARPRESCRIPCIONBindingSource.DataSource = this.dataSetDetallePrescripcion;
            // 
            // mOSTRAR_PRESCRIPCIONTableAdapter
            // 
            this.mOSTRAR_PRESCRIPCIONTableAdapter.ClearBeforeFill = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(56, 57);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 1;
            this.txtId.Visible = false;
            // 
            // Prescripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Prescripcion";
            this.Text = "Prescripcion";
            this.Load += new System.EventHandler(this.Prescripcion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDetallePrescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOSTRARPRESCRIPCIONENCABEZADOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOSTRARPRESCRIPCIONBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource mOSTRARPRESCRIPCIONENCABEZADOBindingSource;
        private DataSetDetallePrescripcion dataSetDetallePrescripcion;
        private System.Windows.Forms.BindingSource mOSTRARPRESCRIPCIONBindingSource;
        private DataSetDetallePrescripcionTableAdapters.MOSTRAR_PRESCRIPCION_ENCABEZADOTableAdapter mOSTRAR_PRESCRIPCION_ENCABEZADOTableAdapter;
        private DataSetDetallePrescripcionTableAdapters.MOSTRAR_PRESCRIPCIONTableAdapter mOSTRAR_PRESCRIPCIONTableAdapter;
        internal System.Windows.Forms.TextBox txtId;
    }
}