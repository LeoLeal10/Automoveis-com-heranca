using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2B2_POO
{
    class Navio : VeiculoAquatico
    {
        public Navio(string id, Modelo model, int capPassageiro)
            : base(id, model, capPassageiro) { }

        public override string ToString()
        {
            return "NAVIO" + Environment.NewLine + base.ToString()+Environment.NewLine;
        }
    }
}
