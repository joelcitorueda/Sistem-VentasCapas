﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.Modelos
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public int IdPersona { get; set; }
        public string TipoCliente { get; set; }
        public string CodigoClie { get; set; }
        public string Estado { get; set; }
    }
}
