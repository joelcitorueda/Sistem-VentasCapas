using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
	public class Consulta5Bss
	{
		Consulta5Dal dal = new Consulta5Dal();
		public DataTable ListarConsulta5Bss()
		{
			return dal.ListarConsulta5Dal();
		}
	}
}
