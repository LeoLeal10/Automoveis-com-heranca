using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2B2_POO
{
    class AviaoGuerra : VeiculoAereo, IVeiculoGuerra
    {

        public AviaoGuerra(string id, Modelo model, int capPassageiro)
            : base(id, model, capPassageiro) { }

        public void Atacar()
        {
            Console.WriteLine("Atacando com o veículo " + Identificacao);
        }

        public void Ejetar()
        {
            Console.WriteLine("Ejetando do veículo "+Identificacao);
        }
        public override string ToString()
        {
            return "AVIÃO DE GUERRA" + Environment.NewLine +
                    base.ToString() + Environment.NewLine;
        }
    }
}
