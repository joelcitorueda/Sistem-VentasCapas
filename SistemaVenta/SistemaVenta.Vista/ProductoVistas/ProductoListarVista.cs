﻿using SistemaVenta.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenta.Vista.ProductoVistas
{
	public partial class ProductoListarVista : Form
	{
		public ProductoListarVista()
		{
			InitializeComponent();
		}
		ProductoBss bss = new ProductoBss();
		private void ProductoListarVista_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = bss.ListarProductosBss();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}
