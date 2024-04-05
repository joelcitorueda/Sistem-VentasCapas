using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
	public class Consulta2Bss
	{
		Consulta2Dal dal = new Consulta2Dal();
		public DataTable ListarConsulta2Bss()
		{
			return dal.ListarConsulta2Dal();
		}
	}
}
