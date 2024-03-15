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

namespace SistemaVenta.Vista.VentaVistas
{
	public partial class VentaInsertarVista : Form
	{
		public VentaInsertarVista()
		{
			InitializeComponent();
		}
		VentaBss bss = new VentaBss();

		private void button1_Click(object sender, EventArgs e)
		{
			Venta venta = new Venta();
			venta.IDCliente = Convert.ToInt32(textBox1.Text);
			venta.IDVendedor = Convert.ToInt32(textBox2.Text); 
			venta.Fecha = DateTime.Now;
			venta.Total = Convert.ToDecimal(textBox3.Text);

			bss.InsertarVentaBss(venta);
			MessageBox.Show("Se guardó correctamente la venta");
		}

	}
}
