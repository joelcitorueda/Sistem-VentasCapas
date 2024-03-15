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
	public class DetalleIngDal
	{
		public DataTable ListarDetalleIngDal()
		{
			string consulta = "select * from detalleing";
			DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
			return lista;
		}
		public void InsertarDetalleIngDal(DetalleIng detalleing)
		{
			string consulta = "insert into detalleing values(" + detalleing.IdIngreso + " , " +
															  detalleing.IdProducto + " , " +
															  "'" + detalleing.FechaVenc.ToString("yyyy-MM-dd HH:mm:ss") + "' , " +
															  detalleing.Cantidad + " , " +
															  detalleing.PrecioCosto + " , " +
															  detalleing.PrecioVenta + " , " +
															  detalleing.Subtotal + " , 'Exitoso')";
			conexion.Ejecutar(consulta);
		}

	}
}                                                                     
