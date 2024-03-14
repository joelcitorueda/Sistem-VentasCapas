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

namespace SistemaVenta.Vista.ProveedorVistas
{
	public partial class ProveedorListarVista : Form
	{
		public ProveedorListarVista()
		{
			InitializeComponent();
		}
		ProveedorBss bss = new ProveedorBss();
		private void ProveedorListarVista_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = bss.ListarProveedoresBss();
		}
	}
}
