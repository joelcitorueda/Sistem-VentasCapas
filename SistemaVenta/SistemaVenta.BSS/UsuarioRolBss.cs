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
	public class UsuarioRolBss
	{
		UsuarioRolDal dal = new UsuarioRolDal();
		public DataTable ListarUsuariosRolesBss()
		{
			return dal.ListarUsuariosRolesDal();
		}
		public void InsertarUsuarioRolBss(UsuarioRol usuarioRol)
		{
			dal.InsertarUsuarioRolDal(usuarioRol);
		}
		public UsuarioRol ObtenerUsuarioRolIdBss(int id)
		{
			return dal.ObtenerUsuarioRolIdDal(id);
		}
		public void EditarUsuarioRolBss(UsuarioRol p)
		{
			dal.EditarUsuarioRolDal(p);
		}
		public void EliminarUsuarioRolBss(int id)
		{
			dal.EliminarUsuarioRolDal(id);
		}
	}
}
