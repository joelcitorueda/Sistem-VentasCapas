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

namespace SistemasVentas.VISTA.RolVistas
{
    public partial class RolEditarVista : Form
    {
        int idx = 0;
        Rol p = new Rol();
        RolBss bss = new RolBss();
        public RolEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void RolEditarVista_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerRolIdBss(idx);
            textBox1.Text = p.Nombre;
            textBox2.Text = p.Estado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.Nombre = textBox1.Text;
            p.Estado = textBox2.Text;

            bss.EditarRolBss(p);
            MessageBox.Show("Datos Actualizados");
        }
    }
}
