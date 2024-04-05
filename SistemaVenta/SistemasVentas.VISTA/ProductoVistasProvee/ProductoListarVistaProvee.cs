using SistemasVentas.BSS;
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

namespace SistemasVentas.VISTA.ProductoVistasProvee
{
	public partial class ProductoListarVistaProvee : Form
	{
		public ProductoListarVistaProvee()
		{
			InitializeComponent();
		}
		ProductoBss bss = new ProductoBss();

		private void ProductoListarVistaProvee_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = bss.ListarProductoBss();
		}
		private void frm_closing(object sender, FormClosingEventArgs e)
		{
			this.Show();
		}
		private void button5_Click(object sender, EventArgs e)
		{
			this.Hide();
			LoginIniciarSecionV fr = new LoginIniciarSecionV();
			fr.Show();
			fr.FormClosing += frm_closing;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			ProductoBuscarVistaProvee fr = new ProductoBuscarVistaProvee();
			fr.Show();
			fr.FormClosing += frm_closing;
		}
	}
}
