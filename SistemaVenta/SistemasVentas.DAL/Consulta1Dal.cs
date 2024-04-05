using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
	public class Consulta1Dal
	{
		public DataTable ListarConsulta1Dal()
		{
			string consulta = "SELECT P.NOMBRE, P.APELLIDO\r\n" +
				"FROM PERSONA P\r\n" +
				"INNER JOIN CLIENTE C ON P.IDPERSONA = C.IDPERSONA;";
			DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
			return lista;
		}
	}
}
