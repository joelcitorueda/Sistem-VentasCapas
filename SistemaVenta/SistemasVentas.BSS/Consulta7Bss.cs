﻿using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
	public class Consulta7Bss
	{
		Consulta7Dal dal = new Consulta7Dal();
		public DataTable ListarConsulta7Bss()
		{
			return dal.ListarConsulta7Dal();
		}
	}
}
