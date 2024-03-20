using SistemaVenta.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenta.Vista.ClienteVistas
{
	public partial class ClienteListarVista : Form
	{
		public ClienteListarVista()
		{
			InitializeComponent();
		}
		ClienteBss bss = new ClienteBss();
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void ClienteListarVista_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = bss.ListarClienteBss();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			ClienteInsertarVista fr = new ClienteInsertarVista();
			if (fr.ShowDialog() == DialogResult.OK)
			{
				dataGridView1.DataSource = bss.ListarClienteBss();
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			ClienteEditarVista fr = new ClienteEditarVista(IdSeleccionada);
			if (fr.ShowDialog() == DialogResult.OK)
			{
				dataGridView1.DataSource = bss.ListarClienteBss();
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			DialogResult result = MessageBox.Show("seguro que desea eliminar a este cliente", "Eliminando", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{
				bss.EliminarClienteBss(IdSeleccionada);
				dataGridView1.DataSource = bss.ListarClienteBss();
			}
		}
	}
}
