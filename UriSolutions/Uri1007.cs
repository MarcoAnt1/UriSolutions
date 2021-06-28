using System;

namespace UriSolutions
{
    /// <summary>
    /// Diferença.
    /// </summary>
    public class Uri1007
    {
        private readonly int pesoA = 2;
        private readonly int pesoB = 3;
        private readonly int pesoC = 5;

        public void Solution()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            var diferenca = (a * b) - (c * d);

            Console.WriteLine($"DIFERENCA = {diferenca}");
            Console.ReadLine();
        }

        public int SolutionForTests(int a, int b, int c, int d)
        {
            var diferenca = (a * b) - (c * d);

            return diferenca;
        }
    }
}
