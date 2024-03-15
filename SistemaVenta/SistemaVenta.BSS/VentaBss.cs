using SistemaVenta.DAL;
using SistemaVenta.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenta.BSS
{
	public class VentaBss
	{
		VentaDal dal = new VentaDal();
		public DataTable ListarVentasBss()
		{
			return dal.ListarVentasDal();
		}
		public void InsertarVentaBss(Venta venta)
		{
			dal.InsertarVentaDal(venta);
		}

	}
}
