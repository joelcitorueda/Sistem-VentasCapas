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
	}
}
