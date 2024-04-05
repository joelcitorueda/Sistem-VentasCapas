using SistemasVentas.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.Examen2
{
	public partial class Consulta6 : Form
	{
		public Consulta6()
		{
			InitializeComponent();
		}
		Consulta6Bss bss = new Consulta6Bss();

		private void Consulta6_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = bss.ListarConsulta6Bss();
		}
	}
}
