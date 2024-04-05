using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
	public class Consulta6Dal
	{
		public DataTable ListarConsulta6Dal()
		{
			string consulta = "SELECT U.NOMBREUSER Vendedor, COUNT(DV.IDDETALLEVENTA) Cantidad_Productos_Vendidos\r\n" +
				"FROM USUARIO U\r\n" +
				"LEFT JOIN VENTA V ON U.IDUSUARIO = V.IDVENDEDOR\r\n" +
				"LEFT JOIN DETALLEVENTA DV ON V.IDVENTA = DV.IDVENTA\r\n" +
				"GROUP BY U.NOMBREUSER;";
			DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
			return lista;
		}
	}
}
