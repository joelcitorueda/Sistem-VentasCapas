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

namespace SistemaVenta.Vista.RolVistas
{
	public partial class RolListarVista : Form
	{
		public RolListarVista()
		{
			InitializeComponent();
		}
		RolBss bss = new RolBss();
		private void RolListarVista_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = bss.ListarRolesBss();
		}
	}
}
