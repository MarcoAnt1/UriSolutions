using System;

namespace UriSolutions
{
    /// <summary>
    /// Produto Simples.
    /// </summary>
    public class Uri1004
    {
        public void Solution()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int prod = a * b;

            Console.WriteLine($"PROD = {prod}");
        }

        public int SolutionForTests(int a, int b)
        {
            int prod = a * b;

            return prod;
        }
    }
}
