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

namespace SistemaVenta.Vista.IngresoVistas
{
	public partial class IngresoInsertarVista : Form
	{
		public IngresoInsertarVista()
		{
			InitializeComponent();
		}
		IngresoBss bss = new IngresoBss();
		private void button1_Click(object sender, EventArgs e)
		{
			Ingreso ingreso = new Ingreso();
			ingreso.IdProveedor = Convert.ToInt32(textBox1.Text);
			ingreso.FechaIngreso = DateTime.Parse(textBox2.Text);
			ingreso.Total = Convert.ToDecimal(textBox3.Text);

			bss.InsertarIngresoBss(ingreso);
			MessageBox.Show("Se guardó correctamente el ingreso");

		}
	}
}
