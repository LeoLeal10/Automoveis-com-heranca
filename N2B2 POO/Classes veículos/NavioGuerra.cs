using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2B2_POO
{
    class NavioGuerra : VeiculoAquatico, IVeiculoGuerra
    {

        public NavioGuerra(string id, Modelo model, int capPassageiro)
            : base(id, model, capPassageiro) { }

        public void Atacar()
        {
            Console.WriteLine("Atacando com o veículo " + Identificacao);
        }

        public override string ToString()
        {
            return "NAVIO DE GUERRA" + Environment.NewLine + base.ToString()+Environment.NewLine;
        }
    }
}
