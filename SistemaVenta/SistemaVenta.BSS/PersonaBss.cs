using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVenta.DAL;


namespace SistemaVenta.BSS
{
	public class PersonaBss
	{
		PersonaDal dal = new PersonaDal();
		public DataTable ListarPersonaBss()
		{
			return dal.ListarPersonasDal();
		}
	}
}
