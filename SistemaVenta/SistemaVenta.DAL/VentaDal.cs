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
	public class VentaDal
	{
		public DataTable ListarVentasDal()
		{
			string consulta = "select * from venta";
			DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
			return lista;
		}
		public void InsertarVentaDal(Venta venta)
		{
			string consulta = "insert into venta values(" + venta.IDCliente + " , " +
														  venta.IDVendedor + " , " +
														"'" + venta.Fecha.ToString("yyyy-MM-dd HH:mm:ss") + "' , " +
														  venta.Total +" , 'Exitoso')";
			conexion.Ejecutar(consulta);
		}
		Venta p = new Venta();
		public Venta ObtenerVentaIdDal(int id)
		{
			string consulta = "select * from venta where idventa=" + id;
			DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
			if (tabla.Rows.Count > 0)
			{
				p.IDVenta = Convert.ToInt32(tabla.Rows[0]["idventa"]);
				p.IDCliente = Convert.ToInt32(tabla.Rows[0]["idcliente"]);
				p.IDVendedor = Convert.ToInt32(tabla.Rows[0]["idvendedor"]);
				p.Fecha = Convert.ToDateTime(tabla.Rows[0]["fecha"]);
				p.Total = Convert.ToDecimal(tabla.Rows[0]["total"]);
				p.Estado = tabla.Rows[0]["estado"].ToString();
			}
			return p;
		}
		public void EditarVentaDal(Venta p)
		{
			string consulta = "update venta set idcliente=" + p.IDCliente + "," +
														"idvendedor=" + p.IDVendedor + "," +
														"fecha='" + p.Fecha + "', " +
														"total=" + p.Total + "," +
														"estado='" + p.Estado + "' " +
												"where idventa=" + p.IDVenta;
			conexion.Ejecutar(consulta);
		}
		public void EliminarVentaDal(int id)
		{
			string consulta = "delete from venta where idventa=" + id;
			conexion.Ejecutar(consulta);
		}
	}
}
