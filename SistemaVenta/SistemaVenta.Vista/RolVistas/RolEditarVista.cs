using SistemaVenta.BSS;
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

namespace SistemaVenta.Vista.RolVistas
{
	public partial class RolEditarVista : Form
	{
		int idx = 0;
		Rol p = new Rol();
		RolBss bss = new RolBss();
		public RolEditarVista(int id)
		{
			idx = id;
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			p.Nombre = textBox1.Text;
			

			bss.EditarRolBss(p);
			MessageBox.Show("se actualizo correctamente");

		}

		private void RolEditarVista_Load(object sender, EventArgs e)
		{
			p = bss.ObtenerRolIdBss(idx);
			textBox1.Text = p.Nombre;
			

		}
	}
}
