using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2B2_POO
{
    abstract class VeiculoAereo : VeiculoBase
    {
        public VeiculoAereo(string id, Modelo model, int capPassageiro)
            : base(id, model, capPassageiro) { }

        bool decolou = false;

        public void Arremeter() 
        {
            if (decolou)
                Console.WriteLine($"Arremetendo avião {Identificacao}");
            else
                throw new Exception("Não é possivel arremeter com o avião no chão!");
        }

        public void Pousar() 
        {
            if (VelocidadeAtual == 0)
                throw new Exception($"O avião {Identificacao} está no solo!");

            int velocidadePouso = VelocidadeAtual;

            for(int x = velocidadePouso; x > 0; x--)            
                Frear();

            Console.WriteLine("Pousando " + Identificacao);
            decolou = false;
        }         

        public void Decolar()
        {
            if (!decolou)
            {
                if (VelocidadeAtual <= 0)
                    throw new Exception($"O avião {Identificacao} não pode decolar porque não tem velocidade suficiente!");
                decolou = true;
                Console.WriteLine("Decolando avião " + Identificacao);
            }
            else
            {
                throw new Exception($"O avião {Identificacao} já está no ar!");
            }
        }

        public override string ToString()
        {
            return base.ToString() + "O avisão está no ar: " + (decolou? "Sim" : "Não") + Environment.NewLine;
        }
    }
}
