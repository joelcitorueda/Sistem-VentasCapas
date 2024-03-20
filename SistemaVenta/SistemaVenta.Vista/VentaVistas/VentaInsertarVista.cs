using SistemaVenta.BSS;
using SistemaVenta.Modelos;
using SistemaVenta.Vista.ClienteVistas;
using SistemaVenta.Vista.UsuarioVistas;
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
			venta.Total = Convert.ToDecimal(textBox4.Text);

			bss.InsertarVentaBss(venta);
			MessageBox.Show("Se guardó correctamente la venta");
		}
		public static int IdClienteSeleccionada = 0;
		ClienteBss bssclie = new ClienteBss();

		private void button3_Click(object sender, EventArgs e)
		{
			ClienteListarVista fr = new ClienteListarVista();
			if (fr.ShowDialog() == DialogResult.OK)
			{
				Cliente cliente = bssclie.ObtenerClienteIdBss(IdClienteSeleccionada);
				textBox1.Text = cliente.IdCliente.ToString();
			}
		}
		public static int IdVendedorSeleccionada = 0;
		UsuarioBss bssven = new UsuarioBss();

		private void button4_Click(object sender, EventArgs e)
		{
			UsuarioListarVista fr = new UsuarioListarVista();
			if (fr.ShowDialog() == DialogResult.OK)
			{
				Usuario usuario = bssven.ObtenerUsuarioIdBss(IdVendedorSeleccionada);
				textBox2.Text = usuario.IdUsuario.ToString();
			}
		}
	}
}
