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
	public partial class Consulta4 : Form
	{
		public Consulta4()
		{
			InitializeComponent();
		}
		Consulta4Bss bss = new Consulta4Bss();

		private void Consulta4_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = bss.ListarConsulta4Bss();
		}
	}
}
