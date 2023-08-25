using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2B2_POO
{
    public class Marca
    {
        private UInt16 Codigo;
        private string Descricao;

        public Marca(ushort codigo, string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
        }

        public UInt16 GetCodigo() { return Codigo; }
        public string GetDescricao() { return Descricao; }

        public void SetCodigo(UInt16 codigo) { Codigo = codigo; }
        public void SetDescricao(string descricao) { Descricao = descricao; }

        public override string ToString()
        {
            return "MARCA" + Environment.NewLine +
                   "Código: " + Codigo + Environment.NewLine +
                   "Descrição: " + Descricao + Environment.NewLine + Environment.NewLine;
        }
    }
}
