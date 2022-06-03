using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2B2_POO
{
    class Trem : VeiculoBase, ILimpador
    {
        private bool acionador;

        public Trem(string id, Modelo model, int capPassageiro , int qtdVagoes)
            : base(id, model, capPassageiro) { }

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

        public int QtdVagoes { get; set; }

        public override string ToString()
        {
            return "TREM" + Environment.NewLine + base.ToString() +
                   "Limpador acionado: " + (acionador ? "Sim " : "Não ") + Environment.NewLine +
                   "Quantidade de vagões: " + QtdVagoes + Environment.NewLine + Environment.NewLine;
        }

    }
}
