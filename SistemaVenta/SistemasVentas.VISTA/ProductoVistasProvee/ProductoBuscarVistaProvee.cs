using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.ClienteVistas;
using SistemasVentas.VISTA.LoginIniciarSecion;
using SistemasVentas.VISTA.PersonaVistas;
using SistemasVentas.VISTA.ProductoVistas;
using SistemasVentas.VISTA.UsuarioVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.ProductoVistasProvee
{
	public partial class ProductoBuscarVistaProvee : Form
	{
		public ProductoBuscarVistaProvee()
		{
			InitializeComponent();
		}
		CompraBss bss = new CompraBss();

		private void button1_Click(object sender, EventArgs e)
		{
			Compra compra = new Compra();
			compra.IdCliente = IdClienteSeleccionada;
			compra.IdProducto = IdProductoSeleccionada;
			compra.Cantidad = Convert.ToInt32(textBox3.Text);
			compra.PrecioUnitario = Convert.ToDecimal(textBox4.Text);
			compra.Total = Convert.ToDecimal(textBox5.Text);
			compra.Descripcion = textBox6.Text;
			compra.FormaDePago = textBox7.Text;

			bss.InsertarCompraBss(compra);
			MessageBox.Show("La compra se ha guardado correctamente.");

		}
		public static int IdClienteSeleccionada = 0;
		ClienteBss bssclie = new ClienteBss();

		private void button4_Click(object sender, EventArgs e)
		{
			ClienteListarVista fr = new ClienteListarVista();
			if (fr.ShowDialog() == DialogResult.OK)
			{
				Cliente cliente = bssclie.ObtenerClienteIdBss(IdClienteSeleccionada);
				textBox1.Text = cliente.IdCliente.ToString();
			}
		}
		public static int IdProductoSeleccionada = 0;
		ProductoBss bsspro = new ProductoBss();

		private void button3_Click(object sender, EventArgs e)
		{
			ProductoListarVista fr = new ProductoListarVista();
			if (fr.ShowDialog() == DialogResult.OK)
			{
				Producto producto = bsspro.ObtenerProductoIdBss(IdProductoSeleccionada);
				textBox2.Text = producto.Nombre;
			}
		}


		private void button2_Click(object sender, EventArgs e)
		{
			string producto = textBox2.Text;
			int cantidad = Convert.ToInt32(textBox3.Text);
			double precio = Convert.ToDouble(textBox4.Text);
			double total = cantidad * precio;
			string descripcion = textBox6.Text;

			// Asignamos el total al TextBox5
			textBox5.Text = total.ToString("F2"); // Mostrar dos decimales


			string[] fila = { producto, cantidad.ToString(), precio.ToString(), total.ToString(), descripcion };
			ListViewItem item = new ListViewItem(fila);

			listView1.Items.Add(item);


		}
		private void LimpiarTextBoxes()
		{

		}
		private void frm_closing(object sender, FormClosingEventArgs e)
		{
			this.Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.Hide();
			ProductoListarVistaProvee fr = new ProductoListarVistaProvee();
			fr.Show();
			fr.FormClosing += frm_closing;
		}
	}
}
