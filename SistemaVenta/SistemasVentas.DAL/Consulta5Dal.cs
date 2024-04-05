using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
	public class Consulta5Dal
	{
		public DataTable ListarConsulta5Dal()
		{
			string consulta = "SELECT PRODUCTO.NOMBRE, DETALLEING.FECHAVENC\r\n" +
				"FROM PRODUCTO\r\n" +
				"INNER JOIN DETALLEING ON PRODUCTO.IDPRODUCTO = DETALLEING.IDPRODUCTO\r\n" +
				"WHERE DATEDIFF(day, GETDATE(), DETALLEING.FECHAVENC) <= 30\r\n" +
				"AND YEAR(DETALLEING.FECHAVENC) = 2024;";
			DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
			return lista;
		}
	}
}
