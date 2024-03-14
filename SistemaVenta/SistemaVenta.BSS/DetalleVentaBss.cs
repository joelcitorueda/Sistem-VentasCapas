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
	}
}
