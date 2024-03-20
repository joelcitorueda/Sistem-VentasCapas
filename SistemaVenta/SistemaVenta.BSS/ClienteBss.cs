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
	public class ClienteBss
	{
		ClienteDal dal = new ClienteDal();
		public DataTable ListarClienteBss()
		{
			return dal.ListarClientesDal();
		}
		public void InsertarClienteBss(Cliente cliente)
		{
			dal.InsertarClienteDal(cliente);
		}
		public Cliente ObtenerClienteIdBss(int id)
		{
			return dal.ObtenerClienteIdDal(id);
		}
		public void EditarClienteBss(Cliente p)
		{
			dal.EditarClienteDal(p);
		}
		public void EliminarClienteBss(int id)
		{
			dal.EliminarClienteDal(id);
		}
	}
}
