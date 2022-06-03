using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2B2_POO
{
    class Caminhao : VeiculoPesadoTerrestre
    {     
        public double PesoCarregado { get; set; }

        public double CapacidadeMaximaEmKG { get; set; }

        public Caminhao(string id, Modelo model, int capPassageiro, int qtdEixos, double carga, double capacidadeMax)
            : base(id, model, capPassageiro, qtdEixos)
        {
            PesoCarregado = carga;
            CapacidadeMaximaEmKG = capacidadeMax;
        }

        public double Carregar(double peso)
        {
            PesoCarregado = PesoCarregado + peso;
            Console.WriteLine($"Carregando o veículo {Identificacao}!");
            return PesoCarregado;
        }

        public void Descarregar()
        {
            Console.WriteLine($"Descarregando o veículo {Identificacao}!");
            PesoCarregado = 0;
        }        

        public override int Acelerar()
        {
            if(PesoCarregado > CapacidadeMaximaEmKG)
            {
                double pesoExcedido = PesoCarregado - CapacidadeMaximaEmKG;

                throw new Exception($"O caminhão {Identificacao} está sobrecarregado e não pode acelerar!" + Environment.NewLine +
                                     "Capacidade excedida: " + pesoExcedido + " Kg" + Environment.NewLine);
            }
            
            Console.WriteLine($"Acelerando o veículo {Identificacao}!");
            return VelocidadeAtual++;
        }

        public override string ToString()
        {
            return "CAMINHÃO" + Environment.NewLine + base.ToString() +
                   "Capacidade maxima: " + CapacidadeMaximaEmKG + " Kg" + Environment.NewLine +
                   "Peso carregado: " + PesoCarregado + " Kg" +  Environment.NewLine + Environment.NewLine;
        }
    }
}
