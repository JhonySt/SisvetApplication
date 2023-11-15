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
//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SisvetAPP.Vistas
{
    public partial class ctlFacturar : UserControl
    {
        #region metodos iniciales
        public ctlFacturar()
        {
            InitializeComponent();
        }

        private void ctlFacturar_Load(object sender, EventArgs e)
        {
            mostrarProductos();
        }
        #endregion

        #region Eventos
        private void GridProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == GridProductos.Columns["Agregar"].Index)
            {
                int Id_Producto = Convert.ToInt32(GridProductos.Rows[e.RowIndex].Cells[1].Value);
                int Codigo = Convert.ToInt32(GridProductos.Rows[e.RowIndex].Cells[2].Value);
                string Nombre = GridProductos.Rows[e.RowIndex].Cells[3].Value.ToString();
                string Presentacion = GridProductos.Rows[e.RowIndex].Cells[4].Value.ToString();
                decimal Precio = Convert.ToDecimal(GridProductos.Rows[e.RowIndex].Cells[5].Value);
                int Cantidad = 1;
                decimal Total = Cantidad * Precio;

                if (GridDetalle.RowCount > 0)
                {
                    bool existe = false;
                    for (int i = 0; i < GridDetalle.RowCount; i++)
                    {
                        if (Convert.ToInt32(GridDetalle.Rows[i].Cells["Id_Producto"].Value) == Id_Producto)
                        {
                            Cantidad = Convert.ToInt32(GridDetalle.Rows[i].Cells["Cantidad"].Value);
                            Cantidad++;
                            Total = Cantidad * Precio;
                            GridDetalle.Rows[i].Cells["Cantidad"].Value = Cantidad;
                            GridDetalle.Rows[i].Cells["Total"].Value = Total;
                            existe = true;
                            break; // debes salirte del ciclo si encuentras el registro, no es necesario seguir dentro
                        }

                    }
                    if (existe == false)
                    {
                        GridDetalle.Rows.Add(new object[]
                        {
                                Id_Producto, Codigo, Nombre, Presentacion, Precio, Cantidad, Total, "Eliminar"
                        });
                    }
                }
                else
                {
                    GridDetalle.Rows.Add(new object[]
                    {
                        Id_Producto, Codigo, Nombre, Presentacion, Precio, Cantidad, Total, "Eliminar"
                    });
                }
                calcularTotal();
            }
        }

        private void GridDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == GridDetalle.Columns["Eliminar"].Index)
            {
                if (Convert.ToInt32(GridDetalle.Rows[e.RowIndex].Cells["Cantidad"].Value) > 1)
                {
                    int cantidad = Convert.ToInt32(GridDetalle.Rows[e.RowIndex].Cells["Cantidad"].Value);
                    decimal precio = Convert.ToDecimal(GridDetalle.Rows[e.RowIndex].Cells["Precio_Unitario"].Value);
                    cantidad--;
                    decimal total = cantidad * precio;
                    GridDetalle.Rows[e.RowIndex].Cells["Cantidad"].Value = cantidad;
                    GridDetalle.Rows[e.RowIndex].Cells["Total"].Value = total;
                }
                else
                {
                    GridDetalle.Rows.RemoveAt(e.RowIndex);
                }
                calcularTotal();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                List<FacturaModelo> listaDetalle = new List<FacturaModelo>();

                foreach (DataGridViewRow row in GridDetalle.Rows)
                {
                    FacturaModelo oDetalle = new FacturaModelo();
                    oDetalle.Id_Producto = Convert.ToInt32(row.Cells["Id_Producto"].Value);
                    oDetalle.Codigo = Convert.ToInt32(row.Cells["Codigo"].Value);
                    oDetalle.Nombre = row.Cells["Nombre"].Value.ToString();
                    oDetalle.presentacion = row.Cells["Presentacion"].Value.ToString();
                    oDetalle.PrecioUnitario = Convert.ToDecimal(row.Cells["Precio_Unitario"].Value.ToString());
                    oDetalle.Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    oDetalle.Total = Convert.ToDecimal(row.Cells["Total"].Value);
                    //string precio = row.Cells["Precio_Unitario"].Value.ToString();
                    //precio = precio.Replace(",", ".");
                    //MessageBox.Show("" + oDetalle.PrecioUnitario);
                    listaDetalle.Add(oDetalle);
                }
                decimal totalCompra = Convert.ToDecimal(txtTotal.Text);
                string documento = txtDocumento.Text;
                FacturaData detalle = new FacturaData();
                DataTable tabla = new DataTable();
                if (detalle.insertarFactura(documento, listaDetalle, totalCompra))
                {
                    MessageBox.Show("Factura guardada con exito");
                    txtIdFactura.Text = detalle.Id_Factura.ToString();

                }
                else MessageBox.Show("Error al guardar la factura");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }
        #endregion

        #region metodos propios
        private void mostrarProductos()
        {
            ProductosModelo productos = new ProductosModelo();
            DataTable tabla = new DataTable();
            productos.mostrarProductos(tabla);
            GridProductos.DataSource = tabla;
            GridProductos.Columns[6].Visible = false;
            //GridClientes.Columns[8].Visible = false;
        }

        private void calcularTotal()
        {
            decimal total = 0;
            decimal x = 0;
            if (GridDetalle.RowCount > 0)
            {
                for (int i = 0; i < GridDetalle.RowCount; i++)
                {
                    x = Convert.ToDecimal(GridDetalle.Rows[i].Cells["Total"].Value);
                    total = total + x;
                }
            }

            txtTotal.Text = total.ToString();
        }



        #endregion

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura();
            factura.txtId.Text = txtIdFactura.Text;
            factura.ShowDialog();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            ProductosModelo productos = new ProductosModelo();
            productos.Buscador = this.txtBuscar.Text;
            productos.buscarProducto(tabla, productos.Buscador);
            GridProductos.DataSource = tabla;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            GridDetalle.Rows.Clear();
            txtBuscar.Clear();
            txtDocumento.Clear();
            txtTotal.Clear();
            txtIdFactura.Clear();

        }


    }
}
