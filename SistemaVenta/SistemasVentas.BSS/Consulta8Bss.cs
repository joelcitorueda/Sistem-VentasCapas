using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
	public class Consulta8Bss
	{
		Consulta8Dal dal = new Consulta8Dal();
		public DataTable ListarConsulta8Bss()
		{
			return dal.ListarConsulta8Dal();
		}
	}
}