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

namespace SistemaVenta.Vista.DetalleVentaVistas
{
	public partial class DetalleVentaInsertarVista : Form
	{
		public DetalleVentaInsertarVista()
		{
			InitializeComponent();
		}
		DetalleVentaBss bss = new DetalleVentaBss();
		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			DetalleVenta d = new DetalleVenta();
			d.IdVenta = Convert.ToInt32(textBox1.Text);
			d.IdProducto = Convert.ToInt32(textBox2.Text);
			d.Cantidad = Convert.ToInt32(textBox3.Text);
			d.PrecioVenta = Convert.ToDecimal(textBox4.Text);
			d.Subtotal = Convert.ToDecimal(textBox5.Text);

			bss.InsertarDetalleVentaBss(d);
			MessageBox.Show("Se guardó correctamente el detalle de la venta");

		}
	}
}
