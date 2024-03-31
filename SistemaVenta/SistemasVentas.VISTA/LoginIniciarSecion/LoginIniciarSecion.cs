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
	public partial class LoginIniciarSecion : Form
	{
		public LoginIniciarSecion()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string usuario = txtNombreUsuario.Text;
			string contraseña = txtContraseña.Text;
			// Crear una instancia de la clase Conexion
			conexion conexion = new conexion();

			// Autenticar al usuario (comprobar en la base de datos)
			string cargo = conexion.AutenticarUsuario(usuario, contraseña);

			if (cargo != null)
			{
				// Obtener el nombre del usuario
				string nombreUsuario = ObtenerNombreUsuario(usuario); // Suponiendo que tienes una función para obtener el nombre del usuario

				// Mostrar mensaje de bienvenida
				string mensajeBienvenida = $"¡Bienvenido, {cargo}";

				// Mostrar rol del usuario
				mensajeBienvenida += $" {nombreUsuario}.";

				MessageBox.Show(mensajeBienvenida);
				// Dependiendo del cargo del usuario, redirigir a la ventana correspondiente
				if (cargo == "Gerente" || cargo == "Administrador")
				{
					// Redirigir al formulario del Gerente o Administrador
					ClienteListarVista gerenteForm = new ClienteListarVista();
					gerenteForm.Show();
				}
				else if (cargo == "Cajero" || cargo == "Vendedor")
				{
					// Redirigir al formulario del Cajero o Vendedor
					ClienteListarVistaVend cajeroForm = new ClienteListarVistaVend();
					cajeroForm.Show();
				}
				else if (cargo == "Guia" || cargo == "Cliente")
				{
					// Redirigir al formulario del Guía
					ProductoListarVistaProvee guiaForm = new ProductoListarVistaProvee();
					guiaForm.Show();
				}
				// Cerrar el formulario actual (Login)
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
