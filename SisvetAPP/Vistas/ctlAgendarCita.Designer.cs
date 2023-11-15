using System;
using System.Drawing;
using System.Windows.Forms;

namespace SisvetAPP.Vistas
{
    partial class ctlAgendarCita
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMedicos = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.gridCitas = new System.Windows.Forms.DataGridView();
            this.Agendar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(171)))), ((int)(((byte)(1)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 80);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 27.75F);
            this.label1.Location = new System.Drawing.Point(734, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Citas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(41, 300);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(248, 26);
            this.txtFecha.TabIndex = 26;
            this.txtFecha.TextChanged += new System.EventHandler(this.txtFecha_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "Seleccione el medico:";
            // 
            // cbMedicos
            // 
            this.cbMedicos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbMedicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedicos.FormattingEnabled = true;
            this.cbMedicos.Location = new System.Drawing.Point(326, 146);
            this.cbMedicos.Name = "cbMedicos";
            this.cbMedicos.Size = new System.Drawing.Size(392, 29);
            this.cbMedicos.TabIndex = 24;
            this.cbMedicos.SelectedValueChanged += new System.EventHandler(this.cbMedicos_SelectedValueChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.monthCalendar1.Location = new System.Drawing.Point(41, 112);
            this.monthCalendar1.MinDate = new System.DateTime(2023, 9, 24, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 23;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // gridCitas
            // 
            this.gridCitas.AllowUserToAddRows = false;
            this.gridCitas.AllowUserToDeleteRows = false;
            this.gridCitas.AllowUserToResizeColumns = false;
            this.gridCitas.AllowUserToResizeRows = false;
            this.gridCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridCitas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridCitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridCitas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridCitas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(6)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(6)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridCitas.ColumnHeadersHeight = 30;
            this.gridCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Agendar});
            this.gridCitas.EnableHeadersVisualStyles = false;
            this.gridCitas.Location = new System.Drawing.Point(325, 300);
            this.gridCitas.Name = "gridCitas";
            this.gridCitas.ReadOnly = true;
            this.gridCitas.RowHeadersVisible = false;
            this.gridCitas.RowHeadersWidth = 50;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(171)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.gridCitas.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gridCitas.RowTemplate.Height = 30;
            this.gridCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCitas.Size = new System.Drawing.Size(393, 204);
            this.gridCitas.TabIndex = 27;
            this.gridCitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCitas_CellClick);
            // 
            // Agendar
            // 
            this.Agendar.HeaderText = "Op";
            this.Agendar.Name = "Agendar";
            this.Agendar.ReadOnly = true;
            this.Agendar.Text = "Agendar";
            this.Agendar.UseColumnTextForButtonValue = true;
            this.Agendar.Width = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 21);
            this.label3.TabIndex = 28;
            this.label3.Text = "No. Documento cliente:";
            // 
            // txtDocumento
            // 
            this.txtDocumento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDocumento.Location = new System.Drawing.Point(326, 248);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(392, 26);
            this.txtDocumento.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(832, 20);
            this.panel2.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 426);
            this.panel3.TabIndex = 31;
            // 
            // ctlAgendarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridCitas);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMedicos);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ctlAgendarCita";
            this.Size = new System.Drawing.Size(832, 526);
            this.Load += new System.EventHandler(this.ctlAgendarCita_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtFecha;
        private Label label2;
        private ComboBox cbMedicos;
        private MonthCalendar monthCalendar1;
        private DataGridView gridCitas;
        private Label label3;
        private TextBox txtDocumento;
        private Panel panel2;
        private Panel panel3;
        private DataGridViewButtonColumn Agendar;
    }
}
