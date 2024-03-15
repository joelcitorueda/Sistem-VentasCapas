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
	public class UsuarioDal
	{
		public DataTable ListarUsuariosDal()
		{
			string consulta = "select * from usuario";
			DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
			return lista;
		}
		public void InsertarUsuarioDal(Usuario usuario)
		{
			string consulta = "insert into usuario values(" + usuario.IdPersona + " , " +
															"'" + usuario.NombreUser + "' , " +
															"'" + usuario.Contraseña + "' , " +
															"'" + usuario.FechaReg.ToString("yyyy-MM-dd HH:mm:ss") + "')";
			conexion.Ejecutar(consulta);
		}

	}
}
