using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemaVenta.DAL;
using SistemaVenta.Modelos;
namespace SistemaVenta.DAL
{
	public class PersonaDal
	{
		public DataTable ListarPersonasDal() 
		{
			string consulta = "select * from persona";
			DataTable lista = conexion.EjecutarDataTabla(consulta,"tabla");
			return lista;
		}

		public void InsertarPersonaDal(Persona persona)
		{
			string consulta = "insert into persona values('" + persona.Nombre + "' , " +
														 "'" + persona.Apellido + "' , " +
														 "'" + persona.Telefono + "' , " +
														 "'" + persona.Ci + "' , " +
														 "'" + persona.Correo + "' , " +
														 "'Activo')";
			conexion.Ejecutar(consulta);
		}
	}
}
