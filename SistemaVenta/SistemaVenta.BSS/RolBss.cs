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
	public class RolBss
	{
		RolDal dal = new RolDal();
		public DataTable ListarRolesBss()
		{
			return dal.ListarRolesDal();
		}
		public void InsertarRolBss(Rol rol)
		{
			dal.InsertarRolDal(rol);
		}
		public Rol ObtenerRolIdBss(int id)
		{
			return dal.ObtenerRolIdDal(id);
		}
		public void EditarRolBss(Rol p)
		{
			dal.EditarRolDal(p);
		}
		public void EliminarRolBss(int id)
		{
			dal.EliminarRolDal(id);
		}


	}
}
