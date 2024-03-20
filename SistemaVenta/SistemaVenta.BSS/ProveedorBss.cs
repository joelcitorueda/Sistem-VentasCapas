﻿using SistemaVenta.DAL;
using SistemaVenta.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenta.BSS
{
	public class ProveedorBss
	{
		ProveedorDal dal = new ProveedorDal();
		public DataTable ListarProveedoresBss()
		{
			return dal.ListarProveedoresDal();
		}
		public void InsertarProveedorBss(Proveedor proveedor)
		{
			dal.InsertarProveedorDal(proveedor);
		}
		public Proveedor ObtenerProveedorIdBss(int id)
		{
			return dal.ObtenerProveedorIdDal(id);
		}
		public void EditarProveedorBss(Proveedor p)
		{
			dal.EditarProveedorDal(p);
		}
		public void EliminarProveedorBss(int id)
		{
			dal.EliminarProveedorDal(id);
		}
	}
}
