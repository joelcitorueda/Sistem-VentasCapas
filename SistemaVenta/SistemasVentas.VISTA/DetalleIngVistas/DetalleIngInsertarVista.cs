using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.ProductoVistas;
using SistemasVentas.VISTA.IngresoVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.DetalleIngVistas
{
    public partial class DetalleIngInsertarVista : Form
    {
        public DetalleIngInsertarVista()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        DetalleIngBss bss = new DetalleIngBss();
        private void button1_Click(object sender, EventArgs e)
        {
            DetalleIng p = new DetalleIng();
            p.IdIngreso = IdIngresoSeleccionada;
            p.IdProducto = IdProductoSeleccionada;
            p.FechaVenc = dateTimePicker1.Value;
            p.Cantidad = Convert.ToInt32(textBox4.Text);
            p.PrecioCosto = Convert.ToDecimal(textBox5.Text);
            p.PrecioVenta = Convert.ToDecimal(textBox6.Text);
            p.SubTotal = Convert.ToDecimal(textBox7.Text);
            bss.InsertarDetalleIngBss(p);
            MessageBox.Show("Se guardó correctamente a Detalle Ing");

        }
        public static int IdProductoSeleccionada = 0;
        ProductoBss bsspro = new ProductoBss();
        private void button3_Click(object sender, EventArgs e)
        {
            ProductoListarVista fr = new ProductoListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto producto = bsspro.ObtenerProductoIdBss(IdProductoSeleccionada);
                textBox1.Text = producto.Nombre;
            }
        }
        public static int IdIngresoSeleccionada = 0;
        IngresoBss bssing = new IngresoBss();
        private void button4_Click(object sender, EventArgs e)
        {
            IngresoListarVista fr = new IngresoListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Ingreso ingreso = bssing.ObtenerIngresoIdBss(IdIngresoSeleccionada);
                textBox2.Text = ingreso.IdIngreso.ToString();
            }
        }

        private void DetalleIngInsertarVista_Load(object sender, EventArgs e)
        {

        }
    }
}
