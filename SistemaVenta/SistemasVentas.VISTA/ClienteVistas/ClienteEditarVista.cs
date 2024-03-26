using System;
using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using SistemasVentas.VISTA.PersonaVistas;

namespace SistemasVentas.VISTA.ClienteVistas
{

    public partial class ClienteEditarVista : Form
    {
        int idx = 0;
        Cliente p = new Cliente();
        ClienteBss bss = new ClienteBss();
        public ClienteEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void ClienteEditarVista_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerClienteIdBss(idx);
            textBox1.Text = p.IdPersona.ToString();
            textBox2.Text = p.TipoCliente;
            textBox3.Text = p.CodigoClie;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.IdPersona = IdPersonaSeleccionada;
            p.TipoCliente = textBox2.Text;
            p.CodigoClie = textBox3.Text;

            bss.EditarClienteBss(p);
            MessageBox.Show("Datos Actualizados");
        }
        public static int IdPersonaSeleccionada = 0;
        PersonaBss bssper = new PersonaBss();
        private void button3_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bssper.ObtenerPersonaIdBss(IdPersonaSeleccionada);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;
            }
        }
    }
}
