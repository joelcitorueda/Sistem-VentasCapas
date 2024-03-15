using SistemaVenta.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemaVenta.DAL;

namespace SistemaVenta.DAL
{
	public class MarcaDal
	{
		public DataTable ListarMarcasDal()
		{
			string consulta = "select * from marca";
			DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
			return lista;
		}
		public void InsertarMarcaDal(Marca marca)
		{
			string consulta = "insert into marca values('" + marca.Nombre + "', 'Activo')";
			conexion.Ejecutar(consulta);
		}

	}
}
