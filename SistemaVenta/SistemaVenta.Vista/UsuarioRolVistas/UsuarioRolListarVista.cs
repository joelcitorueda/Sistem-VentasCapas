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

namespace SistemaVenta.Vista.UsuarioRolVistas
{
	public partial class UsuarioRolListarVista : Form
	{
		public UsuarioRolListarVista()
		{
			InitializeComponent();
		}
		UsuarioRolBss bss = new UsuarioRolBss();
		private void UsuarioRolListarVista_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = bss.ListarUsuariosRolesBss();

		}
	}
}
