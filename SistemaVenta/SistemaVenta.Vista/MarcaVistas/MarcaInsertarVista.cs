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

namespace SistemaVenta.Vista.MarcaVistas
{
	public partial class MarcaInsertarVista : Form
	{
		public MarcaInsertarVista()
		{
			InitializeComponent();
		}
		MarcaBss bss = new MarcaBss();

		private void button1_Click(object sender, EventArgs e)
		{
			Marca m = new Marca();
			m.Nombre = textBox1.Text;

			bss.InsertarMarcaBss(m);
			MessageBox.Show("Se guardó correctamente la marca");
		}
	}
}
