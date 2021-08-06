using System.Collections.Generic;
using TechnicalChallenge.Servicos;
using Xunit;

namespace TechnicalChallenge.Testes
{
    public class CalculadoraTest
    {

        private readonly Calculadora calculadora = new();

        [Fact]
        public void DeveCalcularOsDivisores()
        {
            int valor = 45;
            List<int> listaEsperada = new()
            {
                1, 3, 5, 9, 15, 45
            };

            var resposta = calculadora.CalculaDivisores(valor);

            Assert.Equal(resposta, listaEsperada);
        }

        [Fact]
        public void DeveListarOsDivisoresPrimos()
        {
            List<int> divisores = new()
            {
                1, 3, 5, 9, 15, 45
            };
            List<int> listaEsperada = new()
            {
                3, 5
            };

            var resposta = calculadora.QuantosDivisoresSaoPrimos(divisores);

            Assert.Equal(resposta, listaEsperada);
        }
    }
}
