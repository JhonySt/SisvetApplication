using System.Drawing;
using System.Windows.Forms;

namespace SisvetAPP.Vistas
{
    partial class ctlAtenderCita
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gridCitas = new System.Windows.Forms.DataGridView();
            this.Atender = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlHistoria = new System.Windows.Forms.Panel();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.btnprescripcion = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbMotivo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMascota = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCitas)).BeginInit();
            this.pnlHistoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(171)))), ((int)(((byte)(1)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 80);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 27.75F);
            this.label1.Location = new System.Drawing.Point(789, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Citas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(6)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(6)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridCitas.ColumnHeadersHeight = 30;
            this.gridCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Atender});
            this.gridCitas.EnableHeadersVisualStyles = false;
            this.gridCitas.Location = new System.Drawing.Point(563, 110);
            this.gridCitas.Name = "gridCitas";
            this.gridCitas.ReadOnly = true;
            this.gridCitas.RowHeadersVisible = false;
            this.gridCitas.RowHeadersWidth = 50;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(171)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.gridCitas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridCitas.RowTemplate.Height = 30;
            this.gridCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCitas.Size = new System.Drawing.Size(372, 179);
            this.gridCitas.TabIndex = 28;
            this.gridCitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCitas_CellClick);
            // 
            // Atender
            // 
            this.Atender.HeaderText = "Op";
            this.Atender.Name = "Atender";
            this.Atender.ReadOnly = true;
            this.Atender.Text = "Atender";
            this.Atender.UseColumnTextForButtonValue = true;
            this.Atender.Width = 33;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 577);
            this.panel2.TabIndex = 29;
            // 
            // pnlHistoria
            // 
            this.pnlHistoria.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlHistoria.Controls.Add(this.btnTerminar);
            this.pnlHistoria.Controls.Add(this.btnprescripcion);
            this.pnlHistoria.Controls.Add(this.btnGuardar);
            this.pnlHistoria.Controls.Add(this.txtObservaciones);
            this.pnlHistoria.Controls.Add(this.label11);
            this.pnlHistoria.Controls.Add(this.txtEdad);
            this.pnlHistoria.Controls.Add(this.label10);
            this.pnlHistoria.Controls.Add(this.txtDescripcion);
            this.pnlHistoria.Controls.Add(this.label9);
            this.pnlHistoria.Controls.Add(this.cbMotivo);
            this.pnlHistoria.Controls.Add(this.label8);
            this.pnlHistoria.Controls.Add(this.txtSexo);
            this.pnlHistoria.Controls.Add(this.label7);
            this.pnlHistoria.Controls.Add(this.txtPeso);
            this.pnlHistoria.Controls.Add(this.label6);
            this.pnlHistoria.Controls.Add(this.txtFecha);
            this.pnlHistoria.Controls.Add(this.label5);
            this.pnlHistoria.Controls.Add(this.txtRaza);
            this.pnlHistoria.Controls.Add(this.label4);
            this.pnlHistoria.Controls.Add(this.txtEspecie);
            this.pnlHistoria.Controls.Add(this.label3);
            this.pnlHistoria.Controls.Add(this.cbMascota);
            this.pnlHistoria.Controls.Add(this.label2);
            this.pnlHistoria.Location = new System.Drawing.Point(41, 131);
            this.pnlHistoria.Name = "pnlHistoria";
            this.pnlHistoria.Size = new System.Drawing.Size(706, 503);
            this.pnlHistoria.TabIndex = 30;
            this.pnlHistoria.Visible = false;
            // 
            // btnTerminar
            // 
            this.btnTerminar.BackColor = System.Drawing.Color.Red;
            this.btnTerminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTerminar.FlatAppearance.BorderSize = 0;
            this.btnTerminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerminar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTerminar.Location = new System.Drawing.Point(659, 486);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(88, 35);
            this.btnTerminar.TabIndex = 36;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = false;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // btnprescripcion
            // 
            this.btnprescripcion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnprescripcion.Location = new System.Drawing.Point(406, 154);
            this.btnprescripcion.Name = "btnprescripcion";
            this.btnprescripcion.Size = new System.Drawing.Size(203, 29);
            this.btnprescripcion.TabIndex = 35;
            this.btnprescripcion.Text = "Prescripción Médica";
            this.btnprescripcion.UseVisualStyleBackColor = true;
            this.btnprescripcion.Click += new System.EventHandler(this.btnprescripcion_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardar.Location = new System.Drawing.Point(565, 486);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 35);
            this.btnGuardar.TabIndex = 34;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtObservaciones.Location = new System.Drawing.Point(406, 248);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(341, 207);
            this.txtObservaciones.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(406, 218);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(215, 27);
            this.label11.TabIndex = 32;
            this.label11.Text = "Observaciones/Tratamiento:";
            // 
            // txtEdad
            // 
            this.txtEdad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEdad.Location = new System.Drawing.Point(615, 53);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(125, 26);
            this.txtEdad.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(549, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 21);
            this.label10.TabIndex = 30;
            this.label10.Text = "Edad:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDescripcion.Location = new System.Drawing.Point(12, 248);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(341, 207);
            this.txtDescripcion.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(12, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 27);
            this.label9.TabIndex = 14;
            this.label9.Text = "Descripcion del motivo:";
            // 
            // cbMotivo
            // 
            this.cbMotivo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMotivo.FormattingEnabled = true;
            this.cbMotivo.Items.AddRange(new object[] {
            "Seleccione una opcion",
            "Consulta General",
            "Vacunacion"});
            this.cbMotivo.Location = new System.Drawing.Point(148, 154);
            this.cbMotivo.Name = "cbMotivo";
            this.cbMotivo.Size = new System.Drawing.Size(173, 29);
            this.cbMotivo.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 46);
            this.label8.TabIndex = 12;
            this.label8.Text = "Motivo de la Consulta:";
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(148, 53);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.ReadOnly = true;
            this.txtSexo.Size = new System.Drawing.Size(125, 26);
            this.txtSexo.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "Sexo:";
            // 
            // txtPeso
            // 
            this.txtPeso.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPeso.Location = new System.Drawing.Point(406, 53);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(125, 26);
            this.txtPeso.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Peso:";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(148, 97);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(125, 26);
            this.txtFecha.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha:";
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(615, 10);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.ReadOnly = true;
            this.txtRaza.Size = new System.Drawing.Size(125, 26);
            this.txtRaza.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(549, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Raza:";
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(406, 10);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.ReadOnly = true;
            this.txtEspecie.Size = new System.Drawing.Size(125, 26);
            this.txtEspecie.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Especie:";
            // 
            // cbMascota
            // 
            this.cbMascota.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbMascota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMascota.FormattingEnabled = true;
            this.cbMascota.Location = new System.Drawing.Point(148, 7);
            this.cbMascota.Name = "cbMascota";
            this.cbMascota.Size = new System.Drawing.Size(173, 29);
            this.cbMascota.TabIndex = 1;
            this.cbMascota.TextChanged += new System.EventHandler(this.cbMascota_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre Mascota:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(20, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(867, 20);
            this.panel3.TabIndex = 31;
            // 
            // ctlAtenderCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlHistoria);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridCitas);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ctlAtenderCita";
            this.Size = new System.Drawing.Size(887, 657);
            this.Load += new System.EventHandler(this.ctlAtenderCita_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCitas)).EndInit();
            this.pnlHistoria.ResumeLayout(false);
            this.pnlHistoria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView gridCitas;
        private Panel panel2;
        private Panel pnlHistoria;
        private ComboBox cbMascota;
        private Label label2;
        private Label label3;
        private TextBox txtEspecie;
        private TextBox txtSexo;
        private Label label7;
        private TextBox txtPeso;
        private Label label6;
        private TextBox txtFecha;
        private Label label5;
        private TextBox txtRaza;
        private Label label4;
        private ComboBox cbMotivo;
        private Label label8;
        private Label label9;
        private TextBox txtDescripcion;
        private TextBox txtEdad;
        private Label label10;
        private Label label11;
        private Button btnprescripcion;
        private Button btnGuardar;
        private TextBox txtObservaciones;
        private Button btnTerminar;
        private Panel panel3;
        private DataGridViewButtonColumn Atender;
    }
}
