using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.ClienteVistas;
using SistemasVentas.VISTA.UsuarioVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.VentaVistas
{
    public partial class VentaEditarVista : Form
    {
        int idx = 0;
        Venta p = new Venta();
        VentaBss bss = new VentaBss();
        public VentaEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void VentaEditarVista_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerVentaIdBss(idx);
            textBox1.Text = p.IdCliente.ToString();
            textBox2.Text = p.IdVendedor.ToString();
            dateTimePicker1.Value = p.Fecha;
            textBox3.Text = p.Total.ToString();
            textBox4.Text = p.Estado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.IdCliente = IdClienteSeleccionada;
            p.IdVendedor = IdVendedorSeleccionada;
            p.Fecha = dateTimePicker1.Value;
            p.Total = Convert.ToDecimal(textBox3.Text);
            p.Estado = textBox4.Text;
            bss.EditarVentaBss(p);
            MessageBox.Show("Datos Actualizados");
        }

        public static int IdClienteSeleccionada = 0;
        ClienteBss bssclie = new ClienteBss();
        private void button3_Click(object sender, EventArgs e)
        {
            ClienteListarVista fr = new ClienteListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Cliente cliente = bssclie.ObtenerClienteIdBss(IdClienteSeleccionada);
                textBox1.Text = cliente.IdCliente.ToString();
            }
        }
        public static int IdVendedorSeleccionada = 0;
        UsuarioBss bssven = new UsuarioBss();
        private void button4_Click(object sender, EventArgs e)
        {
            UsuarioListarVista fr = new UsuarioListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Usuario usuario = bssven.ObtenerUsuarioIdBss(IdVendedorSeleccionada);
                textBox2.Text = usuario.IdUsuario.ToString();
            }
        }
    }
}
