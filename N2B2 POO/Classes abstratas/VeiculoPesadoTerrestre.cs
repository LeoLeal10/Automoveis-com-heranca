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

        public int QtdEixos { get; set; }        

        public VeiculoPesadoTerrestre(string id, Modelo model, int capPassageiro, int qtdEixos)
            : base(id, model, capPassageiro)
        {
            QtdEixos = qtdEixos;
        }

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
            return base.ToString() + "Quantidade de eixos: " + QtdEixos + Environment.NewLine +
                                     "Valor pedágio: R$ " + (valorPedagio*QtdEixos).ToString("0.00") + Environment.NewLine +  
                                     "Valor gasto com pedágios: R$ " + GastoTotalPedagios().ToString("0.00") + Environment.NewLine +
                                     "Limpador acionado: " + (acionador ? "Sim " : "Não ") + Environment.NewLine;
            
        }

        public double NumeroPedagiosPagos { get; set; }

        public double PagarPedagio()
        {
            NumeroPedagiosPagos++;
            Console.WriteLine($"Pedágio do veículo {Identificacao} foi pago!");
            return valorPedagio * QtdEixos;            
        }

        public double GastoTotalPedagios() => NumeroPedagiosPagos * valorPedagio * QtdEixos; 
    }
}
