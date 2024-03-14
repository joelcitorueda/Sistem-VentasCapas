using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemaVenta.DAL;

namespace SistemaVenta.DAL
{
	public class IngresoDal
	{
		public DataTable ListarIngresosDal()
		{
			string consulta = "select * from ingreso";
			DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
			return lista;
		}
	}
}
