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
	public class ProveeBss
	{
		ProveeDal dal = new ProveeDal();
		public DataTable ListarProveesBss()
		{
			return dal.ListarProveesDal();
		}
		public void InsertarProveeBss(Provee provee)
		{
			dal.InsertarProveeDal(provee);
		}
		public Provee ObtenerProveeIdBss(int id)
		{
			return dal.ObtenerProveeIdDal(id);
		}
		public void EditarProveeBss(Provee p)
		{
			dal.EditarProveeDal(p);
		}
		public void EliminarProveeBss(int id)
		{
			dal.EliminarProveeDal(id);
		}

	}
}
