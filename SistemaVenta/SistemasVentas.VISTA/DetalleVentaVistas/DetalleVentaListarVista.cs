﻿using iText.Kernel.Pdf;
using SistemasVentas.BSS;
using SistemasVentas.DAL;
using SistemasVentas.VISTA.DetalleIngVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using Org.BouncyCastle.Utilities.Collections;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;



namespace SistemasVentas.VISTA.DetalleVentaVistas
{
	public partial class DetalleVentaListarVista : Form
	{
		public DetalleVentaListarVista()
		{
			InitializeComponent();
		}
		DetalleVentaBss bss = new DetalleVentaBss();
		private void DetalleVentaListarVista_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = bss.ListarDetalleVentaBss();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DetalleVentasInsertarVista fr = new DetalleVentasInsertarVista();
			if (fr.ShowDialog() == DialogResult.OK)
			{
				dataGridView1.DataSource = bss.ListarDetalleVentaBss();
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			DetalleVentaEditarVista fr = new DetalleVentaEditarVista(IdSeleccionada);
			if (fr.ShowDialog() == DialogResult.OK)
			{
				dataGridView1.DataSource = bss.ListarDetalleVentaBss();
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar este DetalleVenta?", "Eliminando", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{
				bss.EliminarDetalleVentaBss(IdSeleccionada);
				dataGridView1.DataSource = bss.ListarDetalleVentaBss();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void btnGuardarPDF_Click(object sender, EventArgs e)
		{
			string consulta = "SELECT DETALLEVENTA.IDDETALLEVENTA, VENTA.FECHA, PRODUCTO.NOMBRE AS PRODUCTO, DETALLEVENTA.CANTIDAD, DETALLEVENTA.PRECIOVENTA, DETALLEVENTA.SUBTOTAL, DETALLEVENTA.ESTADO FROM DETALLEVENTA INNER JOIN VENTA ON DETALLEVENTA.IDVENTA = VENTA.IDVENTA INNER JOIN PRODUCTO ON DETALLEVENTA.IDPRODUCTO = PRODUCTO.IDPRODUCTO";
			DataTable datos = conexion.EjecutarDataTabla(consulta, "tabla");

			// Generar el documento PDF
			GenerarDocumentoPDF(datos);
		}
		private void GenerarDocumentoPDF(DataTable datos)
		{
			// Crear un nuevo documento PDF
			string nombreArchivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "detalle_venta.pdf");
			PdfWriter pdfWriter = new PdfWriter(nombreArchivo);
			PdfDocument pdfDocument = new PdfDocument(pdfWriter);
			Document documento = new Document(pdfDocument);

			// Agregar título al documento
			Paragraph titulo = new Paragraph("LISTADO DE DETALLE VENTAS");
			titulo.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
			documento.Add(titulo);

			// Agregar tabla con los datos obtenidos
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

			// Cerrar el documento
			documento.Close();

			MessageBox.Show("El listado de detalle venta se guardo correctamente");
		}

		private void btnGuardarExcel_Click(object sender, EventArgs e)
		{
			// Obtener los datos de la consulta SQL
			string consulta = "SELECT DETALLEVENTA.IDDETALLEVENTA, VENTA.FECHA, PRODUCTO.NOMBRE AS PRODUCTO, DETALLEVENTA.CANTIDAD, DETALLEVENTA.PRECIOVENTA, DETALLEVENTA.SUBTOTAL, DETALLEVENTA.ESTADO FROM DETALLEVENTA INNER JOIN VENTA ON DETALLEVENTA.IDVENTA = VENTA.IDVENTA INNER JOIN PRODUCTO ON DETALLEVENTA.IDPRODUCTO = PRODUCTO.IDPRODUCTO";
			DataTable datos = conexion.EjecutarDataTabla(consulta, "tabla");

			// Guardar los datos en un archivo de Excel
			GuardarExcel(datos);
		}
		private void GuardarExcel(DataTable datos)
		{
			// Crear un nuevo libro de Excel
			IWorkbook workbook = new XSSFWorkbook();
			ISheet sheet = workbook.CreateSheet("DetalleVenta");

			// Agregar título al archivo de Excel
			IRow titleRow = sheet.CreateRow(0);
			titleRow.CreateCell(0).SetCellValue("Listado de Detalle de Venta");

			// Crear encabezados
			IRow headerRow = sheet.CreateRow(1);
			for (int i = 0; i < datos.Columns.Count; i++)
			{
				headerRow.CreateCell(i).SetCellValue(datos.Columns[i].ColumnName);
			}

			// Agregar datos
			for (int i = 0; i < datos.Rows.Count; i++)
			{
				IRow row = sheet.CreateRow(i + 2); // Comenzar desde la fila 2 después del título y los encabezados
				for (int j = 0; j < datos.Columns.Count; j++)
				{
					row.CreateCell(j).SetCellValue(datos.Rows[i][j].ToString());
				}
			}

			// Obtener la ruta de la carpeta "Documentos" del usuario actual
			string documentosPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

			// Combinar la ruta de la carpeta "Documentos" con el nombre del archivo
			string rutaArchivo = Path.Combine(documentosPath, "detalles_venta.xlsx");

			// Guardar el libro de Excel en el sistema de archivos
			using (FileStream fileStream = new FileStream(rutaArchivo, FileMode.Create, FileAccess.Write))
			{
				workbook.Write(fileStream);
			}

			MessageBox.Show("Detalle de venta guardado en la carpeta Documentos exitosamente.");
		}
	}

}
