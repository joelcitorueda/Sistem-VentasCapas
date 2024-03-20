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
		public Marca ObtenerMarcaId(int id)
		{
			string consulta = "select * from marca where idmarca=" + id;
			DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
			Marca p = new Marca();
			if (tabla.Rows.Count > 0)
			{

				p.IdMarca = Convert.ToInt32(tabla.Rows[0]["idmarca"]);
				p.Nombre = tabla.Rows[0]["nombre"].ToString();
				p.Estado = tabla.Rows[0]["estado"].ToString();
			}
			return p;


		}
		public void EditarMarcaDal(Marca p)
		{
			string consulta = "update marca set nombre='" + p.Nombre + "'," +
							   "where idmarca=" + p.IdMarca;
			conexion.Ejecutar(consulta);
		}
		public void EliminarMarcaDal(int id)
		{
			string consulta = "delete from marca where idmarca =" + id;
			conexion.Ejecutar(consulta);
		}

	}
}
