using SistemasVentas.DAL;
using SistemasVentas.VISTA.ClienteVistas;
using SistemasVentas.VISTA.ClienteVistaVend;
using SistemasVentas.VISTA.ProductoVistasProvee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.LoginIniciarSecion
{
	public partial class LoginIniciarSecionV : Form
	{
		public LoginIniciarSecionV()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string usuario = txtNombreUsuario.Text;
			string contraseña = txtContraseña.Text;
			conexion conexion = new conexion();

			string cargo = conexion.AutenticarUsuario(usuario, contraseña);

			if (cargo != null)
			{
				string nombreUsuario = ObtenerNombreUsuario(usuario); 

				string mensajeBienvenida = $"¡Bienvenido, {cargo}";

				mensajeBienvenida += $" {nombreUsuario}.";

				MessageBox.Show(mensajeBienvenida);
				if (cargo == "Gerente" || cargo == "Administrador")
				{
					ClienteListarVista gerenteForm = new ClienteListarVista();
					gerenteForm.Show();
				}
				else if (cargo == "Cajero" || cargo == "Vendedor")
				{
					ClienteListarVistaVend cajeroForm = new ClienteListarVistaVend();
					cajeroForm.Show();
				}
				else if (cargo == "Guia" || cargo == "Cliente")
				{
					ProductoListarVistaProvee guiaForm = new ProductoListarVistaProvee();
					guiaForm.Show();
				}
				this.Hide();
			}
			else
			{
				MessageBox.Show("Usuario o contraseña incorrectos.");
			}
		}
		private bool ValidarCredenciales(string nombreUsuario, string contrasena)
		{
			return conexion.ValidarCredenciales(nombreUsuario, contrasena);

		}
		private string ObtenerNombreUsuario(string nombreUsuario)
		{
			conexion conexion = new conexion();
			return nombreUsuario;
		}



	}


}
