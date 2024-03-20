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

namespace SistemaVenta.Vista.MarcaVistas
{
	public partial class MarcaEditarVista : Form
	{
		int idx = 0;
		Marca p = new Marca();
		MarcaBss bss = new MarcaBss();
		public MarcaEditarVista(int id)
		{
			idx = id;
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			p.Nombre = textBox1.Text;

			bss.EditarMarcaBss(p);
			MessageBox.Show("Se actualizo correctamente");
		}

		private void MarcaEditarVista_Load(object sender, EventArgs e)
		{

			p = bss.ObtenerIdBss(idx);
			textBox1.Text = p.Nombre;
			
		}
	}
}
