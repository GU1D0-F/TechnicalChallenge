using System.Collections.Generic;

namespace TechnicalChallenge.Interfaces
{
    public interface ICalculadora
    {
        List<int> CalculaDivisores(int numero);
        List<int> QuantosDivisoresSaoPrimos(List<int> listaDeDivisores);
    }
}
