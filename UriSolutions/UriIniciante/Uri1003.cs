using System;

namespace UriSolutions
{
    /// <summary>
    /// Soma Simples.
    /// </summary>
    public class Uri1003
    {
        public void Solution()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int soma = a + b;

            Console.WriteLine($"SOMA = {soma}");
        }

        public int SolutionForTests(int a, int b)
        {
            int soma = a + b;

            return soma;
        }
    }
}
