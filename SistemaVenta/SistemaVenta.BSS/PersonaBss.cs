using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVenta.DAL;
using SistemaVenta.Modelos;

namespace SistemaVenta.BSS
{
	public class PersonaBss
	{
		PersonaDal dal = new PersonaDal();
		public DataTable ListarPersonaBss()
		{
			return dal.ListarPersonasDal();
		}

		public void InsertarPersonaBss(Persona persona)
		{
			dal.InsertarPersonaDal(persona);
		}
	}
}
