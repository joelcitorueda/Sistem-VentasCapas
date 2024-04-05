using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemasVentas.BSS;
using SistemasVentas.VISTA;
using SistemasVentas.DAL;
using SistemasVentas.VISTA.Examen2;


namespace SistemasVentas.VISTA.Examen2
{
	public partial class Consulta1 : Form
	{
		public Consulta1()
		{
			InitializeComponent();
		}
		Consulta1Bss bss = new Consulta1Bss();
		

		private void Consulta1_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = bss.ListarConsulta1Bss();
		}
	}
}
