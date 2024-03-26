using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.ProveedorVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemasVentas.VISTA.IngresoVistas
{

    public partial class IngresoEditarVista : Form
    {
        int idx = 0;
        Ingreso p = new Ingreso();
        IngresoBss bss = new IngresoBss();
        public IngresoEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void IngresoEditarVista_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerIngresoIdBss(idx);
            textBox1.Text = p.IdProveedor.ToString();
            dateTimePicker1.Value = p.FechaIngreso;
            textBox2.Text = p.Total.ToString();
            textBox3.Text = p.Estado;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.IdProveedor = IdProveedorSeleccionada;
            p.FechaIngreso = dateTimePicker1.Value;
            p.Total = Convert.ToDecimal(textBox2.Text);
            p.Estado = textBox3.Text;

            bss.EditarIngresoBss(p);
            MessageBox.Show("Datos Actualizados");
        }
        public static int IdProveedorSeleccionada = 0;
        ProveedorBss bssprov = new ProveedorBss();
        private void button3_Click(object sender, EventArgs e)
        {
            ProveedorListarVista fr = new ProveedorListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Proveedor proveedor = bssprov.ObtenerProveedorIdBss(IdProveedorSeleccionada);
                textBox1.Text = proveedor.Nombre;
            }
        }
    }
}
