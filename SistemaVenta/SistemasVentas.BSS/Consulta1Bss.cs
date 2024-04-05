using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
	public class Consulta1Bss
	{
		Consulta1Dal dal = new Consulta1Dal();
		public DataTable ListarConsulta1Bss()
		{
			return dal.ListarConsulta1Dal();
		}
	}
}
