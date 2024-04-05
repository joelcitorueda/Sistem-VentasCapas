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
	public partial class Consulta3 : Form
	{
		public Consulta3()
		{
			InitializeComponent();
		}
		Consulta3Bss bss = new Consulta3Bss();

		private void Consulta3_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = bss.ListarConsulta3Bss();
		}
	}
}
