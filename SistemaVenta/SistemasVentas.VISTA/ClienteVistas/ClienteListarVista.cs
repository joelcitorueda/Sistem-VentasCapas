﻿using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.DetalleIngVistas;
using SistemasVentas.VISTA.DetalleVentaVistas;
using SistemasVentas.VISTA.IngresoVistas;
using SistemasVentas.VISTA.MarcaVistas;
using SistemasVentas.VISTA.PersonaVistas;
using SistemasVentas.VISTA.ProductoVistas;
using SistemasVentas.VISTA.ProveedorVistas;
using SistemasVentas.VISTA.ProveeVistas;
using SistemasVentas.VISTA.RolVistas;
using SistemasVentas.VISTA.TipoProdVistas;
using SistemasVentas.VISTA.UsuarioRolVistas;
using SistemasVentas.VISTA.UsuarioVistas;
using SistemasVentas.VISTA.VentaVistas;
using SistemasVentas.VISTA.LoginIniciarSecion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.ClienteVistas
{
	public partial class ClienteListarVista : Form
	{

		public static class DatosCliente
		{
			public static DataTable Clientes { get; set; }
		}
		private void ClienteListarVista_Loaded(object sender, EventArgs e)
		{
			DatosCliente.Clientes = bss.ListarClienteBss();
			dataGridView1.DataSource = DatosCliente.Clientes;
		}
		public ClienteListarVista()
		{
			InitializeComponent();
		}
		ClienteBss bss = new ClienteBss();
		private void ClienteListarVista_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = bss.ListarClienteBss();
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
			ProductoVistasProvee.ProductoBuscarVistaProvee.IdClienteSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

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
			/*int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			ClienteEditarVista fr = new ClienteEditarVista(IdSeleccionada);
			this.Hide();
			fr.FormClosing += frm_closing;
			if (fr.ShowDialog() == DialogResult.OK)
			{
				dataGridView1.DataSource = bss.ListarClienteBss();

			}*/
		}

		private void button4_Click(object sender, EventArgs e)
		{
			int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar este DetalleIng?", "Eliminando", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{
				bss.EliminarClienteBss(IdSeleccionada);
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
		private void frm_closing(object sender, FormClosingEventArgs e)
		{
			this.Show();
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

		private void button13_Click(object sender, EventArgs e)
		{
			this.Hide();
			ProveeListarVista fr = new ProveeListarVista();
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

		private void button19_Click(object sender, EventArgs e)
		{
			this.Hide();
			LoginIniciarSecionV fr = new LoginIniciarSecionV();
			fr.Show();
			fr.FormClosing += frm_closing;
		}
		


	}
}
