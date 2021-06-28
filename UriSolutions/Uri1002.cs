using System;

namespace UriSolutions
{
    /// <summary>
    /// Área do Círculo.
    /// </summary>
    public static class Uri1002
    {
        public static void Solution()
        {
            double raio = Convert.ToDouble(Console.ReadLine());

            double p = 3.14159;
            double area = p * Math.Pow(raio, 2);

            Console.WriteLine($"A= {area:0.0000}");
        }
    }
}
