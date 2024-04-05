using Org.BouncyCastle.Pqc.Crypto.Lms;
using SistemasVentas.BSS;
using SistemasVentas.DAL;
using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SistemasVentas.VISTA.ClienteVistas.ClienteListarVista;


namespace SistemasVentas.VISTA.ClienteVistas
{
	public partial class ClienteEliminarVista : Form
	{
		private readonly ClienteBss clienteBss = new ClienteBss();
		private int idClienteSeleccionado;
		public ClienteEliminarVista()
		{
			InitializeComponent();
		}
		

		
		private void button3_Click(object sender, EventArgs e)
		{
			

		}

		private void button1_Click(object sender, EventArgs e)
		{
			
		}
		public partial class ClienteListarVista : Form
		{
			// Campo estático para almacenar el ID del cliente seleccionado
			public static int IdClienteSeleccionado { get; set; }

			// Resto de tu código...
		}
	}
}
