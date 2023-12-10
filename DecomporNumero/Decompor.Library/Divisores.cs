using System.Collections.Generic;

namespace Decompor.Library
{
    public class Divisores
    {
        private List<int> _divisoresNaturais = new List<int>();
        private List<int> _divisoresPrimos = new List<int>();

        public List<int> DivisoresNaturais { get => _divisoresNaturais; }
        public List<int> DivisoresPrimos { get => _divisoresPrimos; }

        public Divisores(int numero)
        {
            _divisoresNaturais = ObterDivisores(numero);
            _divisoresPrimos = ObterDivisoresPrimos(numero);
        }

        public Divisores()
        {

        }

        public List<int> ObterDivisores(int numero)
        {
            List<int> divisores = new List<int>();

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                    divisores.Add(i);
            }

            return divisores;
        }

        public List<int> ObterDivisoresPrimos(int numero)
        {
            List<int> divisores = new List<int>();
            List<int> primos = new List<int>();

            divisores = ObterDivisores(numero);

            foreach (int i in divisores)
            {
                if (ObterDivisores(i).Count == 2)
                    primos.Add(i);
            }

            return primos;
        }
    }
}
