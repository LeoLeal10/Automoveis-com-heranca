using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2B2_POO
{
    abstract class VeiculoAquatico : VeiculoBase
    {
        public VeiculoAquatico(string id, Modelo model, int capPassageiro)
            : base(id, model, capPassageiro) { }

        public void Atracar()
        {
            if (VelocidadeAtual == 0)
            { 
                Console.WriteLine($"O navio {Identificacao} já está atracado!");
                return;
            }


            int velocidadeAtraque = VelocidadeAtual;

            if(VelocidadeAtual > 0)
            {
                for (int x = velocidadeAtraque; x > 0; x--)
                    Frear();
            }

            else if(VelocidadeAtual < 0)
            {
                for (int x = velocidadeAtraque; x < 0; x++)
                    Acelerar();
            }            

            Console.WriteLine("Atracando " + Identificacao);
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
