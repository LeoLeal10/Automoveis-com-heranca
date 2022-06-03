using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2B2_POO
{
    class Moto : VeiculoBase, IPedagio
    {
        private const double valorPedagio = 3;       

        public Moto(string id, Modelo model, int capPassageiro) 
            :base(id, model, capPassageiro) { }

        public void Empinar()
        {
            Console.WriteLine("Empinando moto " + Identificacao);
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
            return "MOTO" + Environment.NewLine + base.ToString() +
                   "Valor pedágio: R$ " + valorPedagio.ToString("0.00") + Environment.NewLine +
                   "Valor gasto com pedágios: R$ " + GastoTotalPedagios().ToString("0.00") + Environment.NewLine + Environment.NewLine;
        }
    }
}
