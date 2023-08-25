using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2B2_POO
{
    public abstract class VeiculoBase
    {
        protected string Identificacao;

        protected Modelo ModeloVeiculo;

        protected int VelocidadeAtual;

        protected int CapacidadePassageiros;

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
            return "Identificação: " + Identificacao + Environment.NewLine +
                   "Modelo: " + ModeloVeiculo.GetDescricao() + Environment.NewLine +
                   "Marca: " +  ModeloVeiculo.GetMarca().GetDescricao() + Environment.NewLine +
                   "Velocidade atual: " + VelocidadeAtual + " Km/h" + Environment.NewLine +
                   "Capacidade de Passageiros: " + CapacidadePassageiros + Environment.NewLine;
        }

        public string GetIdentificacao() { return Identificacao; }
        public Modelo GetModeloVeiculo() { return ModeloVeiculo; }
        public int GetVelocidadeAtual() { return VelocidadeAtual;}
        public int GetCapacidadePassageiros() { return CapacidadePassageiros; }

        public void SetIdentificacao(string Identificacao) { this.Identificacao = Identificacao; }
        public void SetModeloVeiculo(Modelo ModeloVeiculo) { this.ModeloVeiculo = ModeloVeiculo; }
    }
}
