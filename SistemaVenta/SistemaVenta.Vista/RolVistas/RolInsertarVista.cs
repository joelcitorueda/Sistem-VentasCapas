﻿using SistemaVenta.BSS;
using SistemaVenta.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenta.Vista.RolVistas
{
	public partial class RolInsertarVista : Form
	{
		public RolInsertarVista()
		{
			InitializeComponent();
		}
		RolBss bss = new RolBss();

		private void button1_Click(object sender, EventArgs e)
		{
			Rol rol = new Rol();
			rol.Nombre = textBox1.Text;

			bss.InsertarRolBss(rol);
			MessageBox.Show("Se guardó correctamente el rol");
		}

	}
}
