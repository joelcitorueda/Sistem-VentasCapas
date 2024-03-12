using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIstemaVentas.DAL
{
	public class Venta
	{
		public int IDVenta { get; set; }
		public int IDCliente { get; set; }
		public int? IDVendedor { get; set; }
		public DateTime Fecha { get; set; }
		public decimal Total { get; set; }
		public string Estado { get; set; }

	}
}
