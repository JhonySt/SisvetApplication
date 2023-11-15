using System.Drawing;
using System.Windows.Forms;

namespace SisvetAPP.Vistas
{
    partial class Principal
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
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.ibtnCerrarSesion = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMinMax = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.ibtnUsuarios = new FontAwesome.Sharp.IconButton();
            this.ibtnFacturar = new FontAwesome.Sharp.IconButton();
            this.ibtnProductos = new FontAwesome.Sharp.IconButton();
            this.pnlSubCitas = new System.Windows.Forms.Panel();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnAtender = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ibtnCitas = new FontAwesome.Sharp.IconButton();
            this.ibtnMascotas = new FontAwesome.Sharp.IconButton();
            this.ibtnClientes = new FontAwesome.Sharp.IconButton();
            this.ibtnEmpleados = new FontAwesome.Sharp.IconButton();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlSubCitas.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogo
            // 
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(200, 142);
            this.pnlLogo.TabIndex = 0;
            this.pnlLogo.TabStop = true;
            this.pnlLogo.Click += new System.EventHandler(this.pnlLogo_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(6)))), ((int)(((byte)(57)))));
            this.panel3.Controls.Add(this.lblNombre);
            this.panel3.Controls.Add(this.ibtnCerrarSesion);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.MinimumSize = new System.Drawing.Size(0, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(579, 76);
            this.panel3.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombre.Location = new System.Drawing.Point(79, 41);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(22, 21);
            this.lblNombre.TabIndex = 23;
            this.lblNombre.Text = "...";
            // 
            // ibtnCerrarSesion
            // 
            this.ibtnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Right;
            this.ibtnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.ibtnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(126)))), ((int)(((byte)(3)))));
            this.ibtnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(124)))));
            this.ibtnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCerrarSesion.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.ibtnCerrarSesion.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnCerrarSesion.IconSize = 32;
            this.ibtnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnCerrarSesion.Location = new System.Drawing.Point(419, 26);
            this.ibtnCerrarSesion.Name = "ibtnCerrarSesion";
            this.ibtnCerrarSesion.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ibtnCerrarSesion.Size = new System.Drawing.Size(160, 50);
            this.ibtnCerrarSesion.TabIndex = 22;
            this.ibtnCerrarSesion.Text = "Cerrar Sesion";
            this.ibtnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnCerrarSesion.UseVisualStyleBackColor = true;
            this.ibtnCerrarSesion.Click += new System.EventHandler(this.ibtnCerrarSesion_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnMin);
            this.panel2.Controls.Add(this.btnMinMax);
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(579, 26);
            this.panel2.TabIndex = 10;
            // 
            // btnMin
            // 
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(126)))), ((int)(((byte)(3)))));
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(124)))));
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Image = global::SisvetAPP.Properties.Resources.minimizar;
            this.btnMin.Location = new System.Drawing.Point(504, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(25, 26);
            this.btnMin.TabIndex = 25;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMinMax
            // 
            this.btnMinMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinMax.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnMinMax.FlatAppearance.BorderSize = 0;
            this.btnMinMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(126)))), ((int)(((byte)(3)))));
            this.btnMinMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(124)))));
            this.btnMinMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinMax.Image = global::SisvetAPP.Properties.Resources.minMax;
            this.btnMinMax.Location = new System.Drawing.Point(529, 0);
            this.btnMinMax.Name = "btnMinMax";
            this.btnMinMax.Size = new System.Drawing.Size(25, 26);
            this.btnMinMax.TabIndex = 24;
            this.btnMinMax.UseVisualStyleBackColor = true;
            this.btnMinMax.Click += new System.EventHandler(this.btnMinMax_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(126)))), ((int)(((byte)(3)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(124)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::SisvetAPP.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(554, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 26);
            this.btnCerrar.TabIndex = 23;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlContenido
            // 
            this.pnlContenido.AutoSize = true;
            this.pnlContenido.Controls.Add(this.label1);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(200, 76);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(579, 673);
            this.pnlContenido.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F);
            this.label1.Location = new System.Drawing.Point(286, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veterinaria";
            // 
            // pnlMenu
            // 
            this.pnlMenu.AutoScroll = true;
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(6)))), ((int)(((byte)(57)))));
            this.pnlMenu.Controls.Add(this.ibtnUsuarios);
            this.pnlMenu.Controls.Add(this.ibtnFacturar);
            this.pnlMenu.Controls.Add(this.ibtnProductos);
            this.pnlMenu.Controls.Add(this.pnlSubCitas);
            this.pnlMenu.Controls.Add(this.ibtnCitas);
            this.pnlMenu.Controls.Add(this.ibtnMascotas);
            this.pnlMenu.Controls.Add(this.ibtnClientes);
            this.pnlMenu.Controls.Add(this.ibtnEmpleados);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 749);
            this.pnlMenu.TabIndex = 19;
            // 
            // ibtnUsuarios
            // 
            this.ibtnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnUsuarios.FlatAppearance.BorderSize = 0;
            this.ibtnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(126)))), ((int)(((byte)(3)))));
            this.ibtnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(124)))));
            this.ibtnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnUsuarios.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnUsuarios.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.ibtnUsuarios.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnUsuarios.IconSize = 32;
            this.ibtnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnUsuarios.Location = new System.Drawing.Point(0, 668);
            this.ibtnUsuarios.Name = "ibtnUsuarios";
            this.ibtnUsuarios.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnUsuarios.Size = new System.Drawing.Size(200, 55);
            this.ibtnUsuarios.TabIndex = 29;
            this.ibtnUsuarios.Text = "Usuarios";
            this.ibtnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnUsuarios.UseVisualStyleBackColor = true;
            this.ibtnUsuarios.Click += new System.EventHandler(this.ibtnUsuarios_Click);
            // 
            // ibtnFacturar
            // 
            this.ibtnFacturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnFacturar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnFacturar.FlatAppearance.BorderSize = 0;
            this.ibtnFacturar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(126)))), ((int)(((byte)(3)))));
            this.ibtnFacturar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(124)))));
            this.ibtnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnFacturar.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnFacturar.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.ibtnFacturar.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnFacturar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnFacturar.IconSize = 32;
            this.ibtnFacturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnFacturar.Location = new System.Drawing.Point(0, 613);
            this.ibtnFacturar.Name = "ibtnFacturar";
            this.ibtnFacturar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnFacturar.Size = new System.Drawing.Size(200, 55);
            this.ibtnFacturar.TabIndex = 28;
            this.ibtnFacturar.Text = "Ventas";
            this.ibtnFacturar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnFacturar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnFacturar.UseVisualStyleBackColor = true;
            this.ibtnFacturar.Click += new System.EventHandler(this.ibtnFacturar_Click);
            // 
            // ibtnProductos
            // 
            this.ibtnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnProductos.FlatAppearance.BorderSize = 0;
            this.ibtnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(126)))), ((int)(((byte)(3)))));
            this.ibtnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(124)))));
            this.ibtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnProductos.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnProductos.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.ibtnProductos.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnProductos.IconSize = 32;
            this.ibtnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnProductos.Location = new System.Drawing.Point(0, 558);
            this.ibtnProductos.Name = "ibtnProductos";
            this.ibtnProductos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnProductos.Size = new System.Drawing.Size(200, 55);
            this.ibtnProductos.TabIndex = 27;
            this.ibtnProductos.Text = "Productos";
            this.ibtnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnProductos.UseVisualStyleBackColor = true;
            this.ibtnProductos.Click += new System.EventHandler(this.ibtnProductos_Click);
            // 
            // pnlSubCitas
            // 
            this.pnlSubCitas.Controls.Add(this.btnCrear);
            this.pnlSubCitas.Controls.Add(this.btnAtender);
            this.pnlSubCitas.Controls.Add(this.btnCancelar);
            this.pnlSubCitas.Controls.Add(this.btnAgendar);
            this.pnlSubCitas.Controls.Add(this.panel5);
            this.pnlSubCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubCitas.Location = new System.Drawing.Point(0, 362);
            this.pnlSubCitas.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSubCitas.Name = "pnlSubCitas";
            this.pnlSubCitas.Size = new System.Drawing.Size(200, 196);
            this.pnlSubCitas.TabIndex = 26;
            this.pnlSubCitas.Visible = false;
            // 
            // btnCrear
            // 
            this.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(126)))), ((int)(((byte)(3)))));
            this.btnCrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(124)))));
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCrear.Location = new System.Drawing.Point(7, 141);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(193, 47);
            this.btnCrear.TabIndex = 4;
            this.btnCrear.Text = "Crear Agenda";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnAtender
            // 
            this.btnAtender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtender.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAtender.FlatAppearance.BorderSize = 0;
            this.btnAtender.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(126)))), ((int)(((byte)(3)))));
            this.btnAtender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(124)))));
            this.btnAtender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtender.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAtender.Location = new System.Drawing.Point(7, 94);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(193, 47);
            this.btnAtender.TabIndex = 3;
            this.btnAtender.Text = "Atender";
            this.btnAtender.UseVisualStyleBackColor = true;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(126)))), ((int)(((byte)(3)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(124)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCancelar.Location = new System.Drawing.Point(7, 47);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(193, 47);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgendar
            // 
            this.btnAgendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgendar.FlatAppearance.BorderSize = 0;
            this.btnAgendar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(126)))), ((int)(((byte)(3)))));
            this.btnAgendar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(124)))));
            this.btnAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAgendar.Location = new System.Drawing.Point(7, 0);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(193, 47);
            this.btnAgendar.TabIndex = 1;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(126)))), ((int)(((byte)(3)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.MaximumSize = new System.Drawing.Size(7, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(7, 196);
            this.panel5.TabIndex = 0;
            // 
            // ibtnCitas
            // 
            this.ibtnCitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnCitas.FlatAppearance.BorderSize = 0;
            this.ibtnCitas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(126)))), ((int)(((byte)(3)))));
            this.ibtnCitas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(124)))));
            this.ibtnCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCitas.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnCitas.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            this.ibtnCitas.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnCitas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnCitas.IconSize = 32;
            this.ibtnCitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnCitas.Location = new System.Drawing.Point(0, 307);
            this.ibtnCitas.Name = "ibtnCitas";
            this.ibtnCitas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnCitas.Size = new System.Drawing.Size(200, 55);
            this.ibtnCitas.TabIndex = 25;
            this.ibtnCitas.Text = "Citas";
            this.ibtnCitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnCitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnCitas.UseVisualStyleBackColor = true;
            this.ibtnCitas.Click += new System.EventHandler(this.ibtnCitas_Click);
            // 
            // ibtnMascotas
            // 
            this.ibtnMascotas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnMascotas.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnMascotas.FlatAppearance.BorderSize = 0;
            this.ibtnMascotas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(126)))), ((int)(((byte)(3)))));
            this.ibtnMascotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(124)))));
            this.ibtnMascotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnMascotas.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnMascotas.IconChar = FontAwesome.Sharp.IconChar.Paw;
            this.ibtnMascotas.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnMascotas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnMascotas.IconSize = 32;
            this.ibtnMascotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnMascotas.Location = new System.Drawing.Point(0, 252);
            this.ibtnMascotas.Name = "ibtnMascotas";
            this.ibtnMascotas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnMascotas.Size = new System.Drawing.Size(200, 55);
            this.ibtnMascotas.TabIndex = 24;
            this.ibtnMascotas.Text = "Mascotas";
            this.ibtnMascotas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnMascotas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnMascotas.UseVisualStyleBackColor = true;
            this.ibtnMascotas.Click += new System.EventHandler(this.ibtnMascotas_Click);
            // 
            // ibtnClientes
            // 
            this.ibtnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnClientes.FlatAppearance.BorderSize = 0;
            this.ibtnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(126)))), ((int)(((byte)(3)))));
            this.ibtnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(124)))));
            this.ibtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnClientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnClientes.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.ibtnClientes.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnClientes.IconSize = 32;
            this.ibtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnClientes.Location = new System.Drawing.Point(0, 197);
            this.ibtnClientes.Name = "ibtnClientes";
            this.ibtnClientes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnClientes.Size = new System.Drawing.Size(200, 55);
            this.ibtnClientes.TabIndex = 23;
            this.ibtnClientes.Text = "Clientes";
            this.ibtnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnClientes.UseVisualStyleBackColor = true;
            this.ibtnClientes.Click += new System.EventHandler(this.ibtnClientes_Click);
            // 
            // ibtnEmpleados
            // 
            this.ibtnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnEmpleados.FlatAppearance.BorderSize = 0;
            this.ibtnEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(126)))), ((int)(((byte)(3)))));
            this.ibtnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(124)))));
            this.ibtnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnEmpleados.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnEmpleados.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.ibtnEmpleados.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnEmpleados.IconSize = 32;
            this.ibtnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnEmpleados.Location = new System.Drawing.Point(0, 142);
            this.ibtnEmpleados.Name = "ibtnEmpleados";
            this.ibtnEmpleados.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnEmpleados.Size = new System.Drawing.Size(200, 55);
            this.ibtnEmpleados.TabIndex = 22;
            this.ibtnEmpleados.TabStop = false;
            this.ibtnEmpleados.Text = "Empleados";
            this.ibtnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnEmpleados.UseVisualStyleBackColor = true;
            this.ibtnEmpleados.Click += new System.EventHandler(this.ibtnEmpleados_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 749);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlContenido.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlSubCitas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel pnlLogo;
        private Panel panel3;
        private Panel pnlContenido;
        private Label label1;
        private Panel panel2;
        private Panel pnlMenu;
        private FontAwesome.Sharp.IconButton ibtnUsuarios;
        private FontAwesome.Sharp.IconButton ibtnFacturar;
        private FontAwesome.Sharp.IconButton ibtnProductos;
        private Panel pnlSubCitas;
        private Button btnCrear;
        private Button btnAtender;
        private Button btnCancelar;
        private Button btnAgendar;
        private Panel panel5;
        private FontAwesome.Sharp.IconButton ibtnCitas;
        private FontAwesome.Sharp.IconButton ibtnMascotas;
        private FontAwesome.Sharp.IconButton ibtnClientes;
        private FontAwesome.Sharp.IconButton ibtnEmpleados;
        private FontAwesome.Sharp.IconButton ibtnCerrarSesion;
        private Button btnCerrar;
        private Button btnMinMax;
        private Button btnMin;
        private Label lblNombre;
    }
}