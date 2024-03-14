using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemaVenta.DAL;

namespace SistemaVenta.DAL
{
	public class ProveeDal
	{
		public DataTable ListarProveesDal()
		{
			string consulta = "select * from provee";
			DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
			return lista;
		}
	}
}
