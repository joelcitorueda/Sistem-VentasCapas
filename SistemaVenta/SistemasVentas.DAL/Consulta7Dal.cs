using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
	public class Consulta7Dal
	{
		public DataTable ListarConsulta7Dal()
		{
			string consulta = "SELECT C.IDCLIENTE, (P.NOMBRE +' '+ P.APELLIDO) Nombre_del_cliente, SUM(DV.SUBTOTAL) Total_Ingresos\r\n" +
				"FROM CLIENTE C\r\n" +
				"INNER JOIN PERSONA P ON C.IDPERSONA = P.IDPERSONA\r\n" +
				"INNER JOIN VENTA V ON C.IDCLIENTE = V.IDCLIENTE\r\n" +
				"INNER JOIN DETALLEVENTA DV ON V.IDVENTA = DV.IDVENTA\r\n" +
				"GROUP BY C.IDCLIENTE, P.NOMBRE, P.APELLIDO;";
			DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
			return lista;
		}
	}
}
