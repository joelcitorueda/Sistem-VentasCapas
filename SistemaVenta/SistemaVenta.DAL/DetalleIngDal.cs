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
		DetalleIng p = new DetalleIng();
		public DetalleIng ObtenerDetalleIngIdDal(int id)
		{
			string consulta = "select * from detalleing where iddetalleing=" + id;
			DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
			if (tabla.Rows.Count > 0)
			{
				p.IdDetalleIng = Convert.ToInt32(tabla.Rows[0]["iddetalleing"]);
				p.IdIngreso = Convert.ToInt32(tabla.Rows[0]["idingreso"]);
				p.IdProducto = Convert.ToInt32(tabla.Rows[0]["idproducto"]);
				p.FechaVenc = Convert.ToDateTime(tabla.Rows[0]["fechavenc"]);
				p.Cantidad = Convert.ToInt32(tabla.Rows[0]["cantidad"]);
				p.PrecioCosto = Convert.ToDecimal(tabla.Rows[0]["preciocosto"]);
				p.PrecioVenta = Convert.ToDecimal(tabla.Rows[0]["precioventa"]);
				p.Subtotal = Convert.ToDecimal(tabla.Rows[0]["subtotal"]);
				p.Estado = tabla.Rows[0]["estado"].ToString();
			}
			return p;
		}
		public void EditarDetalleIngDal(DetalleIng p)
		{
			string consulta = "update detalleing set idingreso=" + p.IdIngreso + "," +
														"idproducto=" + p.IdProducto + "," +
														"fechavenc='" + p.FechaVenc + "'," +
														"cantidad=" + p.Cantidad + "," +
														"preciocosto=" + p.PrecioCosto + "," +
														"precioventa=" + p.PrecioVenta + "," +
														"subtotal=" + p.Subtotal + " " +
												"where iddetalleing=" + p.IdDetalleIng;
			conexion.Ejecutar(consulta);
		}
		public void EliminarDetalleIngDal(int id)
		{
			string consulta = "delete from detalleing where iddetalleing=" + id;
			conexion.Ejecutar(consulta);
		}

	}
}                                                                     
