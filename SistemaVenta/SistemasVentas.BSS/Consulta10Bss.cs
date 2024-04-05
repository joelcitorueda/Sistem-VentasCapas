using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
	public class Consulta10Bss
	{
		Consulta10Dal dal = new Consulta10Dal();
		public DataTable ListarConsulta10Bss()
		{
			return dal.ListarConsulta10Dal();
		}
	}
}
