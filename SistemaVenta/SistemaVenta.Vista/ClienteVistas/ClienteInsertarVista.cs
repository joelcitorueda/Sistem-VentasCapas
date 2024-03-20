using SistemaVenta.BSS;
using SistemaVenta.Modelos;
using SistemaVenta.Vista.PersonasVistas;
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

namespace SistemaVenta.Vista.ClienteVistas
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
			p.CodigoCliente = textBox3.Text;
			bss.InsertarClienteBss(p);
			MessageBox.Show("Se guardo de manera correcta");
		}
		public static int IdPersonaSeleccionada = 0;
		PersonaBss bssper = new PersonaBss();

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			PersonaListarVista fr = new PersonaListarVista();
			if (fr.ShowDialog() == DialogResult.OK)
			{
				Persona persona = bssper.ObtenerIdBss(IdPersonaSeleccionada);
				textBox1.Text = persona.Nombre + " " + persona.Apellido;
			}
		}
	}
}
