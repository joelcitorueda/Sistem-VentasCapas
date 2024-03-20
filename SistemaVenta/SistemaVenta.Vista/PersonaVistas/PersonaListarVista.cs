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

namespace SistemaVenta.Vista.PersonasVistas
{
	public partial class PersonaListarVista : Form
	{
		public PersonaListarVista()
		{
			InitializeComponent();
		}
		PersonaBss bss = new PersonaBss();

		private void PersonaListarVista_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = bss.ListarPersonaBss();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			UsuarioVistas.UsuarioInsertarVista.IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			ClienteVistas.ClienteInsertarVista.IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			ClienteVistas.ClienteEditarVista.IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			//UsuarioVistas.UsuarioEditarVista.IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			PersonaInsertarVista fr = new PersonaInsertarVista();
			if (fr.ShowDialog() == DialogResult.OK)
			{
				dataGridView1.DataSource = bss.ListarPersonaBss();
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			PersonaEditarVista fr = new PersonaEditarVista(IdPersonaSeleccionada);
			if (fr.ShowDialog() == DialogResult.OK)
			{
				dataGridView1.DataSource = bss.ListarPersonaBss();
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			int IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			DialogResult result = MessageBox.Show("Estas seguro de eliminar a esta persona", "Eliminado", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{
				bss.EliminarPersonaBss(IdPersonaSeleccionada);
				dataGridView1.DataSource = bss.ListarPersonaBss();
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
