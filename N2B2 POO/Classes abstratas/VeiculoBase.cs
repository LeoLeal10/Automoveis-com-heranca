using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2B2_POO
{
    public abstract class VeiculoBase
    {
        public string Identificacao { get; set; }

        public Modelo ModeloVeiculo { get; set; }

        public int VelocidadeAtual { get; set; }

        public int CapacidadePassageiros { get; set; }

        public VeiculoBase(string id, Modelo model, int capPassageiro)
        {
            Identificacao = id;
            ModeloVeiculo = model;
            VelocidadeAtual = 0;
            CapacidadePassageiros = capPassageiro;
        }

        public virtual int Acelerar()
        {
            Console.WriteLine("Acelerando " + Identificacao);
            return VelocidadeAtual++;
        }

        public int Frear()
        {
            Console.WriteLine("Desacelerando " + Identificacao);
            return VelocidadeAtual--;
        }

        public override string ToString()
        {
            return "Identificação:" + Identificacao + Environment.NewLine +
                   "Modelo: " + ModeloVeiculo.Descricao + Environment.NewLine +
                   "Marca: " +  ModeloVeiculo.MarcaVeiculo.Descricao + Environment.NewLine +
                   "Velocidade atual: " + VelocidadeAtual + " Km/h" + Environment.NewLine +
                   "Capacidade de Passageiros: " + CapacidadePassageiros + Environment.NewLine;
        }
    }
}
