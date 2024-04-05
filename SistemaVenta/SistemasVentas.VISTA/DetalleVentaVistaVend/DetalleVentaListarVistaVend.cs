using iText.Kernel.Pdf;
using SistemasVentas.BSS;
using SistemasVentas.DAL;
using SistemasVentas.VISTA.DetalleVentaVistas;
using SistemasVentas.VISTA.LoginIniciarSecion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iText.Layout;
using iText.Layout.Element;
using Org.BouncyCastle.Utilities.Collections;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using SistemasVentas.VISTA.ClienteVistaVend;
using SistemasVentas.VISTA.DetalleIngVistaVend;
using SistemasVentas.VISTA.IngresoVistaVend;
using SistemasVentas.VISTA.MarcaVistaVend;
using SistemasVentas.VISTA.PersonaVistaVend;
using SistemasVentas.VISTA.ProductoVistasVend;
using SistemasVentas.VISTA.ProveedorVistaVend;
using SistemasVentas.VISTA.ProveeVistaVend;
using SistemasVentas.VISTA.RolVistaVend;
using SistemasVentas.VISTA.TipoProdVistaVend;
using SistemasVentas.VISTA.UsuarioRolVistaVend;
using SistemasVentas.VISTA.UsuarioVistaVend;
using SistemasVentas.VISTA.VentaVistaVend;

namespace SistemasVentas.VISTA.DetalleVentaVistaVend
{
	public partial class DetalleVentaListarVistaVend : Form
	{
		public DetalleVentaListarVistaVend()
		{
			InitializeComponent();
		}
		DetalleVentaBss bss = new DetalleVentaBss();
		private void button19_Click(object sender, EventArgs e)
		{
			this.Hide();
			LoginIniciarSecionV fr = new LoginIniciarSecionV();
			fr.Show();
			fr.FormClosing += frm_closing;
		}
		private void frm_closing(object sender, FormClosingEventArgs e)
		{
			this.Show();
		}

		private void DetalleVentaListarVistaVend_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = bss.ListarDetalleVentaBss();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DetalleVentasInsertarVista fr = new DetalleVentasInsertarVista();
			this.Hide();
			fr.FormClosing += frm_closing;
			if (fr.ShowDialog() == DialogResult.OK)
			{
				dataGridView1.DataSource = bss.ListarDetalleVentaBss();
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			DetalleVentaEditarVista fr = new DetalleVentaEditarVista(IdSeleccionada);
			this.Hide();
			fr.FormClosing += frm_closing;
			if (fr.ShowDialog() == DialogResult.OK)
			{
				dataGridView1.DataSource = bss.ListarDetalleVentaBss();
			}
		}
		private void GenerarDocumentoPDF(DataTable datos)
		{
			string nombreArchivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "detalle_venta.pdf");
			PdfWriter pdfWriter = new PdfWriter(nombreArchivo);
			PdfDocument pdfDocument = new PdfDocument(pdfWriter);
			Document documento = new Document(pdfDocument);
			Paragraph titulo = new Paragraph("LISTADO DE DETALLE VENTAS");
			titulo.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
			documento.Add(titulo);
			iText.Layout.Element.Table tabla = new iText.Layout.Element.Table(datos.Columns.Count);
			foreach (DataColumn columna in datos.Columns)
			{
				tabla.AddHeaderCell(columna.ColumnName);
			}
			foreach (DataRow fila in datos.Rows)
			{
				foreach (object valor in fila.ItemArray)
				{
					tabla.AddCell(valor.ToString());
				}
			}
			documento.Add(tabla);

			documento.Close();

			MessageBox.Show("El listado de detalle venta se guardo correctamente");

		}

		private void btnGuardarPDF_Click(object sender, EventArgs e)
		{
			string consulta = "SELECT DETALLEVENTA.IDDETALLEVENTA, VENTA.FECHA, PRODUCTO.NOMBRE AS PRODUCTO, DETALLEVENTA.CANTIDAD, DETALLEVENTA.PRECIOVENTA, DETALLEVENTA.SUBTOTAL, DETALLEVENTA.ESTADO FROM DETALLEVENTA INNER JOIN VENTA ON DETALLEVENTA.IDVENTA = VENTA.IDVENTA INNER JOIN PRODUCTO ON DETALLEVENTA.IDPRODUCTO = PRODUCTO.IDPRODUCTO";
			DataTable datos = conexion.EjecutarDataTabla(consulta, "tabla");

			// Generar el documento PDF
			GenerarDocumentoPDF(datos);
		}

