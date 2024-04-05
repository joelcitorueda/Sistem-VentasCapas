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
	public partial class Consulta8 : Form
	{
		public Consulta8()
		{
			InitializeComponent();
		}
		Consulta8Bss bss = new Consulta8Bss();

		private void Consulta8_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = bss.ListarConsulta8Bss();
		}
	}
}
