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

namespace SistemaVenta.Vista.MarcaVistas
{
	public partial class MarcaListarVista : Form
	{
		public MarcaListarVista()
		{
			InitializeComponent();
		}
		MarcaBss bss = new MarcaBss();
		private void MarcaListarVista_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = bss.ListarMarcasBss();
		}
	}
}
