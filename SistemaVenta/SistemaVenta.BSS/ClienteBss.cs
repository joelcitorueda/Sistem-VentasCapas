using SistemaVenta.DAL;
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
	}
}
