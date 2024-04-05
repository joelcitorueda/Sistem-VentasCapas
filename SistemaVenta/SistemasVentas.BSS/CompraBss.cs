using SistemasVentas.DAL;
using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
	public class CompraBss
	{
		CompraDal dal = new CompraDal();

		public DataTable ListarCompraBss()
		{
			return dal.ListarCompraDal();
		}

		public void InsertarCompraBss(Compra compra)
		{
			dal.InsertarCompraDal(compra);
		}

		public Compra ObtenerCompraIdBss(int id)
		{
			return dal.ObtenerCompraIdDal(id);
		}

		public void EditarCompraBss(Compra compra)
		{
			dal.EditarCompraDal(compra);
		}

		public void EliminarCompraBss(int id)
		{
			dal.EliminarCompraDal(id);
		}


	}
}
