using SistemasVentas.BSS;
using SistemasVentas.DAL;
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

namespace SistemasVentas.VISTA.Examen2
{
	public partial class Consulta10 : Form
	{
		public Consulta10()
		{
			InitializeComponent();
		}
		Consulta10Bss bss = new Consulta10Bss();

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			if (!decimal.TryParse(txtMontoEspecificado.Text, out decimal montoEspecificado))
			{
				MessageBox.Show("Por favor, ingrese un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			string consulta = "SELECT C.IDCLIENTE,  (P.NOMBRE +' '+P.APELLIDO) Nombre_Cleinte, SUM(DV.SUBTOTAL) Total_de_Compras " +
							  "FROM CLIENTE C " +
							  "INNER JOIN PERSONA P ON C.IDPERSONA = P.IDPERSONA " +
							  "INNER JOIN VENTA V ON C.IDCLIENTE = V.IDCLIENTE " +
							  "INNER JOIN DETALLEVENTA DV ON V.IDVENTA = DV.IDVENTA " +
							  "GROUP BY C.IDCLIENTE, P.NOMBRE, P.APELLIDO " +
							  "HAVING SUM(DV.SUBTOTAL) > @montoEspecificado";

			conexion conexion = new conexion();
			DataTable dt = conexion.EjecutarConsulta(consulta, "@montoEspecificado", montoEspecificado);
			dataGridView1.DataSource = dt;
			if (dt.Rows.Count == 0)
			{
				MessageBox.Show("No se encontraron clientes con compras por encima del monto especificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

	}
	

}
