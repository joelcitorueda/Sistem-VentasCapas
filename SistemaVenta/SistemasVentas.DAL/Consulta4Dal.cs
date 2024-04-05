using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
	public class Consulta4Dal
	{
		public DataTable ListarConsulta4Dal()
		{
			string consulta = "SELECT SUM(UNIDAD) Cantidad_Totaal\r\nFROM PRODUCTO;";
			DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
			return lista;
		}
	}
}
