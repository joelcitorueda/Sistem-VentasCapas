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
	public partial class ClienteEditarVista : Form
	{
		int idx = 0;
		Cliente c = new Cliente();
		ClienteBss bss = new ClienteBss();
		public ClienteEditarVista(int id)
		{
			idx = id;
			InitializeComponent();
		}

		private void ClienteEditarVista_Load(object sender, EventArgs e)
		{
			c = bss.ObtenerClienteIdBss(idx);
			textBox1.Text = c.IdPersona.ToString();
			textBox2.Text = c.TipoCliente;
			textBox3.Text = c.CodigoCliente;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			c.IdPersona = Convert.ToInt32(textBox1.Text);
			c.TipoCliente = textBox2.Text;
			c.CodigoCliente = textBox3.Text;

			bss.EditarClienteBss(c);
			MessageBox.Show("se actualizo correctamente");

		}
		public static int IdPersonaSeleccionada = 0;
		PersonaBss bssper = new PersonaBss();
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
