using SistemasVentas.BSS;
using SistemasVentas.VISTA.ClienteVistas;
using SistemasVentas.VISTA.DetalleIngVistas;
using SistemasVentas.VISTA.DetalleVentaVistas;
using SistemasVentas.VISTA.IngresoVistas;
using SistemasVentas.VISTA.MarcaVistas;
using SistemasVentas.VISTA.PersonaVistas;
using SistemasVentas.VISTA.ProductoVistas;
using SistemasVentas.VISTA.ProveedorVistas;
using SistemasVentas.VISTA.RolVistas;
using SistemasVentas.VISTA.TipoProdVistas;
using SistemasVentas.VISTA.UsuarioRolVistas;
using SistemasVentas.VISTA.UsuarioVistas;
using SistemasVentas.VISTA.VentaVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.ProveeVistas
{
	public partial class ProveeListarVista : Form
	{
		public ProveeListarVista()
		{
			InitializeComponent();
		}
		ProveeBss bss = new ProveeBss();
		private void ProveeListarVista_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = bss.ListarProveeBss();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			ProveeInsertarVista fr = new ProveeInsertarVista();
			if (fr.ShowDialog() == DialogResult.OK)
			{
				dataGridView1.DataSource = bss.ListarProveeBss();
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			ProveeEditarVista fr = new ProveeEditarVista(IdSeleccionada);
			if (fr.ShowDialog() == DialogResult.OK)
			{
				dataGridView1.DataSource = bss.ListarProveeBss();
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar este Provee?", "Eliminando", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{
				bss.EliminarProveeBss(IdSeleccionada);
				dataGridView1.DataSource = bss.ListarProveeBss();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (!pServicios.Visible)
				pServicios.Visible = true;
			else
				pServicios.Visible = false;
		}
		private void frm_closing(object sender, FormClosingEventArgs e)
		{
			this.Show();
		}

		private void button13_Click(object sender, EventArgs e)
		{
			this.Hide();
			ClienteListarVista detalleingForm = new ClienteListarVista();
			detalleingForm.Show();
			detalleingForm.FormClosing += frm_closing;
		}

		private void button6_Click(object sender, EventArgs e)
		{
			this.Hide();
			DetalleIngListarVista detalleingForm = new DetalleIngListarVista();
			detalleingForm.Show();
			detalleingForm.FormClosing += frm_closing;
		}

		private void button7_Click(object sender, EventArgs e)
		{
			this.Hide();
			DetalleVentaListarVista fr = new DetalleVentaListarVista();
			fr.Show();
			fr.FormClosing += frm_closing;
		}

		private void button8_Click(object sender, EventArgs e)
		{
			this.Hide();
			IngresoListarVista fr = new IngresoListarVista();
			fr.Show();
			fr.FormClosing += frm_closing;
		}

		private void button9_Click(object sender, EventArgs e)
		{
			this.Hide();
			MarcaListarVista fr = new MarcaListarVista();
			fr.Show();
			fr.FormClosing += frm_closing;
		}

		private void button10_Click(object sender, EventArgs e)
		{
			this.Hide();
			PersonaListarVista fr = new PersonaListarVista();
			fr.Show();
			fr.FormClosing += frm_closing;
		}

		private void button11_Click(object sender, EventArgs e)
		{
			this.Hide();
			ProductoListarVista fr = new ProductoListarVista();
			fr.Show();
			fr.FormClosing += frm_closing;
		}

		private void button12_Click(object sender, EventArgs e)
		{
			this.Hide();
			ProveedorListarVista fr = new ProveedorListarVista();
			fr.Show();
			fr.FormClosing += frm_closing;
		}

		private void button14_Click(object sender, EventArgs e)
		{
			this.Hide();
			RolListarVista fr = new RolListarVista();
			fr.Show();
			fr.FormClosing += frm_closing;
		}

		private void button15_Click(object sender, EventArgs e)
		{
			this.Hide();
			TipoProdListarVista fr = new TipoProdListarVista();
			fr.Show();
			fr.FormClosing += frm_closing;
		}

		private void button16_Click(object sender, EventArgs e)
		{
			this.Hide();
			UsuarioRolListarVista fr = new UsuarioRolListarVista();
			fr.Show();
			fr.FormClosing += frm_closing;
		}

		private void button17_Click(object sender, EventArgs e)
		{
			this.Hide();
			UsuarioListarVista fr = new UsuarioListarVista();
			fr.Show();
			fr.FormClosing += frm_closing;
		}

		private void button18_Click(object sender, EventArgs e)
		{
			this.Hide();
			VentaListarVista fr = new VentaListarVista();
			fr.Show();
			fr.FormClosing += frm_closing;
		}
	}
}
}
