using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
	public class Consulta8Dal
	{
		public DataTable ListarConsulta8Dal()
		{
			string consulta = "SELECT TOP 1 PR.NOMBRE Proveedor, COUNT(P.IDPROVEE) Productos_Suministrados\r\n" +
				"FROM PROVEEDOR PR\r\n" +
				"INNER JOIN PROVEE P ON PR.IDPROVEEDOR = P.IDPROVEEDOR\r\n" +
				"GROUP BY PR.NOMBRE\r\n" +
				"ORDER BY COUNT(P.IDPROVEE) DESC;";
			DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
			return lista;
		}
	}
}
