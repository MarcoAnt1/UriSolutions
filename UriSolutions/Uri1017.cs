using System;

namespace UriSolutions
{
    /// <summary>
    /// Gasto de Combustível.
    /// </summary>
    public class Uri1017
    {
        private const int kmLitro = 12;

        public void Solution()
        {
            int tempo = int.Parse(Console.ReadLine());
            int velocidade = int.Parse(Console.ReadLine());

            double result = tempo * velocidade;
            double litros = result / kmLitro;

            Console.WriteLine($"{litros:0.000}");
            Console.ReadLine();
        }

        public string SolutionForTests(int tempo, int velocidade)
        {
            double result = tempo * velocidade;
            double litros = result / kmLitro;

            return $"{litros:0.000}";
        }
    }
}
