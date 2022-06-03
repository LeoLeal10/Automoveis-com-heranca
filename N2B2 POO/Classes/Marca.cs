﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2B2_POO
{
    public class Marca
    {
        public UInt16 Codigo { get; set; }

        public string Descricao { get; set; }

        public Marca(ushort cod, string desc)
        {
            Codigo = cod;
            Descricao = desc;
        }
        public override string ToString()
        {
            return "MARCA" + Environment.NewLine +
                   "Código: " + Codigo + Environment.NewLine +
                   "Descrição: " + Descricao + Environment.NewLine + Environment.NewLine;
        }
    }
}