		private void GuardarExcel(DataTable datos)
		{
			IWorkbook workbook = new XSSFWorkbook();
			ISheet sheet = workbook.CreateSheet("DetalleVenta");
			IRow titleRow = sheet.CreateRow(0);
			titleRow.CreateCell(0).SetCellValue("Listado de Detalle de Venta");
			IRow headerRow = sheet.CreateRow(1);
			for (int i = 0; i < datos.Columns.Count; i++)
			{
				headerRow.CreateCell(i).SetCellValue(datos.Columns[i].ColumnName);
			}

			for (int i = 0; i < datos.Rows.Count; i++)
			{
				IRow row = sheet.CreateRow(i + 2);
				for (int j = 0; j < datos.Columns.Count; j++)
				{
					row.CreateCell(j).SetCellValue(datos.Rows[i][j].ToString());
				}
			}

			string documentosPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			string rutaArchivo = Path.Combine(documentosPath, "detalles_venta.xlsx");
			using (FileStream fileStream = new FileStream(rutaArchivo, FileMode.Create, FileAccess.Write))
			{
				workbook.Write(fileStream);
			}

			MessageBox.Show("Detalle de venta guardado en la carpeta Documentos exitosamente.");
		}

		private void btnGuardarExcel_Click(object sender, EventArgs e)
		{
			string consulta = "SELECT DETALLEVENTA.IDDETALLEVENTA, VENTA.FECHA, PRODUCTO.NOMBRE AS PRODUCTO, DETALLEVENTA.CANTIDAD, DETALLEVENTA.PRECIOVENTA, DETALLEVENTA.SUBTOTAL, DETALLEVENTA.ESTADO FROM DETALLEVENTA INNER JOIN VENTA ON DETALLEVENTA.IDVENTA = VENTA.IDVENTA INNER JOIN PRODUCTO ON DETALLEVENTA.IDPRODUCTO = PRODUCTO.IDPRODUCTO";
			DataTable datos = conexion.EjecutarDataTabla(consulta, "tabla");
			GuardarExcel(datos);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (!pServicios.Visible)
				pServicios.Visible = true;
			else
				pServicios.Visible = false;
		}

		private void button7_Click(object sender, EventArgs e)
		{
			this.Hide();
			ClienteListarVistaVend detalleingForm = new ClienteListarVistaVend();
			detalleingForm.Show();
			detalleingForm.FormClosing += frm_closing;
		}

		private void button6_Click(object sender, EventArgs e)
		{
			this.Hide();
			DetalleIngListarVistaVend detalleingForm = new DetalleIngListarVistaVend();
			detalleingForm.Show();
			detalleingForm.FormClosing += frm_closing;
		}

		private void button8_Click(object sender, EventArgs e)
		{
			this.Hide();
			IngresoListarVistaVend fr = new IngresoListarVistaVend();
			fr.Show();
			fr.FormClosing += frm_closing;
		}

		private void button9_Click(object sender, EventArgs e)
		{
			this.Hide();
			MarcaListarVistaVend fr = new MarcaListarVistaVend();
			fr.Show();
			fr.FormClosing += frm_closing;
		}

		private void button10_Click(object sender, EventArgs e)
		{
			this.Hide();
			PersonaListarVistaVend fr = new PersonaListarVistaVend();
			fr.Show();
			fr.FormClosing += frm_closing;
		}

		private void button11_Click(object sender, EventArgs e)
		{
			this.Hide();
			ProductoListarVistaVend fr = new ProductoListarVistaVend();
			fr.Show();
			fr.FormClosing += frm_closing;
		}

		private void button12_Click(object sender, EventArgs e)
		{
			this.Hide();
			ProveedorListarVistaVend fr = new ProveedorListarVistaVend();
			fr.Show();
			fr.FormClosing += frm_closing;
		}

		private void button13_Click(object sender, EventArgs e)
		{
			this.Hide();
			ProveeListarVistaVend fr = new ProveeListarVistaVend();
			fr.Show();
			fr.FormClosing += frm_closing;
		}

		private void button14_Click(object sender, EventArgs e)
		{
			this.Hide();
			RolListarVistaVend fr = new RolListarVistaVend();
			fr.Show();
			fr.FormClosing += frm_closing;
		}

		private void button15_Click(object sender, EventArgs e)
		{
			this.Hide();
			TipoProdListarVistaVend fr = new TipoProdListarVistaVend();
			fr.Show();
			fr.FormClosing += frm_closing;
		}

		private void button16_Click(object sender, EventArgs e)
		{
			this.Hide();
			UsuarioRolListarVistaVend fr = new UsuarioRolListarVistaVend();
			fr.Show();
			fr.FormClosing += frm_closing;

		}

		private void button17_Click(object sender, EventArgs e)
		{
			this.Hide();
			UsuarioListarVistaVend fr = new UsuarioListarVistaVend();
			fr.Show();
			fr.FormClosing += frm_closing;

		}

		private void button18_Click(object sender, EventArgs e)
		{
			this.Hide();
			VentaListarVistaVend fr = new VentaListarVistaVend();
			fr.Show();
			fr.FormClosing += frm_closing;

		}
	}
}
