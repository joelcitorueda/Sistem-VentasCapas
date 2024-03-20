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
	public class DetalleVentaBss
	{
		DetalleVentaDal dal = new DetalleVentaDal();
		public DataTable ListarDetalleVentaBss()
		{
			return dal.ListarDetalleVentasDal();
		}
		public void InsertarDetalleVentaBss(DetalleVenta detalleventa)
		{
			dal.InsertarDetalleVentaDal(detalleventa);
		}
		public DetalleVenta ObtenerDetalleVentaIdBss(int id)
		{
			return dal.ObtenerDetalleVentaIdDal(id);
		}
		public void EditarDetalleVentaBss(DetalleVenta p)
		{
			dal.EditarDetalleVentaDal(p);
		}
		public void EliminarDetalleVentaBss(int id)
		{
			dal.EliminarDetalleVentaDal(id);
		}
	}
}
