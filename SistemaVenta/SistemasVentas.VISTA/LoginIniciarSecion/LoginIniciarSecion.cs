using SistemasVentas.DAL;
using SistemasVentas.VISTA.ClienteVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.LoginIniciarSecion
{
	public partial class LoginIniciarSecion : Form
	{
		public LoginIniciarSecion()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string nombreUsuario = txtNombreUsuario.Text;
			string contraseña = txtContraseña.Text;
			if (ValidarCredenciales(nombreUsuario, contraseña))
			{
				MessageBox.Show("Se inicio secion correctamente\nVienvenido a Tiendita Golosal!");
				ClienteListarVista formulario = new ClienteListarVista();
				formulario.Show();
			}
			else
			{
			
				MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
			}
		}
		private bool ValidarCredenciales(string nombreUsuario, string contrasena)
		{
			return conexion.ValidarCredenciales(nombreUsuario, contrasena);
		}
	}
}
