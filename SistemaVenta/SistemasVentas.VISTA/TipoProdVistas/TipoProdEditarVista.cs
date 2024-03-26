﻿using SistemasVentas.BSS;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemasVentas.VISTA.TipoProdVistas
{
    public partial class TipoProdEditarVista : Form
    {
        int idx = 0;
        TipoProd p = new TipoProd();
        TipoProdBss bss = new TipoProdBss();
        public TipoProdEditarVista(int id)
        {
            idx= id;
            InitializeComponent();
        }

        private void TipoProdEditarVista_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerTipoProdIdBss(idx);
            textBox1.Text = p.Nombre;
            textBox2.Text = p.Estado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.Nombre = textBox1.Text;
            p.Estado = textBox2.Text;

            bss.EditarTipoProdBss(p);
            MessageBox.Show("Datos Actualizados");
        }
    }
}
