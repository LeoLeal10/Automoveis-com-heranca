using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2B2_POO
{
    class Onibus : VeiculoPesadoTerrestre
    {
        public bool Leito { get; set; }

        public Onibus(string id, Modelo model, int capPassageiro, int qtdEixos, bool leito)
            : base(id, model, capPassageiro, qtdEixos)
        {
            Leito = leito;
        }

        public override string ToString()
        {
            return "ÔNIBUS" + Environment.NewLine + base.ToString() +
                   "Tem leito: " + (Leito ? "Sim" : "Não") + Environment.NewLine + Environment.NewLine;
        }
    }
}
