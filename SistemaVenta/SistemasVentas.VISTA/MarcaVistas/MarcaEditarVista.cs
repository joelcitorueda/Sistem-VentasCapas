using SistemasVentas.BSS;
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

namespace SistemasVentas.VISTA.MarcaVistas
{
    public partial class MarcaEditarVista : Form
    {
        int idx = 0;
        Marca p = new Marca();
        MarcaBss bss = new MarcaBss();
        public MarcaEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void MarcaEditarVista_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerMarcaIdBss(idx);
            textBox1.Text = p.Nombre;
            textBox2.Text = p.Estado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.Nombre = textBox1.Text;
            p.Estado = textBox2.Text;

            bss.EditarMarcaBss(p);
            MessageBox.Show("Datos Actualizados");
        }
    }
}
