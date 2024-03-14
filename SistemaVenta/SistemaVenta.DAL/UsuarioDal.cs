using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemaVenta.DAL;

namespace SistemaVenta.DAL
{
	public class UsuarioDal
	{
		public DataTable ListarUsuariosDal()
		{
			string consulta = "select * from usuario";
			DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
			return lista;
		}
	}
}
