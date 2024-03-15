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

namespace SistemaVenta.Vista.ProveeVistas
{
	public partial class ProveeInsertarVista : Form
	{
		public ProveeInsertarVista()
		{
			InitializeComponent();
		}
		ProveeBss bss = new ProveeBss();

		private void button1_Click(object sender, EventArgs e)
		{
			Provee provee = new Provee();
			provee.IdProducto = Convert.ToInt32(textBox1.Text);
			provee.IdProveedor = Convert.ToInt32(textBox2.Text);
			provee.Fecha = DateTime.Now; 
			provee.Precio = Convert.ToDecimal(textBox3.Text);

			bss.InsertarProveeBss(provee);
			MessageBox.Show("Se guardó correctamente");
		}

	}
}
