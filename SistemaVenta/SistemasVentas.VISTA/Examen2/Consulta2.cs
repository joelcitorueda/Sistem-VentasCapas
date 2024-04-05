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
	public partial class Consulta2 : Form
	{
		public Consulta2()
		{
			InitializeComponent();
		}
		Consulta2Bss bss = new Consulta2Bss();
		private void Consulta2_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = bss.ListarConsulta2Bss();
		}
	}
}
