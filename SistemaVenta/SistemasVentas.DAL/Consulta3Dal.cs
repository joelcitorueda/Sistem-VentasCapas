using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
	public class Consulta3Dal
	{
		public DataTable ListarConsulta3Dal()
		{
			string consulta = "SELECT TOP 1 M.NOMBRE MARCA_MAS_VENDIDA, \r\n    " +
				"SUM(DV.CANTIDAD * DV.PRECIOVENTA) TOTAL_DE_VENTAS \r\n" +
				"FROM MARCA M\r\n" +
				"INNER JOIN PRODUCTO P ON M.IDMARCA = P.IDMARCA\r\n" +
				"INNER JOIN DETALLEVENTA DV ON P.IDPRODUCTO = DV.IDPRODUCTO\r\n" +
				"GROUP BY M.NOMBRE\r\n" +
				"ORDER BY SUM(DV.CANTIDAD * DV.PRECIOVENTA) DESC;";
			DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
			return lista;
		}
	}
}
