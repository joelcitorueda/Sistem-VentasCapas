using SistemaVenta.BSS;
using SistemaVenta.Vista.PersonaVistas;
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

namespace SistemaVenta.Vista.MarcaVistas
{
	public partial class MarcaListarVista : Form
	{
		public MarcaListarVista()
		{
			InitializeComponent();
		}
		MarcaBss bss = new MarcaBss();
		public static int IdMarcaSeleccionada = 0;
		private void MarcaListarVista_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = bss.ListarMarcasBss();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			MarcaInsertarVista fr = new MarcaInsertarVista();
			if (fr.ShowDialog() == DialogResult.OK)
			{
				dataGridView1.DataSource = bss.ListarMarcasBss();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			///MarcaInsertarVista.IdMarcaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int IdMarcaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			MarcaEditarVista fr = new MarcaEditarVista(IdMarcaSeleccionada);
			if (fr.ShowDialog() == DialogResult.OK)
			{
				dataGridView1.DataSource = bss.ListarMarcasBss();
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			int IdMarcaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			DialogResult result = MessageBox.Show("Estas seguro de eliminar a esta persona", "Eliminado", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{
				bss.EliminarMarcaBss(IdMarcaSeleccionada);
				dataGridView1.DataSource = bss.ListarMarcasBss();
			}
		}
	}
}
