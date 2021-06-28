using System;

namespace UriSolutions
{
    /// <summary>
    /// Soma Simples.
    /// </summary>
    public static class Uri1003
    {
        public static void Solution()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int soma = a + b;

            Console.WriteLine($"SOMA = {soma}");
        }
    }
}
