using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
	public class Consulta9Bss
	{
		Consulta9Dal dal = new Consulta9Dal();
		public DataTable ListarConsulta9Bss()
		{
			return dal.ListarConsulta9Dal();
		}
	}
}
