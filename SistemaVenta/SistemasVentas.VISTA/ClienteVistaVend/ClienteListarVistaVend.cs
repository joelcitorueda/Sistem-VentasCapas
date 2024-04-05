using Org.BouncyCastle.Pqc.Crypto.Lms;
using SistemasVentas.BSS;
using SistemasVentas.VISTA.ClienteVistas;
using SistemasVentas.VISTA.DetalleIngVistas;
using SistemasVentas.VISTA.DetalleIngVistaVend;
using SistemasVentas.VISTA.DetalleVentaVistas;
using SistemasVentas.VISTA.DetalleVentaVistaVend;
using SistemasVentas.VISTA.IngresoVistas;
using SistemasVentas.VISTA.IngresoVistaVend;
using SistemasVentas.VISTA.LoginIniciarSecion;
using SistemasVentas.VISTA.MarcaVistas;
using SistemasVentas.VISTA.MarcaVistaVend;
using SistemasVentas.VISTA.PersonaVistas;
using SistemasVentas.VISTA.PersonaVistaVend;
using SistemasVentas.VISTA.ProductoVistas;
using SistemasVentas.VISTA.ProductoVistasVend;
using SistemasVentas.VISTA.ProveedorVistas;
using SistemasVentas.VISTA.ProveedorVistaVend;
using SistemasVentas.VISTA.ProveeVistas;
using SistemasVentas.VISTA.ProveeVistaVend;
using SistemasVentas.VISTA.RolVistas;
using SistemasVentas.VISTA.RolVistaVend;
using SistemasVentas.VISTA.TipoProdVistas;
using SistemasVentas.VISTA.TipoProdVistaVend;
using SistemasVentas.VISTA.UsuarioRolVistas;
using SistemasVentas.VISTA.UsuarioRolVistaVend;
using SistemasVentas.VISTA.UsuarioVistas;
using SistemasVentas.VISTA.UsuarioVistaVend;
using SistemasVentas.VISTA.VentaVistas;
using SistemasVentas.VISTA.VentaVistaVend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SistemasVentas.VISTA.ClienteVistas.ClienteListarVista;

namespace SistemasVentas.VISTA.ClienteVistaVend
{
	public partial class ClienteListarVistaVend : Form
	{
		public ClienteListarVistaVend()
		{
			InitializeComponent();
		}
		ClienteBss bss = new ClienteBss();

		private void ClienteListarVistaVend_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = bss.ListarClienteBss();
		}
		public static class DatosCliente
		{
			public static DataTable Clientes { get; set; }
		}
		private void ClienteListarVista_Loaded(object sender, EventArgs e)
		{
			DatosCliente.Clientes = bss.ListarClienteBss();
			dataGridView1.DataSource = DatosCliente.Clientes;
		}
		private void frm_closing(object sender, FormClosingEventArgs e)
		{
			this.Show();
		}
		private void button2_Click(object sender, EventArgs e)
		{
			ClienteInsertarVista fr = new ClienteInsertarVista();
			this.Hide();
			fr.FormClosing += frm_closing;
			if (fr.ShowDialog() == DialogResult.OK)
			{
				dataGridView1.DataSource = bss.ListarClienteBss();

			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			VentaVistas.VentaInsertarVista.IdClienteSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			VentaVistas.VentaEditarVista.IdClienteSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int IdClienteSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			ClienteEditarVista fr = new ClienteEditarVista(IdClienteSeleccionada);
			this.Hide();
			fr.FormClosing += frm_closing;
			if (fr.ShowDialog() == DialogResult.OK)
			{
				dataGridView1.DataSource = bss.ListarClienteBss();
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (!pServicios.Visible)
				pServicios.Visible = true;
			else
				pServicios.Visible = false;
		}

		private void button19_Click(object sender, EventArgs e)
		{
			this.Hide();
			LoginIniciarSecionV fr = new LoginIniciarSecionV();
			fr.Show();
			fr.FormClosing += frm_closing;
		}

		private void button6_Click(object sender, EventArgs e)
		{
			this.Hide();
			DetalleIngListarVistaVend detalleingForm = new DetalleIngListarVistaVend();
			detalleingForm.Show();
			detalleingForm.FormClosing += frm_closing;
		}

		private void button7_Click(object sender, EventArgs e)
		{
			this.Hide();
			DetalleVentaListarVistaVend fr = new DetalleVentaListarVistaVend();
			fr.Show();
			fr.FormClosing += frm_closing;
		}

		private void button8_Click(object sender, EventArgs e)
		{
			this.Hide();
			IngresoListarVistaVend fr = new IngresoListarVistaVend();
			fr.Show();
			fr.FormClosing += frm_closing;
		}

		private void button9_Click(object sender, EventArgs e)
		{
			this.Hide();
			MarcaListarVistaVend fr = new MarcaListarVistaVend();
			fr.Show();
			fr.FormClosing += frm_closing;
		}

		private void button10_Click(object sender, EventArgs e)
		{
			this.Hide();
			PersonaListarVistaVend fr = new PersonaListarVistaVend();
			fr.Show();
			fr.FormClosing += frm_closing;
		}

		private void button11_Click(object sender, EventArgs e)
		{
			this.Hide();
			ProductoListarVistaVend fr = new ProductoListarVistaVend();
			fr.Show();
			fr.FormClosing += frm_closing;
		}

		private void button12_Click(object sender, EventArgs e)
		{
			this.Hide();
			ProveedorListarVistaVend fr = new ProveedorListarVistaVend();
			fr.Show();
			fr.FormClosing += frm_closing;
		}

		private void button13_Click(object sender, EventArgs e)
		{
			this.Hide();
			ProveeListarVistaVend fr = new ProveeListarVistaVend();
			fr.Show();
			fr.FormClosing += frm_closing;
		}

		private void button14_Click(object sender, EventArgs e)
		{
			this.Hide();
			RolListarVistaVend fr = new RolListarVistaVend();
			fr.Show();
			fr.FormClosing += frm_closing;
		}

		private void button15_Click(object sender, EventArgs e)
		{
			this.Hide();
			TipoProdListarVistaVend fr = new TipoProdListarVistaVend();
			fr.Show();
			fr.FormClosing += frm_closing;
		}

		private void button16_Click(object sender, EventArgs e)
		{
			this.Hide();
			UsuarioRolListarVistaVend fr = new UsuarioRolListarVistaVend();
			fr.Show();
			fr.FormClosing += frm_closing;
		}

		private void button17_Click(object sender, EventArgs e)
		{
			this.Hide();
			UsuarioListarVistaVend fr = new UsuarioListarVistaVend();
			fr.Show();
			fr.FormClosing += frm_closing;
		}

		private void button18_Click(object sender, EventArgs e)
		{
			this.Hide();
			VentaListarVistaVend fr = new VentaListarVistaVend();
			fr.Show();
			fr.FormClosing += frm_closing;
		}
	}
}
