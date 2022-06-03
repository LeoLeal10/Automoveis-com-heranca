using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2B2_POO
{
    class Carro : VeiculoBase, ILimpador, IPedagio
    {
        private const double valorPedagio = 7;
        
        private bool acionador;

        public ushort QuantidadePortas { get; set; }

        public Carro(string id, Modelo model, ushort capPassageiro, ushort qtdPortas) 
            : base(id, model, capPassageiro)
        {
            QuantidadePortas = qtdPortas;
        }

        public void Limpador()
        {
            if (acionador)
            {
                acionador = false;
                Console.WriteLine($"Limpador do veículo {Identificacao} ligado");
            }

            else
            {
               acionador = true;
               Console.WriteLine($"Limpador do veículo {Identificacao} desligado");
            }               
            
        }

        public double NumeroPedagiosPagos { get; set; }

        public double PagarPedagio()
        {
            NumeroPedagiosPagos++;
            Console.WriteLine($"Pedágio do veículo {Identificacao} foi pago!");
            return valorPedagio;
        }

        public double GastoTotalPedagios() => NumeroPedagiosPagos * valorPedagio;

        public override string ToString()
        {
            return "CARRO" + Environment.NewLine + base.ToString()+
                   "Valor pedágio: R$ " + valorPedagio.ToString("0.00") + Environment.NewLine +
                   "Valor gasto com pedágios: R$ " + GastoTotalPedagios().ToString("0.00") + Environment.NewLine +
                   "Limpador acionado: " + (acionador ? "Sim " : "Não ") + Environment.NewLine + Environment.NewLine;
        }

    }
}
