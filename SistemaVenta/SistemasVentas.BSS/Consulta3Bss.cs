using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
	public class Consulta3Bss
	{
		Consulta3Dal dal = new Consulta3Dal();
		public DataTable ListarConsulta3Bss()
		{
			return dal.ListarConsulta3Dal();
		}
	}
}
