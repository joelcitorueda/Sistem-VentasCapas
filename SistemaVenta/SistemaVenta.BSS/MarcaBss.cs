using SistemaVenta.DAL;
using SistemaVenta.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenta.BSS
{
	public class MarcaBss
	{
		MarcaDal dal = new MarcaDal();
		public DataTable ListarMarcasBss()
		{
			return dal.ListarMarcasDal();
		}
		public void InsertarMarcaBss(Marca marca)
		{
			dal.InsertarMarcaDal(marca);
		}
		public Marca ObtenerIdBss(int id)
		{
			return dal.ObtenerMarcaId(id);
		}
		public void EditarMarcaBss(Marca p)
		{
			dal.EditarMarcaDal(p);
		}
		public void EliminarMarcaBss(int id)
		{
			dal.EliminarMarcaDal(id);
		}
	}
}
