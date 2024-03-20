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
	public class IngresoBss
	{
		IngresoDal dal = new IngresoDal();
		public DataTable ListarIngresosBss()
		{
			return dal.ListarIngresosDal();
		}
		public void InsertarIngresoBss(Ingreso ingreso)
		{
			dal.InsertarIngresoDal(ingreso);
		}
		public Ingreso ObtenerIngresoIdBss(int id)
		{
			return dal.ObtenerIngresoIdDal(id);
		}
		public void EditarIngresoBss(Ingreso p)
		{
			dal.EditarIngresoDal(p);
		}
		public void EliminarIngresoBss(int id)
		{
			dal.EliminarIngresoDal(id);
		}
	}
}
