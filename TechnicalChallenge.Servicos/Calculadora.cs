using System.Collections.Generic;
using TechnicalChallenge.Interfaces;

namespace TechnicalChallenge.Servicos
{
    public class Calculadora : ICalculadora
    {
        public Calculadora() 
        {
        }

        public List<int> CalculaDivisores(int numero)
        {
            List<int> divisores = new();
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    divisores.Add(i);
                }
            }

            return divisores;
        }

        public List<int> QuantosDivisoresSaoPrimos(List<int> listaDeDivisores)
        {
            List<int> divisoresPrimos = new();

            divisoresPrimos = listaDeDivisores.FindAll(divisor => ValidadorNumeroPrimo(divisor));

            return divisoresPrimos;
        }

        private static bool ValidadorNumeroPrimo(int numero)
        {
            int divisao = 0;

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    divisao++;
                }
            }

            return divisao == 2;
        }
    }
}
