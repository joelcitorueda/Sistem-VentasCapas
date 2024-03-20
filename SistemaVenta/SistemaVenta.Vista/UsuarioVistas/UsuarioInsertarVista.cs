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

namespace SistemaVenta.Vista.UsuarioVistas
{
	public partial class UsuarioInsertarVista : Form
	{
		public UsuarioInsertarVista()
		{
			InitializeComponent();
		}
		UsuarioBss bss = new UsuarioBss();

		private void button1_Click(object sender, EventArgs e)
		{
			Usuario usuario = new Usuario();
			usuario.IdPersona = IdPersonaSeleccionada;
			usuario.NombreUser = textBox2.Text;
			usuario.Contraseña = textBox3.Text;
			usuario.FechaReg = DateTime.Now;

			bss.InsertarUsuarioBss(usuario);
			MessageBox.Show("Se guardó correctamente el usuario");
		}
		PersonaBss bsss = new PersonaBss();
		public static int IdPersonaSeleccionada = 0;

		private void button3_Click(object sender, EventArgs e)
		{
			PersonaListarVista fr = new PersonaListarVista();
			if (fr.ShowDialog() == DialogResult.OK)
			{
				Persona persona = bsss.ObtenerIdBss(IdPersonaSeleccionada);
				textBox1.Text = persona.Nombre + " " + persona.Apellido;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{

		}
	}
}
