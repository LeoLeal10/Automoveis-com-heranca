using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2B2_POO
{
    abstract class VeiculoPesadoTerrestre : VeiculoBase, IPedagio, ILimpador
    {
        private const double valorPedagio = 8.50;

        protected int QtdEixos;
        private bool Acionador;
        public double NumeroPedagiosPagos { get; set; }

        public VeiculoPesadoTerrestre(string id, Modelo model, int capPassageiro, int qtdEixos)
            : base(id, model, capPassageiro)
        {
            QtdEixos = qtdEixos;
        }

        public int GetQtdEixos() { return QtdEixos; }
        public bool GetAcionador() { return Acionador; }
        public double GetNumeroPedagiosPagos() { return NumeroPedagiosPagos; }

        public void SetQtdEixos(int QtdEixos) { this.QtdEixos= QtdEixos; }

        public double GastoTotalPedagios() => NumeroPedagiosPagos * valorPedagio * QtdEixos;

        public void Limpador()
        {
            if (Acionador)
            {
                Acionador = false;
                Console.WriteLine($"Limpador do veículo {Identificacao} desligado.");
            }

            else
            {
                Acionador = true;
                Console.WriteLine($"Limpador do veículo {Identificacao} ligado.");
            }
        }        

        public double PagarPedagio()
        {
            NumeroPedagiosPagos++;
            Console.WriteLine($"Pedágio do veículo {Identificacao} foi pago!");
            return valorPedagio * QtdEixos;            
        }

        public override string ToString()
        {
            return base.ToString() + "Quantidade de eixos: " + QtdEixos + Environment.NewLine +
                                     "Valor pedágio: R$ " + (valorPedagio * QtdEixos).ToString("0.00") + Environment.NewLine +
                                     "Valor gasto com pedágios: R$ " + GastoTotalPedagios().ToString("0.00") + Environment.NewLine +
                                     "Limpador acionado: " + (Acionador ? "Sim " : "Não ") + Environment.NewLine;
        }
    }
}
