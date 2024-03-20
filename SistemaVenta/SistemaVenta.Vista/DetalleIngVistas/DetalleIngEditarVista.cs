using SistemaVenta.BSS;
using SistemaVenta.Modelos;
using SistemaVenta.Vista.IngresoVistas;
using SistemaVenta.Vista.ProductoVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenta.Vista.DetalleIngVistas
{
	public partial class DetalleIngEditarVista : Form
	{
		int idx = 0;
		DetalleIng p = new DetalleIng();
		DetalleIngBss bss = new DetalleIngBss();
		public DetalleIngEditarVista(int id)
		{
			idx = id;
			InitializeComponent();
		}
		public static int IdProductoSeleccionada = 0;
		ProductoBss bsspro = new ProductoBss();
		private void button3_Click(object sender, EventArgs e)
		{
			ProductoListarVista fr = new ProductoListarVista();
			if (fr.ShowDialog() == DialogResult.OK)
			{
				Producto producto = bsspro.ObtenerProductoIdBss(IdProductoSeleccionada);
				textBox1.Text = producto.Nombre;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			p.IdIngreso = IdIngresoSeleccionada;
			p.IdProducto = IdProductoSeleccionada;
			p.FechaVenc = DateTime.Parse(textBox3.Text); 
			p.Cantidad = Convert.ToInt32(textBox4.Text);
			p.PrecioCosto = Convert.ToDecimal(textBox5.Text);
			p.PrecioVenta = Convert.ToDecimal(textBox6.Text);
			p.Subtotal = Convert.ToDecimal(textBox7.Text);

			bss.EditarDetalleIngBss(p);
			MessageBox.Show("Datos Actualizados");
		}

		private void DetalleIngEditarVista_Load(object sender, EventArgs e)
		{
			p = bss.ObtenerDetalleIngIdBss(idx);
			textBox1.Text = p.IdIngreso.ToString();
			textBox2.Text = p.IdProducto.ToString();
			textBox3.Text = p.FechaVenc.ToString();
			textBox4.Text = p.Cantidad.ToString();
			textBox5.Text = p.PrecioCosto.ToString();
			textBox6.Text = p.PrecioVenta.ToString();
			textBox7.Text = p.Subtotal.ToString();
		}
		public static int IdIngresoSeleccionada = 0;
		IngresoBss bssing = new IngresoBss();
		private void button4_Click(object sender, EventArgs e)
		{
			IngresoListarVista fr = new IngresoListarVista();
			if (fr.ShowDialog() == DialogResult.OK)
			{
				Ingreso ingreso = bssing.ObtenerIngresoIdBss(IdIngresoSeleccionada);
				textBox2.Text = ingreso.IdIngreso.ToString();
			}
		}
	}
}
