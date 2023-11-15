using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisvetSHARED.Modelos
{
    public class FacturaModelo
    {
		public int Id_Detalle { get; set; }
		public int Id_Producto { get; set; }
		public int Codigo { get; set; }
		public string Nombre { get; set; }
		public string presentacion { get; set; }
		public decimal PrecioUnitario { get; set; }
		public int Cantidad { get; set; }
		public decimal Total { get; set; }
		

		
    }
}
