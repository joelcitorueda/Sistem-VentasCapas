using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
	public class Consulta9Dal
	{
		public DataTable ListarConsulta9Dal()
		{
			string consulta = "SELECT TP.NOMBRE Tipo_Producto, SUM(DV.CANTIDAD) Total_Vendido\r\n" +
				"FROM TIPOPROD TP\r\n" +
				"INNER JOIN PRODUCTO P ON TP.IDTIPOPROD = P.IDTIPOPROD\r\n" +
				"INNER JOIN DETALLEVENTA DV ON P.IDPRODUCTO = DV.IDPRODUCTO\r\n" +
				"INNER JOIN VENTA V ON DV.IDVENTA = V.IDVENTA\r\n" +
				"GROUP BY TP.NOMBRE\r\n" +
				"ORDER BY SUM(DV.CANTIDAD) ASC;";
			DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
			return lista;
		}
	}
}
