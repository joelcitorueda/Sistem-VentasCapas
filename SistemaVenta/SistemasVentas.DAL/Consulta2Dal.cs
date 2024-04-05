using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
	public class Consulta2Dal
	{
		public DataTable ListarConsulta2Dal()
		{
			string consulta = "SELECT PROVEEDOR.NOMBRE PROVEEDOR, INGRESO.FECHAINGRESO, INGRESO.TOTAL TOTAL_INGRESOS\r\n" +
				"FROM     INGRESO INNER JOIN\r\n                  " +
				"PROVEEDOR ON INGRESO.IDPROVEEDOR = PROVEEDOR.IDPROVEEDOR";
			DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
			return lista;
		}
	}
}
