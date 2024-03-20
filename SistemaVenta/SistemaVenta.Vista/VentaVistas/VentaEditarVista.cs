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
	public partial class VentaEditarVista : Form
	{
		int idx = 0;
		Venta p = new Venta();
		VentaBss bss = new VentaBss();
		public VentaEditarVista(int id)
		{
			idx = id;
			InitializeComponent();
		}

		private void VentaEditarVista_Load(object sender, EventArgs e)
		{
			p = bss.ObtenerVentaIdBss(idx);
			textBox1.Text = p.IDCliente.ToString();
			textBox2.Text = p.IDVendedor.ToString();
			textBox3.Text = p.Fecha.ToString();
			textBox3.Text = p.Total.ToString();
			textBox4.Text = p.Estado;
		}

		private void button1_Click(object sender, EventArgs e)
		{

			p.IDCliente = Convert.ToInt32(textBox1.Text);
			p.IDVendedor = Convert.ToInt32(textBox2.Text);
			p.Fecha = DateTime.Now;
			p.Total = Convert.ToDecimal(textBox3.Text);

			bss.EditarVentaBss(p);
			MessageBox.Show("Se actualizo correctamente la venta");
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
