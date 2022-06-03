using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2B2_POO
{
    class Aviao : VeiculoAereo, ILimpador
    {
        public Aviao(string id, Modelo model, int capPassageiro)
            : base(id, model, capPassageiro) { }

        private bool acionador;
        public void Limpador()
        {
            if (acionador)
            {
                acionador = false;
                Console.WriteLine($"Limpador do veículo {Identificacao} desligado.");
            }

            else
            {
                acionador = true;
                Console.WriteLine($"Limpador do veículo {Identificacao} ligado.");
            }
        }

        public override string ToString()
        {
            return "AVIÃO" + Environment.NewLine +
                    base.ToString() +
                    "Limpador acionado: " + (acionador ? " Sim " : " Não ") + Environment.NewLine + Environment.NewLine;
        }
    }
}
