using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.PersonaVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemasVentas.VISTA.ClienteVistas
{
	public partial class ClienteInsertarVista : Form
	{
		public ClienteInsertarVista()
		{
			InitializeComponent();
		}
		ClienteBss bss = new ClienteBss();
		private void button1_Click(object sender, EventArgs e)
		{
			Cliente p = new Cliente();
			p.IdPersona = IdPersonaSeleccionada;
			p.TipoCliente = textBox2.Text;
			p.CodigoClie = textBox3.Text;
			bss.InsertarClienteBss(p);
			MessageBox.Show("Se guardó correctamente a Cliente");
		}
		public static int IdPersonaSeleccionada = 0;
		PersonaBss bssper = new PersonaBss();
		private void button3_Click(object sender, EventArgs e)
		{
			PersonaListarVista fr = new PersonaListarVista();
			if (fr.ShowDialog() == DialogResult.OK)
			{
				Persona persona = bssper.ObtenerPersonaIdBss(IdPersonaSeleccionada);
				textBox1.Text = persona.Nombre + " " + persona.Apellido;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{

		}
	}
}
