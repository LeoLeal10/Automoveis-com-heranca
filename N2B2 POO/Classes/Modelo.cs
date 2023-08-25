using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2B2_POO
{
    public class Modelo
    {
        private int Codigo;
        private string Descricao;
        private Marca MarcaVeiculo;

        public Modelo(ushort cod, string desc, Marca marca)
        {
            Codigo = cod;
            Descricao = desc;
            MarcaVeiculo = marca;
        }

        public int GetCodigo() { return Codigo; }
        public string GetDescricao() { return Descricao; }
        public Marca GetMarca() { return MarcaVeiculo; }

        public void SetCodigo(int codigo) { this.Codigo = codigo; }
        public void SetDescricao(string descricao) { this.Descricao = descricao; }
        public void SetMarca(Marca marcaVeiculo) { this.MarcaVeiculo = marcaVeiculo; }

        public override string ToString()
        {
            return "MODELO" + Environment.NewLine +
                   "Código: " + Codigo + Environment.NewLine +
                   "Descrição: " + Descricao + Environment.NewLine +
                   $"Marca: {MarcaVeiculo.GetCodigo()} - {MarcaVeiculo.GetDescricao()}" + Environment.NewLine + Environment.NewLine;
        }
    }
}
