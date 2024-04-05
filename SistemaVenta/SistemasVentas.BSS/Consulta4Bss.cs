using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
	public class Consulta4Bss
	{
		Consulta4Dal dal = new Consulta4Dal();
		public DataTable ListarConsulta4Bss()
		{
			return dal.ListarConsulta4Dal();
		}
	}
}
