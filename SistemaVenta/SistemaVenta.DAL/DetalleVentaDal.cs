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
	public class DetalleVentaDal
	{
		public DataTable ListarDetalleVentasDal()
		{
			string consulta = "select * from detalleventa";
			DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
			return lista;
		}
		public void InsertarDetalleVentaDal(DetalleVenta detalleventa)
		{
			string consulta = "insert into detalleventa values(" + detalleventa.IdVenta + " , " +
															  detalleventa.IdProducto + " , " +
															  detalleventa.Cantidad + " , " +
															  detalleventa.PrecioVenta + " , " +
															  detalleventa.Subtotal + " , 'Exitoso')";
			conexion.Ejecutar(consulta);
		}
		DetalleVenta p = new DetalleVenta();
		public DetalleVenta ObtenerDetalleVentaIdDal(int id)
		{
			string consulta = "select * from detalleventa where iddetalleventa=" + id;
			DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
			if (tabla.Rows.Count > 0)
			{
				p.IdDetalleVenta = Convert.ToInt32(tabla.Rows[0]["iddetalleventa"]);
				p.IdVenta = Convert.ToInt32(tabla.Rows[0]["idventa"]);
				p.IdProducto = Convert.ToInt32(tabla.Rows[0]["idproducto"]);
				p.Cantidad = Convert.ToInt32(tabla.Rows[0]["cantidad"]);
				p.PrecioVenta = Convert.ToDecimal(tabla.Rows[0]["precioventa"]);
				p.Subtotal = Convert.ToDecimal(tabla.Rows[0]["subtotal"]);
				p.Estado = tabla.Rows[0]["estado"].ToString();
			}
			return p;
		}
		public void EditarDetalleVentaDal(DetalleVenta p)
		{
			string consulta = "update detalleventa set idventa=" + p.IdVenta + "," +
														"idproducto=" + p.IdProducto + "," +
														"cantidad=" + p.Cantidad + "," +
														"precioventa=" + p.PrecioVenta + "," +
														"subtotal=" + p.Subtotal + " " +
												"where iddetalleventa=" + p.IdDetalleVenta;
			conexion.Ejecutar(consulta);
		}
		public void EliminarDetalleVentaDal(int id)
		{
			string consulta = "delete from detalleventa where iddetalleventa=" + id;
			conexion.Ejecutar(consulta);
		}
	}
}
