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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaVenta.Vista.TipoProdVistas
{
	public partial class TipoProdEditarVista : Form
	{
		int idx = 0;
		TipoProd t = new TipoProd();
		TipoProdBss bss = new TipoProdBss();
		public TipoProdEditarVista(int id)
		{
			idx = id;
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			t.Nombre = textBox1.Text;

			bss.EditarTipoProdBss(t);
			MessageBox.Show("Se actualizo correctamente");
		}

		/*private void TipoProdEditarVista_Load(object sender, EventArgs e)
		{
			t = bss.ObtenerIdBss(idx);
			textBox1.Text = t.Nombre;
		}*/
	}
}
