using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
	public class CompraDal
	{
		public DataTable ListarCompraDal()
		{
			string consulta = "select * from CMPRAS";
			DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
			return lista;
		}

		public void InsertarCompraDal(Compra compra)
		{
			string consulta = "INSERT INTO COMPRAS (IDCLIENTE, IDPRODUCTO, CANTIDAD, " +
							  "PRECIOUNITARIO, TOTAL, DESCRIPCION, FORMADEPAGO) " +
							  "VALUES (" + compra.IdCliente + ", " + compra.IdProducto + ", " +
							  compra.Cantidad + ", " + compra.PrecioUnitario + ", " +
							  compra.Total + ", '" + compra.Descripcion + "', '" +
							  compra.FormaDePago + "')";
			conexion.Ejecutar(consulta);
		}

		public Compra ObtenerCompraIdDal(int id)
		{
			Compra compra = new Compra();
			string consulta = "SELECT * FROM COMPRAS WHERE IDCOMPRA=" + id;
			DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
			if (tabla.Rows.Count > 0)
			{
				compra.IdCompra = Convert.ToInt32(tabla.Rows[0]["IDCOMPRA"]);
				compra.IdCliente = Convert.ToInt32(tabla.Rows[0]["IDCLIENTE"]);
				compra.IdProducto = Convert.ToInt32(tabla.Rows[0]["IDPRODUCTO"]);
				compra.Cantidad = Convert.ToInt32(tabla.Rows[0]["CANTIDAD"]);
				compra.PrecioUnitario = Convert.ToDecimal(tabla.Rows[0]["PRECIOUNITARIO"]);
				compra.Total = Convert.ToDecimal(tabla.Rows[0]["TOTAL"]);
				compra.Descripcion = tabla.Rows[0]["DESCRIPCION"].ToString();
				compra.FormaDePago = tabla.Rows[0]["FORMADEPAGO"].ToString();
			}
			return compra;
		}

		public void EditarCompraDal(Compra compra)
		{
			string consulta = "UPDATE COMPRAS SET IDCLIENTE=" + compra.IdCliente + ", " +
							  "IDPRODUCTO=" + compra.IdProducto + ", " +
							  "CANTIDAD=" + compra.Cantidad + ", " +
							  "PRECIOUNITARIO=" + compra.PrecioUnitario + ", " +
							  "TOTAL=" + compra.Total + ", " +
							  "DESCRIPCION='" + compra.Descripcion + "', " +
							  "FORMADEPAGO='" + compra.FormaDePago + "' " +
							  "WHERE IDCOMPRA=" + compra.IdCompra;
			conexion.Ejecutar(consulta);
		}

		public void EliminarCompraDal(int id)
		{
			string consulta = "DELETE FROM COMPRAS WHERE IDCOMPRA=" + id;
			conexion.Ejecutar(consulta);
		}


	}
}
