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

namespace SistemaVenta.Vista.UsuarioRolVistas
{
	public partial class UsuarioRolInsertarVista : Form
	{
		public UsuarioRolInsertarVista()
		{
			InitializeComponent();
		}
		UsuarioRolBss bss = new UsuarioRolBss();
		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			UsuarioRol usuarioRol = new UsuarioRol();
			usuarioRol.IdUsuario = Convert.ToInt32(textBox1.Text);
			usuarioRol.IdRol = Convert.ToInt32(textBox2.Text);
			usuarioRol.FechaAsigna = DateTime.Now; 

			bss.InsertarUsuarioRolBss(usuarioRol);
			MessageBox.Show("Se guardó correctamente");
		}
	}
}
