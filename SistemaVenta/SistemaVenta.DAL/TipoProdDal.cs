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
	public class TipoProdDal
	{
		public DataTable ListarTiposProductosDal()
		{
			string consulta = "select * from tipoprod";
			DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
			return lista;
		}
		public void InsertarTipoProdDal(TipoProd tipoProd)
		{
			string consulta = "insert into tipoprod values('" + tipoProd.Nombre + "', 'Activo')";
			conexion.Ejecutar(consulta);
		}

	}
}
