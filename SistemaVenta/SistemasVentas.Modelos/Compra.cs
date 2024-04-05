using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.Modelos
{
	public class Compra
	{
		public int IdCompra { get; set; }
		public int IdCliente { get; set; }
		public int IdProducto { get; set; }
		public int Cantidad { get; set; }
		public decimal PrecioUnitario { get; set; }
		public decimal Total { get; set; }
		public string Descripcion { get; set; }
		public string FormaDePago { get; set; }
	}
}
