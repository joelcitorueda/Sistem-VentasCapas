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

	}
}
