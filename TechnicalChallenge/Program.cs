using System;
using System.Collections.Generic;
using TechnicalChallenge.Servicos;

namespace TechnicalChallenge.Aplicacao
{
    class Program
    {
        static void Main(string[] args)
        {
            bool parar = false;
            Calculadora calculadora = new();

            Console.WriteLine("----- Bem Vindo -----");
            while (!parar)
            {
                Console.WriteLine();
                Console.Write("Digite um numero: ");
                
                int numero;
                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira apenas números inteiros");
                    Console.WriteLine();
                    Console.Write("Digite um numero: ");
                }

                List<int> Divisores = calculadora.CalculaDivisores(numero);
                List<int> DivisoresPrimos = calculadora.QuantosDivisoresSaoPrimos(Divisores);

                Console.WriteLine();

                //Tratamento caso o usuario digite 0
                if(Divisores.Count < 1)
                    Console.WriteLine($"Números divisores: {numero} não possui divisores");
                else
                    Console.WriteLine($"Números divisores: {String.Join(" ", Divisores)}");

                //Tratamento para quando não existir divisores primos -> Ex: 1
                if(DivisoresPrimos.Count < 1)
                    Console.WriteLine($"Divisores Primos: {numero} não possui divisores que são primos");
                else
                    Console.WriteLine($"Divisores Primos: {String.Join(" ", DivisoresPrimos)}");

                Console.WriteLine();
                Console.Write("Gostaria de ver outro numero ? [y/n] ");
                string decisao = Console.ReadLine();

                if (decisao.Equals("y") || decisao.Equals("Y"))
                    parar = false;
                else if (decisao.Equals("n") || decisao.Equals("N"))
                {
                    Console.WriteLine();
                    Console.WriteLine("Obrigado por usar meu programa");
                    parar = true;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Tecla inválida, programa encerrado!");
                    parar = true;
                }
            }
        }
    }
}


