using System;

namespace UriSolutions
{
    /// <summary>
    /// Produto Simples.
    /// </summary>
    public static class Uri1004
    {
        public static void Solution()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int prod = a * b;

            Console.WriteLine($"PROD = {prod}");
        }
    }
}
