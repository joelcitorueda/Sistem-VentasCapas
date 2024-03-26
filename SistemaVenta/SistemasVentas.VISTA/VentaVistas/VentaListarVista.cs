﻿using SistemasVentas.BSS;
using SistemasVentas.VISTA.ClienteVistas;
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
    public partial class VentaListarVista : Form
    {
        public VentaListarVista()
        {
            InitializeComponent();
        }
        VentaBss bss = new VentaBss();
        private void VentaListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarVentaBss();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VentaInsertarVista fr = new VentaInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarVentaBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            VentaEditarVista fr = new VentaEditarVista(IdSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarVentaBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar esta Venta?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarVentaBss(IdSeleccionada);
                dataGridView1.DataSource = bss.ListarVentaBss();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           DetalleVentaVistas.DetalleVentasInsertarVista.IdVentaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
           DetalleVentaVistas.DetalleVentaEditarVista.IdVentaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
