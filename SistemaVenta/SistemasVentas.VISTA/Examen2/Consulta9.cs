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
	public partial class Consulta9 : Form
	{
		public Consulta9()
		{
			InitializeComponent();
		}
		Consulta9Bss bss = new Consulta9Bss();

		private void Consulta9_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = bss.ListarConsulta9Bss();
		}
	}
}
