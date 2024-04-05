using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
	public class Consulta6Bss
	{
		Consulta6Dal dal = new Consulta6Dal();
		public DataTable ListarConsulta6Bss()
		{
			return dal.ListarConsulta6Dal();
		}
	}
}
