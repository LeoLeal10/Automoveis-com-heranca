using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2B2_POO
{
    public class Modelo
    {
        public int Codigo { get; set; }

        public string Descricao { get; set; }

        public Marca MarcaVeiculo { get; set; }

        public Modelo(ushort cod, string desc, Marca marca)
        {
            Codigo = cod;
            Descricao = desc;
            MarcaVeiculo = marca;
        }

        public override string ToString()
        {
            return "MODELO" + Environment.NewLine +
                   "Código: " + Codigo + Environment.NewLine +
                   "Descrição: " + Descricao + Environment.NewLine +
                   $"Marca: {MarcaVeiculo.Codigo} - {MarcaVeiculo.Descricao}" + Environment.NewLine + Environment.NewLine;
        }
    }
}
