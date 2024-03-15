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
	public class ProductoBss
	{
		ProductoDal dal = new ProductoDal();
		public DataTable ListarProductosBss()
		{
			return dal.ListarProductosDal();
		}
		public void InsertarProductoBss(Producto producto)
		{
			dal.InsertarProductoDal(producto);
		}

	}
}
