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
    public partial class ctlProductos : UserControl
    {
        int Id_Producto;
        #region metodos iniciales
        public ctlProductos()
        {
            InitializeComponent();
        }

        private void ctlProductos_Load(object sender, EventArgs e)
        {
            mostrarProductos();
            this.txtBuscar.Focus();
        }
        #endregion

        #region Eventos
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            buscarProducto();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtBuscar.Clear();
            mostrarProductos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            mostrarRegistro();
            btnGuardar.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            limpiarRegistro();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            insertarProducto();
            mostrarProductos();
            limpiarRegistro();
        }

        private void GridProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //EmpleadosModelo empleado = new EmpleadosModelo();
                Id_Producto = Convert.ToInt32(this.GridProductos.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            mostrarRegistro();
            cargarRegistros();
            btnActualizarVerificar.Visible = true;
        }

        private void btnActualizarVerificar_Click(object sender, EventArgs e)
        {
            actualizarProducto();
            mostrarProductos();
            limpiarRegistro();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Estas seguro de borrar este registro?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.OK)
            {
                borrarProducto();
                mostrarProductos();
            }
        }

        #endregion

        #region Metodos propios
        private void mostrarProductos()
        {
            ProductosModelo productos = new ProductosModelo();
            DataTable tabla = new DataTable();
            productos.mostrarProductos(tabla);
            GridProductos.DataSource = tabla;
            GridProductos.Columns[5].Visible = false;
            //GridClientes.Columns[8].Visible = false;
            if (GridProductos.Rows.Count > 0)
            {
                Id_Producto = Convert.ToInt32(GridProductos.Rows[0].Cells[0].Value);
            }
        }

        private void limpiarRegistro()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPresentacion.Clear();
            txtPrecio.Clear();
            btnActualizarVerificar.Visible = false;
            btnGuardar.Visible = false;
            pnlRegistro.Visible = false;
            pnlBotones.Visible = true;
            picBuscar.Visible = true;
            txtBuscar.Visible = true;
            btnLimpiar.Visible = true;
            GridProductos.Visible = true;

        }

        private void buscarProducto()
        {
            DataTable tabla = new DataTable();
            ProductosModelo productos = new ProductosModelo();
            productos.Buscador = this.txtBuscar.Text;
            productos.buscarProducto(tabla, productos.Buscador);
            GridProductos.DataSource = tabla;
        }

        private void mostrarRegistro()
        {
            pnlRegistro.BringToFront();
            pnlRegistro.Dock = DockStyle.Fill;
            pnlBotones.Visible = false;
            GridProductos.Visible = false;
            pnlRegistro.Visible = true;
            txtCodigo.Focus();
            picBuscar.Visible = false;
            txtBuscar.Visible = false;
            btnLimpiar.Visible = false;
        }

        private void insertarProducto()
        {
            ProductosModelo productos = new ProductosModelo();
            productos.Codigo = this.txtCodigo.Text;
            productos.Nombre = this.txtNombre.Text;
            productos.Presentacion = this.txtPresentacion.Text;
            productos.Precio = Convert.ToDecimal(this.txtPrecio.Text);

            if (productos.insertarProducto())
            {
                MessageBox.Show("Producto ingresado de manera exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"{productos.Error}\nError, el producto no pudo ser ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarRegistros()
        {
            ProductosModelo productos = new ProductosModelo();
            DataTable tabla = new DataTable();
            productos.Id_Producto = Id_Producto;
            productos.buscarProductoId(tabla, productos.Id_Producto);
            this.txtCodigo.Text = tabla.Rows[0]["Codigo"].ToString();
            this.txtNombre.Text = tabla.Rows[0]["Nombre"].ToString();
            this.txtPresentacion.Text = tabla.Rows[0]["Presentacion"].ToString();
            this.txtPrecio.Text = tabla.Rows[0]["Precio"].ToString();

        }

        private void actualizarProducto()
        {
            ProductosModelo productos = new ProductosModelo();
            productos.Id_Producto = Id_Producto;
            productos.Codigo = this.txtCodigo.Text;
            productos.Nombre = this.txtNombre.Text;
            productos.Presentacion = this.txtPresentacion.Text;
            productos.Precio = Convert.ToDecimal(this.txtPrecio.Text);

            if (productos.actualizarProducto())
            {
                MessageBox.Show("Producto actualizado de manera exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"{productos.Error}\nError, el producto no pudo ser actualizado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void borrarProducto()
        {
            ProductosModelo productos = new ProductosModelo();
            productos.Id_Producto = Id_Producto;

            if (productos.borrarProducto())
            {
                MessageBox.Show("Producto eliminado de manera exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error, el producto no pudo ser eliminado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

    }
}
