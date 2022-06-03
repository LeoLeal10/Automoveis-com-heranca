using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2B2_POO
{
    public class Pedagio
    {
        double valorRecebido;

        public string Identificacao { get; set; }

        public string Localizacao { get; set; }
        public double ValorRecebido { get => valorRecebido; set => valorRecebido = value; }

        public Pedagio(string id, string local)
        {
            Identificacao = id;
            Localizacao = local;
        }

        public void RecebePagamento(double valor)
        {
            valorRecebido = valorRecebido + valor;
        }        

        public override string ToString()
        {
            return "PEDÁGIO" + Environment.NewLine +
                   "Identificação: " + Identificacao + Environment.NewLine +
                   "Localização: " + Localizacao + Environment.NewLine +
                   "Valor total recebido: R$ " + ValorRecebido.ToString("0.00") + Environment.NewLine + Environment.NewLine;
        }

    }
}
