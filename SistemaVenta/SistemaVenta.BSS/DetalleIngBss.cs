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
	public class DetalleIngBss
	{
		DetalleIngDal dal = new DetalleIngDal();
		public DataTable ListarDetalleIngBss()
		{
			return dal.ListarDetalleIngDal();
		}
		public void InsertarDetalleIngBss(DetalleIng detalleing)
		{
			dal.InsertarDetalleIngDal(detalleing);
		}
	}
}
