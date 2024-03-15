using SistemaVenta.BSS;
using SistemaVenta.Modelos;
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
			usuario.IdPersona = Convert.ToInt32(textBox1.Text);
			usuario.NombreUser = textBox2.Text;
			usuario.Contraseña = textBox3.Text;
			usuario.FechaReg = DateTime.Now; 

			bss.InsertarUsuarioBss(usuario);
			MessageBox.Show("Se guardó correctamente el usuario");
		}

	}
}
