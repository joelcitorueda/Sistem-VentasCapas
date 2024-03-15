using SistemaVenta.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemaVenta.DAL;

namespace SistemaVenta.DAL
{
	public class UsuarioRolDal
	{
		public DataTable ListarUsuariosRolesDal()
		{
			string consulta = "select * from usuariorol";
			DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
			return lista;
		}
		public void InsertarUsuarioRolDal(UsuarioRol usuarioRol)
		{
			string consulta = "insert into usuariorol values(" + usuarioRol.IdUsuario + " , " +
															  usuarioRol.IdRol + " , " +
															"'" + usuarioRol.FechaAsigna.ToString("yyyy-MM-dd HH:mm:ss") + "', 'Activo')";
			conexion.Ejecutar(consulta);
		}

	}
}
