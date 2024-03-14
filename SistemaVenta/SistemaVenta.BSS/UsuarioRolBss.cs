using SistemaVenta.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenta.BSS
{
	public class UsuarioRolBss
	{
		UsuarioRolDal dal = new UsuarioRolDal();
		public DataTable ListarUsuariosRolesBss()
		{
			return dal.ListarUsuariosRolesDal();
		}
	}
}
