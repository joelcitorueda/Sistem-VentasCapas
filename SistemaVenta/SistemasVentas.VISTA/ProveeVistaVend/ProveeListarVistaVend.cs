using SistemasVentas.BSS;
using SistemasVentas.VISTA.ClienteVistaVend;
using SistemasVentas.VISTA.DetalleIngVistaVend;
using SistemasVentas.VISTA.DetalleVentaVistaVend;
using SistemasVentas.VISTA.IngresoVistaVend;
using SistemasVentas.VISTA.LoginIniciarSecion;
using SistemasVentas.VISTA.MarcaVistaVend;
using SistemasVentas.VISTA.PersonaVistaVend;
using SistemasVentas.VISTA.ProductoVistasVend;
using SistemasVentas.VISTA.ProveedorVistaVend;
using SistemasVentas.VISTA.ProveeVistas;
using SistemasVentas.VISTA.RolVistaVend;
using SistemasVentas.VISTA.TipoProdVistaVend;
using SistemasVentas.VISTA.UsuarioRolVistaVend;
using SistemasVentas.VISTA.UsuarioVistaVend;
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

namespace SistemasVentas.VISTA.ProveeVistaVend
{
	public partial class ProveeListarVistaVend : Form
	{
		public ProveeListarVistaVend()
		{
			InitializeComponent();
		}
		ProveeBss bss = new ProveeBss();
		private void button19_Click(object sender, EventArgs e)
		{
			this.Hide();
			LoginIniciarSecionV fr = new LoginIniciarSecionV();
			fr.Show();
			fr.FormClosing += frm_closing;
		}
		private void frm_closing(object sender, FormClosingEventArgs e)
		{
			this.Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (!pServicios.Visible)
				pServicios.Visible = true;
			else
				pServicios.Visible = false;
		}

		private void ProveeListarVistaVend_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = bss.ListarProveeBss();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			ProveeInsertarVista fr = new ProveeInsertarVista();
			this.Hide();
			fr.FormClosing += frm_closing;
			if (fr.ShowDialog() == DialogResult.OK)
			{
				dataGridView1.DataSource = bss.ListarProveeBss();
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			ProveeEditarVista fr = new ProveeEditarVista(IdSeleccionada);
			this.Hide();
			fr.FormClosing += frm_closing;
			if (fr.ShowDialog() == DialogResult.OK)
			{
				dataGridView1.DataSource = bss.ListarProveeBss();
			}
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

		private void button13_Click(object sender, EventArgs e)
		{
			this.Hide();
			ClienteListarVistaVend detalleingForm = new ClienteListarVistaVend();
			detalleingForm.Show();
			detalleingForm.FormClosing += frm_closing;

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
	}
}
